using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Vetting;

namespace WindowsFormsApplication1
{
    public partial class FormAttendance : Form
    {
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {
            Event_FillAttendance();

        }
        private void Event_FillAttendance()
        {
            SqlConnection con=MyConnection.GetConnection();
            Vetting.Vetting.FillTable(con,this.attendance.VettingInfo);
        }
        private void Event_OpenAttendance()
        {
            if (this.dataGridView_Attendances.SelectedRows.Count == 1)
            {
                int vetid = (int)((this.dataGridView_Attendances.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["VetId"];
                int qid = (int)((this.dataGridView_Attendances.SelectedRows[0] as DataGridViewRow).DataBoundItem as DataRowView)["QId"];
                WindowsFormsApplication1.FormQuestionnaire frmq = new FormQuestionnaire();
                frmq.VetId = vetid;
                frmq.QId = qid;
                frmq.QuestionnaireOrigin = FormQuestionnaire.BasicOrigin.Database;
                frmq.ShowDialog();


            }
        }
        private void bt_openvetting_Click(object sender, EventArgs e)
        {
            this.Event_OpenAttendance();

        }

        private void dataGridView_Attendances_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Event_OpenAttendance();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Event_OpenAttendance();
        }
    }
}
