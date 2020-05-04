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
    public partial class FormBriefcaseVLog : Form
    {
        public System.Data.DataTable vtbl;
        public string filepath;
        public string password;
        public FormBriefcaseVLog()
        {
            InitializeComponent();
        }

        private void FormBriefcaseVLog_Load(object sender, EventArgs e)
        {
            vtbl = Portable.GetVersion(this.filepath, this.password);

            Binding bnd = new Binding("Text", vtbl, "VersionCode");
            this.tb_versioncode.DataBindings.Add(bnd);
            this.lb_filename.Text = this.filepath;
            DataTable tbl = Portable.GetVisitLog(this.filepath, this.password);
            this.dataGridView1.DataSource = tbl;

        }

        private void FormBriefcaseVLog_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (this.tb_versioncode.Text == "" || this.tb_versioncode.Text.Trim() == "")
                {
                    throw new Exception("invalid version code");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                string cname = dgv.Columns[e.ColumnIndex].DataPropertyName;

                if (cname == "ValidFromDate")
                {
                    DateTime adate=DateTime.MinValue;
                    try
                    {
                        DateTime.Parse(e.FormattedValue.ToString());
                    }
                    catch(Exception e1)
                    {
                        throw new Exception("Invalid Valid from date");
                    }
                }
                else if (cname == "ValidToDate")
                {
                    DateTime adate = DateTime.MinValue;
                    try
                    {
                        if (e.FormattedValue.ToString().Trim()!="")
                        DateTime.Parse(e.FormattedValue.ToString());
                    }
                    catch (Exception e1)
                    {
                        throw new Exception("Invalid Valid until date");
                    }
                }
                else if (cname == "LastDate")
                {
                    DateTime adate = DateTime.MinValue;
                    try
                    {
                        if (e.FormattedValue.ToString().Trim() != "")
                            DateTime.Parse(e.FormattedValue.ToString());
                    }
                    catch (Exception e1)
                    {
                        throw new Exception("Invalid Last date");
                    }
                }
                else if (cname == "QuestionnaireLimit")
                {
                    try
                    {
                        uint dummy=Convert.ToUInt32(e.FormattedValue);
                    }
                    catch(Exception e1)
                    {
                        throw new Exception("Invalid questionnaire limit");
                    }
                }
                else if (cname == "VisitNumberLimit")
                {
                    try
                    {
                        uint dummy = Convert.ToUInt32(e.FormattedValue);
                    }
                    catch (Exception e1)
                    {
                        throw new Exception("Invalid visit number limit");
                    }
                }
                else if (cname == "VettingNumberLimit")
                {
                    try
                    {
                        uint dummy = Convert.ToUInt32(e.FormattedValue);
                    }
                    catch (Exception e1)
                    {
                        throw new Exception("Invalid vetting number limit");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                e.Cancel = true;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                DataGridView dgv=(DataGridView) sender;
                DataGridViewRow dgvr=dgv.Rows[e.RowIndex];
                DataRowView drv = dgvr.DataBoundItem as DataRowView;



                if (drv["ValidFromdate"] != DBNull.Value)
                {
                    if (drv["ValidToDate"] != DBNull.Value)
                    {
                        DateTime dtfrom = (DateTime)drv["ValidFromdate"];
                        DateTime dtto = (DateTime)drv["Validtodate"];
                        if (dtfrom >= dtto)
                            throw new Exception("Date from should be less than date to");
                    }

                    if (drv["LastDate"] != DBNull.Value)
                    {
                        DateTime dtfrom = (DateTime)drv["ValidFromdate"];
                        DateTime dtlast = (DateTime)drv["Lastdate"];
                        if (dtlast < dtfrom)
                            throw new Exception("Last date cannot be less than from date");
                    }
                }
                else
                    throw new Exception("Date from cannot be null");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                e.Cancel = true;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.tb_versioncode.DataBindings[0].WriteValue();
                Portable.UpdateVersion(this.filepath, this.password, vtbl);
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            try{
                Portable.UpdateVisitLogInfo(this.filepath, this.password, this.dataGridView1.DataSource as DataTable);
                MessageBox.Show("Attendance updated successfully");
            }
            
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
