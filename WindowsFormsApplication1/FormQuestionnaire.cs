#define ASPOSE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Collections;
using Vetting;

namespace WindowsFormsApplication1
{
    public partial class FormQuestionnaire : Form
    {
        private VettingInfo vi;
        private string m_password;
        private object m_author;
        private object m_title;
        private object m_regdate;
        private object m_comments;
        private string FilterNegative;
        private string FilterPositive;
        private string FilterComments;
        private string ActiveFilter;
        private int m_QId;
        private int m_VETId;
        private Guid m_VETGUI;
        private Guid m_VIQGUI;
        private string m_briefcasefilename;
        public enum BasicOrigin {Database,Briefcase};
        private BasicOrigin m_questionnaire_origin;
        public bool NewAttendance;
        public bool UpdatedAttendance;
        private WindowsFormsApplication1.Attendance.QuestionnaireDataTable CategoryTable;
        public Questionnaire.ViewerApplication ViewerApp;
        private string m_defaultnavigationcode;
        public String FilePassword
        {
            set
            {
                this.m_password=value;
            }
        }
        public string BriefcaseFilenName
        {
            set
            {
                this.m_briefcasefilename = value;
            }
        }
        
        public BasicOrigin QuestionnaireOrigin
        {
            set
            {
                this.m_questionnaire_origin = value;
            }
        }
        public object Author
        {
            set
            {
                this.m_author = value;
            }
        }
        public object Title
        {
            set
            {
                this.m_title = value;
            }
        }
        public object RegDate
        {
            set
            {
                this.m_regdate = value;
            }
        }
        public int QId
        {
            set
            {
                this.m_QId = value;
            }
        }
        public int VetId
        {
            set
            {
                this.m_VETId = value;
            }
            get
            {
                return this.m_VETId;
            }
        }


        public FormQuestionnaire()
        {
            InitializeComponent();
            NewAttendance = false;
            this.UpdatedAttendance = false;
            this.m_author = "{}";
            this.m_title = "{}";
            this.m_regdate = DateTime.MinValue;
            this.m_VETId = -1;
            this.m_password="";

            this.FilterComments = "";
            this.FilterNegative = "";
            this.FilterPositive = "";
            this.ActiveFilter = "";
            
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Label", typeof(string));
            tbl.Columns.Add("Number", typeof(string));
            tbl.Rows.Add(new object[2] { "", "0" });
            tbl.Rows.Add(new object[2] { "1. YES", "1" });
            tbl.Rows.Add(new object[2] { "2.  NO", "2" });
            tbl.Rows.Add(new object[2] { "3. N/S", "3" });
            tbl.Rows.Add(new object[2] { "4. N/A", "4" });


            //new object[3,2]{{,"1"},{"2.  NO","2"},{"3. N/S","3"}});

            /*
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */


            this.answerColumn.ValueMember = "Number";
            this.answerColumn.DisplayMember = "Label";
            this.answerColumn.DataSource = tbl;
            this.answerColumn.ValueType = typeof(int);

            /*
            this.significanceDataGridViewTextBoxColumn.Items.Add(DBNull.Value);
            this.significanceDataGridViewTextBoxColumn.Items.Add("1");
            this.significanceDataGridViewTextBoxColumn.Items.Add("2");
            this.significanceDataGridViewTextBoxColumn.Items.Add("3");
            this.significanceDataGridViewTextBoxColumn.Items.Add("4");
            this.significanceDataGridViewTextBoxColumn.Items.Add("5");
            */
            DataTable tblsig = new DataTable();
            tblsig.Columns.Add("Label", typeof(string));
            tblsig.Columns.Add("Number", typeof(string));
            tblsig.Rows.Add(new object[2] { "", DBNull.Value });
            tblsig.Rows.Add(new object[2] { "Low", "1" });
            tblsig.Rows.Add(new object[2] { "Medium", "2" });
            tblsig.Rows.Add(new object[2] { "Important", "3" });
            tblsig.Rows.Add(new object[2] { "High", "4" });
            tblsig.Rows.Add(new object[2] { "Critical", "5" });


            this.significanceColumn.ValueMember = "Number";
            this.significanceColumn.DisplayMember = "Label";
            this.significanceColumn.DataSource = tblsig;

            this.Event_EnableVetting(false);
            
        }

        public string DefaultNavigationQuestionCode
        {
            set
            {
                this.m_defaultnavigationcode = value;
            }
        }

