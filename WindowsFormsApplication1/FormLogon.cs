using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormLogon : Form
    {
        public FormLogon()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (this.tb_username.Text.Trim() == "")
            {
                this.lb_status.Text = "Invalid user name";
                return;
            }
            if (this.tb_password.Text.Trim() == "")
            {
                this.lb_status.Text = "Invalid password";
                return;
            }

            this.DialogResult = DialogResult.OK;
            
        }
    }
}
