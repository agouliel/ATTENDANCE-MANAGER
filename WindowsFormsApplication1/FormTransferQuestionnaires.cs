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
    public partial class FormTransferQuestionnaires : Form
    {
        string m_FilePath;
        string m_password;
        public FormTransferQuestionnaires()
        {
            InitializeComponent();
        }
        public string FilePath
        {
            set
            {
                this.m_FilePath = value;
            }
        }
        public string FilePassword
        {
            set
            {
                this.m_password = value;
            }
        }

        private void FormTransferQuestionnaires_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance.VIQInfo' table. You can move, or remove it, as needed.

            this.RefreshQuery(); 
        }

        private void RefreshQuery()
        {
            this.attendance.VIQInfo.Clear();
            Vetting.VIQInfo.Select(MyConnection.GetConnection(),this.attendance.VIQInfo);
            
        }

        private void bt_Transfer_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgv in this.dataGridView1.SelectedRows)
                {
                    var drv = (DataRowView)dgv.DataBoundItem;
                    int qid=(int)drv["Qid"];


                    Portable.TransferQuestionnaireTemplate(MyConnection.GetConnection() ,qid,this.m_FilePath,this.m_password);   
                }
                
            }
            

        }
    }
}
