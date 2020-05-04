using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApplication1
{
    public partial class FormBriefcaseFileNameInfo : Form
    {
        private string strFilePath;
        private string strFileName;
        private SqlConnection ActiveConnection;

        public FormBriefcaseFileNameInfo(SqlConnection con)
        {
        
            InitializeComponent();
            this.ActiveConnection = con;
        }

        public DateTime FromDate
        {
            get;
            set;
        }

        public DateTime ToDate
        {
            get;
            set;
        }

        private void btPath_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.folderBrowserDialog1.ShowDialog())
            {
                if (this.folderBrowserDialog1.SelectedPath != null)
                {
                    this.tb_Path.Text = this.folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (!CheckValidate())
            {
                return;
            }
            CreateFileName();
            this.DialogResult = DialogResult.OK;
            
        }
        public string FileName
        {
            get
            {
                return this.strFileName;
            }
        }

        public string UserName // a.goulielmos
        {
            get
            {
                return this.tbUser.Text;
            }
        }


        public string FilePath
        {
            get
            {
                return this.strFilePath;
            }
        }
        private void CreateFileName()
        {
            DateTime fromdate = DateTime.Now.Date;
            DateTime todate = fromdate.AddMonths(1);

            this.strFileName = this.tbUser.Text + "_" + this.cmbVettingTypes.Text + "_" + fromdate.ToString("dd-MM-yyyy") + "_to_" + todate.ToString("dd-MM-yyyy") + ".sdf";
            this.strFilePath = this.tb_Path.Text + "\\";
            this.FromDate = fromdate;
            this.ToDate = todate;
        }
        private bool CheckValidate()
        {
            if (this.tbUser.Text.Trim() == "")
            {
                lbError.Text = "User Name is missing or invalid";
                return false;
            }
            if (this.cmbVettingTypes.Text.Trim() == "")
            {
                lbError.Text = "Attendance type is missing or invalid";
                return false;
            }
            if (this.tb_Path.Text==null||this.tb_Path.Text==""||this.tb_Path.Text != this.folderBrowserDialog1.SelectedPath)
            {
                lbError.Text = "Current path is not selected from browser";
                return false;
            }
            
            return true;
            
        }

        private void FormBriefcaseFileNameInfo_Load(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlDataAdapter da = null;
            try
            {
                da = Vetting.InspectionType.GetAdapter(ActiveConnection);
                DataTable tbl = new DataTable();
                da.Fill(tbl);
                this.cmbVettingTypes.DataSource = tbl;
                this.cmbVettingTypes.DisplayMember = "InspectionType";
            }
            finally
            {
                da.Dispose();
                
            }
        }
    }
}
