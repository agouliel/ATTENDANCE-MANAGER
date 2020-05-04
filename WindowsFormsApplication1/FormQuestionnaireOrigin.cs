using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vetting;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormQuestionnaireOrigin : Form
    {

        SqlDataAdapter daQuestionnaireOrigin = null;
        public FormQuestionnaireOrigin()
        {
            InitializeComponent();
        }

        private void questionnaireOriginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.questionnaireOriginBindingSource.EndEdit();

                this.daQuestionnaireOrigin.Update(this.attendance.QuestionnaireOrigin);
                MessageBox.Show("Changes committed");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void InitializeRole(bool yesno)
        {
            this.questionnaireOriginDataGridView.ReadOnly = !yesno;
            this.bindingNavigatorAddNewItem.Visible = yesno;
            this.bindingNavigatorDeleteItem.Visible = yesno;
            this.questionnaireOriginBindingNavigatorSaveItem.Visible = yesno;
        }
        private void FormQuestionnaireOrigin_Load(object sender, EventArgs e)
        {
            daQuestionnaireOrigin = Vetting.QuestionnaireOrigin.GetAdapter(MyConnection.GetConnection());
            this.questionnaireOriginBindingSource.DataSource = this.attendance;
            // TODO: This line of code loads data into the 'attendance.QuestionnaireOrigin' table. You can move, or remove it, as needed.
            int num=daQuestionnaireOrigin.Fill(this.attendance.QuestionnaireOrigin);
            this.questionnaireOriginBindingSource.AddingNew += new AddingNewEventHandler(questionnaireOriginBindingSource_AddingNew);
        }

        void questionnaireOriginBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            int i = 0;
            //( sender as BindingSource).Current["OriginId"] = Guid.Empty;
            DataRowView drv = (DataRowView)((sender as BindingSource).List as DataView).AddNew();
            drv["OriginId"] = Guid.Empty;
            e.NewObject = drv;
            (sender as BindingSource).MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DataRowView drv = this.questionnaireOriginBindingSource.Current as DataRowView;
            if (drv == null)
                return;

            int originid = (int)drv["OriginNo"];

            try
            {
                if (!Questionnaire.HasRelatedOrigin(MyConnection.GetConnection(), originid))
                drv.Delete();
                else
                throw new Exception("Questions related to this questionnaire were detected.");
            }
            catch (Exception e1)
            {
                MessageBox.Show("Deletion failed " + e1.Message);
            }

        }

        private void FormQuestionnaireOrigin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Utility.HasChanges(this.attendance.QuestionnaireOrigin))
            {
                if (DialogResult.OK == MessageBox.Show("Uncommitted changes were detected. Proceed ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    this.attendance.QuestionnaireOrigin.RejectChanges();
                }
                else
                    e.Cancel = true;
            }
        }

        
    }
}
