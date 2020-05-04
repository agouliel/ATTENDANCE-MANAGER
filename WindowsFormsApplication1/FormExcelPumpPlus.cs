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
    public partial class FormExcelPumpPlus : Form
    {
        public FormExcelPumpPlus()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_proceed_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

       
    }
}
