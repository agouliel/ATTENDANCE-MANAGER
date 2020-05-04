using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;// SOS VERSION 3.5.1 NOT OLDER VERSIONS
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Vetting
{

    public class Majors
    {
        public string MajorName;
        public string MajorCode;
        public int MajorId;

        public void SelectById(SqlConnection con, int majorid)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlDataReader dr = null;

            cmd.CommandText = "Select a.MajorId,a.MajorCode,a.MajorName from Majors where majorid =@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int).Value = majorid;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.MajorId = (int)dr[0];
                    this.MajorCode = dr[1].ToString();
                    this.MajorName = dr[2].ToString();
                }
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                if (dr != null)
                    dr.Close();
                con.Close();
            }
        }
        public static DataTable FillTable(SqlConnection con)
        {
            DataTable tblTarget = new DataTable();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.CommandText = "Select a.MajorId,a.MajorCode,a.MajorName from Majors order by majorcode";
            try
            {
                int num = da.Fill(tblTarget);
                if (num > 0)
                    return tblTarget;
                return null;
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }
        }
    }
    public class Portable
    {

        public static DataTable GetVisitLog(string filepath, string password)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "select  ValidFromDate,ValidTodate,LastDate,VisitNumberLimit,VettingNumberLimit,QuestionnaireLimit,VettingNumber,QuestionnaireNumber,VisitNumber from [VisitLog]";

            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.SelectCommand = cmd;

            DataTable tbl = new System.Data.DataTable();
            try
            {

                int num = da.Fill(tbl);
                return tbl;

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot load briefcase's v-log. " + e2.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }

        public static void UpdateVisitLogInfo(string filepath, string password, DataTable tbl)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update visitlog set ValidFromDate=@p0,ValidTodate=@p1,LastDate=@p2," +
                              "VisitNumberLimit=@p3,VettingNumberLimit=@p4,QuestionnaireLimit=@p5,VettingNumber=@p6," +
                              "QuestionnaireNumber=@p7,VisitNumber=@p8";
            cmd.Parameters.Add("@p0", SqlDbType.DateTime, 0, "ValidFromdate");
            cmd.Parameters.Add("@p1", SqlDbType.DateTime, 0, "ValidToDate");
            cmd.Parameters.Add("@p2", SqlDbType.DateTime, 0, "LastDate");
            cmd.Parameters.Add("@p3", SqlDbType.Int, 4, "VisitNumberLimit");
            cmd.Parameters.Add("@p4", SqlDbType.Int, 4, "VettingNumberLimit");
            cmd.Parameters.Add("@p5", SqlDbType.Int, 4, "QuestionnaireLimit");
            cmd.Parameters.Add("@p6", SqlDbType.Int, 4, "VettingNumber");
            cmd.Parameters.Add("@p7", SqlDbType.Int, 4, "QuestionnaireNumber");
            cmd.Parameters.Add("@p8", SqlDbType.Int, 4, "VisitNumber");

            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.UpdateCommand = cmd;


            try
            {

                int num = da.Update(tbl);
                if (num == 0)
                    throw new Exception("Nothing updated");

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot update briefcase's v-log. " + e2.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public static DataTable GetVersion(string filepath, string password)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "select  Versioncode from [Version]";


            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.SelectCommand = cmd;
            try
            {
                DataTable tbl = new DataTable();
                int num = da.Fill(tbl);
                return tbl;

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot load briefcase's version. " + e2.Message);
            }
            finally
            {
                con.Close();

            }

        }
        public static void UpdateVersion(string filepath, string password, DataTable tbl)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update [Version] set Versioncode =@p0";
            cmd.Parameters.Add("@p0", SqlDbType.NVarChar, 256, "VersionCode");
            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.UpdateCommand = cmd;

            try
            {

                int num = da.Update(tbl);
                if (num == 0)
                    throw new Exception("Nothing updated");
            }
            catch (Exception e2)
            {
                throw new Exception("Briefcase's version update failed. " + e2.Message);
            }
            finally
            {
                con.Close();

            }

        }


        public static void FillVesselTable(string filepath, string password, System.Data.DataTable tbl)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Vessel order by vesselname ";

            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.SelectCommand = cmd;


            try
            {

                int num = da.Fill(tbl);

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot load briefcase vessels. " + e2.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public static bool CheckVesselExists(string filepath, string password, int vesselid)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "select top 1 vesselid from Vessels where vesselid=@p0 ";
            cmd.Parameters.Add("@p0", SqlDbType.Int);


            cmd.Parameters[0].Value = vesselid;


            try
            {

                int num = (int)cmd.ExecuteScalar();
                return true;
            }
            catch (Exception e2)
            {
                return false;
            }
            finally
            {
                con.Close();
            }



        }


        public static void InsertVessel(string dbpath, string password, int vesselid, string vesselname, string imo, string flag, float gton, float dwt, object deldate)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(dbpath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into Vessels (vesselid,vesselname,imo,flag,grosstonage,deadweight,deliverydate) " +
                            " values (@p_vid,@p_vname,@p_imo,@p_flag,@p_gton,@p_dwt,@p_deldate) ";
            cmd.Parameters.Add("@p_vid", SqlDbType.Int);
            cmd.Parameters.Add("@p_vname", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_imo", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@p_flag", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_gton", SqlDbType.Float);
            cmd.Parameters.Add("@p_dwt", SqlDbType.Float);
            cmd.Parameters.Add("@p_deldate", SqlDbType.DateTime);


            cmd.Parameters[0].Value = vesselid;
            cmd.Parameters[1].Value = vesselname;
            cmd.Parameters[2].Value = imo;
            cmd.Parameters[3].Value = flag;
            cmd.Parameters[4].Value = gton;
            cmd.Parameters[5].Value = dwt;
            cmd.Parameters[6].Value = deldate;

            try
            {

                int num = cmd.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
                throw new Exception("Insertion failed. " + e2.Message);
            }
            finally
            {
                con.Close();
            }



        }

        public static VettingInfo GetVettingInfo(SqlCeConnection cecon, int vetid)
        {
            VettingInfo vi = new VettingInfo();
            SqlCeDataReader dr = Portable.GetVettingInfoReader(cecon, vetid);
            //cmd.CommandText = "Select QId,VesselName,InspectorName,CompanyRepresentativeName,VettingCode,VetGUI,port,vettingdate,comments from VettingInfo where vetid=@p0";
            while (dr.Read())
            {
                vi.Qid = dr.GetInt32(0);
                vi.VesselName = dr.GetString(1);
                vi.InspectorName = dr.GetString(2);
                vi.CompanyRepresentativeName = dr.GetString(3);
                vi.VettingCode = dr.GetString(4);
                vi.VetGUI = dr.GetGuid(5);
                vi.Port = dr.GetString(6);
                vi.VettingDate = dr.GetDateTime(7);
                vi.Comments = dr.GetString(8);
                vi.ViqGUI = (Guid)dr.GetValue(9);
                vi.InspectionType = dr.GetString(10);
                //    vi.InspectionTypeId = dr.GetInt32(10);
                try
                {
                    vi.InspectionTypeId = (int)dr.GetValue(11);
                }
                catch
                {
                    vi.InspectionTypeId = -1;
                }
                vi.VesselId = (int)dr.GetValue(12);



            }
            dr.Close();
            return vi;
        }


        public static SqlCeConnection ConnectionFromFile(string filepath, string password)
        {
            try
            {

                return new SqlCeConnection(Portable.ConnectionStringFromFile(filepath, password));
            }
            catch (Exception e1)
            {
                return null;
            }

        }

        public static bool CreateVettingContext(SqlCeConnection SourceConnection, SqlCeTransaction trans, int VetId, int QId)
        {
            if (SourceConnection.State != ConnectionState.Open)
            {
                SourceConnection.Open();
            }



            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "INSERT INTO SMVETTING (VETID,QUESTIONID) SELECT " + VetId + " as  VetId ,OBJECTID FROM SMQUESTIONNAIRE WHERE QID=@p_qid and OBJECTTYPE=0";
            cmd.Parameters.Add("@p_qid", SqlDbType.Int);
            cmd.Connection = SourceConnection;
            if (trans != null)
                cmd.Transaction = trans;
            try
            {

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                if (trans == null)
                    SourceConnection.Close();
            }

        }


        public static int GetID(SqlCeConnection SourceConnection)
        {
            SqlCeCommand cmd = new SqlCeCommand("Select COUNT(*) FROM VETTINGINFO", SourceConnection);
            return Convert.ToInt32(cmd.ExecuteScalar()) + 1;

        }
        public static bool VettingInfoInsert(SqlCeConnection SourceConnection,
            SqlCeTransaction trans, string sdfpassword, out object vetid, out System.Guid vetgui,
            object qid, object inspectorname, object inspectorsirname, object companyrepresentativename,
            object portid, object port, object countryid, object countryname,
            object vetdate, object vettime, object password, object comments,
            object vesselid, object vesselname, object vetcode, object vettypeid)
        {
            vetid = null;
            vetgui = System.Guid.NewGuid();
            if (trans == null && SourceConnection == null)
            {
                System.Windows.Forms.OpenFileDialog dlg = Portable.OpenBriefcaseFile(false);
                if (dlg != null)
                {
                    SourceConnection = Portable.ConnectionFromFile(dlg.FileName, sdfpassword);
                }
                else
                {
                    MessageBox.Show("Connection not established");
                    return false;
                }
            }
            if (SourceConnection.State != ConnectionState.Open)
            {
                SourceConnection.Open();
            }


            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "INSERT INTO VETTINGINFO "
                + "(vetid,QId,InspectorName,CompanyRepresentativeName,InspectorSirname,Portid,Port,"
                + " CountryId,Country,Vetdate,vettime, "
                + " password,comments,vesselid,vesselname,vettingcode,vetGUI,InspectionTypeId) "
                + "values (@p_vetid,@p_qid,@p_inspname,@p_cmprepresentativename,@p_inspsirname,@p_portid,@p_port,@p_countryid,@p_country,@p_vetdate,@p_vettime,@p_pswd,"
                + " @p_comments,@p_vesselid,@p_vesselname,@p_vetcode,@p_vetgui,@p_InspTypeId) ";
            cmd.Parameters.Add("@p_vetid", SqlDbType.Int);
            cmd.Parameters.Add("@p_qid", SqlDbType.Int);
            cmd.Parameters.Add("@p_inspname", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_cmprepresentativename", SqlDbType.NVarChar, 64);

            cmd.Parameters.Add("@p_inspsirname", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_portid", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add("@p_port", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_countryid", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add("@p_country", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_vetdate", SqlDbType.DateTime);
            cmd.Parameters.Add("@p_vettime", SqlDbType.DateTime);
            cmd.Parameters.Add("@p_pswd", SqlDbType.NVarChar, 128);
            cmd.Parameters.Add("@p_comments", SqlDbType.NVarChar, 4000);
            cmd.Parameters.Add("@p_vesselid", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add("@p_vesselname", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_vetcode", SqlDbType.NVarChar, 64);
            cmd.Parameters.Add("@p_vetgui", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add("@p_InspTypeId", SqlDbType.Int);




            if (vetid == null)
                vetid = Portable.GetID(SourceConnection);



            cmd.Parameters["@p_vetid"].Value = vetid;
            cmd.Parameters["@p_qid"].Value = qid;
            cmd.Parameters["@p_inspname"].Value = inspectorname;
            cmd.Parameters["@p_cmprepresentativename"].Value = companyrepresentativename;

            cmd.Parameters["@p_inspsirname"].Value = inspectorsirname;
            cmd.Parameters["@p_portid"].Value = portid;
            cmd.Parameters["@p_port"].Value = port;
            cmd.Parameters["@p_countryid"].Value = countryid;
            cmd.Parameters["@p_country"].Value = countryname;
            cmd.Parameters["@p_vetdate"].Value = vetdate;
            cmd.Parameters["@p_vettime"].Value = vettime;
            cmd.Parameters["@p_pswd"].Value = password;
            cmd.Parameters["@p_comments"].Value = comments;
            cmd.Parameters["@p_vesselid"].Value = vesselid;
            cmd.Parameters["@p_vesselname"].Value = vesselname;
            cmd.Parameters["@p_vetcode"].Value = vetcode;
            cmd.Parameters["@p_vetgui"].Value = vetgui;
            cmd.Parameters["@p_InspTypeId"].Value = vettypeid;

            if (trans != null)
                cmd.Transaction = trans;
            cmd.Connection = SourceConnection;


            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                return false;
            }
            finally
            {
                if (trans == null)
                    SourceConnection.Close();
            }


        }

        public static bool CreateVettingContextSlowVersion(SqlCeConnection SourceConnection, SqlCeTransaction trans, int VetId, int QId)
        {



            if (SourceConnection == null)
            {
                string password = "";
                System.Windows.Forms.OpenFileDialog dlg = Portable.OpenBriefcaseFile(false);
                if (dlg != null)
                {
                    SourceConnection = Portable.ConnectionFromFile(dlg.FileName, password);
                }
                else
                {
                    MessageBox.Show("Connection not established");
                    return false;
                }
            }
            if (SourceConnection.State != ConnectionState.Open)
            {
                SourceConnection.Open();
            }

            SqlCeTransaction tr = null;

            if (trans == null)
                tr = SourceConnection.BeginTransaction();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT objectid FROM SMQUESTIONNAIRE WHERE QID=@p_qid and OBJECTTYPE=0 ORDER BY GLOBALDISPLAYINDEX";
            cmd.Parameters.Add("@p_qid", SqlDbType.Int);
            if (trans == null)
                cmd.Transaction = tr;
            else
                cmd.Transaction = trans;
            cmd.Connection = SourceConnection;


            SqlCeCommand cmd_ins = new SqlCeCommand();
            cmd_ins.CommandText = "INSERT INTO SMVETTING (VETID,OBJECTID) VALUES (@P0,@P1)";
            cmd_ins.Parameters.Add("@P0", SqlDbType.Int);
            cmd_ins.Parameters.Add("@P1", SqlDbType.UniqueIdentifier);
            if (trans == null)
                cmd_ins.Transaction = tr;
            else
                cmd_ins.Transaction = trans;

            cmd_ins.Connection = SourceConnection;

            cmd_ins.Parameters[0].Value = VetId;
            try
            {
                cmd.Parameters[0].Value = QId;
                System.Data.SqlServerCe.SqlCeDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    cmd_ins.Parameters[1].Value = dr.GetGuid(0);
                    cmd_ins.ExecuteNonQuery();

                }


                dr.Close();
                if (trans == null)
                    tr.Commit();
                return true;
            }
            catch (Exception e1)
            {
                if (trans == null)
                    tr.Rollback();
                else
                    trans.Rollback();
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                if (trans == null)
                    SourceConnection.Close();
            }

        }
        public static string ConnectionStringFromFile(string FilePath, string password)
        {
            return string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
        }
        public static System.Windows.Forms.OpenFileDialog OpenBriefcaseFile(bool create)
        {
            System.Windows.Forms.OpenFileDialog fdlg = new OpenFileDialog();
            if (create)
            {
                fdlg.Title = "Create Briefcase File";
                fdlg.CheckFileExists = false;

            }
            else
                fdlg.Title = "Open Briefcase File";
            fdlg.AddExtension = true;
            fdlg.Filter = "(Briefcase files *.sdf)|*.sdf";
            fdlg.ShowDialog();
            if (fdlg.FileName != "")
                return fdlg;
            else
            {
                return null;
            }
        }

        public static SqlCeDataReader GetVettingInfoReader(SqlCeConnection cecon, int vetid)
        {

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = cecon;

            cmd.CommandText = "Select a.QId,a.VesselName,a.InspectorName,a.CompanyRepresentativeName,a.VettingCode,a.VetGUI,a.Port,a.Vetdate,a.comments,b.VIQGUI,c.InspectionType,c.InspectionTypeId,a.VesselId from VettingInfo  a join VIQInfo b on a.qid=b.qid join INSPECTIONTYPES c on a.inspectiontypeid=c.inspectiontypeid where vetid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = vetid;

            SqlCeDataReader dtr = cmd.ExecuteReader();
            return dtr;

        }


        public static SqlCeDataAdapter GetVettingAdapter(SqlCeConnection cecon, int vetid)
        {

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = cecon;

            cmd.CommandText = "Select b.objectid,b.answer,b.significance,b.comments from  SMVetting b where b.vetid=@p1";//unsorted


            cmd.Parameters.Add("@p1", SqlDbType.Int);

            cmd.Parameters[0].Value = vetid;
            SqlCeDataAdapter ceda = new SqlCeDataAdapter(cmd);
            return ceda;
        }


        public static bool LoadVetting(string filepath, string password, int VetId, out System.Guid VetGUI, out int QId, out Guid VIQGUI, System.Data.DataTable target, out string VesselName, out string Inspectorname, out string CompanyRepresentativeName, out string VettingCode)
        {
            QId = -1;
            VetGUI = System.Guid.Empty;
            VIQGUI = System.Guid.Empty;
            VesselName = null;
            Inspectorname = null;
            VettingCode = null;
            CompanyRepresentativeName = null;
            SqlCeConnection cecon = Portable.ConnectionFromFile(filepath, password);
            if (cecon.State != ConnectionState.Open)
            {
                cecon.Open();
            }



            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = cecon;

            cmd.CommandText = "Select a.QId,a.VetGUI,a.VesselName,a.InspectorName,a.CompanyRepresentativeName,a.VettingCode,b.VIQGUI from VettingInfo a join VIQInfo b on a.qid=b.qid where a.vetid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = VetId;

            SqlCeDataReader dtr = cmd.ExecuteReader();

            if (dtr.Read())
            {
                QId = Convert.ToInt32(dtr.GetValue(0));
                VetGUI = (System.Guid)dtr.GetValue(1);
                VesselName = dtr.GetValue(2).ToString();
                Inspectorname = dtr.GetValue(3).ToString();
                CompanyRepresentativeName = dtr.GetValue(4).ToString();
                VettingCode = dtr.GetValue(5).ToString();
                VIQGUI = (System.Guid)dtr.GetValue(6);

            }
            dtr.Close();


            cmd.CommandText = "Select a.* ,b.answer,b.significance,b.comments from SMQuestionnaire a  LEFT JOIN SMVetting b on a.objectid=b.objectid where (b.vetid is null OR b.vetid=@p0) and a.qid=@p1 order by a.globaldisplayindex";
            cmd.Parameters.Add("@p1", SqlDbType.Int);

            cmd.Parameters[1].Value = QId;
            SqlCeDataAdapter ceda = new SqlCeDataAdapter(cmd);

            try
            {
                int num = ceda.Fill(target);
                return true;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                return false;
            }


        }



        public static bool SaveVetting(System.Data.SqlServerCe.SqlCeConnection SourceConnection,
            int VetId, int QId,
            DataTable tblinfo,
            DataTable tblvet)
        {

            if (SourceConnection == null)
            {
                string password = "";
                OpenFileDialog dlg = Portable.OpenBriefcaseFile(false);
                if (dlg == null)
                {
                    MessageBox.Show("Cannot connect to a briefcase file");
                    return false;
                }
                SourceConnection = Portable.ConnectionFromFile(dlg.FileName, password);
            }

            if (SourceConnection.State != ConnectionState.Open)
                SourceConnection.Open();
            System.Data.SqlServerCe.SqlCeTransaction trans = SourceConnection.BeginTransaction();
            System.Data.SqlServerCe.SqlCeDataAdapter da = new SqlCeDataAdapter();




            if (SourceConnection == null)
            {
                Portable.OpenBriefcaseFile(false);
            }

            //var vinforow=(WindowsFormsApplication1.Attendance.VettingInfoRow  );

            System.Data.SqlServerCe.SqlCeCommand cmd_ins = new SqlCeCommand();
            System.Data.SqlServerCe.SqlCeCommand cmd_upd = new SqlCeCommand();
            cmd_ins.Connection = SourceConnection;
            cmd_upd.Connection = SourceConnection;




            if (trans != null)
            {
                cmd_ins.Transaction = trans;
                cmd_upd.Transaction = trans;
            }
            if (cmd_ins.Connection.State != ConnectionState.Open)
            {
                cmd_ins.Connection.Open();
                cmd_upd.Connection.Open();
            }
            /*
           cmd_ins.Parameters.Add("@p_vetid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_qid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_insname", SqlDbType.NVarChar,64);
           cmd_ins.Parameters.Add("@p_insname2", SqlDbType.NVarChar, 64);
           cmd_ins.Parameters.Add("@p_portid", SqlDbType.Int );
           cmd_ins.Parameters.Add("@p_port", SqlDbType.NVarChar,64);
           cmd_ins.Parameters.Add("@p_countryid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_country", SqlDbType.NVarChar,64 );
           cmd_ins.Parameters.Add("@p_vetdate", SqlDbType.DateTime);
           cmd_ins.Parameters.Add("@p_vettime", SqlDbType.DateTime);
           cmd_ins.Parameters.Add("@p_pass", SqlDbType.NVarChar,128);
           cmd_ins.Parameters.Add("@p_comm", SqlDbType.NVarChar,4000);
           cmd_ins.Parameters.Add("@p_vessid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_vess", SqlDbType.NVarChar,64);
           cmd_ins.Parameters.Add("@p_vetcode", SqlDbType.NVarChar, 64);
 
             */




            /*
           cmd_ins.CommandText = "INSERT INTO VETTING (VETID,OBJECTID,ANSWER,SIGNIFICANCE,COMMENTS) " +
               " VALUES (@p_vetid,@p_objid,@p_answer,@p_signif,@p_comm) ";
           cmd_ins.Parameters.Add("@p_vetid", SqlDbType.Int,4);
           cmd_ins.Parameters.Add("@p_objid", SqlDbType.UniqueIdentifier,4,"ObjectId");
           cmd_ins.Parameters.Add("@p_answer", SqlDbType.Int,4,"answer");
           cmd_ins.Parameters.Add("@p_signif", SqlDbType.Int,4,"significance");
           cmd_ins.Parameters.Add("@p_comm", SqlDbType.NVarChar,4000,"comments");


           cmd_ins.Parameters[0].Value = 100;    
            */

            cmd_upd.CommandText = "UPDATE VETTING SET ANSWER=@p_answer " +
                   ",SIGNIFICANCE=@p_signif,COMMENTS=@p_comm where OBJECTID=@p_objid and " +
               "  VETID=@p_vetid ";
            cmd_upd.Parameters.Add("@p_vetid", SqlDbType.Int, 4);
            cmd_upd.Parameters.Add("@p_objid", SqlDbType.UniqueIdentifier, 4, "ObjectId");
            cmd_upd.Parameters.Add("@p_answer", SqlDbType.Int, 4, "answer");
            cmd_upd.Parameters.Add("@p_signif", SqlDbType.Int, 4, "significance");
            cmd_upd.Parameters.Add("@p_comm", SqlDbType.NVarChar, 4000, "comments");




            cmd_upd.Parameters[0].Value = VetId;

            //da.InsertCommand = cmd_ins;
            da.UpdateCommand = cmd_upd;

            try
            {

                /*
                foreach (WindowsFormsApplication1.Attendance.VettingRow vtrow in tblvet.Rows)
                {



                    cmd_ins.Parameters[0].value = VETId;
                    cmd_ins.Parameters[1].Value = vtrow.ObjectId;
                    cmd_ins.Parameters[2].Value = vtrow.Answer;
                    cmd_ins.Parameters[3].Value = vtrow.Significance;
                    cmd_ins.Parameters[4].Value = vtrow.Comments;
                }
                 */

                int num = da.Update(tblvet);

                trans.Commit();
                if (num > 0)
                    return true;
                return false;

            }
            catch (Exception e1)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                SourceConnection.Close();
            }





        }





        public static bool TransferQuestionnaireTemplate(System.Data.SqlClient.SqlConnection SourceConnection, int QId, string FilePath, string password)
        {

            string Title = "";
            string Author = "";
            DateTime RegistrationDate = DateTime.MinValue;

            System.Data.SqlClient.SqlCommand sourcecmd = new System.Data.SqlClient.SqlCommand();
            sourcecmd.CommandText = "SELECT * FROM VIQInfo where QId =@p0";
            sourcecmd.Parameters.Add("@p0", SqlDbType.Int);
            sourcecmd.Parameters[0].Value = QId;
            sourcecmd.Connection = SourceConnection;
            if (SourceConnection.State != ConnectionState.Open)
                SourceConnection.Open();
            System.Data.SqlClient.SqlDataReader sqldr_info = sourcecmd.ExecuteReader();

            if (sqldr_info.Read())
            {
                //QId = sqldr_info.GetValue(sqldr_info.GetOrdinal("QId"));
                Title = (string)sqldr_info.GetValue(sqldr_info.GetOrdinal("Title"));
                Author = (string)sqldr_info.GetValue(sqldr_info.GetOrdinal("Author"));
                RegistrationDate = (DateTime)sqldr_info.GetValue(sqldr_info.GetOrdinal("RegistrationDate"));
            }













            string ConnectionString;






            ConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);


            System.Data.SqlServerCe.SqlCeConnection con = new SqlCeConnection(ConnectionString);
            con.Open();

            SqlCeCommand cmd = new SqlCeCommand();

            System.Data.SqlServerCe.SqlCeTransaction CETRANS = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = CETRANS;
            try
            {

                cmd.CommandText = "INSERT INTO VIQINFO (QID,Title,Author,Finalized,Registrationdate,comments,viqgui,NumOfQuestions) " +
                    "VALUES (@p_qid,@p_title,@p_author,@p_final,@p_regdate,@p_comment,@p_viqgui,@p_numofq)";


                cmd.Parameters.Add("@p_qid", SqlDbType.Int);
                cmd.Parameters.Add("@p_title", SqlDbType.NVarChar, 128);
                cmd.Parameters.Add("@p_author", SqlDbType.NVarChar, 128);
                cmd.Parameters.Add("@p_final", SqlDbType.SmallInt);
                cmd.Parameters.Add("@p_regdate", SqlDbType.DateTime);
                cmd.Parameters.Add("@p_comment", SqlDbType.NVarChar, 4000);
                cmd.Parameters.Add("@p_viqgui", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@p_numofq", SqlDbType.Int);


                cmd.Parameters["@p_qid"].Value = QId;
                cmd.Parameters["@p_title"].Value = Title;
                cmd.Parameters["@p_author"].Value = Author;
                cmd.Parameters["@p_final"].Value = DBNull.Value;
                cmd.Parameters["@p_regdate"].Value = RegistrationDate;
                cmd.Parameters["@p_comment"].Value = sqldr_info.GetValue(sqldr_info.GetOrdinal("Comments"));
                cmd.Parameters["@p_viqgui"].Value = sqldr_info.GetValue(sqldr_info.GetOrdinal("VIQGUI"));
                cmd.Parameters["@p_numofq"].Value = sqldr_info.GetValue(sqldr_info.GetOrdinal("NumOfQuestions"));


                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                    if (e2.Message.IndexOf("duplicate") >= 0)
                    {
                        throw new Exception(string.Format("Questionnaire {0} Author {1} @{2} hase been already transferred", Title, Author, RegistrationDate));

                    }

                    throw e2;
                }









                sqldr_info.Close();



                System.Data.SqlClient.SqlCommand sourcecmd_viq = new System.Data.SqlClient.SqlCommand();
                sourcecmd_viq.Connection = SourceConnection;
                sourcecmd_viq.CommandText = "SELECT * FROM VIQ where QId =@p0";
                sourcecmd_viq.Parameters.Add("@p0", SqlDbType.Int);
                sourcecmd_viq.Parameters[0].Value = QId;

                object sp_Title = "";
                object sp_Author = "";
                object sp_RegDate = "";
                object sp_Numquestions = null;

                System.Data.SqlClient.SqlDataReader sqldr_viq = Questionnaire.GetServerReader(SourceConnection, QId, out sp_Title, out sp_Author, out sp_RegDate, out sp_Numquestions);




                cmd.Parameters.Clear();



                cmd.CommandText =
                 "INSERT INTO [SMQuestionnaire] ( " +
                "[QId], " +
                "[ObjectId], " +
                "[ObjectType], " +
                "[CategoryId], " +
                "[ParentCategoryId], " +
                "[GlobalDisplayIndex], " +
                "[DisplayLevel], " +
                "[Children], " +
                "[ObjectDescription], " +
                "[ObjectComments]," +
                "[DisplayCode], " +
                "[DefaultCode]," +
                "[ParentId]," +
                "[InternalDisplayCode] ) VALUES (@p_qid,@p_objid,@p_objtype,@p_catid,@p_parcatid,@p_glbidx,@p_dl,@p_children,@p_objdescr,@p_comm,@p_displcode,@p_defcode,@p_parentid,@p_intdisplaycode)";



                cmd.Parameters.Add("@p_qid", SqlDbType.Int);
                cmd.Parameters.Add("@p_objid", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@p_objtype", SqlDbType.NVarChar, 2);
                cmd.Parameters.Add("@p_catid", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@p_parcatid", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@p_glbidx", SqlDbType.Int);
                cmd.Parameters.Add("@p_dl", SqlDbType.Int);
                cmd.Parameters.Add("@p_children", SqlDbType.Int);
                cmd.Parameters.Add("@p_objdescr", SqlDbType.NVarChar, 4000);
                cmd.Parameters.Add("@p_comm", SqlDbType.NVarChar, 4000);
                cmd.Parameters.Add("@p_displcode", SqlDbType.NVarChar, 64);
                cmd.Parameters.Add("@p_defcode", SqlDbType.NVarChar, 64);
                cmd.Parameters.Add("@p_parentid", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@p_intdisplaycode", SqlDbType.NVarChar, 64);


                while (sqldr_viq.Read())
                {

                    cmd.Parameters["@p_qid"].Value = QId;
                    cmd.Parameters["@p_objid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectId"));
                    cmd.Parameters["@p_objtype"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectType"));
                    cmd.Parameters["@p_catid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("categoryId"));
                    cmd.Parameters["@p_parcatid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ParentCategoryId"));
                    cmd.Parameters["@p_glbidx"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("GlobalDisplayIndex"));
                    cmd.Parameters["@p_dl"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("DisplayLevel"));
                    cmd.Parameters["@p_children"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("Children"));
                    cmd.Parameters["@p_objdescr"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectDescription"));
                    cmd.Parameters["@p_comm"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectComments"));
                    cmd.Parameters["@p_displcode"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("DisplayCode"));
                    cmd.Parameters["@p_defcode"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("DefaultCode"));
                    cmd.Parameters["@p_parentid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ParentId"));
                    cmd.Parameters["@p_intdisplaycode"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("InternalDisplayCode"));

                    cmd.ExecuteNonQuery();



                }




                /*
                        "CREATE TABLE [Questionnaire]( " +
                    "[QId] [int] NOT NULL, " +
                    "[ObjectId] [uniqueidentifier] NOT NULL, " +
                    "[ObjectType] [nvarchar](2) NOT NULL, " +
                    "[CategoryId] [uniqueidentifier] NULL, " +
                    "[ParentCategoryId] [uniqueidentifier] NULL, " +
                    "[GlobalDisplayIndex] [int] NOT NULL, " +
                    "[DisplayLevel] [int] NOT NULL, " +
                    "[Children] [int] NOT NULL, " +
                    "[ObjectDescription] [nvarchar](4000) NOT NULL, " +
                    "[ObjectComments] [nvarchar](4000) NULL, " +

                    "[DisplayCode] [nvarchar](64)  NULL, " +
                    "[DefaultCode] [nvarchar](64) NULL " +
                    ") ";
                */


                MessageBox.Show(string.Format("Questionnaire {0} Author {1} @{2} successfuly transferred.", Title, Author, RegistrationDate));
                CETRANS.Commit();
                return true;
            }
            catch (Exception e1)
            {
                CETRANS.Rollback();
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                SourceConnection.Close();
                con.Close();

            }





        }


        public static bool RemoveQuestionnaire(int qid, string FilePath, string password)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "DELETE  FROM VIQINFO WHERE QID=@pqid";

            cmd.Connection = con;
            cmd.Parameters.Add("@pqid", SqlDbType.Int);
            cmd.Parameters[0].Value = qid;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e1)
            {

                if (e1.Message.IndexOf("VettingInfo_FK") > 0)
                {
                    MessageBox.Show("Questionnaire cannot be deleted. Relevant atttendances were detected");
                }
                else
                    MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        public static bool LoadQuestionnaires(string FilePath, string password, System.Data.DataTable target)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            try
            {
                con.Open();
            }
            catch (Exception e3)
            {
                throw new Exception("Cannot open Briefcase file { " + FilePath + " }. Invalid or corrupted file");

            }


            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT * FROM VIQINFO order by registrationdate";

            cmd.Connection = con;
            SqlCeDataAdapter sqlceadap = new SqlCeDataAdapter(cmd);

            try
            {
                int num = 0;
                num = sqlceadap.Fill(target);
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        public static bool LoadAllVettingInfos(string FilePath, string password, System.Data.DataTable target)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            try
            {
                con.Open();
            }
            catch (Exception e3)
            {
                throw new Exception("Cannot establish connection. Invalid or corrupted file");
            }
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT A.*,B.NUMANSWER FROM (SELECT a.*,b.title as QuestionnaireTitle FROM VETTINGINFO a left join VIQInfo b on a.qid=b.qid  )AS A  LEFT JOIN (SELECT VETID,COUNT(*) as NUMANSWER FROM SMVETTING WHERE ANSWER IS NOT NULL GROUP BY VETID) as B ON A.VETID=B.VETID ORDER BY A.VETDATE";

            cmd.Connection = con;
            SqlCeDataAdapter sqlceadap = new SqlCeDataAdapter(cmd);

            try
            {
                int num = 0;
                num = sqlceadap.Fill(target);
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }


        public static int GetVettingStatistics(string FilePath, string password, int vetid, out int total, out float perc_compl)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);
            int answers = 0;
            total = 0;
            perc_compl = 0;

            con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = string.Format(" select count(*) from SMVETTING where VETID = {0} and answer is not null", vetid);

            cmd.Connection = con;


            try
            {

                answers = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.CommandText = string.Format(" select count(*) from SMVETTING where VETID = {0}", vetid);
                total = Convert.ToInt32(cmd.ExecuteScalar());
                perc_compl = (float)answers / (float)total;
                return answers;




            }
            catch (Exception e1)
            {
                MessageBox.Show("Cannot retrieve count of answers : " + e1.Message);
                throw e1;
            }
            finally
            {
                con.Close();
            }

        }
        public static bool LoadVettingInfo(string FilePath, string password, System.Data.DataTable target, int vetid)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = string.Format(" select * from VETTINGINFO where VETID = {0}", vetid);

            cmd.Connection = con;
            SqlCeDataAdapter sqlceadap = new SqlCeDataAdapter(cmd);

            try
            {
                int num = 0;
                num = sqlceadap.Fill(target);
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }


        public static bool SaveSchema(string filepath, string filename, string password, DateTime fromdate, DateTime todate, string myuser)
        {
            //string connectionstring;

            string strBCaseFilePath = filepath + filename;
            System.Data.SqlServerCe.SqlCeEngine sqlce = new SqlCeEngine();
            sqlce.LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", strBCaseFilePath, password);
            try
            {
                FileInfo fi = new FileInfo(strBCaseFilePath);
                if (fi.Exists)
                {
                    if (DialogResult.Yes != MessageBox.Show("File already exists. Overwrite ?", "Create briefcase", MessageBoxButtons.YesNo))
                    {
                        return false;
                    }
                    else
                        fi.Delete();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Cannot delete file." + e2.Message);
                return false;
            }

            try
            {
                sqlce.CreateDatabase();
            }
            catch (Exception e3)
            {
                MessageBox.Show("Cannot create new briefcase file." + e3.Message);
                return false;
            }
            //sqlce.Dispose();


            SqlCeConnection con = new SqlCeConnection(sqlce.LocalConnectionString);
            con.Open();

            SqlCeCommand cmd = new SqlCeCommand();
            try
            {
                cmd.CommandText =
                  "CREATE TABLE [Version]( " +
                  "[VersionCode] [nvarchar](1000) NOT NULL " +
                ") ";
                cmd.Connection = con;

                cmd.ExecuteNonQuery(); //create version table

                cmd.CommandText = "Insert into version (VersionCode) values('NullVersion 2009')";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                "CREATE TABLE [VisitLog]( " +
                "[ValidFromDate] [datetime] ," +
                "[ValidToDate] [datetime] ," +
                "[LastDate] [datetime] ," +

                "[VisitNumberLimit] [int], " +
                "[VettingNumberLimit] [int] ," +
                "[QuestionnaireLimit] [int] ," +
                "[VettingNumber] [int] ," +
                "[QuestionnaireNumber] [int] ," +
                "[VisitNumber] [int] ," +
                "[GuiFileId] [nvarchar](1024), " + // a.goulielmos 2014
                "[OriginalFileName] [nvarchar](1024) " +
                ") ";
                cmd.Connection = con;//create visit log table
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Insert into VisitLog (ValidFromdate, ValidToDate, VisitNumber, VisitNumberLimit, VettingNumberLimit, OriginalFileName)" +
                    "values (@p0, @p1, @p2, @p3, 10, @p5)"; // a.goulielmos 2014 (changed VettingNumberLimit from 3 to 10)
                
                cmd.Parameters.Add("@p0", SqlDbType.DateTime).Value = fromdate;
                cmd.Parameters.Add("@p1", SqlDbType.DateTime).Value = todate;
                cmd.Parameters.Add("@p2", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@p3", SqlDbType.Int).Value = 30;
                cmd.Parameters.Add("@p5", SqlDbType.NVarChar).Value = filename;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText =
                "CREATE TABLE [SMVetting]( " +
                "[VETId] [int] NOT NULL, " +
                "[ObjectId] [uniqueidentifier] NOT NULL, " +
                "[answer] [nvarchar](5)  NULL, " +
                "[significance] [nvarchar](5)  NULL, " +
                "[comments] [nvarchar](4000) NULL, " +
                "[WithAttachment] [bit] NULL " +
                ") ";
                cmd.Connection = con;

                cmd.ExecuteNonQuery(); //create vetting table

                cmd.CommandText =
                "CREATE TABLE [SMQuestionnaire]( " +
                "[QId] [int] NOT NULL, " +
                "[ObjectId] [uniqueidentifier] NOT NULL, " +
                "[ObjectType] [nvarchar](2) NOT NULL, " +
                "[CategoryId] [uniqueidentifier] NULL, " +
                "[ParentCategoryId] [uniqueidentifier] NULL, " +
                "[GlobalDisplayIndex] [int] NOT NULL, " +
                "[DisplayLevel] [int] NOT NULL, " +
                "[Children] [int] NOT NULL, " +
                "[ObjectDescription] [nvarchar](4000) NOT NULL, " +
                "[ObjectComments] [nvarchar](4000) NULL, " +
                "[DisplayCode] [nvarchar](64)  NULL, " +
                "[DefaultCode] [nvarchar](64) NULL, " +
                "[ParentId] [uniqueidentifier] NULL, " +
                "[InternalDisplayCode] [nvarchar](64)  NULL " +
                ") ";

                cmd.ExecuteNonQuery();
                cmd.CommandText =
                    "ALTER TABLE [SMQuestionnaire] ADD CONSTRAINT QUESTIONNAIRE_PK PRIMARY KEY ([Qid],[ObjectId])";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                    "CREATE TABLE [VIQInfo](" +
                    "[QId] [int]  PRIMARY KEY," +
                    "[VIQGUI][uniqueidentifier] NULL ," +
                    "[Title] [nvarchar](128)  NOT NULL," +
                    //"[Comments] [nvarchar](4000)  NULL," + // a.goulielmos 30/4/2020
                    "[Comments] ntext NULL," +
                    "[Author] [nvarchar](256) NULL," +
                    "[Finalized] [smallint] NULL," +
                    "[RegistrationDate] [datetime] NULL, " +
                    "[NumOfQuestions] [int] NULL " +
                    " )";

                cmd.ExecuteNonQuery();

                cmd.CommandText =
                    "ALTER TABLE [SMQuestionnaire] ADD CONSTRAINT QUESTIONNAIRE_FK FOREIGN KEY ([Qid]) REFERENCES VIQINFO (QID) ON DELETE CASCADE";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                "CREATE TABLE [VettingInfo]( " +
                "[VetId] [int] PRIMARY KEY," +
                "[QId] [int] ," +
                "[InspectorName] [Nvarchar](50) NULL," +
                "[InspectorSirName] [Nvarchar](50) NULL," +
                "[CompanyRepresentativeName] [Nvarchar](64) NOT NULL," +
                "[PortId] [int] NULL," +
                "[Port] [Nvarchar](64) NOT NULL," +
                "[CountryId] [int] NULL," +
                "[Country] [Nvarchar](64) NULL," +
                "[VetDate] [datetime] NOT NULL," +
                "[VetTime] [datetime] NULL," +
                "[Password] [Nvarchar](128) NULL," +
                "[Comments] [Nvarchar](4000) NULL," +
                "[VesselId] [int] NULL," +
                "[VesselName] [Nvarchar](64) NOT NULL," +
                "[VettingCode] [Nvarchar](64) NULL," +
                "[VetGUI] [uniqueidentifier] NULL," +
                "[InspectionTypeId] [int] NULL" +

                ")";

                cmd.ExecuteNonQuery(); // create table VettingInfo - AttendancePortable will insert into this table


                cmd.CommandText =
                    "ALTER TABLE [VettingInfo] ADD CONSTRAINT VettingInfo_FK FOREIGN KEY ([Qid]) REFERENCES VIQINFO (QID)";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
               "ALTER TABLE [SMVetting] ADD CONSTRAINT Vetting_VettingInfo_FK FOREIGN KEY ([Vetid]) REFERENCES VETTINGINFO (VETID) ON DELETE CASCADE";
                cmd.ExecuteNonQuery();


                cmd.CommandText =
            "CREATE TABLE [Vessel]( " +
            "[VesselId] [int] PRIMARY KEY," +
            "[VesselName] [Nvarchar](64)NOT NULL," +
            "[IMO] [Nvarchar](32) NULL," +
            "[FLAG][Nvarchar](64) NULL," +
            "[DeliveryDate] [datetime] NULL," +
            "[GrossTonage] [float] NULL," +
            "[DeadWeight] [float]  NULL," +
            "[VesselCode][Nvarchar](64) NULL" +
            ")";

                cmd.ExecuteNonQuery();


                cmd.CommandText =
           "CREATE TABLE [InspectionTypes]( " +
           "[InspectionTypeId] [int] PRIMARY KEY," +
           "[InspectionType] [Nvarchar](64)NOT NULL," +
           "[InspectionCode] [Nvarchar](50) NULL" +
           ")";

                cmd.ExecuteNonQuery();



                cmd.CommandText =
          "CREATE TABLE [Attachment]( " +
          "[AttachmentId] [uniqueidentifier] PRIMARY KEY," +
          "[AttachmentFileName] [Nvarchar](64)NOT NULL," +
          "[AttachmentPath] [Nvarchar](2000)NOT NULL," +
          "[AttachmentType] [Nvarchar](64)NULL," +
          "[AttachmentFileExtension] [Nvarchar](8) NULL," +
          "[AttachmentSizeInBytes] [int] NULL" +
          ")";

                cmd.ExecuteNonQuery();

                /*   SOS SOS SOS UNCOMMENT TO CREATE UNIQUE FILE CONSTRAINT
                 * OBSOLETE AS LONG AS EACH ATTACHMENT BY DEFAULT GETS A NEW ID
           cmd.CommandText =
           "ALTER TABLE [Attachment] ADD CONSTRAINT Attachment_UK  UNIQUE ([AttachmentPath])";
          cmd.ExecuteNonQuery();
                */


                cmd.CommandText =
       "CREATE TABLE [ObjectAttachment]( " +
       "[AttachmentId] [uniqueidentifier] not null," +
       "[ObjectId] [uniqueidentifier] NOT NULL," +
       "[VetId] [int] NOT NULL," +
       "[VetGui] [uniqueidentifier] NULL" +
       ")";

                cmd.ExecuteNonQuery();



                cmd.CommandText =
                "ALTER TABLE [ObjectAttachment] ADD CONSTRAINT ObjectAttachment_UK  UNIQUE ([AttachmentId],[ObjectId],[VetId])";
                cmd.ExecuteNonQuery();



                cmd.CommandText =
       "CREATE TABLE [AttachmentInfo]( " +
       "[MainPath] [NVarchar](4000) not null" +
       ")";

                cmd.ExecuteNonQuery();


                /* ------------------- a.goulielmos 2014 --------------------- */
                cmd.CommandText =
                  "CREATE TABLE [InspectionSource]( " +
                  "[SOURCENAME] [nvarchar](1000)" +
                  "," +
                  "[SOURCECODE] [nvarchar](1000)" +
                  "," +
                  "[INSPECTIONSOURCEID] [int]" +
                  "," +
                  "[typecode] [int]" +
                ") ";
                cmd.Connection = con;

                cmd.ExecuteNonQuery(); //create InspectionSource table


                cmd.CommandText =
                  "CREATE TABLE [Users]( " +
                  "[UserId] [int]" +
                  "," +
                  "[UserName] [nvarchar](1000)" +
                ") ";
                cmd.Connection = con;

                cmd.ExecuteNonQuery(); //create Users table

                cmd.CommandText = "Insert into Users (UserId, UserName) values(1, '" + myuser + "')";
                cmd.ExecuteNonQuery();



                return true;


            }
            catch (Exception e1)
            {
                MessageBox.Show("a.goulielmos 2014 SaveSchema error: " + e1.Message);
                return false;
            }
            finally
            {

                con.Close();

            }


        }

    }

    public class QuestionnaireObject
    {
        public static SqlDataAdapter GetAdapter(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand("SELECT ObjectId, ObjectNo, ObjectDescription, ObjectCode, ObjectType, OriginId, ObjectComments, ParentId, GlobalDisplayIndex, Children FROM dbo.QuestionnaireObjects", con);

         



         
            return da;

        }

    }

    public class InspectionType
    {
        public static SqlDataAdapter GetAdapter(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand("SELECT InspectionTypeId, InspectionType FROM dbo.InspectionTypes", con);

            da.InsertCommand = new SqlCommand("INSERT INTO [dbo].[InspectionTypes] ([InspectionType]) VALUES (@InspectionType); "+
                                              "SELECT InspectionTypeId, InspectionType FROM InspectionTypes WHERE (InspectionTypeId = SCOPE_IDENTITY())", con);
            da.InsertCommand.Parameters.Add("@InspectionType",SqlDbType.VarChar,64,"InspectionType");


            da.UpdateCommand = new SqlCommand("UPDATE [dbo].[InspectionTypes] SET [InspectionType] = @InspectionType WHERE (([InspectionTypeId] = @Original_InspectionTypeId) AND ([InspectionType] = @Original_InspectionType));"+
                                              "SELECT InspectionTypeId, InspectionType FROM InspectionTypes WHERE (InspectionTypeId = @InspectionTypeId)", con);

            da.UpdateCommand.Parameters.Add("@InspectionType",SqlDbType.VarChar,64,"InspectionType");
            da.UpdateCommand.Parameters.Add("@Original_InspectionTypeId",SqlDbType.Int,4,"InspectionTypeId").SourceVersion=DataRowVersion.Original;
            da.UpdateCommand.Parameters.Add("@Original_InspectionType",SqlDbType.VarChar,64,"InspectionType").SourceVersion=DataRowVersion.Original;




            da.DeleteCommand = new SqlCommand("DELETE FROM [dbo].[InspectionTypes] WHERE (([InspectionTypeId] = @Original_InspectionTypeId) AND ([InspectionType] = @Original_InspectionType))", con);
            da.DeleteCommand.Parameters.Add("@Original_InspectionTypeId",SqlDbType.Int,4,"InspectionTypeId").SourceVersion=DataRowVersion.Original;
            da.DeleteCommand.Parameters.Add("@Original_InspectionType",SqlDbType.VarChar,64,"InspectionType").SourceVersion=DataRowVersion.Original;

            
            return da;

        }
    }
    public class Questionnaire
    {
        public enum ViewerApplication { Attendance, AttendancePortable };
        public static int FillObjectRelatedTable(SqlConnection con, Guid objectid, System.Data.DataTable target)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.CommandText = "Select a.* from VIQInfo a join VIQ b on a.qid=b.qid and b.objectid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
            cmd.Parameters[0].Value = objectid;
            try
            {
                int num = da.Fill(target);
                return num;
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }

        }


        public static bool HasRelatedOrigin(SqlConnection con, int originid)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.CommandText = " Select origin from questionpoolnew where exists( select origin from questionpoolnew where Origin=@p0)";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            //cmd.Parameters.Add("@p1", SqlDbType.Int).Direction=ParameterDirection.Output;

            cmd.Parameters[0].Value = originid;
            try
            {

                object o = cmd.ExecuteScalar();

                if (o == null)
                    return false;
                int num = Convert.ToInt32(o);
                return true;
            }
            catch (Exception e1)
            {

                return false;
            }
            finally
            {
                con.Close();
            }

        }


        public static bool TransferRegistryInfoToBriefcase(SqlConnection con, string fpath, string password)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlCeConnection cecon = Portable.ConnectionFromFile(fpath, password);
            cecon.Open();
            SqlCeTransaction cetrans = cecon.BeginTransaction();
            SqlCeCommand cecmd = new SqlCeCommand();
            cecmd.Connection = cecon;
            cecmd.Transaction = cetrans;

            //----------------------------------------------------------------------------

            try
            {
              cmd.CommandText = "Select InspectionTypeId, InspectionType, InspectionCode from InspectionTypes";

              cecmd.CommandText = "Insert into InspectionTypes (InspectionTypeId, InspectionType, InspectionCode) values (@p0, @p1, @p2)";
              cecmd.Parameters.Add("@p0", SqlDbType.Int);
              cecmd.Parameters.Add("@p1", SqlDbType.NVarChar, 64);
              cecmd.Parameters.Add("@p2", SqlDbType.NVarChar, 50);
              
            
              SqlDataReader dr = cmd.ExecuteReader();
              while (dr.Read())
                {
                    cecmd.Parameters[0].Value = dr.GetValue(0);
                    cecmd.Parameters[1].Value = dr.GetValue(1);
                    cecmd.Parameters[2].Value = dr.GetValue(2);

                    cecmd.ExecuteNonQuery();

                }
              dr.Close();
            


            //---------------------------------------------------------------------------------

            cmd.CommandText = "Select VesselId, VesselName, Imo, flag, deliverydate, Grosstonage, deadweight, VesselCode" +
                                " from Vessel ";
                

            cecmd.Parameters.Clear();
            cecmd.CommandText = "Insert into Vessel (VesselId, VesselName, Imo, flag, deliverydate, Grosstonage, deadweight, VesselCode) " +
                                  " values (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7) ";
            cecmd.Parameters.Add("@p0", SqlDbType.Int);
            cecmd.Parameters.Add("@p1", SqlDbType.NVarChar, 64);
            cecmd.Parameters.Add("@p2", SqlDbType.NVarChar, 32);
            cecmd.Parameters.Add("@p3", SqlDbType.NVarChar, 64);
            cecmd.Parameters.Add("@p4", SqlDbType.DateTime);
            cecmd.Parameters.Add("@p5", SqlDbType.Float);
            cecmd.Parameters.Add("@p6", SqlDbType.Float);
            cecmd.Parameters.Add("@p7", SqlDbType.NVarChar, 64);

            
                SqlDataReader dr2 = cmd.ExecuteReader();

                while (dr2.Read())
                {
                    cecmd.Parameters[0].Value = dr2.GetValue(0);
                    cecmd.Parameters[1].Value = dr2.GetValue(1);
                    cecmd.Parameters[2].Value = dr2.GetValue(2);
                    cecmd.Parameters[3].Value = dr2.GetValue(3);
                    cecmd.Parameters[4].Value = dr2.GetValue(4);
                    cecmd.Parameters[5].Value = dr2.GetValue(5);
                    cecmd.Parameters[6].Value = dr2.GetValue(6);
                    cecmd.Parameters[7].Value = dr2.GetValue(7);

                    cecmd.ExecuteNonQuery();

                }
                dr2.Close();

                //--------------------------------a.goulielmos 2014 --------------------------------------------------

                cmd.CommandText = "Select SOURCENAME, SOURCECODE, INSPECTIONSOURCEID, typecode from InspectionSource";

                cecmd.Parameters.Clear();
                cecmd.CommandText = "Insert into InspectionSource (SOURCENAME, SOURCECODE, INSPECTIONSOURCEID) values (@p0, @p1, @p2)";
                cecmd.Parameters.Add("@p0", SqlDbType.NVarChar, 256);
                cecmd.Parameters.Add("@p1", SqlDbType.NVarChar, 64);
                cecmd.Parameters.Add("@p2", SqlDbType.Int);
                //cecmd.Parameters.Add("@p3", SqlDbType.Int);


                SqlDataReader dr3 = cmd.ExecuteReader();
                while (dr3.Read())
                {
                    cecmd.Parameters[0].Value = dr3.GetValue(0);
                    cecmd.Parameters[1].Value = dr3.GetValue(1);
                    cecmd.Parameters[2].Value = dr3.GetValue(2);
                    //cecmd.Parameters[3].Value = dr3.GetValue(3);

                    cecmd.ExecuteNonQuery();

                }
                dr3.Close();

                /*cmd.CommandText = "Insert into InspectionSource (SOURCENAME, SOURCECODE) values('Abu Dhabi ADCO', 'ADCO')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Insert into InspectionSource (SOURCENAME, SOURCECODE) values('Abu Dhabi ADNOC', 'ADNOC')";
                cmd.ExecuteNonQuery();*/


                //----------------------------------------------------------------------------------

                /*cmd.CommandText = "Select UserId,UserName from Users";

                cecmd.CommandText = "Insert into Users (UserId, UserName) values (@p0, @p1)";
                cecmd.Parameters.Add("@p0", SqlDbType.Int);
                cecmd.Parameters.Add("@p1", SqlDbType.NVarChar, 64);


                SqlDataReader dr4 = cmd.ExecuteReader();
                while (dr4.Read())
                {
                    cecmd.Parameters[0].Value = dr4.GetValue(0);
                    cecmd.Parameters[1].Value = dr4.GetValue(1);

                    cecmd.ExecuteNonQuery();

                }
                dr.Close();*/

                //--------------------------------------------------------------------------------

                cetrans.Commit();
                return true;

            }
            catch (Exception e1)
            {
                MessageBox.Show("a.goulielmos 2014 TransferRegistryInfoToBriefcase error: " + e1.Message);
                cetrans.Rollback();
                return false;
            }
            finally
            {
                cecon.Close();
                con.Close();
            }


        }


        public static void GetBriefcaseInfo(string fpath, string password, int qid, out object Title, out object Author, out object comments, out object Registrationdate)
        {
            Title = "";
            Author = "";
            comments = "";
            Registrationdate = null;
            SqlCeConnection con = Portable.ConnectionFromFile(fpath, password);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCeCommand cmd = new SqlCeCommand("Select Title,author,comments,registrationdate from VIQInfo where Qid=@p0", con);
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = qid;
            cmd.Connection = con;
            try
            {
                SqlCeDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    Title = dtr.GetValue(0).ToString();
                    Author = dtr.GetValue(1).ToString();
                    comments = dtr.GetValue(2).ToString();
                    Registrationdate = (DateTime)dtr.GetValue(3);
                    dtr.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Questionnaire Info retrieval failed." + e1.Message);
            }
            finally
            {
                con.Close();
            }


        }



        public static bool FillTableFromBriefcase(string Filepath, string password, int qid, System.Data.DataTable target, out  object Title, out object Author, out object RegDate, out object NumQuestions)
        {
            Title = "";
            Author = "";
            RegDate = DateTime.MinValue;
            NumQuestions = null;

            System.Data.SqlServerCe.SqlCeCommand cmd = new System.Data.SqlServerCe.SqlCeCommand();

            cmd.Connection = Portable.ConnectionFromFile(Filepath, password);
            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();
            cmd.Parameters.Add("@p1", SqlDbType.Int);
            cmd.Parameters["@p1"].Value = qid;

            cmd.CommandText = "Select Author,Title,Comments,RegistrationDate from VIQInfo where QId=@p1";
            SqlCeDataReader dar = null;
            dar = cmd.ExecuteReader();
            if (dar.Read())
            {
                Title = dar.GetValue(1);
                Author = dar.GetValue(0);

                RegDate = dar.GetValue(3);

                dar.Close();
            }



            cmd.CommandText = "Select QId,CategoryId,DisplayCode,ParentCategoryId,ParentId ,ObjectComments,Defaultcode,ObjectId,ObjectType,ObjectDescription,CHildren,GlobalDisplayIndex,DisplayLevel,InternalDisplayCode from SMquestionnaire where QId=@p1 ORDER BY GLOBALDISPLAYINDEX";


            System.Data.SqlServerCe.SqlCeDataAdapter sqladp = new System.Data.SqlServerCe.SqlCeDataAdapter(cmd);
            sqladp.MissingMappingAction = MissingMappingAction.Passthrough;


            try
            {
                target.Clear();


                int num = sqladp.Fill(target);

                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }


        }



        public static bool FillTable(System.Data.SqlClient.SqlConnection sqlcon, int qid, System.Data.DataTable target, out  object Title, out object Author, out object RegDate, out object NumQuestions)
        {
            Title = "";
            Author = "";
            RegDate = DateTime.MinValue;
            NumQuestions = null;

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.questionnaire_get";
            cmd.Parameters.Add("@p1", SqlDbType.Int);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 128);
            cmd.Parameters[1].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p3", SqlDbType.VarChar, 256);
            cmd.Parameters[2].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p4", SqlDbType.VarChar, 2048);
            cmd.Parameters[3].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p5", SqlDbType.DateTime);
            cmd.Parameters[4].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p6", SqlDbType.Int);
            cmd.Parameters[5].Direction = System.Data.ParameterDirection.Output;

            System.Data.SqlClient.SqlDataAdapter sqladp = new System.Data.SqlClient.SqlDataAdapter(cmd);

            cmd.Connection = sqlcon;
            try
            {
                target.Clear();

                cmd.Parameters["@p1"].Value = qid;
                int num = sqladp.Fill(target);
                Title = cmd.Parameters["@p2"].Value;
                Author = cmd.Parameters["@p3"].Value;
                RegDate = cmd.Parameters["@p5"].Value;
                NumQuestions = cmd.Parameters["@p6"].Value;
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }


        }
        public static System.Data.SqlClient.SqlDataReader GetServerReader(System.Data.SqlClient.SqlConnection sqlcon, int qid, out  object Title, out object Author, out object RegDate, out object NumQuestions)
        {
            Title = "";
            Author = "";
            RegDate = DateTime.MinValue;
            NumQuestions = null;

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.questionnaire_get";
            cmd.Parameters.Add("@p1", SqlDbType.Int);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 128);
            cmd.Parameters[1].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p3", SqlDbType.VarChar, 256);
            cmd.Parameters[2].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p4", SqlDbType.VarChar, 2048);
            cmd.Parameters[3].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p5", SqlDbType.DateTime);
            cmd.Parameters[4].Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@p6", SqlDbType.Int);
            cmd.Parameters[5].Direction = System.Data.ParameterDirection.Output;

            cmd.Connection = sqlcon;
            try
            {
                cmd.Parameters["@p1"].Value = qid;
                System.Data.SqlClient.SqlDataReader sqldr = cmd.ExecuteReader();
                Title = cmd.Parameters["@p2"].Value;
                Author = cmd.Parameters["@p3"].Value;
                RegDate = cmd.Parameters["@p5"].Value;
                NumQuestions = cmd.Parameters["@p6"].Value;
                return sqldr;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return null;
            }


        }

    }

    public class Reporter
    {







        public static void GetQuestionStatistics(SqlConnection con, object fromdate, object todate, object Vesselname, object objectid, out int totalnum, out int totalseen, out int significance, out int errnum, out float perc)
        {

            totalseen = 0;
            totalnum = 0;
            errnum = 0;
            perc = 0f;
            significance = 0;
            if (con == null)
            {
                con = MyConnection.GetConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
            cmd.Parameters[0].Value = objectid;


            cmd.Parameters.Add("@p1", SqlDbType.DateTime);
            cmd.Parameters.Add("@p2", SqlDbType.DateTime);


            if (fromdate != null)
            {
                cmd.Parameters["@p1"].Value = fromdate;
            }
            else
            {
                cmd.Parameters["@p1"].Value = new DateTime(1800, 1, 1);
            }
            if (todate != null)
            {
                cmd.Parameters["@p2"].Value = todate;
            }
            else
            {
                cmd.Parameters["@p2"].Value = DateTime.MaxValue;
            }




            if (Vesselname == null)
            {
                cmd.CommandText = "SELECT count(*) as Total " +
                                 "FROM   Vetting  a inner join VettingInfo b on a.vetid=b.vetid " +
                                 "WHERE  (a.objectid =@p0) and (b.vetdate between @p1 and @p2)";
                // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";
            }
            else
            {
                cmd.CommandText = "SELECT count(*) as Total " +
                                 "FROM   Vetting  a  join VettingInfo b on a.vetid=b.vetid " +
                                 "WHERE  (a.objectid =@p0) and b.VesselName = '" + Vesselname + "'  and (b.vetdate between @p1 and @p2) ";
            }



            totalnum = (int)cmd.ExecuteScalar();



            //-----------------------------------------------
            if (Vesselname == null)
            {
                cmd.CommandText = "SELECT count(*) as Total " +
                                 "FROM   Vetting  a join VettingInfo b on a.vetid=b.vetid " +
                                 "WHERE  (a.objectid =@p0) and (a.answer=1 or a.answer=2) and (b.vetdate between @p1 and @p2)";
                // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";
            }
            else
            {
                cmd.CommandText = "SELECT count(*) as Total " +
                                 "FROM   Vetting  a  join VettingInfo b on a.vetid=b.vetid " +
                                 "WHERE  (a.objectid =@p0) and b.VesselName = '" + Vesselname + "' and (a.answer=1 or a.answer=2) and (b.vetdate between @p1 and @p2)";
            }



            totalseen = (int)cmd.ExecuteScalar();

            //----------------------------------------------
            cmd.CommandText = "SELECT count(*) as Total, sum(significance) as SumSignificance     " +
                             "FROM   " +
                             "Vetting  a JOIN " +
                             "VettingInfo b on a.vetid=b.vetid " +
                             "WHERE  a.answer=2 and    (a.objectid =@p0) and (b.vetdate between @p1 and @p2) ";
            if (Vesselname != null)
                cmd.CommandText += " and vesselname = '" + Vesselname + "' ";




            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    errnum = dr.GetInt32(0);
                    significance = dr.GetInt32(1);
                    if (totalseen > 0)
                    {
                        perc = (float)errnum / (float)totalseen;
                    }
                }
                else
                    throw new Exception("Cannot open data reader");
            }
            catch (Exception e2)
            {
                int i = 0;
            }
            finally
            {
                con.Close();
            }

        }


        public static void FillTableNegativeQuestions(SqlConnection con, System.Data.DataTable tbl)
        {
            if (con == null)
            {
                con = MyConnection.GetConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";

            cmd.CommandText = "SELECT     distinct e.Questioncode,d.categoryDescription category,c.VesselId,c.VesselName, b.categoryid as categorynewid,b.objectid, b.ObjectDescription, b.ObjectComments,d.displayorder " +
                             "FROM         Vetting AS a INNER JOIN " +
                             "Objects AS b ON a.ObjectId = b.ObjectId INNER JOIN " +
                             "VettingInfo AS c ON a.VETId = c.VetId INNER JOIN category as d on b.CategoryId=d.categoryNewid LEFT JOIN QuestionPoolNew e on b.objectid=e.questionid " +
                             "WHERE     (a.answer = 2) order by d.categorydescription";
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                int num = adap.Fill(tbl);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void FillTableVetting(SqlConnection con, System.Data.DataTable tbl)
        {
            if (con == null)
            {
                con = MyConnection.GetConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";

            cmd.CommandText = "SELECT     d.CategoryDescription as Category,c.VesselName,c.InspectorName,c.CompanyRepresentativeName,c.VettingCode,c.VetDate, a.VETId, a.ObjectId, b.ObjectDescription, b.ObjectComments, a.comments AS Comments, a.significance ,e.MajorName ,c.vesselid " +
                             "FROM         Vetting AS a INNER JOIN " +
                             "Objects AS b ON a.ObjectId = b.ObjectId INNER JOIN " +
                             "VettingInfo AS c ON a.VETId = c.VetId INNER JOIN category as d on b.CategoryId=d.categoryNewid " +
                             " LEFT OUTER JOIN MAJORS e ON c.majorid=e.majorid " +
                             "WHERE     (a.answer = 2)";
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                int num = adap.Fill(tbl);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void FillTableVessel(SqlConnection con, System.Data.DataTable tbl)
        {
            if (con == null)
            {
                con = MyConnection.GetConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";

            cmd.CommandText = "SELECT  distinct c.Vesselname,c.VesselId " +
                             "FROM   Vetting AS a INNER JOIN " +
                             "Objects AS b ON a.ObjectId = b.ObjectId INNER JOIN " +
                             "VettingInfo AS c ON a.VETId = c.VetId  " +
                             "WHERE     (a.answer = 2)";
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                int num = adap.Fill(tbl);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static void FillTableQuestion(SqlConnection con, System.Data.DataTable tbl)
        {
            if (con == null)
            {
                con = MyConnection.GetConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";

            cmd.CommandText = "SELECT     d.CategoryDescription as Category,c.VesselName, a.VETId, a.ObjectId, b.ObjectDescription, b.ObjectComments, a.comments AS Comments, a.significance " +
                             "FROM         Vetting AS a INNER JOIN " +
                             "Objects AS b ON a.ObjectId = b.ObjectId INNER JOIN " +
                             "VettingInfo AS c ON a.VETId = c.VetId INNER JOIN category as d on b.CategoryId=d.categoryNewid " +
                             "WHERE     (a.answer = 2)";
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                int num = adap.Fill(tbl);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }









        public static void FillTableNegativeCategoriesPerVessel(SqlConnection con, System.Data.DataTable tbl, int vesselid)
        {
            if (con == null)
            {
                con = MyConnection.GetConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";

            cmd.CommandText = "SELECT     f.categoryid,f.categoryDescription ,isnull(f.categorycode,'?') as CategoryCode,f.categoryNewId,f.displayorder  FROM " +
                             " (Select distinct c.categoryid " +
                             "FROM         Vetting AS a INNER JOIN VettingInfo d on a.vetid=d.vetid inner join " +
                             "Objects AS b ON a.objectid = b.objectid INNER JOIN category c  on b.CategoryId=c.categoryNewid " +
                             "WHERE     (a.answer = 2) and (d.vesselid=@pvesselid)    ) g join category f on g.categoryid=f.categoryid order by f.displayorder";
            cmd.Parameters.Add("@pvesselid", SqlDbType.Int).Value = vesselid;

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                int num = adap.Fill(tbl);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public static void FillTableNegativeCategoriesPerFleet(SqlConnection con, System.Data.DataTable tbl)
        {
            if (con == null)
            {
                con = MyConnection.GetConnection();
            }
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            // cmd.CommandText = " (Select a.objectid,b.ObjectDescription,b.ObjectComments,a.comments As Comments,a.significance from vetting a join Objects b on a.objectid=b.objectid where a.answer=1) a  join VettingInfo c on a.vetid=c.vetid ";

            cmd.CommandText = "Select a.*,b.categorydescription,b.categorycode,c.vesselname,b.categorynewid from " +
                                " ( SELECT     distinct b.categoryid,d.vesselid " +
                             " FROM         Vetting AS a INNER JOIN VettingInfo d on a.vetid=d.vetid inner join " +
                             " Objects AS b ON a.objectid = b.objectid INNER JOIN category c  on b.CategoryId=c.categoryNewid " +
                             " WHERE     (a.answer = 2))  as a join category b on a.categoryid=b.categorynewid join vessel c on a.vesselid=c.vesselid " +

                             " order by categorycode,c.vesselname";


            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                int num = adap.Fill(tbl);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }
        }



    }



     



    public class VIQInfo
    {

        public void UpdateVIQInfo(int viqid, string title, string author, string comment, System.Data.SqlClient.SqlTransaction tr)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Update VIQInfo set title=@p1,author=@p2,comments=@p3,Registrationdate=getdate()where qid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters.Add("@p1", SqlDbType.VarChar);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar);
            cmd.Parameters.Add("@p3", SqlDbType.VarChar);


            cmd.Parameters[0].Value = viqid;
            cmd.Parameters[1].Value = title;
            cmd.Parameters[2].Value = author;
            cmd.Parameters[3].Value = comment;

            cmd.Connection = tr.Connection;
            cmd.Transaction = tr;
            cmd.ExecuteNonQuery();

        }


        public static void SaveVIQInfo(out int viqid, string title, string author, string comment, System.Data.SqlClient.SqlTransaction tr)
        {
            viqid = -1;
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Insert into VIQInfo (title,author,comments,Registrationdate,VIQGUI) values (@p1,@p2,@p3,getdate(),@p4)";
            //cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters.Add("@p1", SqlDbType.VarChar);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar);
            cmd.Parameters.Add("@p3", SqlDbType.VarChar);
            cmd.Parameters.Add("@p4", SqlDbType.UniqueIdentifier);


            //cmd.Parameters[0].Value = viqid;
            cmd.Parameters[0].Value = title;
            cmd.Parameters[1].Value = author;
            cmd.Parameters[2].Value = comment;
            Guid newid = System.Guid.NewGuid();
            cmd.Parameters[3].Value = newid;

            cmd.Connection = tr.Connection;
            cmd.Transaction = tr;
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Select Qid from VIQInfo where ViqGUI =@p0";
            cmd.Parameters.Clear();

            cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
            cmd.Parameters[0].Value = newid;
            viqid = (int)cmd.ExecuteScalar();




        }
       


        public static void SaveVIQInfo1(out int viqid, string title, System.Data.SqlClient.SqlTransaction tr)
        {
            viqid = -1;
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            //cmd.CommandText = "Insert into VIQInfo (qid,title,author,comments,Registrationdate) values (@p0,@p1,@p2,@p3,getdate())";
            cmd.CommandText = "Insert into VIQInfo (title,author,comments,Registrationdate) values (@p1,@p2,@p3,getdate())";
            //cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters.Add("@p1", SqlDbType.VarChar);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar);
            cmd.Parameters.Add("@p3", SqlDbType.VarChar);


            //cmd.Parameters[0].Value = viqid;
            cmd.Parameters[1].Value = title;
            cmd.Parameters[2].Value = DBNull.Value;
            cmd.Parameters[3].Value = DBNull.Value;

            cmd.Connection = tr.Connection;
            cmd.Transaction = tr;
            cmd.ExecuteNonQuery();

        }


        public static int Select(SqlConnection con, DataTable tbl)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT QId, Title, RegistrationDate, Comments, Author, Finalized, NumOfQuestions, EffectiveDate, Version " +
                            "FROM VIQInfo ";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                return da.Fill(tbl);
            }
            catch (Exception e1)
            {
                throw new Exception("VQIInfo select error :" + e1.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
    public class VIQ
    {
        public int QID;
        public object Title;
        public object Author;
        public object Description;
        public object Finalized;
        public object Registrationdate;



        bool CheckIfExists(int qid, System.Data.SqlClient.SqlTransaction trn)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "select count(*) from VIQInfo where qid = @p0 ";
            cmd.Parameters.Add("@p0", SqlDbType.Int);


            cmd.Parameters[0].Value = qid;
            cmd.Connection = trn.Connection;
            cmd.Transaction = trn;
            if ((int)cmd.ExecuteScalar() != 0)
                return true;
            return false;
        }

        public  static void Delete(int qid, System.Data.SqlClient.SqlConnection con)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "delete from VIQInfo where qid = @p0 ";
            cmd.Parameters.Add("@p0", SqlDbType.Int);


            cmd.Parameters[0].Value = qid;
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
        }



        public static void SetAdapterSelectParameter(SqlDataAdapter da,int qid)
        {
            da.SelectCommand.Parameters[0].Value = qid;
        }

        public static SqlDataAdapter GetAdapter(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "SELECT Children,QId, ObjectType, CategoryId, QuestionId, CommentId, ParentId, ParentType, DisplayIndex, DisplayLevel, ObjectId, ParentCategory FROM VIQ WHERE (QId = @P0) ORDER BY GlobalDisplayIndex";
            da.SelectCommand.Parameters.Add("@p0",SqlDbType.Int);

            da.InsertCommand=new SqlCommand();
            da.InsertCommand.CommandText="INSERT INTO [VIQ] ([Children], [QId], [ObjectType], [CategoryId], [QuestionId], [CommentId], [ParentId], [ParentType], [DisplayIndex], [DisplayLevel], [ObjectId], [ParentCategory]) VALUES (@Children, @QId, @ObjectType, @CategoryId, @QuestionId, @CommentId, @ParentId, @ParentType, @DisplayIndex, @DisplayLevel, @ObjectId, @ParentCategory)";
            da.InsertCommand.Parameters.Add("@Children",SqlDbType.Int,4,"@Children");
            da.InsertCommand.Parameters.Add("@QId",SqlDbType.Int,4,"@QId");
            da.InsertCommand.Parameters.Add("@ObjectType",SqlDbType.Int,4,"@ObjectType");
            da.InsertCommand.Parameters.Add("@CategoryId",SqlDbType.Int,4,"@CategoryId");
            da.InsertCommand.Parameters.Add("@QuestionId",SqlDbType.UniqueIdentifier,16,"@QuestionId");
            da.InsertCommand.Parameters.Add("@CommentId",SqlDbType.UniqueIdentifier,16,"@CommentId");
            da.InsertCommand.Parameters.Add("@ParentId",SqlDbType.UniqueIdentifier,16,"@ParentId");
            da.InsertCommand.Parameters.Add("@ParentType",SqlDbType.Int,4,"@ParentType");
            da.InsertCommand.Parameters.Add("@DisplayIndex",SqlDbType.Int,4,"@DisplayIndex");
            da.InsertCommand.Parameters.Add("@DisplayLevel",SqlDbType.Int,4,"@DisplayLevel");
            da.InsertCommand.Parameters.Add("@ObjectId",SqlDbType.UniqueIdentifier,16,"@ObjectId");
            da.InsertCommand.Parameters.Add("@ParentCategory",SqlDbType.UniqueIdentifier,16,"@ParentCategory");


            da.InsertCommand.Connection = con;
            da.SelectCommand.Connection = con;


            return da;





        }

        public static string GetObjectTitlePath(SqlConnection con, Guid objectid, int Qid)
        {

            Stack<object> s = new Stack<object>();
            Guid anid = objectid;
            string k = "";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Select objectdescription,parentid from VIQPlus  where qid=@p2 and objectid=@p1";
            cmd.Connection = con;
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Parameters.Add("@p1", SqlDbType.UniqueIdentifier).Value = anid;
            cmd.Parameters.Add("@p2", SqlDbType.Int).Value = Qid;

            try
            {
                SqlDataReader sdr = null;
                while (anid != Guid.Empty)
                {
                    cmd.Parameters[0].Value = anid;
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        anid = (Guid)sdr[1];
                        s.Push(sdr[0]);
                    }
                    sdr.Close();
                }
                while (s.Count > 0)
                {
                    k += s.Pop().ToString() + " / ";
                }
                return k;
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }
        }



        public static bool HasCategoryRelatedQuestionsInVIQ(SqlConnection con, Guid catid)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = " SELECT TOP 1 QID from VIQ where OBJECTID in  (SELECT QUESTIONID FROM QUESTIONPOOLNEW WHERE CATEGORYNEWID=@p1 )";
            cmd.Parameters.Add("@p1", SqlDbType.UniqueIdentifier);
            cmd.Parameters[0].Value = catid;
            cmd.Connection = con;
            if (con.State != ConnectionState.Open)
                con.Open();

            try
            {
                int num = (int)cmd.ExecuteScalar();
                return true;
            }
            catch (Exception e1)
            {
                return false;
            }
            finally
            {
                con.Close();
            }

        }

        public static bool IsVIQRelatedObject(SqlConnection con, Guid quid)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = " SELECT TOP 1 QID from VIQ where OBJECTID =@p1 ";
            cmd.Parameters.Add("@p1", SqlDbType.UniqueIdentifier);
            cmd.Parameters[0].Value = quid;
            cmd.Connection = con;
            if (con.State != ConnectionState.Open)
                con.Open();

            try
            {
                int num = (int)cmd.ExecuteScalar();
                return true;
            }
            catch (Exception e1)
            {
                return false;
            }
            finally
            {
                con.Close();
            }


        }

        public static void DeleteQuestionnaire(SqlConnection con, SqlTransaction trans, int anid)
        {

            if (VIQ.HasRelatedAttendances(con, trans, anid))
            {
                throw new Exception("Questionnaire is related to registered attendances");

            }
            if (VIQ.IsFinalized(con, trans, anid))
            {
                throw new Exception("Finalized questionnaire cannot be deleted without permission.");
            }


            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Delete from VIQInfo where qid = @p1";
            cmd.Parameters.Add("@p1", SqlDbType.Int);
            cmd.Parameters["@p1"].Value = anid;
            cmd.Connection = con;
            if (trans != null)
                cmd.Transaction = trans;

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e1)
            {
                throw new Exception("Cannot delete VIQ");
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }
        }

        public void Select(int anid, System.Data.SqlClient.SqlConnection con)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Select * from VIQInfo where qid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = anid;
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();
            System.Data.SqlClient.SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Title = (string)dr["Title"];
                this.QID = anid;
                this.Author = dr["Author"];
                this.Description = dr["comments"];
                this.Registrationdate = dr["Registrationdate"];
            }
            con.Close();
        }

        public static bool IsFinalized(SqlConnection con, SqlTransaction trans, int qid)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "select finalized from VIQInfo where Qid= @p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);



            cmd.Parameters[0].Value = qid;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.Connection = con;
            if (con.State != ConnectionState.Open)
                con.Open();

            try
            {
                object o = cmd.ExecuteScalar();
                int num = Convert.ToInt32(o);
                if (num == 1)
                    return true;
                return false;

            }
            catch (Exception e1)
            {
                return false;
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }

        }


        public static bool HasRelatedAttendances(SqlConnection con, SqlTransaction trans, int qid)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "select count(*) from VettingInfo where Qid= @p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);



            cmd.Parameters[0].Value = qid;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.Connection = con;
            if (con.State != ConnectionState.Open)
                con.Open();

            try
            {
                int num = (int)cmd.ExecuteScalar();
                if (num == 0)
                    return false;
                return true;

            }
            catch (Exception e1)
            {
                throw new Exception("Failed to retrieve Question num " + e1.Message);
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }

        }

        public static void updateQuestionCount(System.Data.SqlClient.SqlConnection con, System.Data.SqlClient.SqlTransaction trans, int Qid, int NofQ)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "update  VIQInfo set NumOfQuestions = @p0 where qid= @p1 ";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters.Add("@p1", SqlDbType.Int);

            cmd.Parameters[0].Value = NofQ;
            cmd.Parameters[1].Value = Qid;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.Connection = con;
            try
            {
                int num = cmd.ExecuteNonQuery();

            }
            catch (Exception e1)
            {
                throw new Exception("Failed to retrieve Question num " + e1.Message);
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }


        }

        public static int GetQuestionCount(System.Data.SqlClient.SqlConnection con, System.Data.SqlClient.SqlTransaction trans, int Qid)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Select COUNT(*) from VIQ where qid=@p0 and ObjectType<>2 ";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = Qid;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.Connection = con;
            try
            {
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                return num;
            }
            catch (Exception e1)
            {
                throw new Exception("Failed to retrieve Question num " + e1.Message);
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }


        }
    }

    public class VIQObject
    {
        public enum VIQType { Question = 0, Comment = 1, Category = 2 }
        public VIQType OType;
        public VIQObject(VIQType atype)
        {
            this.OType = atype;
            this.parent = Guid.Empty;
            this.QuestionId = Guid.Empty;
            this.Category = Guid.Empty;
            this.ObjectId = Guid.Empty;
            this.CommentId = Guid.Empty;
            Level = 0;
            DisplayIndex = 0;
            AnId = 0;
            this.Node = null;
        }
        public Guid ObjectId;
        public int AnId;
        public int DisplayIndex;
        public int Level;
        public Guid parent;
        public Guid Category;
        public Guid QuestionId;
        public Guid CommentId;
        public int CategoryId;
        public TreeNode Node;
        public String Content;
        public DataRow NodeDataRow;
        public string DisplayCode;
        public string DefaultCode;
        public string InternalDisplayCode;
        public int Origin;



        public static void FillVIO(VIQObject vo, System.Data.SqlClient.SqlConnection con)
        {
            System.Data.SqlClient.SqlCommand sqlcmd = null;


            System.Data.SqlClient.SqlCommand cmd_q = new System.Data.SqlClient.SqlCommand();
            cmd_q.Connection = con;
            cmd_q.CommandText = "Select question,comment,Origin,QuestionCode from QuestionPoolNew where questionid = @p0";
            cmd_q.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);

            System.Data.SqlClient.SqlCommand cmd_c = new System.Data.SqlClient.SqlCommand();
            cmd_c.Connection = con;
            cmd_c.CommandText = "Select CategoryDescription,CategoryCode from Category where categoryNewId = @p0";
            cmd_c.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (vo.OType == VIQObject.VIQType.Category)
            {
                sqlcmd = cmd_c;
                sqlcmd.Connection = con;
                sqlcmd.Parameters[0].Value = vo.ObjectId;
                System.Data.SqlClient.SqlDataReader dr = cmd_c.ExecuteReader();
                if (dr.Read())
                {
                    vo.Content = (string)dr["CategoryDescription"];
                    vo.DefaultCode = dr["CategoryCode"].ToString();
                }
                dr.Close();
            }
            else if (vo.OType == VIQObject.VIQType.Question)
            {

                sqlcmd = cmd_q;
                sqlcmd.Connection = con;
                sqlcmd.Parameters[0].Value = vo.ObjectId;
                System.Data.SqlClient.SqlDataReader dr = sqlcmd.ExecuteReader();
                if (dr.Read())
                {
                    vo.Content = (string)dr["Question"];
                    vo.Origin = (int)dr["Origin"];
                    vo.DefaultCode = dr["QuestionCode"].ToString();
                }
                dr.Close();
            }


        }




        public static void ClearPersistance(System.Data.SqlClient.SqlTransaction trn)
        {

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Delete from VIQ";
            cmd.Connection = trn.Connection;
            cmd.Transaction = trn;
            cmd.ExecuteNonQuery();


        }
        public static void ClearPersistance(System.Data.SqlClient.SqlTransaction trn, int qid)
        {

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = "Delete from VIQ where qid =@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Connection = trn.Connection;
            cmd.Transaction = trn;
            cmd.Parameters[0].Value = qid;
            cmd.ExecuteNonQuery();


        }
        public int SaveToPersistance(int viqid, ref int row, System.Data.SqlClient.SqlTransaction trn)
        {





            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

            cmd.Connection = trn.Connection;
            cmd.Transaction = trn;


            cmd.CommandText = "insert into VIQ (QId,ObjectType,CategoryId,QuestionId,CommentId,ObjectId,ParentId,ParentType,DisplayIndex,DisplayLevel,ParentCategory,GlobalDisplayIndex,Children,DisplayCode,InternalDisplayCode) values (@p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)";
            cmd.Parameters.Add("@p0", SqlDbType.Int);//QID
            cmd.Parameters.Add("@p1", SqlDbType.Int);//ObjectType
            cmd.Parameters.Add("@p2", SqlDbType.Int);//CategoryID
            cmd.Parameters.Add("@p3", SqlDbType.UniqueIdentifier);//QuestionId

            cmd.Parameters.Add("@p4", SqlDbType.UniqueIdentifier);//commentID
            cmd.Parameters.Add("@p5", SqlDbType.UniqueIdentifier);//ObjectId
            cmd.Parameters.Add("@p6", SqlDbType.UniqueIdentifier);//ParentId
            cmd.Parameters.Add("@p7", SqlDbType.Int);//ParentType
            cmd.Parameters.Add("@p8", SqlDbType.Int);//DisplayIndex
            cmd.Parameters.Add("@p9", SqlDbType.Int);//DisplayLevel
            cmd.Parameters.Add("@p10", SqlDbType.UniqueIdentifier);//ParentCategory

            cmd.Parameters.Add("@p11", SqlDbType.Int);
            cmd.Parameters.Add("@p12", SqlDbType.Int);
            cmd.Parameters.Add("@p13", SqlDbType.VarChar, 64).Value = DBNull.Value;
            cmd.Parameters.Add("@p14", SqlDbType.VarChar, 64).Value = DBNull.Value;
            //cmd.CommandText = "insert into VIQ (QId) values (@p0)";
            cmd.Parameters[0].Value = viqid;
            cmd.Parameters[1].Value = this.OType;
            cmd.Parameters[2].Value = this.CategoryId;
            cmd.Parameters[3].Value = this.CommentId;
            cmd.Parameters[4].Value = this.QuestionId;
            cmd.Parameters[5].Value = this.ObjectId;



            if (this.Node.Parent != null && this.Node.Parent.Level > 0)
            {
                cmd.Parameters[6].Value = (this.Node.Parent.Tag as VIQObject).ObjectId;
                cmd.Parameters[7].Value = (this.Node.Parent.Tag as VIQObject).OType;
                TreeNode cn = this.Node.Parent;
                cmd.Parameters[10].Value = Guid.Empty;
                while (cn.Level != 0)
                {
                    if ((cn.Tag as VIQObject).OType == VIQType.Category)
                    {
                        cmd.Parameters[10].Value = (cn.Tag as VIQObject).ObjectId;
                        break;
                    }
                    cn = cn.Parent;
                }
            }
            else
            {
                cmd.Parameters[6].Value = Guid.Empty;
                cmd.Parameters[7].Value = DBNull.Value;
                cmd.Parameters[10].Value = Guid.Empty;
            }
            cmd.Parameters[8].Value = this.Node.Index;
            cmd.Parameters[9].Value = this.Node.Level;

            cmd.Parameters[11].Value = row++;
            cmd.Parameters[12].Value = this.Node.Nodes.Count;
            if (this.DisplayCode != null)

                cmd.Parameters[13].Value = this.DisplayCode;
            if (this.InternalDisplayCode != null)
                cmd.Parameters[14].Value = this.InternalDisplayCode;

            int rows = cmd.ExecuteNonQuery();



            if (this.Node.Nodes.Count > 0)
            {
                for (int i = 0; i < this.Node.Nodes.Count; i++)
                {
                    rows += (this.Node.Nodes[i].Tag as VIQObject).SaveToPersistance(viqid, ref row, trn);
                }

            }
            return rows;

        }


    }


    
    public class VettingRequest
    {

        public static DataTable SelectSchedule(SqlConnection con, object RequestId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT RequestScheduleId,VetRequestId, VesselId, VetDateFrom, VetDateTo, Comments "+
                              " FROM AttendanceV1.dbo.RequestSchedule where VetRequestId=VetRequestId ";
            
            if (RequestId!=null)
            {
               cmd.CommandText+=" and VetRequestid=@VetRequestid" ;
               cmd.Parameters.Add("@VetRequestid", SqlDbType.Int).Value = RequestId;
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);



            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            DataTable tbl = new DataTable();
            try
            {
                int num = da.Fill(tbl);
                return tbl;
            }
            catch (Exception e)
            {
                throw new Exception("Select Request's Schedule error : " + e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable Select(SqlConnection con)
        {
            SqlCommand cmd=new SqlCommand();
            cmd.Connection=con;
            cmd.CommandText=" SELECT VetRequestId, UserId, UserName, ComputerName, RequestCode, RequestDate, Granted, GrantedDate"+ 
          " FROM AttendanceV1.dbo.VettingRequest ";
            SqlDataAdapter da=new SqlDataAdapter(cmd);



            if (con.State!=ConnectionState.Open)

            {
                con.Open();
            }
            DataTable tbl=new DataTable();
            try
            {
                int num=da.Fill(tbl);
                return tbl;
            }
            catch(Exception e)
            {
                throw new Exception("Select Requests error : "+e.Message);
            }
            finally
            {
                con.Close();
            }


        }


        public static void SaveSchedule(SqlConnection con, DataTable tbl)
        {

            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmdi = new SqlCommand();
            cmdi.Connection = con;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            cmdi.CommandText = "INSERT INTO AttendanceV1.dbo.RequestSchedule " +
                               "(VetRequestId, VesselId, VetDateFrom, VetDateTo, Comments) " +
                                        " VALUES (VetRequestId, VesselId, 'VetDateFrom', VetDateTo, 'Comments') set @requestscheduleid=scope_identity()";

            cmdi.Parameters.Add("@VetRequestId", SqlDbType.Int, 4, "VetRequestID");
            cmdi.Parameters.Add("@VesselId", SqlDbType.Int, 4, "VesselId").Value = DBNull.Value;
            cmdi.Parameters.Add("@VetDateFrom", SqlDbType.DateTime, -1, "VetDateFrom").Value = DBNull.Value;
            cmdi.Parameters.Add("@VetDateTo", SqlDbType.DateTime, -1, "VetDateTo").Value = DBNull.Value;
            cmdi.Parameters.Add("@Comments", SqlDbType.VarChar, -1, "Comments");
            cmdi.Parameters.Add("@RequestScheduleId", SqlDbType.Int,4, "requestShceduleId");
            
            


            da.InsertCommand = cmdi;

            
            try
            {
                int num = da.Update(tbl);
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }


        }


        public static void Save(SqlConnection con, DataTable tbl)
        {

            SqlDataAdapter da = new SqlDataAdapter();

            SqlCommand cmdi = new SqlCommand();
            cmdi.Connection = con;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            cmdi.CommandText = "INSERT INTO AttendanceV1.dbo.VettingRequest(UserId, UserName, ComputerName, RequestCode, RequestDate)" +
                            "VALUES (@UserId, @UserName, @ComputerName, @RequestCode, @RequestDate) set @VetRequestId=scope_identity()";
            cmdi.Parameters.Add("@UserId", SqlDbType.Int, 4, "UserId").Value = DBNull.Value;
            cmdi.Parameters.Add("@UserName", SqlDbType.VarChar, -1, "UserName").Value = DBNull.Value;
            cmdi.Parameters.Add("@ComputerName", SqlDbType.VarChar, -1, "ComputerName").Value = DBNull.Value;
            cmdi.Parameters.Add("@RequestCode", SqlDbType.VarChar, -1, "RequestCode");
            cmdi.Parameters.Add("@RequestDate", SqlDbType.DateTime, -1, "RequestDate");
            cmdi.Parameters.Add("@VetRequestId", SqlDbType.Int, -1, "VetRequestID").Direction = ParameterDirection.Output;


            da.InsertCommand = cmdi;

            SqlCommand cmdd = new SqlCommand();

            cmdd.CommandText = "Delete from  AttendanceV1.dbo.VettingRequest where VetRequestId=@VetRequestId";
            cmdd.Parameters.Add("@VetRequestId", SqlDbType.Int, -1, "VetRequestID").SourceVersion = DataRowVersion.Original;



            da.DeleteCommand = cmdd;

            try
            {
                int num = da.Update(tbl);
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }











        }
    }

    public class Vetting
    {

        public static int VesselEncounter(SqlConnection con, int vesselid)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            //cmd.CommandText = "Select a.*,b.answer,b.significance,b.Comments as InspectorComments from VettingInfo a join Vetting b on a.vetid=b.vetid and b.objectid=@p0";
            cmd.CommandText = "Select count(*) from VettingInfo where vesselid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = vesselid;
            try
            {
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                return num;

            }
            catch (Exception e1)
            {
                throw new Exception("Vessel vetting relation failed to be retrieved");
            }
            finally
            {
                con.Close();
            }


        }

        public static int FillObjectRelatedTable(SqlConnection con, Guid objectid, int Vesselid, System.Data.DataTable target)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cmd.CommandText = "Select a.*,b.answer,b.significance,b.Comments as InspectorComments from VettingInfo a join Vetting b on a.vetid=b.vetid and b.objectid=@p0";
            if (Vesselid != -1)
            {
                cmd.CommandText = "Select a.*,b.answer,b.Significance,b.Comments as InspectorComments from VettingInfo a join Vetting b  on a.vetid=b.vetid and b.objectid=@p0 join VIQ c on b.objectid=c.objectid and a.qid=c.qid where a.vesselid=@p1 order by a.vetdate";
                cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
                cmd.Parameters.Add("@p1", SqlDbType.Int).Value = Vesselid;

            }
            else
            {
                cmd.CommandText = "Select a.*,b.answer,b.Significance,b.Comments as InspectorComments from VettingInfo a join Vetting b  on a.vetid=b.vetid and b.objectid=@p0 join VIQ c on b.objectid=c.objectid and a.qid=c.qid order by a.vetdate";
                cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);

            }
            cmd.Parameters[0].Value = objectid;

            try
            {
                return da.Fill(target);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }

        }
        public static VettingInfo LoadInfo(SqlConnection con, int vetid)
        {
            VettingInfo vi = new VettingInfo();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.CommandText =

            cmd.CommandText = "Select a.QId,a.VesselName,a.InspectorName,a.VettingCode,a.VetGUI,a.port,a.vetdate,a.comments,a.CompanyRepresentativeName,a.Inspectiontypeid,b.Inspectiontype from VettingInfo a join InspectionTypes b on a.inspectiontypeid=b.inspectiontypeid where vetid=@P0";
            cmd.Parameters.Add("@P0", SqlDbType.Int);

            cmd.Parameters[0].Value = vetid;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    vi.Qid = dr.GetInt32(0);
                    vi.VesselName = dr.GetValue(1).ToString();
                    vi.InspectorName = dr.GetValue(2).ToString();

                    vi.VettingCode = dr.GetValue(3).ToString();
                    vi.VetGUI = dr.GetGuid(4);
                    vi.Port = dr.GetValue(5).ToString();
                    vi.VettingDate = dr.GetDateTime(6);

                    vi.Comments = dr.GetValue(7).ToString();
                    vi.CompanyRepresentativeName = dr.GetValue(8).ToString();
                    vi.InspectionTypeId = (int)dr.GetValue(9);
                    vi.InspectionType = dr.GetValue(10).ToString();

                }
                dr.Close();

                return vi;


            }
            catch (Exception e1)
            {
                throw new Exception("failed to retrieve vetting info" + e1.Message);

            }
            finally
            {
                con.Close();
            }

        }

        public static void LoadResults(SqlConnection con, int vetid, int qid, System.Data.DataTable target)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "   select a.*,b.answer,b.significance,b.comments from    select * from ( Select a1.qid,a1.globaldisplayindex,a1.ObjectId,a1.ObjectType,a1.children ,a2.CategoryDescription ObjectDescription from VIQ a1 join Category  a2 on a1.objectid=a2.categorynewid UNION ALL 
            //Select a1.qid,a1.globaldisplayindex,a1.ObjectId,a1.ObjectType,a1.children ,a2.question ObjectDescription from VIQ a1 join QuestionPoolnew  a2 on a1.objectid=a2.questionid ) a  LEFT JOIN VETTING B ON A.OBJECTID=B.OBJECTID WHERE A.Qid=@P0 AND B.VETID=@P1 ORDER BY A.GLOBALDISPLAYINDEX";


            cmd.CommandText =
