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
    public partial class Form_WelcomeScreen : Form
    {
        public Form_WelcomeScreen()
        {
            InitializeComponent();
        }

        private void Form_WelcomeScreen_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.Hide();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
