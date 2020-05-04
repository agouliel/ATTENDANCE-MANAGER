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
    public partial class FormInspectionType : Form
    {

        SqlDataAdapter daInspectionType=null;
        public FormInspectionType()
        {
            InitializeComponent();
        }

        private void FormInspectionType_Load(object sender, EventArgs e)
        {
            daInspectionType = Vetting.InspectionType.GetAdapter(MyConnection.GetConnection());
            // TODO: This line of code loads data into the 'attendance.InspectionTypes' table. You can move, or remove it, as needed.
            daInspectionType.Fill(this.attendance.InspectionTypes);
          
            if (ApplicationInfo.ActiveUserMode == ApplicationInfo.UserMode.NormalUser)
                this.InitializeRole(false);
            else
                this.InitializeRole(true);
        }
        private void InitializeRole(bool yesno)
        {
            this.dataGridView1.ReadOnly = !yesno;
            this.bindingNavigatorAddNewItem.Visible = yesno;
            this.bindingNavigatorDeleteItem.Visible = yesno;
            this.saveToolStripButton.Visible = yesno;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utility.HasChanges(this.attendance.InspectionTypes))
                {
                    int num = daInspectionType.Update(this.attendance.InspectionTypes);
                    MessageBox.Show("Changes successfuly saved");
                }
                else
                {
                    MessageBox.Show("Nothing to save");
                }
            }
            catch (Exception e2)
            {
                if (e2.Message.IndexOf("FK_VettingInfo_InspectionTypes")>0)
                    MessageBox.Show("Inspection type is already used in vettings.");
                else
                MessageBox.Show(e2.Message);
                
                this.attendance.RejectChanges();
            }
        }
    }
}
