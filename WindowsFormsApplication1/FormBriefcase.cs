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
    public partial class FormBriefcase : Form
    {
        string m_filepath;
        string m_password;

        public string FilePath
        {
            set
            {
                this.m_filepath = value;
            }
        }

        public string FilePassword
        {
            set
            {
                this.m_password = value;
            }
        }

        public FormBriefcase()
        {
            InitializeComponent();
        }

        private void FormBriefcase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance.VIQInfo' table. You can move, or remove it, as needed.
            //this.vIQInfoTableAdapter.Fill(this.attendance.VIQInfo);
            if (this.m_filepath != "")
            {
                try
                {
                    Portable.LoadQuestionnaires(this.m_filepath, this.m_password, this.attendance.VIQInfo);
                    Portable.LoadAllVettingInfos(this.m_filepath, this.m_password, this.attendance.VettingInfo);
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                   
                    this.Hide();
                    this.Dispose();
                }
            }
            this.Text = "Briefcase { " + this.m_filepath + " }";
        }

        private void bt_Addquestionnaire_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.FormTransferQuestionnaires frmtrans = new FormTransferQuestionnaires();
            frmtrans.FilePath = this.m_filepath;
            frmtrans.FilePassword = this.m_password;
            frmtrans.ShowDialog();
            this.RefreshQuestionnaires();
        }
        private void RefreshQuestionnaires()
        {
            this.attendance.VIQInfo.Clear();
            Portable.LoadQuestionnaires(this.m_filepath, this.m_password, this.attendance.VIQInfo);
        }

        private void bt_removequestionnaire_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewQuestionnaires.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvr in this.dataGridViewQuestionnaires.SelectedRows)
                {
                    var drv = (DataRowView)dgvr.DataBoundItem;
                    int qid = (int)drv["Qid"];
                    if (Portable.RemoveQuestionnaire(qid,this.m_filepath,this.m_password))
                    {
                        drv.Row.Delete();
                        this.attendance.VIQInfo.AcceptChanges();  
                        
                    }
                    
                }
            }
        }

        private void bt_OpenQuestionnaire_Click(object sender, EventArgs e)
        {
            Event_ShowBriefcaseQuestionnaire(-1,-1);
        }

        private void Event_ShowBriefcaseQuestionnaire(int QId,int vetid)
        {
            int qid = QId;
            if (qid == -1)
            {
                if (this.dataGridViewQuestionnaires.SelectedRows.Count == 1)
                {
                    DataGridViewRow dgvr = this.dataGridViewQuestionnaires.SelectedRows[0];
                    DataRowView drv = dgvr.DataBoundItem as DataRowView;
                    
                    qid = (int)drv["qid"];
                }
                else
                    return;

            }

            WindowsFormsApplication1.FormQuestionnaire frmq = new FormQuestionnaire();
            frmq.FormClosed += new FormClosedEventHandler(FormQuestionnaire__FormClosed);
            object title=null, author=null, adate=DateTime.MinValue, questions=null;

                if (vetid==-1&&!Questionnaire.FillTableFromBriefcase(this.m_filepath,this.m_password, qid, frmq.attendance.Questionnaire, out title, out author, out adate, out questions))
                {
                    MessageBox.Show("Failed to retrieve questionnaire");
                    return;
                }

                    frmq.QuestionnaireOrigin = WindowsFormsApplication1.FormQuestionnaire.BasicOrigin.Briefcase;
                    frmq.QId = qid;
                    frmq.BriefcaseFilenName = this.m_filepath;
                    frmq.Title = title;
                    frmq.Author = author;
                    frmq.RegDate = adate;
                    frmq.FilePassword = this.m_password;
                    frmq.ViewerApp = Questionnaire.ViewerApplication.Attendance;

                    frmq.VetId = vetid;
                    frmq.Show();
                
            

        }

        void FormQuestionnaire__FormClosed(object sender, FormClosedEventArgs e)
        {
            FormQuestionnaire frmq = (FormQuestionnaire)sender;
            if (frmq.NewAttendance)
            {
                Portable.LoadVettingInfo(this.m_filepath, this.m_password, this.attendance.VettingInfo, frmq.VetId);
            }
            else if (frmq.UpdatedAttendance)
            {
                DataRow []dr=this.attendance.VettingInfo.Select("VETID = " + frmq.VetId.ToString());
                if (dr.GetLength(0) == 1)
                {
                    int total = 0;
                    float perc = 0;
                    dr[0]["NumAnswer"] = Portable.GetVettingStatistics(this.m_filepath, this.m_password, frmq.VetId,out total,out perc);
                    dr[0].AcceptChanges();
                }

            }

          
        }

        private void dataGridViewQuestionnaires_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Event_ShowBriefcaseQuestionnaire(-1,-1);
        }

        private void bt_openattendance_Click(object sender, EventArgs e)
        {

            this.Event_ShowVetting();
        }

        private void Event_ShowVetting()
        {
            if (this.dataGridViewVettings.SelectedRows.Count == 1)
            {
                int vetid = (int)((this.dataGridViewVettings.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["VETId"];
                int qid = (int)((this.dataGridViewVettings.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["QId"];
                this.Event_ShowBriefcaseQuestionnaire(qid, vetid);
            }

        }
        private void Event_ImportVetting()
        {
            if (this.dataGridViewVettings.SelectedRows.Count == 1)
            {
                int vetid = (int)((this.dataGridViewVettings.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["VETId"];
                int qid = (int)((this.dataGridViewVettings.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["QId"];
                System.Guid vetgui = (Guid)((this.dataGridViewVettings.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["VetGUI"];
                Vetting.Vetting.TransferFromBriefcase(this.m_filepath, this.m_password, vetid, vetgui, qid);
            }

        }




        private void dataGridViewVettings_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Event_ShowVetting();
        }

        private void bt_transfervetting_Click(object sender, EventArgs e)
        {
            this.Event_ImportVetting(); 
        }

        private void vesselsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.FormBriefcaseVessels frm = new FormBriefcaseVessels();
            frm.FilePath = this.m_filepath;
            frm.FilePassword = this.m_password;
            frm.ShowDialog();
        }
    }
}
