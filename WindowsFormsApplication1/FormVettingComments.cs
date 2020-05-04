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
    public partial class FormVettingComments : Form
    {
        int m_vetid;
        public string m_password;
        public string  m_filepath;
       VettingInfo vi;

        public FormVettingComments()
        {
            InitializeComponent();
        }
        public int VetID
        {
            set
            {
                this.m_vetid = value;
            }
        }
        private void FormVettingComments_Load(object sender, EventArgs e)
        {
             vi= new VettingInfo();
             vi.VetId = this.m_vetid;
            vi.SelectByVetId(MyConnection.GetConnection(), this.m_vetid);
            this.tb_comments.Text = vi.Comments;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            vi.Comments = this.tb_comments.Text;
            
            try
            {
                vi.Save(MyConnection.GetConnection());
                MessageBox.Show("Changes committed");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