        private void Event_NavigateToCode()
        {
            if (this.m_defaultnavigationcode==null||this.m_defaultnavigationcode.Trim() == "")
                return;
            try
            {
                DataRow[] srows = this.attendance.Questionnaire.Select("DefaultCode ='" + this.m_defaultnavigationcode + "'");
                int cidx = 0;
                if (srows.GetLength(0) >= 1)
                {
                    foreach (DataRowView drv in this.bindingSource_questionnaire.List)
                    {
                        if (drv.Row == srows[0])
                        {
                            this.bindingSource_questionnaire.CurrencyManager.Position = cidx;

                            break;
                        }
                        cidx++;
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void FormQuestionnaire_Load(object sender, EventArgs e)
        {



             string prefix="";




             if (this.m_questionnaire_origin == BasicOrigin.Briefcase)
             {
                 prefix = "Questionnaire";
                 this.statusStrip1.Items[0].Text = "BRIEFCASE";
                 (this.MainMenuStrip.Items["Template_DropDown"] as ToolStripDropDownItem).Enabled=false;
             }
             else
             {

                 prefix = "Questionnaire";
                 this.statusStrip1.Items[0].Text = "RDBMS";
                 (this.MainMenuStrip.Items["Template_DropDown"] as  ToolStripDropDownItem).Enabled = true;
             }



             
        Application.DoEvents();  
        this.bindingSource_questionnaire.DataSource = this.attendance;


        this.toolStripStatusLabelFilePath.Text = this.m_briefcasefilename;

        if (this.m_VETId != -1)
        {
            string vesselname = "";
            string inspectorname = "";
            string vettingcode = "";
            string companyrepresentativename = "";
                
            if (this.m_questionnaire_origin == BasicOrigin.Briefcase)
            {
                if (Portable.LoadVetting(this.m_briefcasefilename,this.m_password, this.m_VETId,out this.m_VETGUI, out this.m_QId,out this.m_VIQGUI, this.attendance.Questionnaire, out vesselname, out inspectorname,out companyrepresentativename, out vettingcode))
                {
                    this.lb_vesselname.Text = vesselname;
                    this.lb_inspectorname.Text = inspectorname;
                    this.lb_attendancecode.Text = companyrepresentativename;
                    this.lb_companyrepresentative.Text = companyrepresentativename;


                    //this.lb_vettingcode.Text = vettingcode;
                    this.lb_attendancecode.Text = vettingcode;

                    Questionnaire.GetBriefcaseInfo(this.m_briefcasefilename,this.m_password, this.m_QId, out this.m_title, out this.m_author, out this.m_comments, out this.m_regdate);
                    this.Event_EnableVetting(true);
                }
            }
            else
            {
               
                try
                { 
                    //Enable function: Export to excel file
                    this.exportToExcelToolStripMenuItem.Enabled = true;
                    System.Data.SqlClient.SqlConnection con = MyConnection.GetConnection();
                    vi = Vetting.Vetting.LoadInfo(con, this.m_VETId);
                    this.m_QId = vi.Qid;
                    this.m_title = "Not implemented";
                    Vetting.Vetting.LoadResults(con, this.m_VETId, this.m_QId, this.attendance.Questionnaire);

                    this.lb_vesselname.Text = vi.VesselName;
                    this.lb_inspectorname.Text = vi.InspectorName;
                    this.Text = this.Text + " As of " + vi.VettingDate.ToShortDateString();

                    //this.lb_vettingcode.Text = vettingcode;
                    this.lb_attendancecode.Text = vi.VettingCode;
                    this.lb_companyrepresentative.Text = vi.CompanyRepresentativeName;
                    this.Event_EnableVetting(true);
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
                finally
                {
                    
                }
            }
        }


        if (this.ViewerApp == Questionnaire.ViewerApplication.Attendance)
        {
            (this.MainMenuStrip.Items["Attendance_DropDown"] as ToolStripDropDownItem).Enabled = false;
            this.EnableUserInput(false);

        }
        else if (this.ViewerApp == Questionnaire.ViewerApplication.AttendancePortable)
        {
            this.EnableUserInput(true);
            (this.MainMenuStrip.Items["Attendance_DropDown"] as ToolStripDropDownItem).Enabled = true;

        }

        if ((DateTime)this.m_regdate != DateTime.MinValue)
            this.Text = prefix + " : {" + this.m_title.ToString() + "}       Author : " + this.m_author.ToString() + " @ " + this.m_regdate.ToString();

        //this.PrepaireCategoriesFiltering();
        this.PrepaireCategoriesFilteringVersion2();
        this.Event_NavigateToCode();
        }
        /// <summary>
        /// 17/6/2008
        /// </summary>
        private void PrepaireCategoriesFilteringVersion2()
        {

            DataView dv = new DataView(this.attendance.Questionnaire);
            dv.RowFilter = "ObjectType =2 ";
            dv.Sort = "GlobalDisplayIndex asc";
            TreeView tv = this.treeView_category;

            ArrayList MyList = new ArrayList();
            ArrayList IdList = new ArrayList();
            ArrayList GuiList = new ArrayList();

            

            TreeNode pn=null;

            tv.Nodes.Add("All");
            
            for (int i = 0; i < dv.Count; i++)
            {

                
                DataRowView drv = dv[i];
                TreeNode newnode = new TreeNode();

                newnode.Tag = dv[i];
               
                string code = drv["DefaultCode"].ToString().Trim();
                newnode.Text = drv["DisplayCode"]+" {"+code + "} " + drv["ObjectDescription"];
                int niter = IdList.Count;
                Guid gui = (Guid)drv["ObjectId"];
                Guid pgui = Guid.Empty;
                try
                {
                    pgui = (Guid)drv["ParentId"];
                }
                catch (Exception e1)
                {
                    pgui = Guid.Empty;
                }
                bool foundparent=false;
                if ( (int)drv["DisplayLevel"]==1 )
                newnode.ImageIndex = 1;
                else
                    newnode.ImageIndex = 2;

                for (int j = 0; j < niter; j++)
                {
                    if (pgui!=Guid.Empty&&pgui ==(Guid)GuiList[GuiList.Count - 1])
                    {
                        
                            TreeNode ln = MyList[MyList.Count - 1] as TreeNode;
                            ln.Nodes.Add(newnode);

                            foundparent = true;
                            break;
                        
                    }
                    else
                    {
                        MyList.RemoveAt(MyList.Count - 1);
                        IdList.RemoveAt(IdList.Count - 1);
                        GuiList.RemoveAt(GuiList.Count - 1);
                    }

                    
                    
                }

                MyList.Add(newnode);
                IdList.Add(drv["DefaultCode"]);
                GuiList.Add(gui);
                if (!foundparent)
                tv.Nodes[0].Nodes.Add(newnode);
                
            }
            MyList.Clear();
            IdList.Clear();
            GuiList.Clear();

        }

        private void EnableUserInput(bool yesno)
        {
            if (!yesno)
            {
                this.tb_usercomments.ReadOnly = true;
                this.dgv_questionnaire.ReadOnly = true;
            }
            else
            {
                
                this.tb_usercomments.ReadOnly=false;
                this.dgv_questionnaire.ReadOnly = false;
            }
        }
        private void PrepaireCategoriesFiltering()
        {

            ArrayList nclist = new ArrayList();
            DataView dv = new DataView(this.attendance.Questionnaire);
            dv.RowFilter = "ObjectType =2 ";
            dv.Sort = "GlobalDisplayIndex asc";

            TreeView tv = this.treeView_category;

            TreeNode pn=null;

            tv.Nodes.Add("All");
            for (int i = 0; i < dv.Count; i++)
            {

                int children = (int)dv[i]["children"];
                TreeNode tn = new TreeNode();
                tn.Tag = dv[i];
                tn.Text = dv[i]["DisplayCode"]+" "+dv[i]["ObjectDescription"].ToString();
                tv.Nodes.Add(tn);
                /*
                if (nclist.Count > 0)
                {
                    NodeInfo ni = (nclist[nclist.Count - 1] as NodeInfo);
                    ni.NodePlug.Add(tn);
                    ni.children--;
                    if (ni.children == 0)
                        nclist.RemoveAt(nclist.Count - 1);
                }


                if (children > 0)
                {
                    NodeInfo ni = new NodeInfo();
                    ni.children = children;
                    if (pn != null)
                        ni.NodePlug = pn.Nodes;
                    else
                        ni.NodePlug = tv.Nodes;
                    ni.NodePlug.Add(tn);
                }
                //                tv.Nodes.Add(tn);
                                pn = tn;
                 * 
                 */ 
            }


            
            

        }
        private void Event_FilterRows()
        {
            string finalfilter = ActiveFilter;
            if (finalfilter != "")
            {
                if (this.FilterNegative != "")
                    finalfilter += " and " + this.FilterNegative;
            }
            else
                finalfilter += this.FilterNegative;


            if (finalfilter != "")
            {
                if (this.FilterComments != "")
                    finalfilter += " and " + this.FilterComments;
            }
            else
                finalfilter += this.FilterComments;


            if (finalfilter != "")
            {
                if (this.FilterPositive != "")
                    finalfilter += " and " + this.FilterPositive;
            }
            else
                finalfilter += this.FilterPositive;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.bindingSource_questionnaire.SuspendBinding();
                this.bindingSource_questionnaire.Filter = finalfilter;
            }
            finally
            {

                this.bindingSource_questionnaire.ResumeBinding();
                this.Cursor = Cursors.Default;
            }
        }
        private bool CheckEditState()
        {
            if (this.dgv_questionnaire.IsCurrentCellInEditMode)
            {

                if (this.dgv_questionnaire.IsCurrentRowDirty)
                {


                    {
                        MessageBox.Show("Edit operation not completed. Press CTRL+<Enter> and repeat procedure.");
                        return false;
                    }


                }
            }
            return true;
        }

        private void Event_FilterActiveNode(bool bclearfilter)
        {
            if (!bclearfilter)
            {
                if (!CheckEditState())
                    return;

                int i = 0;
                try
                {
                    this.Cursor = Cursors.WaitCursor;

                    DataRowView drv = (this.treeView_category.SelectedNode.Tag as DataRowView);
                    //Guid cid = (Guid)drv["ObjectId"];
                    //this.ActiveFilter = "ParentId = '" + cid.ToString() + "'";
                    string acode = drv["InternalDisplayCode"].ToString();
                    this.ActiveFilter = "InternalDisplayCode like '" + acode + ".*'";
                    //this.label_Filterlabel.Text = drv["DisplayCode"] + "  {"+drv["DefaultCode"]+"} " + drv["ObjectDescription"];
                    this.label_Filterlabel.Text = drv["DisplayCode"] + "  " + drv["ObjectDescription"];
                    this.panel_filterlabel.Visible = true;
                    this.Event_FilterRows();

                }
                catch
                {
                    this.ActiveFilter = "";

                    this.label_Filterlabel.Text = "";
                    this.panel_filterlabel.Visible = false;

                    this.Event_FilterRows();
                }

            }
            else
            {
                this.bindingSource_questionnaire.SuspendBinding();
                this.ActiveFilter = "";
                this.Event_FilterRows();
            }


        }
        private void chb_positive_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                if (this.chb_negativefilter.Checked)
                {
                    this.chb_negativefilter.Checked = false;
                    this.FilterNegative = "";



                }
                this.FilterPositive = " answer = '1' ";

            }
            else
            {
                this.FilterPositive = "";

            }
            Event_FilterRows();
        }

        private void chb_remark_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                this.FilterComments = " comments is not null ";

            }
            else
            {
                this.FilterComments = "";

            }
            Event_FilterRows();
        }


        private void chb_negativefilter_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {
                if (this.chb_positive.Checked)
                {
                    this.chb_positive.Checked = false;
                    this.FilterPositive = "";
                }
                this.FilterNegative = " answer = '2' ";

            }
            else
            {
                this.FilterNegative = "";

            }
            Event_FilterRows();
        }



        private void dgv_questionnaire_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;


            int i = 0;

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow dgvr = null;
            DataRowView drv = null;
            DataRow dr = null;


            try
            {
                dgvr = dgv.Rows[e.RowIndex];

                drv = (DataRowView)dgvr.DataBoundItem;
                dr = drv.Row;

            }
            catch (Exception e2)
            {
                return;

            }



            Rectangle rect = new Rectangle();




            if ((int)drv["ObjectType"] == 2)
            {

                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Answer" ||
                    dgv.Columns[e.ColumnIndex].DataPropertyName == "Significance")
                {


                    e.Handled = true;
                    //e.PaintBackground(e.ClipBounds, false);
                    rect.X = e.CellBounds.X;
                    rect.Y = e.CellBounds.Y;
                    rect.Width = e.CellBounds.Width;
                    rect.Height = e.CellBounds.Height;


                    //rect.Inflate(-1, 0);
                    if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                    {
                        Brush b = new SolidBrush(e.CellStyle.SelectionBackColor);
                        e.Graphics.FillRectangle(b, e.CellBounds);
                        b.Dispose();
                    }
                    else
                        e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

                    e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
                    //e.PaintBackground(e.ClipBounds,true);
                    //e.Graphics.DrawRectangle(Pens.Black , e.CellBounds);
                }
                else if (dgv.Columns[e.ColumnIndex].DataPropertyName == "ObjectDescription")
                {
                    int dlv = (int)drv["DisplayLevel"];


                    e.PaintBackground(e.ClipBounds, true);

                    e.CellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    e.PaintContent(NewClipBounds(dlv, e.ClipBounds));
                    //e.PaintContent(e.ClipBounds);
                    e.Handled = true;
                }

