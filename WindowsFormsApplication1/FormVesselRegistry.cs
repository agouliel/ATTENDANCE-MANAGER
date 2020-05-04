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
    public partial class FormVesselRegistry : Form
    {
        SqlDataAdapter daVessel;
        public FormVesselRegistry()
        {
            InitializeComponent();
        }

        private void vesselBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vesselBindingSource.EndEdit();
            this.daVessel.Update(this.attendance.Vessel);

        }

        private void FormVesselRegistry_Load(object sender, EventArgs e)
        {
            daVessel = Vetting.Vessel.GetAdapter(MyConnection.GetConnection());
            // TODO: This line of code loads data into the 'attendance.Vessel' table. You can move, or remove it, as needed.
            Vetting.Vessel.FillVesselTable(MyConnection.GetConnection(),this.attendance.Vessel);

            if (ApplicationInfo.ActiveUserMode == ApplicationInfo.UserMode.NormalUser)
                this.InitializeRole(false);
            else
                this.InitializeRole(true);
        }
        private void InitializeRole(bool yesno)
        {
            this.bindingNavigatorAddNewItem.Visible = yesno;
            this.bindingNavigatorDeleteItem.Visible = yesno;
            this.vesselBindingNavigatorSaveItem.Visible = yesno;
            this.vesselIdTextBox.ReadOnly = !yesno;
            this.vesselNameTextBox.ReadOnly = !yesno;
            this.iMOTextBox.ReadOnly = !yesno;
            this.fLAGTextBox.ReadOnly = !yesno;
            this.deadWeightTextBox.ReadOnly = !yesno;
            this.deliveryDateDateTimePicker.Visible = yesno;
            this.grossTonageTextBox.ReadOnly = !yesno;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv=this.vesselBindingSource.Current as DataRowView;

                if (drv == null)
                    return;
                int vesselid = (int)drv["Vesselid"];

                



                if (Vetting.Vetting.VesselEncounter(MyConnection.GetConnection(),vesselid)>0)
                {
                    throw new Exception("Vessel cannot be deleted.She participates into registered vetting(s)");
                }
                else
                {
                    drv.Delete();
                }

                if (drv["Locked"] != DBNull.Value)
                {
                    if ((int)drv["Locked"] > 0)
                    {
                        throw new Exception("Vessel cannot be deleted. System lock detected.");
                    }
                }
                
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }


    }
}
