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
    public partial class Form_QuestionnaireInfo : Form
    {
        private System.Data.SqlClient.SqlConnection _CurrentConnection;
        public object QID=-1;
       
        
        public Form_QuestionnaireInfo()
        {
            InitializeComponent();
        }



        public System.Data.SqlClient.SqlConnection  SQL_Connection
        {
            set
            {
                _CurrentConnection = value;
            }
            get
            {
                return _CurrentConnection;
            }

        }

        private void Form_QuestionnaireInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance.VIQInfo' table. You can move, or remove it, as needed.
            int rows=Vetting.VIQInfo.Select(MyConnection.GetConnection(),this.attendance.VIQInfo);

            if (ApplicationInfo.ActiveUserMode == ApplicationInfo.UserMode.Administrator)
            {
                this.dataGridViewVIQRegistry.MultiSelect = true;
                this.dataGridViewVIQRegistry.ContextMenuStrip = this.contextMenuStrip1;
            }

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVIQRegistry.SelectedRows.Count > 0)
            {
                QID = (this.dataGridViewVIQRegistry.SelectedRows[0].DataBoundItem as DataRowView)["QID"];
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Abort;
            }
            
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVIQRegistry.SelectedRows.Count  > 0)
                QID = (this.dataGridViewVIQRegistry.SelectedRows[0].DataBoundItem as DataRowView)["QID"];
            else
                return;
            try
            {


                int qid = Convert.ToInt32(QID);
                VIQ.DeleteQuestionnaire(this._CurrentConnection,null,qid);
                
                DataRow []rows=this.attendance.VIQInfo.Select("QID = " + qid);
                rows[0].Delete();
                



            }
            catch (Exception e1)
            {
                MessageBox.Show("Cannot delete VIQ."+e1.Message);
            }

        }
        

        private void dataGridViewVIQRegistry_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                var drv = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;
                int viqid = (int)drv["QId"];
                this.QID = viqid;
                this.DialogResult = DialogResult.OK;


            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void exportToBriefcaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExportToBriefcaseFile();
        }

        private void ExportToBriefcaseFile()
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Filter = "(briefcase files *.sdf)|*.sdf";
            if (DialogResult.OK == sfdlg.ShowDialog())
            {

                if (this.dataGridViewVIQRegistry.SelectedRows.Count > 0)
                {

                    try
                    {
                        Portable.SaveSchema(sfdlg.FileName, ApplicationInfo.bfpassword);

                    }
                    catch (Exception e2)
                    {
                        MessageBox.Show("Metadata failed to be exported :" + e2.Message);
                        return;
                    }

                    if (!Questionnaire.TransferRegistryInfoToBriefcase(MyConnection.GetConnection(), sfdlg.FileName, ApplicationInfo.bfpassword))
                    {

                        MessageBox.Show("Registry data failed to be transfered.");
                        
                        return;
                    }
                    foreach (DataGridViewRow dgv in this.dataGridViewVIQRegistry.SelectedRows)
                    {
                        var drv = (DataRowView)dgv.DataBoundItem;
                        int qid = (int)drv["Qid"];
                        try
                        {
                            if ((byte)drv["finalized"] != 1)
                            {
                                throw new Exception("not finalized");
                            }
                        }
                        catch (Exception e3)
                        {
                            MessageBox.Show(drv["Qid"].ToString() + " skipped :not finalized");
                            continue;

                        }

                       
                        try
                        {
                            Portable.TransferQuestionnaireTemplate(MyConnection.GetConnection(), qid, sfdlg.FileName, ApplicationInfo.bfpassword);
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show("Questionnaire export failed :"+e2.Message);
                        }
                    }
                    MessageBox.Show(string.Format("Briefcase file {0} created.",sfdlg.FileName));

                }
            }
        }
    }
}
