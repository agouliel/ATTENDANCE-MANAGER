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
    public partial class Form_CategoryEditor : Form
    {
        public Form_CategoryEditor()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (this.tb_categorycode.Text.Trim() == "")
                this.DialogResult = DialogResult.Abort;
            if (this.tb_categorydescription.Text.Trim() == "")
                this.DialogResult = DialogResult.Abort;
            this.DialogResult = DialogResult.OK;

        }
    }
}
