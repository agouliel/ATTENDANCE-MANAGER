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
    public partial class FormObjectContext : Form
    {
        private Guid m_objectid = Guid.Empty;
        private int m_vesselid = -1;
        private string vesselfilter = "";
        public Guid ObjectId
        {
            set
            {
                this.m_objectid = value;
            }

        }
        public int VesselId
        {
            set
            {
                this.m_vesselid = value;
            }

        }
        public FormObjectContext()
        {
            InitializeComponent();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Label", typeof(string));
            tbl.Columns.Add("Number", typeof(string));
            tbl.Rows.Add(new object[2] { "", "0" });
            tbl.Rows.Add(new object[2] { "1. YES", "1" });
            tbl.Rows.Add(new object[2] { "2.  NO", "2" });
            tbl.Rows.Add(new object[2] { "3. N/S", "3" });
            tbl.Rows.Add(new object[2] { "4. N/A", "4" });


            //new object[3,2]{{,"1"},{"2.  NO","2"},{"3. N/S","3"}});



            
            
            this.answerDataGridViewTextBoxColumn.ValueMember = "Number";
            this.answerDataGridViewTextBoxColumn.DisplayMember = "Label";
            this.answerDataGridViewTextBoxColumn.DataSource = tbl;
            this.answerDataGridViewTextBoxColumn.ValueType = typeof(int);
        }

        private void FormObjectContext_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance.VIQInfo' table. You can move, or remove it, as needed.
            if (Questionnaire.FillObjectRelatedTable(MyConnection.GetConnection(), this.m_objectid, this.attendance.VIQInfo)==0)
            {
                this.splitContainer1.Panel2Collapsed = true;
            }
            if (Vetting.Vetting.FillObjectRelatedTable(MyConnection.GetConnection(), this.m_objectid, -1, this.attendance.ObjectVettingInfo) == 0)
           {
               this.splitContainer1.Panel1Collapsed = true;
           }
           if (this.m_vesselid != -1)
           {
               this.chb_vesselspecific.Visible = true;
                vesselfilter= "Vesselid = " + this.m_vesselid.ToString();
                ApplyFilter(false);
           }

            
               

        }
        private void ApplyFilter(bool bignore)
        {
            if (!bignore)
                this.objectVettingInfoBindingSource.Filter = this.vesselfilter;
            else
                this.objectVettingInfoBindingSource.Filter = "";

        }

        private void dataGridView_vettings_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
                if (dgvr.Cells[this.answerDataGridViewTextBoxColumn.Name].Value.ToString()=="2")
                        dgvr.Cells[this.answerDataGridViewTextBoxColumn.Name].Style.BackColor = Color.Red;
                else
                    dgvr.Cells[this.answerDataGridViewTextBoxColumn.Name].Style.BackColor = Color.LightGreen;

            }

        }

        private void chb_vesselspecific_CheckStateChanged(object sender, EventArgs e)
        {
          //  if (!this.chb_vesselspecific.Focused)
            //    return;
            if (this.chb_vesselspecific.Checked)
                this.ApplyFilter(false);
            else
                this.ApplyFilter(true);

        }

        private void dataGridView_vettings_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Event_OpenAttendance();
        }
        private void Event_OpenAttendance()
        {
            DataGridView dgv = this.dataGridView_vettings;

            if (dgv.SelectedRows.Count == 1)
            {
                int vetid = (int)((dgv.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["VetId"];
                int qid = (int)((dgv.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["QId"];
                WindowsFormsApplication1.FormQuestionnaire frmq = new FormQuestionnaire();
                frmq.VetId = vetid;
                frmq.QId = qid;
                frmq.QuestionnaireOrigin = FormQuestionnaire.BasicOrigin.Database;
                frmq.ShowDialog();


            }
        }
    }
}
