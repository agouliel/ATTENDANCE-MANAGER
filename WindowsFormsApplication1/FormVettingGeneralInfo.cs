using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormVettingGeneralInfo : Form
    {
        public FormVettingGeneralInfo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormVettingGeneralInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance1.InspectionTypes' table. You can move, or remove it, as needed.

            SqlDataAdapter da = Vetting.InspectionType.GetAdapter(Vetting.MyConnection.GetConnection());
            da.Fill(this.attendance1.InspectionTypes);

        }
    }
}
