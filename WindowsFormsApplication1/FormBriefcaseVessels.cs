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
    
    public partial class FormBriefcaseVessels : Form
    {
        private string m_filepath;
        private string m_password;
        public FormBriefcaseVessels()
        {
            InitializeComponent();
        }
        public String FilePath
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
        private void FormBriefcaseVessels_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance_rdbms.Vessel' table. You can move, or remove it, as needed.
            Vessel.FillVesselTable(MyConnection.GetConnection(),this.attendance_rdbms.Vessel);
            try
            {
                Portable.FillVesselTable(this.m_filepath,this.m_password, this.attendance_briefcase.Vessel);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void bt_tobc_Click(object sender, EventArgs e)
        {

        }
    }
}
