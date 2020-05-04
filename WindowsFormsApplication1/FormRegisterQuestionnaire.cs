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
    public partial class QuestionnaireForm : Form
    {
        public QuestionnaireForm()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void QuestionnaireForm_Load(object sender, EventArgs e)
        {

        }
    }
}
