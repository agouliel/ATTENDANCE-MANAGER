using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vetting;
namespace WindowsFormsApplication1
{
    public partial class FormVettingRequest : Form
    {
        BindingSource bs_vessels;
        BindingSource bs_inspectiontypes;
        BindingSource bs_vettingrequests;
        BindingSource bs_requestShcedule;
        public FormVettingRequest()
        {
            InitializeComponent();
            PrepareBindingSources();
        }
        private void PrepareBindingSources()
        {
            bs_vessels = new BindingSource();
            DataTable tbl_vessels = new DataTable();
                Vessel.FillVesselTable(MyConnection.GetConnection(), tbl_vessels);
                DataTable tbl_inspectiontypes=null;
                tbl_inspectiontypes=Vetting.Vetting.SelectInspectionTypes(MyConnection.GetConnection());
                bs_vessels.DataSource = tbl_vessels;
                bs_inspectiontypes = new BindingSource();
                bs_inspectiontypes.DataSource = tbl_inspectiontypes;
                this.dgvcol_InspectionTypeCmb.DataSource = bs_inspectiontypes;
                this.dgvcol_InspectionTypeCmb.DisplayMember = "InspectionType";

                this.dgvcol_VesselId_cmb.DataSource = bs_vessels;
                this.dgvcol_VesselId_cmb.DisplayMember = "VesselName";

                

            /*
                DataTable tbl_requests = new DataTable();
                tbl_requests.Columns.Add("UserId", typeof(int));
                tbl_requests.Columns.Add("ComputerName", typeof(string));

                tbl_requests.Columns.Add("UserName", typeof(String));
                tbl_requests.Columns.Add("RequestDate", typeof(DateTime));
                tbl_requests.Columns.Add("RequestCode", typeof(string));
                tbl_requests.Columns.Add("VetRequestId", typeof(int));
                tbl_requests.Columns.Add("Granted", typeof(byte));
                tbl_requests.Columns.Add("BriefcaseFile", typeof(string));
             */ 

            
               
            
        }

        void bs_vettingrequests_PositionChanged(object sender, EventArgs e)
        {
            
            DataRowView drv = this.bs_vettingrequests.Current as DataRowView;
            if (drv == null)
                return;
            if (drv["Granted"] != DBNull.Value && (bool)drv["Granted"])
            {
                this.bt_download.Enabled = true;
            }
            else
                this.bt_download.Enabled = false;

            bs_requestShcedule.Filter = " VetRequestid " + drv["VetRequestId"].ToString();


        }
       
        

        private void FormVettingRequest_Load(object sender, EventArgs e)
        {
            bs_vettingrequests = new BindingSource();
            DataTable tbl = Vetting.VettingRequest.Select(MyConnection.GetConnection());
            bs_vettingrequests.DataSource = tbl;
            bs_vettingrequests.PositionChanged += new EventHandler(bs_vettingrequests_PositionChanged);

            this.dgv_vettingrequest.DataSource = bs_vettingrequests;


            bs_requestShcedule = new BindingSource();
            DataTable tbl_sch = Vetting.VettingRequest.SelectSchedule(MyConnection.GetConnection(),null);

            bs_requestShcedule.DataSource = tbl_sch;


        }

        private void dgv_schedule_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            

            DataGridView dgv = (DataGridView)sender;

            
            bool bFoundNotNull=false;
            bool bErrorFound = false;
            object o=null;
            for (int i = 0; i < 4; i++)
            {
                o = dgv[i, e.RowIndex].Value;
                if (o == null)
                {
                
                    bErrorFound = true;
                }
                else
                    bFoundNotNull = true;
            }

            if (dgv.Rows[e.RowIndex].IsNewRow)
            {
                if (!bFoundNotNull) return;
            }

            if (bErrorFound)
            {
                statMessage.Text = "Invalid values detected";
                return;
            }

            DateTime dtFrom = Convert.ToDateTime(dgv[2, e.RowIndex].Value).Date;
            DateTime dtTo = Convert.ToDateTime(dgv[3, e.RowIndex].Value).Date;

            if (dtTo < dtFrom)
            {
                e.Cancel = true;
                statMessage.Text = "Termination date should be >= than Starting date";
                return;
            }

            if (e.RowIndex > 0)
            {
                if (dtFrom.Date<Convert.ToDateTime(dgv[2,e.RowIndex-1].Value).Date)
                {
                    e.Cancel=true;
                    statMessage.Text="Starting dates in ascending order";
                    return;
                }
            }


        }

       

        private void dgv_schedule_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            this.statMessage.Text = "";
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (bs_requestShcedule.Count == 0)
            {
                MessageBox.Show("Define vetting schedule to proceed");
                return;
            }



            try
            {
                Vetting.VettingRequest.Save(MyConnection.GetConnection(), bs_vettingrequests.DataSource as DataTable);
                MessageBox.Show("Changes committed successfully.");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView dgvr=(DataRowView)bs_vettingrequests.AddNew();

            
            


            DateTime rdate = DateTime.Now;
            dgvr["vetRequestId"] = -1;
            dgvr["UserId"] = DBNull.Value;
            dgvr["ComputerName"] = System.Net.Dns.GetHostName() ;
            dgvr["UserName"] = "Unknown";
            dgvr["RequestDate"] = rdate;
            dgvr["RequestCode"] = rdate.Year + rdate.Month.ToString().PadLeft(2, '0') + rdate.Day.ToString().PadLeft(2, '0') + rdate.Minute.ToString().PadLeft(2, '0') + rdate.Second.ToString().PadLeft(2, '0')+rdate.Millisecond.ToString().PadLeft(3,'0');
            
       

        }
    }
}