                if (dgv.Columns[e.ColumnIndex].Name == "UnboundImageColumn")
                {

                    e.PaintBackground(e.CellBounds, true);
                    e.Handled = true;


                }
                else if (dgv.Columns[e.ColumnIndex].Name == "WithAttachment")
                {
                    e.PaintBackground(e.CellBounds, true);
                    e.Handled = true;

                }
            }
            else //question type
            {
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Answer")
                {
                    if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "2")
                    {
                        e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
                        e.PaintContent(e.CellBounds);
                        e.Handled = true;

                    }
                    else
                        if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1")
                        {
                            e.Graphics.FillRectangle(Brushes.LightGreen, e.CellBounds);
                            e.PaintContent(e.CellBounds);
                            e.Handled = true;

                        }

                }

                //"UnboundImageColumn"
                else if (dgv.Columns[e.ColumnIndex].Name == "UnboundImageColumn")
                {

                    if (drv["Comments"] != null && drv["Comments"] != DBNull.Value && drv["Comments"].ToString() != "")
                    {
                        //e.Graphics.FillRectangle(Brushes.White,e.CellBounds);
                        e.PaintBackground(e.CellBounds, true);
                        //dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.imageList1.Images[0];
                        //e.PaintContent(e.ClipBounds);
                        e.Graphics.DrawImage(this.imageList1.Images[5], e.CellBounds.Left, e.CellBounds.Top, 24, 24);
                        // e.Graphics.DrawImage(this.imageList1.Images[5], e.CellBounds.Left + 2, e.CellBounds.Top + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);

                        e.Handled = true;
                    }
                    else
                    {
                        e.PaintBackground(e.CellBounds, true);
                        e.Handled = true;

                    }

                }

                else if (dgv.Columns[e.ColumnIndex].Name == "WithAttachment")
                {

                    if (drv["WithAttachment"] != DBNull.Value && (bool)drv["WithAttachment"] != false)
                    {
                        //e.Graphics.FillRectangle(Brushes.White,e.CellBounds);
                        e.PaintBackground(e.CellBounds, true);
                        //dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.imageList1.Images[0];
                        //e.PaintContent(e.ClipBounds);
                        //e.Graphics.DrawImage(this.imageList1.Images[6],e.CellBounds.Left+2, e.CellBounds.Top+2,e.CellBounds.Width-4,e.CellBounds.Height-4);
                        e.Graphics.DrawImage(this.imageList1.Images[6], e.CellBounds.Left, e.CellBounds.Top, 24, 24);
                        e.Handled = true;
                    }
                    else
                    {
                        e.PaintBackground(e.CellBounds, true);
                        e.Handled = true;

                    }

                }
            }



            /*
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "DisplayCode")
                {

                    int lv = (int)drv["DisplayLevel"];
                    string s = "";
                    for (int j = 0; j < lv; j++)
                        s += "  ";
                    e.PaintBackground(e.ClipBounds, true);
                    e.Graphics.DrawString(s+e.FormattedValue,e.CellStyle.Font, e.CellStyle.Brushes.Black, new Point(e.CellBounds.X,e.CellBounds.Y));
                    
                    e.Handled = true;

                }
            */
            /*
            else
            {
                if ((string)drv["ObjectType"] == "2")
                {
                    string s = (string)drv["ObjectDescription"];
                    if (drv.Row.Table.Columns[e.ColumnIndex].ColumnName == "ObjectDescription")
                    {

                        int dlv = (int)drv["DisplayLevel"];
                        

                        e.PaintBackground(e.ClipBounds, true);

                        e.CellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                        //e.PaintContent(NewClipBounds(dlv, e.ClipBounds));
                        e.PaintContent(e.ClipBounds);
                        e.Handled = true;
                    }
                    
                }

            }
             */
            /*
            DataGridView dgv = (DataGridView)sender;


            int i = 0;

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewRow dgvr = dgv.Rows[e.RowIndex];

            DataRowView drv = (DataRowView)dgvr.DataBoundItem;
            DataRow dr = drv.Row;

            Rectangle rect = new Rectangle();




            if ((string)drv["ObjectType"] == "2")
            {

                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Answer" ||
                    dgv.Columns[e.ColumnIndex].DataPropertyName == "Significance")
                {


                    e.Handled = true;
                    //e.PaintBackground(e.ClipBounds, false);
                    rect.X = e.CellBounds.X;
                    rect.Y = e.CellBounds.Y;
                    rect.Width = e.CellBounds.Width;
                    rect.Height = e.CellBounds.Height;


                    //rect.Inflate(-1, 0);
                    e.Graphics.FillRectangle(Brushes.White, rect);
                    //e.Graphics.DrawRectangle(Pens.Black , e.CellBounds);
                }
                else if (dgv.Columns[e.ColumnIndex].DataPropertyName == "ObjectDescription")
                {
                    int dlv = (int)drv["DisplayLevel"];


                    e.PaintBackground(e.ClipBounds, true);

                    e.CellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    e.PaintContent(NewClipBounds(dlv, e.ClipBounds));
                    //e.PaintContent(e.ClipBounds);
                    e.Handled = true;
                }
            }
            else
            {
                if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Answer")
                {
                    if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "2")
                    {
                        e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
                        e.PaintContent(e.CellBounds);
                        e.Handled = true;

                    }
                    else
                        if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "1")
                        {
                            e.Graphics.FillRectangle(Brushes.LightGreen, e.CellBounds);
                            e.PaintContent(e.CellBounds);
                            e.Handled = true;

                        }

                }
            }

            /*
            else
            {
                if ((string)drv["ObjectType"] == "2")
                {
                    string s = (string)drv["ObjectDescription"];
                    if (drv.Row.Table.Columns[e.ColumnIndex].ColumnName == "ObjectDescription")
                    {

                        int dlv = (int)drv["DisplayLevel"];
                        

                        e.PaintBackground(e.ClipBounds, true);

                        e.CellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                        //e.PaintContent(NewClipBounds(dlv, e.ClipBounds));
                        e.PaintContent(e.ClipBounds);
                        e.Handled = true;
                    }
                    
                }

            }
             */


        }

        private void dgv_questionnaire_CellPaintingOld(object sender, DataGridViewCellPaintingEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;

            
            int i = 0;

            if (e.RowIndex < 0 || e.ColumnIndex <0)
                return;

            DataGridViewRow dgvr = dgv.Rows[e.RowIndex];

            DataRowView drv =  (DataRowView)dgvr.DataBoundItem ;
            DataRow dr = drv.Row;

            Rectangle rect = new Rectangle();

            if ((string)drv["ObjectType"] == "2")
            {
            
             if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Answer" ||
                 dgv.Columns[e.ColumnIndex].DataPropertyName == "Significance")
             {

                
                    e.Handled = true;
                    //e.PaintBackground(e.ClipBounds, false);
                    rect.X  = e.CellBounds.X ;
                    rect.Y = e.CellBounds.Y;
                    rect.Width  = e.CellBounds.Width ;
                    rect.Height  = e.CellBounds.Height;


                    //rect.Inflate(-1, 0);
                    e.Graphics.FillRectangle(Brushes.White, rect);
                    //e.Graphics.DrawRectangle(Pens.Black , e.CellBounds);
              }
             else if (dgv.Columns[e.ColumnIndex].DataPropertyName == "ObjectDescription")
             {
                 int dlv = (int)drv["DisplayLevel"];


                 e.PaintBackground(e.ClipBounds, true);

                 e.CellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                 e.PaintContent(NewClipBounds(dlv, e.ClipBounds));
                 //e.PaintContent(e.ClipBounds);
                 e.Handled = true;
             }
            }
            
            /*
            else
            {
                if ((string)drv["ObjectType"] == "2")
                {
                    string s = (string)drv["ObjectDescription"];
                    if (drv.Row.Table.Columns[e.ColumnIndex].ColumnName == "ObjectDescription")
                    {

                        int dlv = (int)drv["DisplayLevel"];
                        

                        e.PaintBackground(e.ClipBounds, true);

                        e.CellStyle.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                        //e.PaintContent(NewClipBounds(dlv, e.ClipBounds));
                        e.PaintContent(e.ClipBounds);
                        e.Handled = true;
                    }
                    
                }

            }
             */
            
           
        }

        private Rectangle NewClipBounds(int dlevel,Rectangle cb)
        {
            return cb;

            Rectangle newb=new Rectangle();
            newb.X =cb.X;
            newb.Y =cb.Y;
            newb.Width =cb.Width;
            newb.Height =cb.Height;
            
            int offset = (cb.Width / 10) * dlevel;
            newb.X += offset;
            newb.Width -=offset;
            return newb;
            
        }
        private void dgv_questionnaire_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow dgvr = (sender as DataGridView).Rows[e.RowIndex];
            if (dgvr.Cells != null)
            {
                if (dgvr.Cells[11].Value != DBNull.Value)
                {
                    if (dgvr.Cells[11].Value.ToString() != "2")
                    {
                        if (dgvr.Cells[12].Value != DBNull.Value)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }

                    if (dgvr.Cells[11].Value.ToString() == "2")
                    {
                        if (dgvr.Cells[12].Value == DBNull.Value)
                            e.Cancel = true;
                    }
                }
            }



            //if ( dgvr.Cells[e.ColumnIndex].OwningColumn.DataPropertyName=="answer 
        }

        private void attendanceToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


            if ((string)e.ClickedItem.Tag == "NewAttendance")
            {
                this.Event_NewAttendance();
            }
           
            else if ((string)e.ClickedItem.Tag == "SaveVetting")
            {
                //MessageBox.Show("Just for implementation purposes");
                this.Event_SaveVetting();  
            }
 
            

        }

        private void Event_SaveVetting()
        {

            if (this.dgv_questionnaire.IsCurrentCellInEditMode)
            {

                if (this.dgv_questionnaire.IsCurrentRowDirty)
                {
                    
                    
                    {
                        MessageBox.Show("Edit operation not completed. Press CTRL+<Enter> and repeat procedure.");
                        return;
                    }


                }
            }

            if (this.m_questionnaire_origin == BasicOrigin.Briefcase)
            {
                SqlCeConnection ce = Portable.ConnectionFromFile(this.m_briefcasefilename, "");
                if (Portable.SaveVetting(ce, this.m_VETId, this.m_QId, this.attendance.VettingInfo, this.attendance.Questionnaire))
                {
                    MessageBox.Show("Attendance successfuly saved");
                    this.UpdatedAttendance = true;
                }
                else
                    MessageBox.Show("Nothing saved");

            }
            else
                MessageBox.Show("Attendance storage not implemented yet");

        }

        private void Event_NewAttendance()
        {
            if (this.m_questionnaire_origin == BasicOrigin.Briefcase)
            {
                if (this.HasChanges(this.attendance.Questionnaire, DataRowState.Modified))
                {
                    if (MessageBox.Show("Uncommited changes detected. All changes will be lost. Proceed ?") != DialogResult.OK)
                        return;
                    this.ClearQuestionnaire();
                }

                this.Event_ShowGeneralInfo();
                this.NewAttendance = true;//to be reconsidered
            }
            else
            {
                MessageBox.Show("New attendance (origin RDBMS) not implemented yet");
            }
        }

        private void ClearQuestionnaire()
        {
            DataTable tbl = attendance.Questionnaire;
            int answeridx = tbl.Columns.IndexOf("answer");
            int sigidx = tbl.Columns.IndexOf("significance");
            int commentidx = tbl.Columns.IndexOf("comments");
            foreach (DataRow dr in tbl.Rows)
            {
                dr[answeridx] = DBNull.Value;
                dr[sigidx] = DBNull.Value;
                dr[commentidx] = DBNull.Value;

            }
            tbl.AcceptChanges();

        }



        public void Event_EnableVetting(bool ok)
        {
            if (ok)
            {
                this.dgv_questionnaire.ReadOnly = false;
                this.tb_usercomments.ReadOnly = false;
                var o = (this.menuStrip1.Items["Attendance_DropDown"] as ToolStripDropDownItem).DropDownItems["Save_MenuItem"].Enabled = true;
                panel_vettinginfo.Visible = true;
                this.bindingSource_questionnaire.SuspendBinding();
                this.dgv_questionnaire.Columns[11].Visible = true;
                this.dgv_questionnaire.Columns[12].Visible = true;
                this.dgv_questionnaire.Columns[14].Visible = true;
                
                this.bindingSource_questionnaire.ResumeBinding();

            }
            else
            {
                this.dgv_questionnaire.ReadOnly = true;
                this.tb_usercomments.ReadOnly = true;
                var o = (this.menuStrip1.Items["Attendance_DropDown"] as ToolStripDropDownItem).DropDownItems["Save_MenuItem"].Enabled = false;
                panel_vettinginfo.Visible = false;

                this.dgv_questionnaire.Columns[11].Visible = false;
                this.dgv_questionnaire.Columns[12].Visible = false;
                this.dgv_questionnaire.Columns[14].Visible = false;
                
            }
        }
        private void Event_ShowGeneralInfo()
        {

            
            VettingInfo vi = new VettingInfo();
            if (GetDialogInformation(vi))
            {
                this.Event_EnableVetting(true);  
                //o=(o as ToolStripDropDownItem).DropDownItems["Save"];//.Enabled =true;
            }
            else
            {
                this.Event_EnableVetting(false);
                return;

            }

            MessageBox.Show("Implemented for developing purposes");
            #region BRIEFCASEVERSION

            if (this.m_questionnaire_origin == BasicOrigin.Briefcase)
            {
                if (this.m_briefcasefilename == null || this.m_briefcasefilename.Trim() == "")
                {
                    MessageBox.Show("Cannot open briefcase file");
                    return;
                }

                SqlCeConnection cecon = Portable.ConnectionFromFile(this.m_briefcasefilename, "");
                if (cecon.State == ConnectionState.Closed)
                    cecon.Open();
                SqlCeTransaction trans = cecon.BeginTransaction();
                object vetid = null;
                System.Guid _vetgui = System.Guid.Empty;
                Portable.VettingInfoInsert(cecon, trans,this.m_password, out vetid,out _vetgui, this.m_QId, vi.InspectorName, vi.InspectorName,vi.CompanyRepresentativeName, System.Guid.Empty, vi.Port, System.Guid.Empty, vi.Country, vi.VettingDate,
                    vi.VettingTime, DBNull.Value, vi.Comments, System.Guid.Empty, vi.VesselName, vi.VettingCode,vi.InspectionTypeId);
                Portable.CreateVettingContextSlowVersion(cecon, trans, (int)vetid, this.m_QId);
                trans.Commit();
                cecon.Close();
                this.m_VETId = (int)vetid;
                
            #endregion
                this.ShowVettingInfoPanel(true, vi.InspectorName, vi.VesselName, vi.VettingCode, vi.Port, vi.VettingDate);
            }
            else
                MessageBox.Show("New attendance (RDBMS related)not implemented yet");



        }
        private void ShowVettingInfoPanel(bool showme,object inspectorname,object vesselname,object vettingcode,object port,object vdate)
        {
            this.panel_vettinginfo.Visible = showme;
            if (showme)
            {
                
                this.lb_inspectorname.Text = inspectorname.ToString();
                this.lb_vesselname.Text = vesselname.ToString();
                this.lb_attendancecode.Text = vettingcode.ToString();
                //this.lb
                //this.lb_vettingcode.Text = vettingcode.ToString();
            }
            else
            {
                this.lb_inspectorname.Text = "";
                this.lb_vesselname.Text = "";
                this.lb_attendancecode.Text = "";
                //this.lb_vettingcode.Text = "";

            }

           
        }

        private void ExportToPortable()
        {
            string ConnectionString;
            string filepath;
            string password="";
            

            OpenFileDialog odlg=Portable.OpenBriefcaseFile(false);
            
            if (odlg == null)
                return;

            
            


            System.Data.SqlServerCe.SqlCeConnection con = Portable.ConnectionFromFile(odlg.FileName,"");
            
            con.Open();

            SqlCeCommand cmd=new SqlCeCommand();
            cmd.Connection = con;
            try{ 
            
            cmd.CommandText = "INSERT INTO VIQINFO (QID,Title,Author,Finalized,Registrationdate) "+
                "VALUES (@p_qid,@p_title,@p_author,@p_final,@p_regdate)";


                    cmd.Parameters.Add ("@p_qid",SqlDbType.Int ); 
                    cmd.Parameters.Add ("@p_title",SqlDbType.NVarChar,128); 
                    cmd.Parameters.Add ("@p_author",SqlDbType.NVarChar,128); 
                    cmd.Parameters.Add ("@p_final",SqlDbType.SmallInt); 
                    cmd.Parameters.Add ("@p_regdate",SqlDbType.DateTime);



                    cmd.Parameters["@p_qid"].Value =this.m_QId ;
                    cmd.Parameters["@p_title"].Value=this.m_title  ;
                    cmd.Parameters["@p_author"].Value=this.m_author  ;
                    cmd.Parameters["@p_final"].Value =DBNull.Value ;
                    cmd.Parameters["@p_regdate"].Value =this.m_regdate;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e2)
                    {
                        if (e2.Message.IndexOf("duplicate") >= 0)
                        {
                            throw new Exception(string.Format ("Questionnaire {0} Author {1} @{2} hase been already transferred ",this.m_title,this.m_author,this.m_regdate  ));

                        }
                        throw e2;
                    }

                    

            
            
            
            
            
            
            
            
           
                cmd.CommandText =
                 "INSERT INTO [Questionnaire] ( " +
                "[QId], " +
                "[ObjectId], " +
                "[ObjectType], " +
                "[CategoryId], " +
                "[ParentCategoryId], " +
                "[GlobalDisplayIndex], " +
                "[DisplayLevel], " +
                "[Children], " +
                "[ObjectDescription], " +
                "[ObjectComments]," +
                "[DisplayCode], " +
                "[DefaultCode]) VALUES (@p_qid,@p_objid,@p_objtype,@p_catid,@p_parcatid,@p_glbidx,@p_dl,@p_children,@p_objdescr,@p_comm,@p_displcode,@p_defcode)";


                
                    cmd.Parameters.Add ("@p_qid",SqlDbType.Int ); 
                    cmd.Parameters.Add ("@p_objid",SqlDbType.UniqueIdentifier); 
                    cmd.Parameters.Add ("@p_objtype",SqlDbType.NVarChar,2); 
                    cmd.Parameters.Add ("@p_catid",SqlDbType.UniqueIdentifier); 
                    cmd.Parameters.Add ("@p_parcatid",SqlDbType.UniqueIdentifier); 
                    cmd.Parameters.Add ("@p_glbidx",SqlDbType.Int ); 
                    cmd.Parameters.Add ("@p_dl",SqlDbType.Int ); 
                    cmd.Parameters.Add ("@p_children",SqlDbType.Int ); 
                    cmd.Parameters.Add ("@p_objdescr",SqlDbType.NVarChar,4000); 
                    cmd.Parameters.Add ("@p_comm",SqlDbType.NVarChar,4000); 
                    cmd.Parameters.Add ("@p_displcode",SqlDbType.NVarChar,64); 
                    cmd.Parameters.Add ("@p_defcode",SqlDbType.NVarChar,64); 

                
                foreach (DataRow dr in this.attendance.Questionnaire.Rows)
                {
                    
                    cmd.Parameters["@p_qid"].Value=this.m_QId ;
                    cmd.Parameters["@p_objid"].Value = dr["ObjectId"];
                    cmd.Parameters["@p_objtype"].Value = dr["ObjectType"];
                    cmd.Parameters["@p_catid"].Value = dr["categoryId"];
                    cmd.Parameters["@p_parcatid"].Value = dr["ParentCategory"];
                    cmd.Parameters["@p_glbidx"].Value = dr["GlobalDisplayIndex"];
                    cmd.Parameters["@p_dl"].Value = dr["DisplayLevel"];
                    cmd.Parameters["@p_children"].Value = dr["Children"];
                    cmd.Parameters["@p_objdescr"].Value = dr["ObjectDescription"];
                    cmd.Parameters["@p_comm"].Value = dr["ObjectComments"];
                    cmd.Parameters["@p_displcode"].Value = dr["DisplayCode"];
                    cmd.Parameters["@p_defcode"].Value = dr["DefaultCode"];
                    cmd.ExecuteNonQuery();
                    
                    

                }




            /*
                    "CREATE TABLE [Questionnaire]( " +
                "[QId] [int] NOT NULL, " +
                "[ObjectId] [uniqueidentifier] NOT NULL, " +
                "[ObjectType] [nvarchar](2) NOT NULL, " +
                "[CategoryId] [uniqueidentifier] NULL, " +
                "[ParentCategoryId] [uniqueidentifier] NULL, " +
                "[GlobalDisplayIndex] [int] NOT NULL, " +
                "[DisplayLevel] [int] NOT NULL, " +
                "[Children] [int] NOT NULL, " +
                "[ObjectDescription] [nvarchar](4000) NOT NULL, " +
                "[ObjectComments] [nvarchar](4000) NULL, " +

                "[DisplayCode] [nvarchar](64)  NULL, " +
                "[DefaultCode] [nvarchar](64) NULL " +
                ") ";
            */


                MessageBox.Show(string.Format("Questionnaire {0} Author {1} @{2} successfuly transferred.", this.m_title, this.m_author, this.m_regdate));
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally
            {
                con.Close();

            }



        }


        /// <summary>
        /// Utility function to check if a datable has rowstate
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="astate"></param>
        /// <returns></returns>
        private bool HasChanges(System.Data.DataTable tbl,DataRowState astate)
        {
            foreach (DataRow dr in tbl.Rows)
            {
                if (dr.RowState == astate)
                    return true;
            }
            return false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Template_DropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             if((string)e.ClickedItem.Tag == "SendPortable")
            {
                this.ExportToPortable();
            }
        }

       

        private void treeView_category_DoubleClick(object sender, EventArgs e)
        {
            //Guid cid = (Guid)(this.treeView_category.SelectedNode.Tag as DataRowView)["CategoryId"];
            this.Event_FilterActiveNode(false);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag.ToString() == "FilterObjects")
            {
                this.Event_FilterActiveNode(false);

            }
            else if (e.ClickedItem.Tag.ToString() == "FilterRemove")
            {
                this.Event_FilterActiveNode(true);

            }
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if ((e.ClickedItem.Tag as string) == "ContextView")
            {
                this.Event_ShowContext();
            }


            if (this.bindingSource_questionnaire.Current == null)
                return;
            DataRowView drv = this.bindingSource_questionnaire.Current as DataRowView;


            if (e.ClickedItem.Name == "no1MenuItem")
            {
                drv["answer"] = 2;
                drv["Significance"] = 1;
                this.bindingSource_questionnaire.ResetCurrentItem();
                this.bindingSource_questionnaire.EndEdit();
            }
            else if (e.ClickedItem.Name == "no2MenuItem")
            {
                drv["answer"] = 2;
                drv["Significance"] = 2;
                this.bindingSource_questionnaire.ResetCurrentItem();
                this.bindingSource_questionnaire.EndEdit();
            }
            else if (e.ClickedItem.Name == "no3MenuItem")
            {
                drv["answer"] = 2;
                drv["Significance"] = 3;
                this.bindingSource_questionnaire.ResetCurrentItem();
                this.bindingSource_questionnaire.EndEdit();
            }
            else if (e.ClickedItem.Name == "no4MenuItem")
            {
                drv["answer"] = 2;
                drv["Significance"] = 4;
                this.bindingSource_questionnaire.ResetCurrentItem();
                this.bindingSource_questionnaire.EndEdit();
            }
            else if (e.ClickedItem.Name == "no5MenuItem")
            {
                drv["answer"] = 2;
                drv["Significance"] = 5;
                this.bindingSource_questionnaire.ResetCurrentItem();
                this.bindingSource_questionnaire.EndEdit();
            }
            else if (e.ClickedItem.Name == "yesMenuItem")
            {
                drv["answer"] = 1;
                drv["Significance"] = DBNull.Value;
                this.bindingSource_questionnaire.ResetCurrentItem();
                this.bindingSource_questionnaire.EndEdit();

            }
            else if (e.ClickedItem.Name == "rejectChangesMenuItem")
            {
                drv.Row.RejectChanges();
                this.bindingSource_questionnaire.ResetCurrentItem();
            }
            else if (e.ClickedItem.Name == "rejectAllChangesMenuItem")
            {
                
                this.attendance.Questionnaire.RejectChanges();
                this.bindingSource_questionnaire.ResetBindings(false);
            }
            

        }
        private void Event_ShowContext()
        {
            if (this.dgv_questionnaire.CurrentRow!=null)
            {
                DataRowView drv = this.dgv_questionnaire.CurrentRow.DataBoundItem as DataRowView;
                WindowsFormsApplication1.FormObjectContext frm = new FormObjectContext();
                frm.ObjectId = (Guid)drv["ObjectId"];
                frm.tb_question.Text = drv["ObjectDescription"].ToString();
                frm.tb_comment.Text = drv["ObjectComments"].ToString();
                frm.tb_question.Text = drv["ObjectComments"].ToString();
                frm.tb_inspectorcomment.Text = drv["Comments"].ToString();
                frm.lb_defcode.Text = drv["DefaultCode"].ToString();
                frm.ShowDialog();
            }
        }

        private void treeView_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Event_FilterActiveNode(false);
            }
        }

        private void toolStripComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.toolStripComboBoxFont.SelectedIndex != -1)
            {
                try
                {
                    float fsize = Convert.ToSingle(this.toolStripComboBoxFont.SelectedItem);
                    System.Drawing.Font f = new System.Drawing.Font(this.dgv_questionnaire.DefaultCellStyle.Font.FontFamily, fsize);
                    this.dgv_questionnaire.DefaultCellStyle.Font = f;
                    this.treeView_category.Font = f;
                    this.tb_comments.Font = f;
                    this.tb_question.Font = f;
                    this.tb_usercomments.Font = f;
                


                }
                catch
                {
                }

            }
        }


        private void toolStripTextBox_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.toolStripTextBox_Search.Text.Trim() == "")
                {
                    this.panel_filterlabel.Visible = false;
                    this.bindingSource_questionnaire.Filter = "";
                }
                else
                {
                    this.panel_filterlabel.Visible = false;
                    string filter = "ObjectDescription Like '" + this.toolStripTextBox_Search.Text.Trim() + "'";
                    this.bindingSource_questionnaire.Filter = filter;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        
        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if ASPOSE

            string outfilename = "";
            try
            {

                SaveFileDialog odlg = new SaveFileDialog();
                odlg.Filter = "Excel 2003 files|*.xls";
                odlg.FileName = "C:\\AttendanceDefaultOutputExcelFile.xls";
                if (DialogResult.OK == odlg.ShowDialog())
                {
                    outfilename = odlg.FileName;
                }
                else
                    throw new Exception("Invalid file name");
            }
            catch (Exception e1)
            {
                return;
            }
            Aspose.Cells.Comments ccomm = null;// new Aspose.Cells.Comments();

            System.IO.FileStream fs = null;
            try
            {
                fs=new System.IO.FileStream(outfilename, System.IO.FileMode.Create);
                Aspose.Cells.Workbook wkb = new Aspose.Cells.Workbook();

            
                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                wkb.Open(fs);

                Aspose.Cells.Worksheet wsh = wkb.Worksheets.Add("Vetting Information");


                wkb.Styles.Add();
                Aspose.Cells.Style astyle = wkb.Styles[0];
                astyle.BackgroundColor = Color.Yellow;
                astyle.Font.IsBold = true;


                //wkb.Styles.Add();
                //Aspose.Cells.Style bstyle = wkb.Styles[1];
                //bstyle.Font.IsBold = true;
                //bstyle.BackgroundColor = Color.Red;

                wsh.Cells.SetColumnWidth(0, 50);
                wsh.Cells.SetColumnWidth(1, 50);


                wsh.Cells[0, 0].PutValue("Company's Representative");
                wsh.Cells[0, 0].Style = astyle;

                wsh.Cells[1, 0].PutValue("Inspector Name");
                wsh.Cells[1, 0].Style = astyle;

                wsh.Cells[2, 0].PutValue("Port / Place");
                wsh.Cells[2, 0].Style = astyle;

                wsh.Cells[3, 0].PutValue("Vetting Date");
                wsh.Cells[3, 0].Style = astyle;

                wsh.Cells[4, 0].PutValue("Vetting time");
                wsh.Cells[4, 0].Style = astyle;

                wsh.Cells[5, 0].PutValue("Vessel Name");
                wsh.Cells[5, 0].Style = astyle;

                wsh.Cells[6, 0].PutValue("Vetting Code");
                wsh.Cells[6, 0].Style = astyle;

                wsh.Cells[7, 0].PutValue("Inspection");
                wsh.Cells[7, 0].Style = astyle;

                wsh.Cells[8, 0].PutValue("Comments");
                wsh.Cells[8, 0].Style = astyle;
               // wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
               // return;
                DataTable tbl = this.attendance.Questionnaire;
              //  DataRow dr = tbl.Rows[0];
                astyle.BackgroundColor = Color.Yellow;
                astyle.ForegroundColor = Color.Blue;
                wsh.Cells[0, 1].PutValue(vi.CompanyRepresentativeName.ToString());
                wsh.Cells[0, 0].SetStyle(astyle);
                

                wsh.Cells[1, 1].PutValue(vi.InspectorName.ToString());
                //wsh.Cells[1, 0].Style = astyle;

                wsh.Cells[2, 1].PutValue(vi.Port.ToString());
                //wsh.Cells[2, 0].Style = astyle;

                wsh.Cells[3, 1].PutValue(vi.VettingDate.ToLongDateString());
                //wsh.Cells[3, 0].Style = astyle;

                wsh.Cells[4, 1].PutValue(vi.VettingTime);
                //wsh.Cells[4, 0].Style = astyle;

                wsh.Cells[5, 1].PutValue(vi.VesselName);
                //wsh.Cells[5, 0].Style = astyle;

                wsh.Cells[6, 1].PutValue(vi.VettingCode);
                //wsh.Cells[6, 0].Style = astyle;

                wsh.Cells[7, 1].PutValue(vi.InspectionType.ToString());
                //wsh.Cells[7, 0].Style = astyle;

                wsh.Cells[8, 1].PutValue(vi.Comments.ToString());
                //wsh.Cells[8, 0].Style = astyle;


                string title;
                string ocode;
                int i = 0;
                Aspose.Cells.Worksheet AWsh = null;
                int srow = 1;
                int coloff = 1;
                ArrayList PList = new ArrayList();
                foreach (DataRow dr in this.attendance.Questionnaire)
                {
                    string answer = dr["Answer"].ToString();
                    string significanse = dr["Significance"].ToString();
                    Guid ogui = (Guid)dr["ObjectId"];
                    Guid pgui = (Guid)dr["ParentId"];
                    int otype = (int)dr["ObjectType"];
                    string ocomments = dr["ObjectComments"].ToString();
                    ocode = dr["DefaultCode"].ToString();
                    title = dr["ObjectDescription"].ToString();
                    if (otype == 2)
                    {
                        PList.Add(ogui);

                        if (pgui == Guid.Empty)
                        {
                            AWsh = wkb.Worksheets.Add("ch" + i.ToString() + "_" + Utility.ReplaceSpaceWithDash(title));
                            astyle.Font.IsBold = true;
                            astyle.Font.Size = 20;
                            AWsh.Cells.SetRowHeight(0, 40);
                            AWsh.Cells.SetColumnWidthInch(2, 6);
                            
                            AWsh.Cells[0, 0].Style.BackgroundColor = Color.Yellow;
                            AWsh.Cells[0, 0].PutValue(title);
                            AWsh.Cells[0, 0].Style = astyle;
                            
                            srow = 1;
                            ccomm=AWsh.Comments;
                            i++;
                        }
                        else
                        {
                            AWsh.Cells.SetRowHeight(srow, 20);
                         
                            astyle.Font.Size = 14;
                            if (pgui != (Guid)PList[PList.Count - 1])
                            {
                                AWsh.Cells[srow, 0].Style = astyle;
                                AWsh.Cells[srow, 0].PutValue(ocode);

                                AWsh.Cells[srow, 1].Style = astyle;
                                AWsh.Cells[srow, 1].PutValue(title);

                                //AWsh.Cells[srow, 2].Style = astyle;
                                //AWsh.Cells[srow, 2].PutValue(ocomments);
                                if (ocomments != "")
                                {
                                    int cidx = ccomm.Add(srow, 1);
                                    ccomm[cidx].Note = ocomments;
                                }
                                srow++;
                            }
                            else
                            {
                                AWsh.Cells[srow, 0].Style = astyle;
                                AWsh.Cells[srow, 0].PutValue(ocode);

                                AWsh.Cells[srow, 1].Style = astyle;
                                AWsh.Cells[srow, 1].PutValue(title);
                                if (ocomments != "")
                                {
                                    int cidx = ccomm.Add(srow, 1);
                                    ccomm[cidx].Note = ocomments;
                                }

                                //AWsh.Cells[srow, 2].Style = astyle;
                                //AWsh.Cells[srow, 2].PutValue(ocomments);
                             
                                srow++;

                            }
                        }
                    }
                    else
                    {
                        astyle.Font.Size = 9;
                        astyle.Font.IsBold = false;
                        
                        AWsh.Cells[srow, coloff+0].PutValue(ocode);
                        AWsh.Cells[srow, coloff + 1].PutValue(title);

                        AWsh.Cells[srow, coloff + 0].Style = astyle;
                        AWsh.Cells[srow, coloff + 1].Style = astyle;


                        astyle.Font.IsBold = true;
                        if (answer == "2")
                        {
                            answer = "NO";
                            
                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;


                            astyle.BackgroundColor = Color.Red;
                            AWsh.Cells[srow, coloff + 2].Style = astyle;

                            AWsh.Cells[srow, coloff + 2].PutValue(answer);
                            
                            //AWsh.Cells[srow, coloff + 3].Style.BackgroundColor = Color.Red;

                        }
                        else if (answer == "1")
                        {
                            answer = "YES";
                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;
                            AWsh.Cells[srow, coloff + 2].Style = astyle;

                            AWsh.Cells[srow, coloff + 2].PutValue(answer);
                            
                            //AWsh.Cells[srow, coloff + 3].Style.BackgroundColor = Color.LightGreen;

                            astyle.BackgroundColor = Color.LightGreen;
                        }
                        else if (answer == "4")
                        {
                            answer = "N/A";
                            AWsh.Cells[srow, coloff + 2].PutValue(answer);
                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;

                        }

                        string sig = "";
                        if (significanse == "1")
                        {
                            sig = "Low";
                        }
                        else if (significanse == "2")
                        {
                            sig = "Medium";
                        }
                        else if (significanse == "3")
                        {
                            sig = "Important";
                        }
                        else if (significanse == "4")
                        {
                            sig = "High";
                        }
                        else if (significanse == "5")
                        {
                            sig = "Critical";
                        }
                        AWsh.Cells[srow, coloff + 3].Style.Font.IsBold = true;
                        AWsh.Cells[srow, coloff + 3].PutValue(sig);




                       



                        //AWsh.Cells[srow, coloff + 2].PutValue(ocomments);
                        if (ocomments != "")
                        {
                            int cidx = ccomm.Add(srow, coloff+1);
                            ccomm[cidx].Note = ocomments;
                        }
                        srow++;



                    }


                }




                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                fs.Close();
                if (DialogResult.Yes == MessageBox.Show("Excel file was created. Do you want to open it?","Excel creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,  MessageBoxDefaultButton.Button2))
                {

                    Utility.OpenApplication(outfilename);
                }

                
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            finally
            {
                if (fs!=null)
                    fs.Close();
            }

#endif            
        }


        private void RenderCategory(ref int srow, int col,Aspose.Cells.Worksheet AWsh, ArrayList CList)
        {

            for (int i = 0; i < CList.Count; i++)
            {

                DataRow dr=CList[i] as DataRow;


                //string ocomments = dr["ObjectComments"].ToString();
                string ocode = dr["DefaultCode"].ToString();
                string title = ocode+" "+dr["ObjectDescription"].ToString();
                    
                
                //astyle.Font.IsBold = true;
                //astyle.Font.Size = 14;
                AWsh.Cells.SetRowHeight(0, 20);
                AWsh.Cells.SetColumnWidthInch(2, 6);

                

                
                AWsh.Cells[srow, 0].Style.BackgroundColor = Color.Yellow;
                AWsh.Cells[srow, 0].PutValue(title);
                //AWsh.Cells[srow, 0].Style = astyle;
                srow++;

                

            }

        }

        /*
        private DataRow[] GetDescendants(Guid objectid, DataTable q)
        {
            DataRow[] rows = q.Select = "ParentId =" + objectid.ToString();
            return rows;
        }
        private void HasDescendantRemarks(Guid objectid,DataTable q )
        {
            DataRow[] rows = GetDescendants(objectid,q);

            foreach (DataRow dr in rows)
            {
                DataRow[] srows=q.Select
            }
        }*/

        private void exportToExcelRemarksOld_Click(object sender, EventArgs e)
        {
#if ASPOSE

            string outfilename = "";
            try
            {

                SaveFileDialog odlg = new SaveFileDialog();
                odlg.Filter = "Excel 2003 files|*.xls";
                odlg.FileName = "C:\\AttendanceDefaultOutputExcelFile.xls";
                if (DialogResult.OK == odlg.ShowDialog())
                {
                    outfilename = odlg.FileName;
                }
                else
                    throw new Exception("Invalid file name");
            }
            catch (Exception e1)
            {
                return;
            }
            Aspose.Cells.Comments ccomm = null;// new Aspose.Cells.Comments();

            System.IO.FileStream fs = null;
            try
            {
                fs = new System.IO.FileStream(outfilename, System.IO.FileMode.Create);
                Aspose.Cells.Workbook wkb = new Aspose.Cells.Workbook();


                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                wkb.Open(fs);

                Aspose.Cells.Worksheet wsh = wkb.Worksheets.Add("Vetting Information");


                wkb.Styles.Add();
                Aspose.Cells.Style astyle = wkb.Styles[0];
                astyle.BackgroundColor = Color.Yellow;
                astyle.Font.IsBold = true;


                //wkb.Styles.Add();
                //Aspose.Cells.Style bstyle = wkb.Styles[1];
                //bstyle.Font.IsBold = true;
                //bstyle.BackgroundColor = Color.Red;

                wsh.Cells.SetColumnWidth(0, 50);
                wsh.Cells.SetColumnWidth(1, 50);


                wsh.Cells[0, 0].PutValue("Company's Representative");
                wsh.Cells[0, 0].Style = astyle;

                wsh.Cells[1, 0].PutValue("Inspector Name");
                wsh.Cells[1, 0].Style = astyle;

                wsh.Cells[2, 0].PutValue("Port / Place");
                wsh.Cells[2, 0].Style = astyle;

                wsh.Cells[3, 0].PutValue("Vetting Date");
                wsh.Cells[3, 0].Style = astyle;

                wsh.Cells[4, 0].PutValue("Vetting time");
                wsh.Cells[4, 0].Style = astyle;

                wsh.Cells[5, 0].PutValue("Vessel Name");
                wsh.Cells[5, 0].Style = astyle;

                wsh.Cells[6, 0].PutValue("Vetting Code");
                wsh.Cells[6, 0].Style = astyle;

                wsh.Cells[7, 0].PutValue("Inspection");
                wsh.Cells[7, 0].Style = astyle;

                wsh.Cells[8, 0].PutValue("Comments");
                wsh.Cells[8, 0].Style = astyle;
                // wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                // return;
                DataTable tbl = this.attendance.Questionnaire;
                //  DataRow dr = tbl.Rows[0];
                astyle.BackgroundColor = Color.Yellow;
                astyle.ForegroundColor = Color.Blue;
                wsh.Cells[0, 1].PutValue(vi.CompanyRepresentativeName.ToString());
                wsh.Cells[0, 0].SetStyle(astyle);


                wsh.Cells[1, 1].PutValue(vi.InspectorName.ToString());
                //wsh.Cells[1, 0].Style = astyle;

                wsh.Cells[2, 1].PutValue(vi.Port.ToString());
                //wsh.Cells[2, 0].Style = astyle;

                wsh.Cells[3, 1].PutValue(vi.VettingDate.ToLongDateString());
                //wsh.Cells[3, 0].Style = astyle;

                wsh.Cells[4, 1].PutValue(vi.VettingTime);
                //wsh.Cells[4, 0].Style = astyle;

                wsh.Cells[5, 1].PutValue(vi.VesselName);
                //wsh.Cells[5, 0].Style = astyle;

                wsh.Cells[6, 1].PutValue(vi.VettingCode);
                //wsh.Cells[6, 0].Style = astyle;

                wsh.Cells[7, 1].PutValue(vi.InspectionType.ToString());
                //wsh.Cells[7, 0].Style = astyle;

                wsh.Cells[8, 1].PutValue(vi.Comments.ToString());
                //wsh.Cells[8, 0].Style = astyle;


                string title;
                string ocode;
                int i = 0;
                int countrem = 0;
                Aspose.Cells.Worksheet AWsh = null;
                int srow = 1;
                int coloff = 1;
                ArrayList PList = new ArrayList();

                AWsh = wkb.Worksheets.Add("Remarks");

                AWsh.Cells.SetColumnWidthInch(5, 3);

                bool brendered = false;


                string Category = "";
                string SubCategory = "";
                Guid category_gui = Guid.Empty;
                srow = 1;
                foreach (DataRow dr in this.attendance.Questionnaire)
                {
                    string answer = dr["Answer"].ToString();
                    string significanse = dr["Significance"].ToString();
                    Guid ogui = (Guid)dr["ObjectId"];
                    Guid pgui = (Guid)dr["ParentId"];
                    int otype = (int)dr["ObjectType"];
                    string ocomments = dr["ObjectComments"].ToString();
                    ocode = dr["DefaultCode"].ToString();
                    title = dr["ObjectDescription"].ToString();
                    string remarks = "";

                    if (otype == 2)
                    {

                        
                        brendered = false;
                        category_gui = ogui;
                        Category = dr["ObjectDescription"].ToString();


                        if (pgui == Guid.Empty)
                        {
                            PList.Clear();
                            PList.Add(dr);
                            astyle.Font.IsBold = true;
                            astyle.Font.Size = 20;
                            AWsh.Cells.SetRowHeight(0, 40);
                            AWsh.Cells.SetColumnWidthInch(2, 6);

                            AWsh.Cells[0, 0].Style.BackgroundColor = Color.Yellow;
                            //AWsh.Cells[0, 0].PutValue(title);
                            AWsh.Cells[0, 0].Style = astyle;

                            
                            ccomm = AWsh.Comments;
                            i++;
                        }
                        else
                        {

                            AWsh.Cells.SetRowHeight(srow, 20);

                            

                            astyle.Font.Size = 14;
                            if (PList.Count==0||pgui == (Guid) (PList[0] as DataRow)["ObjectId"] )
                            {
                                PList.Add(dr);

                                AWsh.Cells[srow, 0].Style = astyle;
                                //AWsh.Cells[srow, 0].PutValue(ocode);

                                AWsh.Cells[srow, 1].Style = astyle;
                                //AWsh.Cells[srow, 1].PutValue(title);

                                //AWsh.Cells[srow, 2].Style = astyle;
                                //AWsh.Cells[srow, 2].PutValue(ocomments);
                                if (ocomments != "")
                                {
                                    int cidx = ccomm.Add(srow, 1);
                                    ccomm[cidx].Note = ocomments;
                                }
                                //srow++;
                            }
                            else
                            {
                                AWsh.Cells[srow, 0].Style = astyle;
                                //AWsh.Cells[srow, 0].PutValue(ocode);

                                AWsh.Cells[srow, 1].Style = astyle;
                                //AWsh.Cells[srow, 1].PutValue(title);
                                if (ocomments != "")
                                {
                                    int cidx = ccomm.Add(srow, 1);
                                    ccomm[cidx].Note = ocomments;
                                }

                                //AWsh.Cells[srow, 2].Style = astyle;
                                //AWsh.Cells[srow, 2].PutValue(ocomments);

                                //srow++;

                            }
                        }

                        countrem = 0;

                    }
                    else
                    {





                        if (dr["Comments"] == DBNull.Value)
                        {
                            continue;

                        }
                        countrem++;
                        remarks= dr["Comments"].ToString();

                        string k = VIQ.GetObjectTitlePath(MyConnection.GetConnection(), pgui, this.m_QId);
                        if (PList.Count > 0)
                        {
                            if (!brendered&&((Guid)(PList[PList.Count-1] as DataRow)["objectid"]) == pgui)
                            {
                                RenderCategory(ref srow, coloff,AWsh,PList);
                                brendered = true;

                            }

                        }

                        astyle.Font.Size = 9;
                        astyle.Font.IsBold = false;

                        AWsh.Cells[srow, coloff + 0].PutValue(ocode);
                        AWsh.Cells[srow, coloff + 1].PutValue(title);

                        AWsh.Cells[srow, coloff + 0].Style = astyle;
                        AWsh.Cells[srow, coloff + 1].Style = astyle;


                        astyle.Font.IsBold = true;
                        if (answer == "2")
                        {
                            answer = "NO";

                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;


                            astyle.BackgroundColor = Color.Red;
                            AWsh.Cells[srow, coloff + 2].Style = astyle;

                            AWsh.Cells[srow, coloff + 2].PutValue(answer);

                            //AWsh.Cells[srow, coloff + 3].Style.BackgroundColor = Color.Red;

                        }
                        else if (answer == "1")
                        {
                            answer = "YES";
                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;
                            AWsh.Cells[srow, coloff + 2].Style = astyle;

                            AWsh.Cells[srow, coloff + 2].PutValue(answer);

                            //AWsh.Cells[srow, coloff + 3].Style.BackgroundColor = Color.LightGreen;

                            astyle.BackgroundColor = Color.LightGreen;
                        }

                        string sig = "";
                        if (significanse == "1")
                        {
                            sig = "Low";
                        }
                        else if (significanse == "2")
                        {
                            sig = "Medium";
                        }
                        else if (significanse == "3")
                        {
                            sig = "Important";
                        }
                        else if (significanse == "4")
                        {
                            sig = "High";
                        }
                        else if (significanse == "5")
                        {
                            sig = "Critical";
                        }
                        AWsh.Cells[srow, coloff + 3].Style.Font.IsBold = true;
                        AWsh.Cells[srow, coloff + 3].PutValue(sig);






                        




                        //AWsh.Cells[srow, coloff + 2].PutValue(ocomments);
                        if (ocomments != "")
                        {
                            int cidx = ccomm.Add(srow, coloff + 1);
                            ccomm[cidx].Note = ocomments;
                        }

                        srow ++;
                        AWsh.Cells[srow, coloff+4].PutValue(remarks);
                        AWsh.Cells[srow, coloff + 4].Style.Font.IsBold = true;
                        AWsh.Cells[srow, coloff + 4].Style.Font.Color = Color.Blue;
                        AWsh.Cells[srow, coloff + 4].Style.VerticalAlignment = Aspose.Cells.TextAlignmentType.Top;

                        AWsh.Cells[srow, coloff + 4].Style.IsTextWrapped = true;
                        AWsh.AutoFitRow(srow);


                        

                        srow++;



                    }


                }



               
                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                fs.Close();
                if (DialogResult.Yes == MessageBox.Show("Excel file was created. Do you want to open it?", "Excel creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    Utility.OpenApplication(outfilename);
                }


            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

#endif
        }

        private void exportToExcelRemarks_Click(object sender, EventArgs e)
        {
#if ASPOSE

            string outfilename = "";
            try
            {

                SaveFileDialog odlg = new SaveFileDialog();
                odlg.Filter = "Excel 2003 files|*.xls";
                odlg.FileName = "C:\\AttendanceDefaultOutputExcelFile.xls";
                if (DialogResult.OK == odlg.ShowDialog())
                {
                    outfilename = odlg.FileName;
                }
                else
                    throw new Exception("Invalid file name");
            }
            catch (Exception e1)
            {
                return;
            }
            Aspose.Cells.Comments ccomm = null;// new Aspose.Cells.Comments();

            System.IO.FileStream fs = null;
            try
            {
                fs = new System.IO.FileStream(outfilename, System.IO.FileMode.Create);
                Aspose.Cells.Workbook wkb = new Aspose.Cells.Workbook();


                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                wkb.Open(fs);

                Aspose.Cells.Worksheet wsh = wkb.Worksheets.Add("Vetting Information");


                wkb.Styles.Add();
                Aspose.Cells.Style astyle = wkb.Styles[0];
                astyle.BackgroundColor = Color.Yellow;
                astyle.Font.IsBold = true;


                //wkb.Styles.Add();
                //Aspose.Cells.Style bstyle = wkb.Styles[1];
                //bstyle.Font.IsBold = true;
                //bstyle.BackgroundColor = Color.Red;

                wsh.Cells.SetColumnWidth(0, 50);
                wsh.Cells.SetColumnWidth(1, 50);


                wsh.Cells[0, 0].PutValue("Company's Representative");
                wsh.Cells[0, 0].Style = astyle;

                wsh.Cells[1, 0].PutValue("Inspector Name");
                wsh.Cells[1, 0].Style = astyle;

                wsh.Cells[2, 0].PutValue("Port / Place");
                wsh.Cells[2, 0].Style = astyle;

                wsh.Cells[3, 0].PutValue("Vetting Date");
                wsh.Cells[3, 0].Style = astyle;

                wsh.Cells[4, 0].PutValue("Vetting time");
                wsh.Cells[4, 0].Style = astyle;

                wsh.Cells[5, 0].PutValue("Vessel Name");
                wsh.Cells[5, 0].Style = astyle;

                wsh.Cells[6, 0].PutValue("Vetting Code");
                wsh.Cells[6, 0].Style = astyle;

                wsh.Cells[7, 0].PutValue("Inspection");
                wsh.Cells[7, 0].Style = astyle;

                wsh.Cells[8, 0].PutValue("Comments");
                wsh.Cells[8, 0].Style = astyle;
                // wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                // return;
                DataTable tbl = this.attendance.Questionnaire;
                //  DataRow dr = tbl.Rows[0];
                astyle.BackgroundColor = Color.Yellow;
                astyle.ForegroundColor = Color.Blue;
                wsh.Cells[0, 1].PutValue(vi.CompanyRepresentativeName.ToString());
                wsh.Cells[0, 0].SetStyle(astyle);


                wsh.Cells[1, 1].PutValue(vi.InspectorName.ToString());
                //wsh.Cells[1, 0].Style = astyle;

                wsh.Cells[2, 1].PutValue(vi.Port.ToString());
                //wsh.Cells[2, 0].Style = astyle;

                wsh.Cells[3, 1].PutValue(vi.VettingDate.ToLongDateString());
                //wsh.Cells[3, 0].Style = astyle;

                wsh.Cells[4, 1].PutValue(vi.VettingTime);
                //wsh.Cells[4, 0].Style = astyle;

                wsh.Cells[5, 1].PutValue(vi.VesselName);
                //wsh.Cells[5, 0].Style = astyle;

                wsh.Cells[6, 1].PutValue(vi.VettingCode);
                //wsh.Cells[6, 0].Style = astyle;

                wsh.Cells[7, 1].PutValue(vi.InspectionType.ToString());
                //wsh.Cells[7, 0].Style = astyle;

                wsh.Cells[8, 1].PutValue(vi.Comments.ToString());
                //wsh.Cells[8, 0].Style = astyle;


                string title;
                string ocode;
                int i = 0;
                int countrem = 0;
                Aspose.Cells.Worksheet AWsh = null;
                int srow = 1;
                int coloff = 1;
                ArrayList PList = new ArrayList();

                AWsh = wkb.Worksheets.Add("Remarks");

                AWsh.Cells.SetColumnWidthInch(5, 3);
                AWsh.Cells.SetColumnWidthInch(2, 3);

                bool brendered = false;


                string Category = "";
                string SubCategory = "";
                Guid category_gui = Guid.Empty;
                srow = 1;

                int pathrow = 1;
                string catpath = "";
                ccomm = AWsh.Comments;
                foreach (DataRow dr in this.attendance.Questionnaire)
                {
                    string answer = dr["Answer"].ToString();
                    string significanse = dr["Significance"].ToString();
                    Guid ogui = (Guid)dr["ObjectId"];
                    Guid pgui = (Guid)dr["ParentId"];
                    int otype = (int)dr["ObjectType"];
                    string ocomments = dr["ObjectComments"].ToString();
                    ocode = dr["DefaultCode"].ToString();
                    title = dr["ObjectDescription"].ToString();
                    string remarks = "";
                    

                    if (otype == 2)
                    {

                        continue;
                       
                    }
                    else
                    {





                        if (dr["Comments"] == DBNull.Value)
                        {
                            continue;

                        }
                        countrem++;
                        remarks = dr["Comments"].ToString();
                        
                        string k = VIQ.GetObjectTitlePath(MyConnection.GetConnection(), pgui, this.m_QId);
                        if (k != catpath)
                        {
                            pathrow = srow;
                            AWsh.Cells[pathrow, coloff -1].PutValue(k);
                            AWsh.Cells[pathrow, coloff -1].Style.Font.IsBold = true;
                            AWsh.Cells[pathrow, coloff - 1].Style.Font.Size = 12;

                            catpath = k;
                            srow += 2;
                        }
                         

                        astyle.Font.Size = 9;
                        astyle.Font.IsBold = false;

                        AWsh.Cells[srow, coloff + 0].PutValue(ocode);
                        AWsh.Cells[srow, coloff + 1].PutValue(title);
                      

                        AWsh.Cells[srow, coloff + 0].Style = astyle;
                        AWsh.Cells[srow, coloff + 1].Style = astyle;
                       // AWsh.Cells[srow, coloff + 1].Style.IsTextWrapped = true;


                        astyle.Font.IsBold = true;
                        if (answer == "2")
                        {
                            answer = "NO";
                            AWsh.Cells[srow, coloff + 2].PutValue(answer);

                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;


                            astyle.BackgroundColor = Color.Red;
                            AWsh.Cells[srow, coloff + 2].Style.BackgroundColor = Color.Red;//=astyle;

                            

                            //AWsh.Cells[srow, coloff + 3].Style.BackgroundColor = Color.Red;

                        }
                        else if (answer == "1")
                        {
                            answer = "YES";
                            AWsh.Cells[srow, coloff + 2].PutValue(answer);
                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;
                            AWsh.Cells[srow, coloff + 2].Style = astyle;


                            //AWsh.Cells[srow, coloff + 3].Style.BackgroundColor = Color.LightGreen;

                            astyle.BackgroundColor = Color.LightGreen;
                        }
                        else if (answer == "4")
                        {
                            answer = "N/A";
                            AWsh.Cells[srow, coloff + 2].PutValue(answer);
                            AWsh.Cells[srow, coloff + 2].Style.Font.IsBold = true;
                         
                        }

                        string sig = "";
                        if (significanse == "1")
                        {
                            sig = "Low";
                        }
                        else if (significanse == "2")
                        {
                            sig = "Medium";
                        }
                        else if (significanse == "3")
                        {
                            sig = "Important";
                        }
                        else if (significanse == "4")
                        {
                            sig = "High";
                        }
                        else if (significanse == "5")
                        {
                            sig = "Critical";
                        }
                        AWsh.Cells[srow, coloff + 3].Style.Font.IsBold = true;
                        AWsh.Cells[srow, coloff + 3].PutValue(sig);











                        //AWsh.Cells[srow, coloff + 2].PutValue(ocomments);
                        if (ocomments != "")
                        {
                            int cidx = ccomm.Add(srow, coloff + 1);
                            ccomm[cidx].Note = ocomments;
                        }

                        srow++;
                        AWsh.Cells[srow, coloff + 4].PutValue(remarks);
                        AWsh.Cells[srow, coloff + 4].Style.Font.IsBold = true;
                        AWsh.Cells[srow, coloff + 4].Style.Font.Color = Color.Blue;
                        AWsh.Cells[srow, coloff + 4].Style.VerticalAlignment = Aspose.Cells.TextAlignmentType.Top;

                        AWsh.Cells[srow, coloff + 4].Style.IsTextWrapped = true;
                        AWsh.AutoFitRow(srow);




                        srow++;



                    }


                }




                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                fs.Close();
                if (DialogResult.Yes == MessageBox.Show("Excel file was created. Do you want to open it?", "Excel creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    Utility.OpenApplication(outfilename);
                }


            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }

#endif
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editToolStripMenuItem.Checked)
            {
                this.dgv_questionnaire.ReadOnly = false;
                answerColumn.ReadOnly = false;
                significanceColumn.ReadOnly = false;
                this.tb_usercomments.ReadOnly = false;
                editToolStripMenuItem.Checked = true;
                this.Attendance_DropDown.Enabled = true;
                this.new_MenuItem.Enabled = false;
                this.Save_Menuitem.Enabled = true;
                this.editGenericCommentsMenuItem.Enabled = true;
                

            }
            else
            {

                if (Utility.HasChanges(this.attendance.Questionnaire))
                {
                    MessageBox.Show("Uncommitted changes detected");
                    return;
                }
                this.dgv_questionnaire.ReadOnly = true;
                answerColumn.ReadOnly = true;
                significanceColumn.ReadOnly = true;
                this.tb_usercomments.ReadOnly = true;
                editToolStripMenuItem.Checked = false;
                this.Save_Menuitem.Enabled = false;
                this.Attendance_DropDown.Enabled = false;
                this.new_MenuItem.Enabled = true;
                this.editGenericCommentsMenuItem.Enabled = false;
                
                
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            bool Editmode=this.editToolStripMenuItem.Checked;

            this.yesMenuItem.Visible = Editmode;
            this.no1MenuItem.Visible = Editmode;
            this.no2MenuItem.Visible = Editmode;
            this.no3MenuItem.Visible = Editmode;
            this.no4MenuItem.Visible = Editmode;
            this.no5MenuItem.Visible = Editmode;
            this.rejectAllChangesMenuItem.Visible = Editmode;
            this.rejectChangesMenuItem.Visible = Editmode;


            
        }

        private void editGenericCommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVettingComments frmvc=new FormVettingComments();
            frmvc.VetID=this.VetId;

            frmvc.ShowDialog();
        }



        public bool GetDialogInformation(VettingInfo vi)
        {
            WindowsFormsApplication1.FormVettingGeneralInfo frm = new FormVettingGeneralInfo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                vi.VesselName = frm.tb_vesselname.Text;
                vi.InspectorName = frm.tb_inspectorname.Text;
                vi.CompanyRepresentativeName = frm.tb_companyrepresentativename.Text;
                vi.Comments = frm.tb_comments.Text;
                vi.VettingDate = frm.dtp_vetdate.Value;
                vi.VettingTime = frm.dtp_vettime.Value;
                vi.Port = frm.tb_port.Text;
                vi.Country = frm.tb_country.Text;
                vi.VettingCode = frm.tb_vettingcode.Text;
                try
                {
                    vi.InspectionTypeId = (int)frm.cmb_insepctiontypes.SelectedValue;
                }
                catch
                {
                    vi.InspectionTypeId = -1;
                }
                vi.InspectionType = frm.cmb_insepctiontypes.SelectedText;
                return true;

            }
            return false;

        }
  
    }

    class NodeInfo
    {
        public int children;
        public TreeNodeCollection NodePlug;
    }


}