" select InternalDisplayCode,a.*,b.answer,b.significance,b.comments from " +

"(" +

"Select a1.InternalDisplayCode,a1.DisplayCode,a1.ParentId,a1.displaylevel,a1.qid,a1.globaldisplayindex," +
        "a1.ObjectId,a1.ObjectType,a1.children ,a2.CategoryDescription ObjectDescription,null ObjectComments,a2.categorycode as defaultcode from " +
"VIQ a1  " +
" join " +
"Category  as a2 on a1.objectid=a2.categorynewid  where a1.qid=@p0 " +


" UNION ALL " +

"Select a1.InternalDisplayCode,a1.DisplayCode,a1.ParentId,a1.displaylevel,a1.qid,a1.globaldisplayindex," +
        "a1.ObjectId,a1.ObjectType,a1.children ,a2.question ObjectDescription,a2.comment ObjectComments, a2.questioncode as defaultcode from " +
"VIQ a1 " +
" join " +
"QuestionPoolnew as  a2 on a1.objectid=a2.questionid  where a1.qid=@p0  " +

")A  " +
" LEFT JOIN VETTING B ON A.OBJECTID=B.OBJECTID WHERE B.VETID=@P1 ORDER BY A.GLOBALDISPLAYINDEX "

;
            cmd.Parameters.Add("@P0", SqlDbType.Int);
            cmd.Parameters.Add("@P1", SqlDbType.Int);

            cmd.Parameters[0].Value = qid;
            cmd.Parameters[1].Value = vetid;
            if (con.State != ConnectionState.Open)
                con.Open();

            SqlDataAdapter sqlad = new SqlDataAdapter();
            sqlad.SelectCommand = cmd;
            try
            {
                int num = sqlad.Fill(target);
            }
            catch (Exception e1)
            {
                throw new Exception("Failed to retrieve registered attendances " + e1.Message);
            }
            finally
            {
                con.Close();
            }

        }


        public static DataTable SelectInspectionTypes(SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select InspectionTypeid,InspectionType,InspectionCode from InspectionTypes order by inspectiontype ";
            if (con.State != ConnectionState.Open)
                con.Open();

            SqlDataAdapter sqlad = new SqlDataAdapter();
            sqlad.SelectCommand = cmd;
            DataTable target = new DataTable();
            try
            {
                int num = sqlad.Fill(target);
                if (num > 0)
                    return target;
                return null;
            }
            catch (Exception e1)
            {
                throw new Exception("Failed to retrieve registered types " + e1.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public static void FillTable(SqlConnection con, System.Data.DataTable target)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select a.*,b.title as questionnairetitle,b.title,b.version,c.inspectiontype,b.NumOfQuestions as QuestionnaireTemplate,b.NumOfQuestions,e.majorname from VettingInfo a join VIQInfo b on a.qid=b.qid  join InspectionTypes c on a.inspectiontypeid=c.inspectiontypeid left outer join majors e on a.majorid=e.majorid order by a.Vetdate desc";
            if (con.State != ConnectionState.Open)
                con.Open();

            SqlDataAdapter sqlad = new SqlDataAdapter();
            sqlad.SelectCommand = cmd;
            try
            {
                int num = sqlad.Fill(target);
            }
            catch (Exception e1)
            {
                throw new Exception("Failed to retrieve registered attendances " + e1.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static bool CopyQuestionnaireContext(SqlConnection con, SqlTransaction trans, int VetId, int Qid)
        {
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            if (trans != null)
                cmd.Transaction = trans;
            cmd.Connection = con;





            cmd.CommandText = " insert into vetting (VetId,ObjectId) Select " + VetId.ToString() + " as VetId, ObjectId from VIQ where Qid= @p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = Qid;
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show("Creation of vetting context failed :" + e1.Message);
                return false;
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }

        }

        public static bool QuestionnaireExist(SqlConnection con, SqlTransaction trans, Guid quid)
        {
            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            if (trans != null)
                cmd.Transaction = trans;




            cmd.CommandText = "select count(*) from VIQInfo where viqgui = @p0 ";



            cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);


            cmd.Parameters[0].Value = quid;




            try
            {
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                if (num > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }


        }


        public static bool InsertVettingInfo(SqlConnection con, SqlTransaction trans, out int VetId, Guid VetGUI, int QId, object VettingCode, object VetDate, object InspectorName, object CompanyRepresentativeName, object VesselId, object VesselName, object Port, object VetTypeId, object Comments)
        {
            VetId = -1;


            System.Data.SqlClient.SqlCommand cmd = new SqlCommand();
            if (trans != null)
                cmd.Transaction = trans;
            cmd.Connection = con;





            cmd.CommandText = " Insert into VettingInfo  (Qid,VetGUI,Inspectorname,CompanyRepresentativeName,VesselId,VesselName,Port,VetDate,VettingCode,InspectionTypeId,Comments,RegistrationDate) values(@p0,@p1,@p2,@p9,@p3,@p4,@p5,@p6,@p7,@p8,@p10,@p11) ";


            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters.Add("@p1", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add("@p2", SqlDbType.VarChar, 64);
            cmd.Parameters.Add("@p3", SqlDbType.Int);
            cmd.Parameters.Add("@p4", SqlDbType.VarChar, 64);
            cmd.Parameters.Add("@p5", SqlDbType.VarChar, 64);
            cmd.Parameters.Add("@p6", SqlDbType.DateTime);
            cmd.Parameters.Add("@p7", SqlDbType.VarChar, 64);
            cmd.Parameters.Add("@p8", SqlDbType.Int);
            cmd.Parameters.Add("@p9", SqlDbType.VarChar, 64);
            cmd.Parameters.Add("@p10", SqlDbType.VarChar, 4000);
            cmd.Parameters.Add("@p11", SqlDbType.DateTime).Value = DateTime.Now;


            cmd.Parameters[0].Value = QId;
            cmd.Parameters[1].Value = VetGUI;
            cmd.Parameters[2].Value = InspectorName;
            cmd.Parameters[3].Value = VesselId;
            cmd.Parameters[4].Value = VesselName;
            cmd.Parameters[5].Value = Port;
            cmd.Parameters[6].Value = VetDate;
            cmd.Parameters[7].Value = VettingCode;
            cmd.Parameters[8].Value = VetTypeId;
            cmd.Parameters[9].Value = CompanyRepresentativeName;
            cmd.Parameters[10].Value = Comments;



            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT VetId from VettingInfo where VetGUI = @p0";
                cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
                cmd.Parameters[0].Value = VetGUI;


                VetId = (int)cmd.ExecuteScalar();




                return true;
            }
            catch (Exception e1)
            {
                string message = "";
                if (e1.Message.IndexOf("UK_VettingInfo_VetGUI") > 0)
                    message = "Attendace is already registered";
                else
                    message = e1.Message;
                MessageBox.Show("Creation of vetting context failed :" + message);
                return false;
            }
            finally
            {
                if (trans == null)
                    con.Close();

            }
        }
        public static void TransferFromBriefcase(string fpath, string password, int VetId, Guid VetGUI, int QId)
        {
            SqlCeConnection cecon = Portable.ConnectionFromFile(fpath, password);
            if (cecon.State != ConnectionState.Open)
            {
                cecon.Open();
            }




            //Get vetting Info


            VettingInfo BC_vet = Portable.GetVettingInfo(cecon, VetId);



            System.Data.DataSet ds = new DataSet();
            DataTable b_vet_table = new DataTable();
            ds.Tables.Add(b_vet_table);
            int qid = -1;
            object vesselname = null;
            object inspectorname = null;
            object companyrepresentativename = null;
            object vetocde = null;
            ds.EnforceConstraints = false;







            System.Data.SqlServerCe.SqlCeDataAdapter vad = Portable.GetVettingAdapter(cecon, VetId);

            int num = vad.Fill(b_vet_table);

            foreach (DataRow dr in b_vet_table.Rows)
            {
                dr.SetModified();
            }


            cecon.Close();




            SqlConnection con = MyConnection.GetConnection();
            SqlTransaction trans = con.BeginTransaction();
            int db_vetid = -1;
            Guid db_vetgui = System.Guid.Empty;

            try
            {

                if (!Vetting.QuestionnaireExist(con, trans, BC_vet.ViqGUI))
                    throw new Exception("Questionnaire is not registered import aborted");

                if (!Vessel.Exist(con, trans, BC_vet.VesselName))
                    throw new Exception("Vessel name is not registered import aborted");
                if (!Vetting.InsertVettingInfo(con, trans, out db_vetid, VetGUI, QId, BC_vet.VettingCode, BC_vet.VettingDate, BC_vet.InspectorName, BC_vet.CompanyRepresentativeName, BC_vet.VesselId, BC_vet.VesselName, BC_vet.Port, BC_vet.InspectionTypeId, BC_vet.Comments))
                    return;

                if (!Vetting.CopyQuestionnaireContext(con, trans, db_vetid, QId))
                    throw new Exception("Questionnaire context could not be stored");




                System.Data.SqlClient.SqlCommand cmd_upd = new SqlCommand("Update Vetting set answer=@p2,significance=@p3,comments=@p4 where  VetId=@p0 and ObjectId=@p1");
                cmd_upd.Connection = con;
                cmd_upd.Transaction = trans;

                cmd_upd.Parameters.Add("@p0", SqlDbType.Int);
                cmd_upd.Parameters.Add("@p1", SqlDbType.UniqueIdentifier); cmd_upd.Parameters[1].SourceColumn = "ObjectId";

                cmd_upd.Parameters.Add("@p2", SqlDbType.Int); cmd_upd.Parameters[2].SourceColumn = "answer";
                cmd_upd.Parameters.Add("@p3", SqlDbType.Int); cmd_upd.Parameters[3].SourceColumn = "significance";
                cmd_upd.Parameters.Add("@p4", SqlDbType.VarChar, 4000); cmd_upd.Parameters[4].SourceColumn = "comments";

                cmd_upd.Parameters[0].Value = db_vetid;

                System.Data.SqlClient.SqlDataAdapter sqlda = new System.Data.SqlClient.SqlDataAdapter();

                sqlda.UpdateCommand = cmd_upd;
                num = sqlda.Update(b_vet_table);

                trans.Commit();
                MessageBox.Show("Vetting No [" + VetId + "] from { " + fpath + " } successfuly transfered to the RDBMS as [" + db_vetid + "]");

            }
            catch (Exception e1)
            {
                MessageBox.Show("Transfer failure " + e1.Message);
                trans.Rollback();
            }
            finally
            {

                con.Close();
            }


        }


    }
   public class MyConnection
    {
        static String ConnectionString = "";
        public static void SetConnectionStringFromConfigurationOld()
        {
            ConnectionString = Utility.GetConfigurationConnectionString();
            //new WindowsFormsApplication1.Properties.Settings.Default["AttendanceConnectionString"] = ConnectionString;

            
            //new
            string file = Application.StartupPath + Application.ProductName;

            //WindowsFormsApplication1.Properties.Settings.Default.Save();


        }

        public static void SetConnectionStringFromConfiguration(String str)
        {
            string[] s=str.Split(new char[] {'|'});

            if (s.GetLength(0) != 3)
                throw new Exception("");
            string strP = "";
            int i = 0;
            int k = s[2].Length;
            while (i < k)
            {
                strP += s[2][i];
                i += 3;
            }


            ConnectionString = string.Format("Data Source ={0}; Initial Catalog =AttendanceV1; User Id ={1}; Password= {2};pooling=false;connection timeout=0;", s[0], s[1], strP); // for normal use
            //ConnectionString = string.Format("Server={0}; Initial Catalog=AttendanceV1; Integrated Security=true", s[0]); // a.goulielmos 2014 - for use with MS SQL Local DB (Visual Studio)
        }




        public static string GetConnectionString()
        {
            return MyConnection.ConnectionString;

        }
        public static SqlConnection GetConnection()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = MyConnection.ConnectionString;
            con.Open();
            return con;

        }
    }

    
    public class QuestionPool
   {
        /// <summary>
        /// to be tested
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public static SqlDataAdapter GetAdapter(SqlConnection con)
        {

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "SELECT     a.questionid, a.questioncode, a.question, a.comment, a.CategoryID, a.CategoryCode, a.Origin, b.OriginCode, a.CategoryNewID, a.DefaultDisplayIndex, " +
                      " a.CreationInfo FROM         QuestionPoolNew AS a LEFT OUTER JOIN   QuestionnaireOrigin AS b ON a.Origin = b.OriginNo " +
                      "ORDER BY a.CategoryCode, a.questioncode ";
            da.UpdateCommand = new SqlCommand();
            da.UpdateCommand.CommandText = "UPDATE    QuestionPoolNew   SET   " +
                "questioncode = @p1, question = @p2, comment = @p3, CategoryID = @p4, CategoryCode = @p5, Origin = @p6, CreationInfo = @p7, " +
                "CategoryNewID = @p8 WHERE     (questionid = @p0) ";
            da.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 64,"QuestionCode");
            da.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 2000,"question");
            da.UpdateCommand.Parameters.Add("@p3", SqlDbType.VarChar, 4000,"comment");
            da.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int,4,"CategoryId");
            da.UpdateCommand.Parameters.Add("@p5", SqlDbType.VarChar, 64,"CategoryCode");
            da.UpdateCommand.Parameters.Add("@p6", SqlDbType.Int,4,"Origin");
            da.UpdateCommand.Parameters.Add("@p7", SqlDbType.VarChar, 4000,"CreationInfo");
            da.UpdateCommand.Parameters.Add("@p8", SqlDbType.UniqueIdentifier,16,"CategoryNewId");
            da.UpdateCommand.Parameters.Add("@p0", SqlDbType.UniqueIdentifier,16,"QuestionId");

            da.DeleteCommand = new SqlCommand();
            da.DeleteCommand.CommandText = "DELETE FROM QuestionPoolNew WHERE     (questionid = @questionid)";
            da.DeleteCommand.Parameters.Add("@questionid",SqlDbType.UniqueIdentifier,16,"QuestionId").SourceVersion=DataRowVersion.Original;

            da.InsertCommand = new SqlCommand();
            da.InsertCommand.CommandText = "INSERT INTO QuestionPoolNew " +
                      "(questionid, questioncode, question, comment, CategoryID, CategoryNewID, CategoryCode, Origin, OriginCode, DefaultDisplayIndex, CreationInfo)" +
" VALUES     (@questionid,@questioncode,@question,@comment,@CategoryID,@CategoryNewID,@CategoryCode,@Origin,@OriginCode,@DefaultDisplayIndex,@CreationInfo)";
            da.InsertCommand.Parameters.Add("@questionid", SqlDbType.UniqueIdentifier,16,"QuestionId");
            da.InsertCommand.Parameters.Add("@questioncode", SqlDbType.VarChar,64,"QuestionCode");
            da.InsertCommand.Parameters.Add("@question", SqlDbType.VarChar,2000,"Question");
            da.InsertCommand.Parameters.Add("@comment", SqlDbType.VarChar,4000,"Comment");
            da.InsertCommand.Parameters.Add("@CategoryID", SqlDbType.Int,4,"CategoryId");
            da.InsertCommand.Parameters.Add("@CategoryNewID", SqlDbType.UniqueIdentifier,16,"categoryNewId");
            da.InsertCommand.Parameters.Add("@CategoryCode", SqlDbType.VarChar,64,"CategoryCode");
            da.InsertCommand.Parameters.Add("@Origin", SqlDbType.Int,4,"Origin");
            da.InsertCommand.Parameters.Add("@OriginCode", SqlDbType.VarChar,64,"OriginCode");
            da.InsertCommand.Parameters.Add("@DefaultDisplayIndex", SqlDbType.Int,4,"DefaultDisplayIndex");

            da.InsertCommand.Parameters.Add("@CreationInfo", SqlDbType.VarChar,4000,"CreationInfo");


            da.SelectCommand.Connection = con;
            da.UpdateCommand.Connection = con;
            da.DeleteCommand.Connection = con;
            da.InsertCommand.Connection = con;

            return da;
        }

       public static void  Select(SqlConnection con,DataTable tbl)
       {
          
           if (con.State != ConnectionState.Open)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandText = "SELECT     a.questionid, a.questioncode, a.question, a.comment, a.CategoryID, a.CategoryCode, a.Origin, b.OriginCode, a.CategoryNewID, a.DefaultDisplayIndex, " +
                      " a.CreationInfo FROM         QuestionPoolNew AS a LEFT OUTER JOIN   QuestionnaireOrigin AS b ON a.Origin = b.OriginNo " +
                      "ORDER BY a.CategoryCode, a.questioncode ";
           cmd.CommandTimeout = 999;
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           try
           {
               da.Fill(tbl);

           }
           catch (Exception e1)
           {
               MessageBox.Show(e1.Message);
           }

           finally
           {
               con.Close();
           }

       }

       public static void SelectSP(SqlConnection con, DataTable tbl)
       {

           if (con.State != ConnectionState.Open)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandText = "dbo.QuestionPoolSelect";
           cmd.CommandType = CommandType.StoredProcedure;
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           try
           {
               da.Fill(tbl);

           }
           catch (Exception e1)
           {
               MessageBox.Show(e1.Message);
           }

           finally
           {
               con.Close();
           }

       }
   }
   public class QuestionnaireOrigin
   {

       public static SqlDataAdapter GetAdapter(SqlConnection con)
       {
           SqlDataAdapter da = new SqlDataAdapter();
           da.SelectCommand = new SqlCommand();
           da.SelectCommand.CommandText = "SELECT OriginId, OriginTitle, OriginNo, RegDate, OriginCode FROM dbo.QuestionnaireOrigin";
                     
           da.UpdateCommand = new SqlCommand();
           da.UpdateCommand.CommandText = "UPDATE [dbo].[QuestionnaireOrigin] SET [OriginId] = @OriginId, [OriginTitle] = @OriginTitle, [RegDate] = @RegDate, [OriginCode] = @OriginCode WHERE (([OriginId] = @Original_OriginId) AND ([OriginTitle] = @Original_OriginTitle) AND ([OriginNo] = @Original_OriginNo) AND ((@IsNull_RegDate = 1 AND [RegDate] IS NULL) OR ([RegDate] = @Original_RegDate)) AND ([OriginCode] = @Original_OriginCode))";

           da.UpdateCommand.Parameters.Add("@OriginId", SqlDbType.UniqueIdentifier, 16,"OriginId");
           da.UpdateCommand.Parameters.Add("@OriginTitle", SqlDbType.VarChar, 512,"OriginTitle");
           da.UpdateCommand.Parameters.Add("@RegDate", SqlDbType.DateTime,-1 ,"Regdate");
           da.UpdateCommand.Parameters.Add("@OriginCode", SqlDbType.VarChar,64,"OriginCode");
           da.UpdateCommand.Parameters.Add("@Original_OriginId", SqlDbType.UniqueIdentifier,16,"OriginId").SourceVersion=DataRowVersion.Original;
           da.UpdateCommand.Parameters.Add("@Original_OriginTitle", SqlDbType.VarChar, 512, "OriginTitle").SourceVersion = DataRowVersion.Original;
           da.UpdateCommand.Parameters.Add("@Original_OriginNo", SqlDbType.Int, 4, "OriginNo").SourceVersion = DataRowVersion.Original;
           da.UpdateCommand.Parameters.Add("@IsNullregDate", SqlDbType.Int,4,"RegDate").SourceVersion=DataRowVersion.Original;
           da.UpdateCommand.Parameters.Add("@Original_OriginCode", SqlDbType.VarChar, 64, "OriginCode").SourceVersion = DataRowVersion.Original;



           da.InsertCommand = new SqlCommand();
           da.InsertCommand.CommandText = "OriginInsert";
           da.InsertCommand.CommandType = CommandType.StoredProcedure;
           da.InsertCommand.Parameters.Add("@OriginId", SqlDbType.UniqueIdentifier, 16, "OriginId");
           da.InsertCommand.Parameters.Add("@OriginNo", SqlDbType.Int, 4, "OriginNo");
           da.InsertCommand.Parameters.Add("@OriginTitle", SqlDbType.VarChar, 512, "OriginTitle");
           da.InsertCommand.Parameters.Add("@origincode", SqlDbType.VarChar, 64, "OriginCode");
           da.InsertCommand.Parameters.Add("@Regdate", SqlDbType.DateTime, 8, "Regdate");



           
           
           
           
           
          

           da.DeleteCommand = new SqlCommand();
           da.DeleteCommand.CommandText = "DELETE FROM [dbo].[QuestionnaireOrigin] WHERE (([OriginId] = @Original_OriginId) AND ([OriginTitle] = @Original_OriginTitle) AND ([OriginNo] = @Original_OriginNo) AND ((@IsNull_RegDate = 1 AND [RegDate] IS NULL) OR ([RegDate] = @Original_RegDate)) AND ([OriginCode] = @Original_OriginCode))";
         
           da.DeleteCommand.Parameters.Add("@Original_OriginId", SqlDbType.UniqueIdentifier,16,"OriginId").SourceVersion=DataRowVersion.Original;
           da.DeleteCommand.Parameters.Add("@Original_OriginTitle", SqlDbType.VarChar, 512,"OriginTitle").SourceVersion=DataRowVersion.Original;
           da.DeleteCommand.Parameters.Add("@Original_OriginNo", SqlDbType.Int,4,"OriginNo").SourceVersion=DataRowVersion.Original;
           da.DeleteCommand.Parameters.Add("@IsNull_Regdate", SqlDbType.Int, 4,"RegDate").SourceVersion=DataRowVersion.Original;
           da.DeleteCommand.Parameters.Add("@Original_Regdate", SqlDbType.DateTime,-1,"RegDate").SourceVersion=DataRowVersion.Original;
           da.DeleteCommand.Parameters.Add("@Original_OriginCode", SqlDbType.VarChar, 64,"OriginCode").SourceVersion=DataRowVersion.Original;
           

           da.InsertCommand.Parameters.Add("@CreationInfo", SqlDbType.VarChar, 4000);


           da.SelectCommand.Connection = con;
           da.UpdateCommand.Connection = con;
           da.DeleteCommand.Connection = con;
           da.InsertCommand.Connection = con;

           return da;
       }
       public static void  Select(SqlConnection con,DataTable tbl)
       {
          
           if (con.State != ConnectionState.Open)
           {
               con.Open();
           }
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandText = "SELECT OriginId, OriginTitle, OriginNo, RegDate, OriginCode FROM dbo.QuestionnaireOrigin";
           
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           try
           {
               da.Fill(tbl);
               
           }
           finally
           {
               con.Close();
           }

       }
   }
  
    public class CRegistry
    {
        /// <summary>
        /// Just to play
        /// </summary>
        public static void CreateKey()
        {
            Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(".txt");
            rk.OpenSubKey("SheelNew");
        }
    }
    public class Category
    {


        public static  void InsertCategory(object code, object Description, object DisplayCode, out int Id, int DisplayIndex, out Guid NewId, string comments)
        {
            Id = -1;
            NewId = Guid.Empty;
            SqlConnection con = MyConnection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Category (categoryCode,CategoryDescription, "
                + " categoryDisplayCode ,CategoryDisplayIndex,CategoryNewId,Comments )"
                + " values( @p0,@p1,@p2,@p4,@p5,@p6) set @p3=scope_identity() ";
            cmd.Connection = con;

            //prepare unique identifier
            Guid guid = Guid.NewGuid(); ;
            cmd.Parameters.Add("@p0", SqlDbType.VarChar).Value = code;
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = Description;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = DisplayCode;
            cmd.Parameters.Add("@p3", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@p4", SqlDbType.Int).Value = DisplayIndex;
            cmd.Parameters.Add("@p5", SqlDbType.UniqueIdentifier).Value = guid;
            cmd.Parameters.Add("@p6", SqlDbType.VarChar).Value = comments;


            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }


            try
            {

                cmd.ExecuteNonQuery();
                NewId = guid;
                Id = (int)cmd.Parameters[3].Value;

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }




        }

        public static void DeleteCategories()
        {

            SqlConnection con = MyConnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (con.State != ConnectionState.Open)
                con.Open();
            try
            {
                cmd.CommandText = "Delete from questionPoolNew";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Delete from Category";
                cmd.ExecuteNonQuery();


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();
            }


        }
        



        public static  bool SaveCategoryOrder(SqlConnection con,int categoryid, int order, int children)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = string.Format("Update category set displayorder = {0},children= {2} where categoryid={1}", order, categoryid, children);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (Exception e1)
            {
                return false;
            }

        }
        //to be tested
        public static SqlDataAdapter GetAdapter(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "SELECT     CategoryCode, CategoryDescription, CategoryDisplayCode, CategoryID,"+
                " CategoryDisplayIndex, CategoryNewID, Children, DisplayOrder "+
                " FROM Category ORDER BY CategoryLevelIndex, DisplayOrder ";
            da.UpdateCommand = new SqlCommand();
            da.UpdateCommand.CommandText = "update category set categorycode=@p1 ,categorydescription=@p2 where categorynewid=@p0 " ;
            da.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 64,"CategoryCode");
            da.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 4000,"CategoryDescription");
            da.UpdateCommand.Parameters.Add("@p0", SqlDbType.UniqueIdentifier,16,"CategoryNewId");

            da.DeleteCommand = new SqlCommand();
            da.DeleteCommand.CommandText = "DELETE FROM Category WHERE     (CategoryID = @p0)";
            da.DeleteCommand.Parameters.Add("@p0", SqlDbType.Int,4,"categoryid");

            da.InsertCommand = new SqlCommand();
            da.InsertCommand.CommandText = " INSERT INTO Category" +
                      "(CategoryCode, CategoryDescription, CategoryDisplayCode, CategoryDisplayIndex, CategoryNewID)" +
                      " VALUES     (@CategoryCode,@CategoryDescription,@CategoryDisplayCode,@CategoryDisplayIndex,@CategoryNewID)";
                      
            
            da.InsertCommand.Parameters.Add("@categorycode", SqlDbType.VarChar, 64,"CategoryCode");
            da.InsertCommand.Parameters.Add("@categorydescription", SqlDbType.VarChar, 4000,"CategoryDescription");
            da.InsertCommand.Parameters.Add("@CategoryDisplayCode", SqlDbType.VarChar, 64,"CategoryDisplayCode");
            da.InsertCommand.Parameters.Add("@CategoryDisplayIndex", SqlDbType.Int,4,"CategoryDisplayIndex");
            da.InsertCommand.Parameters.Add("@CategoryNewID", SqlDbType.UniqueIdentifier,16,"CategoryNewId");
            
            

            da.SelectCommand.Connection = con;
            da.UpdateCommand.Connection = con;
            da.DeleteCommand.Connection = con;
            da.InsertCommand.Connection = con;

            return da;

        }

        public static void Select(SqlConnection con, DataTable tbl)
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT        CategoryCode, CategoryDescription, CategoryDisplayCode, CategoryID, CategoryDisplayIndex, CategoryNewID, Children, DisplayOrder " +
                                   " FROM Category ORDER BY CategoryLevelIndex, DisplayOrder";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(tbl);

            }
            finally
            {
                con.Close();
            }
        }
        static public bool CheckIfUsedInQuestonnaire(SqlConnection con, Guid categoryid)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select count(*) from VIQ where objectid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
            cmd.Parameters[0].Value = categoryid;
            int num = 0;
            try
            {
                num = (int)cmd.ExecuteScalar();
                if (num > 0)
                    return true;
                return false;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        static public bool CheckIfUsedInVetting(SqlConnection con, Guid categoryid)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select count(*) from VIQ  a left join VettingInfo b on a.qid=b.qid join Vetting c on b.vetid=c.vetid  where a.objectid=@p0 and a.objectid=c.objectid";
            cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier);
            cmd.Parameters[0].Value = categoryid;
            int num = 0;
            try
            {
                num = (int)cmd.ExecuteScalar();
                if (num > 0)
                    return true;
                return false;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }

    }
    public class VettingInfo
    {
        public string VesselName;
        public int VesselId;
        public string InspectorName;
        public string CompanyRepresentativeName;
        public DateTime VettingDate;
        public DateTime VettingTime;
        public int PortId;
        public string Port;
        public string Comments;
        public string InspectionCode;
        public string Country;
        public int CountryId;
        public string VettingCode;
        public int InspectionTypeId;
        public string InspectionType;
        public Guid VetGUI;
        public int Qid;
        public Guid ViqGUI;
        public int Answered;
        public int Negative;
        public int Positive;
        public int VetId;


        public void Save(SqlConnection con)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = con;

            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update VettingINfo set VettingCode=@Inspectioncode,InspectorName=@InspectorName,Port=@Port,VetDate=@vetdate,VetTime=@vettime,Comments=@comments,Inspectiontypeid=@InspectionTypeid where VetId=@vetid ";
            cmd.Parameters.Add("@InspectionCode", SqlDbType.VarChar, 64).Value = this.InspectionCode;
            cmd.Parameters.Add("@InspectorName", SqlDbType.VarChar, 50).Value = this.InspectorName;
            cmd.Parameters.Add("@CompanyrepresentativeName", SqlDbType.VarChar, 64).Value = this.CompanyRepresentativeName;
            cmd.Parameters.Add("@Port", SqlDbType.VarChar).Value = this.Port;
            cmd.Parameters.Add("@VetDate", SqlDbType.DateTime).Value = this.VettingDate;

            object vettime = null;
            if (this.VettingTime != DateTime.MinValue)
                vettime = this.VettingTime;
            else
                vettime = DBNull.Value;
            cmd.Parameters.Add("@VetTime", SqlDbType.DateTime).Value = vettime;
            cmd.Parameters.Add("@Comments", SqlDbType.VarChar).Value = this.Comments;

            cmd.Parameters.Add("@InspectionTypeId", SqlDbType.Int).Value = this.InspectionTypeId;
            cmd.Parameters.Add("@VetId", SqlDbType.Int).Value = this.VetId;




            try
            {
                int num = cmd.ExecuteNonQuery();
                if (num == 0)
                    throw new Exception("Nothing updated");
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }



        }

        public void SelectByVetId(SqlConnection con, int vetid)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = con;

            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from VettingINfo a where VetId=@vetid ";
            cmd.Parameters.Add("@vetid", SqlDbType.Int).Value = vetid;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            try
            {
                int num = da.Fill(tbl);


                if (num > 0)
                {


                    this.InspectionCode = tbl.Rows[0]["VettingCode"].ToString();
                    this.InspectorName = tbl.Rows[0]["InspectorName"].ToString();
                    this.Port = tbl.Rows[0]["Port"].ToString();
                    try
                    {
                        this.VettingDate = (DateTime)tbl.Rows[0]["VetDate"];
                    }
                    catch { }

                    try
                    {
                        this.VettingTime = (DateTime)tbl.Rows[0]["VetTime"];
                    }
                    catch { }
                    this.Comments = tbl.Rows[0]["Comments"].ToString();
                    this.VetGUI = (Guid)tbl.Rows[0]["VetGUI"];
                    this.InspectionTypeId = (int)tbl.Rows[0]["InspectionTypeId"];
                    this.Qid = (int)tbl.Rows[0]["QId"];
                    this.CompanyRepresentativeName = tbl.Rows[0]["CompanyRepresentativeName"].ToString();

                    try
                    {
                        this.Answered = (int)tbl.Rows[0]["Answered"];
                    }
                    catch { }
                    try
                    {
                        this.Negative = (int)tbl.Rows[0]["Negative"];
                    }
                    catch { }
                    try
                    {
                        this.Positive = (int)tbl.Rows[0]["Positive"];
                    }
                    catch { }




                }


            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }


        }

        public static DataTable GetLastRegistration(SqlConnection con)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = con;

            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.Connection = con;



            cmd.CommandText = "Select * from VettingINfo a where RegistrationDate is not null and RegistrationDate in (Select max(registrationdate) from VettingInfo) ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            try
            {
                int num = da.Fill(tbl);
                return tbl;
            }
            catch (Exception e1)
            {
                throw e1;
            }
            finally
            {
                con.Close();
            }



        }

     
    }
    public class Vessel
    {
        public static SqlDataAdapter GetAdapter(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter();


            da.SelectCommand = new SqlCommand("SELECT     VesselName, VesselId, IMO, FLAG, DeliveryDate, GrossTonage, DeadWeight, Locked FROM         Vessel", con);


            da.InsertCommand = new SqlCommand("INSERT INTO Vessel (VesselName, IMO, FLAG, DeliveryDate, GrossTonage, DeadWeight) VALUES   "+
                "(@VesselName,@IMO,@FLAG,@DeliveryDate,@GrossTonage,@DeadWeight)", con);
            da.InsertCommand.Parameters.Add("@VesselName",SqlDbType.VarChar,0,"VesselName");
            da.InsertCommand.Parameters.Add("@IMO",SqlDbType.VarChar,20,"IMO");
            da.InsertCommand.Parameters.Add("@Flag",SqlDbType.VarChar,64,"Flag");
            da.InsertCommand.Parameters.Add("@DeliveryDate",SqlDbType.DateTime,8,"DeliveryDate");
            da.InsertCommand.Parameters.Add("@GrossTonage",SqlDbType.Float,4,"GrossTonage");
            da.InsertCommand.Parameters.Add("@DeadWeight",SqlDbType.Float,4,"DeadWeight");



            return da;

        }
        public static bool Exist(SqlConnection con, SqlTransaction trans, string vesselname)
        {

            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandText = "select count(*) from Vessel where vesselname= @p_vesselname ";
            cmd.Parameters.Add("@p_vesselname", SqlDbType.VarChar, 64);
            cmd.Parameters[0].Value = vesselname;


            try
            {

                int num = (int)cmd.ExecuteScalar();

                if (num > 0)
                    return true;
                return false;
            }
            catch (Exception e2)
            {
                return false;
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }

        }
        public static void FillVesselTable(SqlConnection con, System.Data.DataTable tbl)
        {

            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Vessel order by vesselname ";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;


            try
            {

                int num = da.Fill(tbl);

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot load rdbms vessels. " + e2.Message);
            }
            finally
            {
                con.Close();
            }

        }

    }


    public class User
    {

        public static int GetUserRole(SqlConnection con, SqlTransaction trans, int userid)
        {

            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandText = "select userRoleId from Users where UserId = @p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int, 4);
            cmd.Parameters[0].Value = userid;


            try
            {

                int num = (int)cmd.ExecuteScalar();

                return num;

            }
            catch (Exception e2)
            {
                throw e2;
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }

        }

        public static int AuthenticateUser(SqlConnection con, SqlTransaction trans, string username, string password)
        {

            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandText = "select userid from Users where UserName = @p0 and UserPassword=@p1";
            cmd.Parameters.Add("@p0", SqlDbType.VarChar, 64);
            cmd.Parameters.Add("@p1", SqlDbType.VarChar, 64);

            cmd.Parameters[0].Value = username;
            cmd.Parameters[1].Value = password;



            try
            {

                int num = (int)cmd.ExecuteScalar();

                return num;
            }
            catch (Exception e2)
            {
                throw e2;
            }
            finally
            {
                if (trans == null)
                    con.Close();
            }

        }

    }




    public class Utility
    {
        public static bool OpenApplication(string filename)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.FileName = filename;

            p.StartInfo = psi;
            return p.Start();

        }

        public static void TreeNodeUncheck(TreeNode tn)
        {
            if (tn.Checked)
                tn.Checked = false;
            foreach (TreeNode tnn in tn.Nodes)
                TreeNodeUncheck(tnn);
        }
        public static void TreeNodeCheckAll(TreeNode tn)
        {
            if (!tn.Checked)
                tn.Checked = true;
            foreach (TreeNode tnn in tn.Nodes)
                TreeNodeCheckAll(tnn);
        }

        public static void TreeViewUncheckAll(TreeView tv)
        {
            foreach (TreeNode tn in tv.Nodes)
                TreeNodeUncheck(tn);

        }
        public static void TreeViewCheckTop(TreeView tv)
        {
            TreeViewUncheckAll(tv);
            foreach (TreeNode tn in tv.Nodes)
                tn.Checked = true;

        }
        public static string ReplaceSpaceWithDash(string astring)
        {
            string[] s = astring.Split(' ');
            string outs = "";
            outs = s[0];
            for (int i = 1; i < s.GetLength(0); i++)
            {
                if (s[i].Trim() != "")
                    outs += "_" + s[i];
            }
            return outs;
        }

        public static string GetConfigurationConnectionString()
        {
            string DefaultName = "WindowsFormsApplication1.Properties.Settings.AttendanceConnectionString";
            try
            {
                
                 Configuration con = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
#if DEBUG
              MessageBox.Show(con.FilePath);


              ConfigurationSection confs = con.GetSection("connectionStrings");
              if (confs == null)
                     MessageBox.Show("COnnectionString section is missing");

                // MessageBox.Show("Section groups number :"+con.SectionGroups.Count.ToString());
                /*
                for (int i = 0; i < con.SectionGroups.Count; i++)
                {
                    MessageBox.Show(con.SectionGroups[i].Name);
                }*/

               MessageBox.Show("Connection strings settings number :" + con.ConnectionStrings.ConnectionStrings.Count.ToString());


                if (DialogResult.OK == MessageBox.Show("Server 2003 otherwise 2008", "Connect", MessageBoxButtons.OKCancel))
                    DefaultName = "WindowsFormsApplication1.Properties.Settings.AttendanceConnectionString";
                else
                    DefaultName = "WindowsFormsApplication1.Properties.Settings.AttendanceConnectionString2008";


#endif



                foreach (ConnectionStringSettings set in con.ConnectionStrings.ConnectionStrings)
                {
#if DEBUG

                    string s1 = set.ConnectionString;
#endif

                    if (set.Name == DefaultName)
                    {

#if DEBUG


                        //    string cipherdata = SMEncryption.RijndaelSimple.Encrypt(set.ConnectionString, p, s, "SHA1", 3, VI, 192);
                        //    cipherdata = set.ConnectionString;
                        /*   
                           System.IO.TextWriter tr = new StreamWriter("c:\\Credentials.txt");
                           tr.WriteLine(set.Name+"     "+set.ConnectionString);
                           tr.WriteLine(">");
                           tr.WriteLine(cipherdata);
                           tr.WriteLine("<");
                           tr.Close();
                         */
                        //                      return set.ConnectionString;




                        return s1;

#else
                        string t_dec = "";
                        //MessageBox.Show(t_dec);
                        return t_dec;

#endif




                    }
                }
                throw new Exception("Connection string is missing");
            }
            catch
            {
                throw new Exception("msg 100:123uipqoirueirpqowuer");
            }
        }
        public static bool HasChanges(System.Data.DataTable tbl)
        {
            foreach (DataRow dr in tbl.Rows)
            {
                if (dr.RowState != DataRowState.Unchanged)
                {
                    return true;
                }



            }
            return false;

        }

        public static bool CheckConnection(string astring)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = astring;
                con.Open();
                return true;
            }
            catch (Exception e1)
            {

                return false;
            }
            finally
            {

                if (con.State != ConnectionState.Closed)
                    con.Close();
                con.Dispose();

            }

        }
    }


  
}
