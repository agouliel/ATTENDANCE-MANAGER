using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
//version 3.5.1.0 ***************
using System.Data.SqlServerCe;


namespace VettingP
{
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
            WindowsFormsApplication1.Attendance.VettingInfoDataTable tblinfo,
            WindowsFormsApplication1.Attendance.QuestionnaireDataTable tblvet)
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


        public static bool SaveSchema(string filepath, string password)
        {
            string connectionstring;






            System.Data.SqlServerCe.SqlCeEngine sqlce = new SqlCeEngine();
            sqlce.LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", filepath, password);
            try
            {
                FileInfo fi = new FileInfo(filepath);
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
                "[VisitNumber] [int] " +

                ") ";
                cmd.Connection = con;//create visit log table
                cmd.ExecuteNonQuery();


                cmd.CommandText = "Insert into VisitLog (ValidFromdate,ValidToDate,VisitNumber,VisitNumberLimit,VettingNumberLimit)" +
                    "values (@p0,@p1,@p2,@p3,3)";
                DateTime adate = DateTime.Now;
                cmd.Parameters.Add("@p0", SqlDbType.DateTime).Value = adate;
                cmd.Parameters.Add("@p1", SqlDbType.DateTime).Value = adate.AddMonths(1);
                cmd.Parameters.Add("@p2", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@p3", SqlDbType.Int).Value = 30;
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
                    "[Comments] [nvarchar](4000)  NULL," +
                    "[Author] [nvarchar](256)    NULL," +
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

                cmd.ExecuteNonQuery();


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
            "[DeadWeight] [float]  NULL" +
            ")";

                cmd.ExecuteNonQuery();


                cmd.CommandText =
           "CREATE TABLE [InspectionTypes]( " +
           "[InspectionTypeId] [int] PRIMARY KEY," +
           "[InspectionType] [Nvarchar](64)NOT NULL" +
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

    }

    public class Class1
    {
    }
}
