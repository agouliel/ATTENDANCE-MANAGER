#define EXCEL2003
//#define DEBUG
//#define SRV2008

using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;
using Vetting;
using System.Data.SqlClient;
#if XLSGEN
using xlsgen;
#endif
namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {

        private delegate void Delegate_GeneralPurpose();
       private bool bCategoryTreeHierarchyReady;
        private bool bAllowCategoryTreeView;
        Hashtable selected_reportnodes = new Hashtable();
        private string FilterCategory;
        private FormImportQuestionnaire frmImportQuestions;
        private  string FilterOrigin;
        private Font ActiveFont;
        private string CaptionOld;
        private DragDrop CDragDrop;
        private Hashtable pool;
        private bool bchildren;
        private int m_origin;
        private string m_password;
        private bool KANETONKINEZO;
        private bool bPreparingReport;
        System.Data.DataTable DeletedQuestion = new WindowsFormsApplication1.Attendance.QuestionPoolNewDataTable();
        private SqlDataAdapter daQuestionPoolNew;
        private SqlDataAdapter daCategory;
        private ArrayList RowsForRemoval;
        ThreadTask NewRegistrationNotirfier;
        public Form1()
        {

            

            NewRegistrationNotirfier = new ThreadTask(4);
            NewRegistrationNotirfier.OnThreadAction += new ThreadTask.Delegate_ThreadTask(NewRegistrationNotirfier_OnThreadAction);
            

            this.bCategoryTreeHierarchyReady = false;
            this.bAllowCategoryTreeView = false;
            //WindowsFormsApplication1.Properties.Settings.Default.SettingsLoaded += new SettingsLoadedEventHandler(Default_SettingsLoaded);
            //this.DecryptConnStrings();



            this.RowsForRemoval = new ArrayList(10);
            this.ActiveFont = null;
            KANETONKINEZO = false;

            InitializeComponent();
            this.bchildren = true;
            pool = new Hashtable(1000);
            WindowsFormsApplication1.Form_WelcomeScreen frm = new Form_WelcomeScreen();
            frm.ShowDialog();
            this.m_password = ")!(@*#&$^%!@#$%^&*()(*&^%$#@!";
            ApplicationInfo.bfpassword=this.m_password;
            //just for developing
            CRegistry.CreateKey();
            this.CaptionOld = this.Text;

            this.panel_top.Height = this.MainMenuStrip.Height;
            this.InitializeDesigner(false);


            this.GetDBSettings();
          
        }

        void NewRegistrationNotirfier_OnThreadAction(System.Threading.Thread th)
        {
            if ( this.dataGrid_ourquestion.IsHandleCreated)
            this.dataGrid_ourquestion.Invoke(new Delegate_GeneralPurpose(this.ShowLastRegistration));
        }

        void GetDBSettings()
        {
            try
            {
                MyConnection.SetConnectionStringFromConfiguration(Properties.Settings.Default.CnStr);
                //MessageBox.Show("a.goulielmos inside GetDBSettings: " + MyConnection.GetConnectionString());

                if (!Utility.CheckConnection(MyConnection.GetConnectionString()))
                {
                    
                    this.KANETONKINEZO = true;
                    this.DisableEverything();
                }
                else
                {
                  
                Properties.Settings.Default["AttendanceConnectionString"] = MyConnection.GetConnectionString();
                }
            }
            catch (Exception e1)
            {
                this.KANETONKINEZO = true;
                this.DisableEverything();
            }

        }


        void Default_SettingsLoaded(object sender, SettingsLoadedEventArgs e)
        {
            try
            {

                MyConnection.SetConnectionStringFromConfiguration(Properties.Settings.Default.CnStr);
                //NewRegistrationNotirfier.MainThread.Start();
                if (!Utility.CheckConnection(MyConnection.GetConnectionString()))
                {
                    this.KANETONKINEZO=true;
                    this.DisableEverything();
                }
            }
            catch (Exception e1)
            {
                this.KANETONKINEZO = true;
                this.DisableEverything();
            }



            
        }

        private void ShowLastRegistration()
        {
           DataTable tbl= VettingInfo.GetLastRegistration(MyConnection.GetConnection());
           if (tbl.Rows.Count > 0)
           {
               this.lb_lastregistrationinfo.Text =  ((DateTime)tbl.Rows[0]["RegistrationDate"]).ToLongDateString()+" Vet. date: "+((DateTime)tbl.Rows[0]["VetDate"]).ToShortDateString()+" Comp. Repr. :"+tbl.Rows[0]["CompanyRepresentativeName"];
               this.lb_registrationreporttime.Text =  DateTime.Now.ToShortDateString() + " "+DateTime.Now.ToLongTimeString() ;

           }


        }
        


        private void DisableEverything()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
                ctrl.Visible = false;
            }
        }
        private void ExportTotext()
        {
            StreamWriter sw=File.CreateText("c:\\contents.txt");
            try
            {
                for (int i = 0; i < this.categoryBindingSource.List.Count; i++)
                {
                    DataRowView drv = (DataRowView)this.categoryBindingSource.List[i];
                    sw.WriteLine("Category : "+drv["CategoryCode"].ToString()+" "+drv["CategoryDescription"].ToString());
                    sw.WriteLine("________________________________________");
                    
                    
                    sw.WriteLine("");
                    DataView dv = drv.CreateChildView(this.attendance.Relations[0]);
                    for (int j = 0; j < dv.Count; j++)
                    {
                        DataRowView drv1 = (DataRowView)dv[j];

                        sw.WriteLine("Question " + drv1["questioncode"].ToString());
                        sw.WriteLine(drv1["question"].ToString());
                        sw.WriteLine("Comment");
                        sw.WriteLine(drv1["Comment"].ToString());

                        sw.WriteLine("===========================================================");



                    }
                }
            }
            catch (Exception e1)
            {
            }
            finally
            {
                sw.Close();
            }
        }

        private void BuildReportVesselsTree()
        {
            DataTable vessels = new DataTable();

            Vessel.FillVesselTable(MyConnection.GetConnection(), vessels);
            this.tv_vessels.Nodes.Clear();
            foreach (DataRow dr in vessels.Rows)
            {
                TreeNode anode = new TreeNode();
                anode.Text = dr["Vesselname"].ToString();
                
                anode.Tag = dr;
                this.tv_vessels.Nodes.Add(anode);
            }

        }


        private void GiveTagSortIndex(TreeNode anode,ref int idx)
        {
            (anode.Tag as CategoryTag).sortindex= idx;
            idx++;
            if (anode.Nodes.Count > 0)
            {
                foreach (TreeNode tn in anode.Nodes)
                {
                    GiveTagSortIndex(tn, ref idx);
                }
            }
        }
        private void BuilCategoryTreeSortIndex()
        {
            int idx = 0;
            foreach (TreeNode tn in this.tv_categories.Nodes)
            {
                GiveTagSortIndex(tn, ref idx);
            }
        }

        private void BuildCategoryTreefromSortedDataset()
        {

            if (bCategoryTreeHierarchyReady)
                return;
               try
               {
                   
                   this.Cursor = Cursors.WaitCursor;
                   this.treeView_Category.Nodes.Clear();
                   this.tv_categories.Nodes.Clear();
                   DataView dv = attendance.Category.DefaultView;
                   //dv.RowFilter = "CategoryCode not like '%.%' ";


                   int idx = 0;


                   var nl = new List<TreeNode>();
                   var lf = new List<int>();


                   string prevcode = "";
                   TreeNode activenode = null;
                   TreeNode newnode = null;
                   int leafcount = 0;



                   
                   if ( dv.Count>0 && (dv[0] as DataRowView).Row["children"] == DBNull.Value)
                   {
                       throw new Exception("Display order is not set");
                   }
                   while (idx < dv.Count - 1)
                   {

                       Application.DoEvents();

                       DataRow dr = (DataRow)(dv[idx] as DataRowView).Row;
                       newnode = new TreeNode();
                       string code = dr["CategoryCode"].ToString();
                       newnode.Text = code + " " + dr["CategoryDescription"].ToString();
                       int children = (int)dr["Children"];
                       bool bParentfound = false;
                       bool bCheckActive = false;
                       if (children > 0)
                       {

                           bParentfound = true;

                       }
                       
                       
                       
                           
                           if (lf.Count > 0)
                           {
                               if (lf[lf.Count - 1] ==1)
                               {
                                   
                                   bCheckActive = true;
                               }
                               lf[lf.Count - 1]--;
                               

                               
                           }
                           else
                           {
                               activenode = null;
                           }
                      

                       CategoryTag ct = new CategoryTag();
                       ct.Datarow = dr;
                       newnode.Tag = ct;
                       ct.sortindex = (int)dr["DisplayOrder"];
                       if (activenode != null)
                           activenode.Nodes.Add(newnode);
                       else


                           this.tv_categories.Nodes.Add(newnode);
                       
                       if (bCheckActive)
                       {
                           bCheckActive = false;
                           
                               nl.RemoveAt(nl.Count - 1);
                               lf.RemoveAt(lf.Count - 1);
                           
                           if (lf.Count > 0)
                           {
                               activenode = nl[nl.Count - 1];

                           }
                           else
                               activenode = null;
                       }
                       if (bParentfound)
                       {
                           nl.Add(newnode);
                           lf.Add(children);
                           activenode = newnode;
                       }

                       idx++;
                   }

                   this.bCategoryTreeHierarchyReady = true;
               }
               catch (Exception e1)
               {
                   MessageBox.Show(e1.Message);
               }
               finally
               {
                   this.Cursor = Cursors.Default;
               }


        }
        private void BuildCategoryTree()
        {
            
            if (bCategoryTreeHierarchyReady)
                return;
            
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.treeView_Category.Nodes.Clear();
                this.tv_categories.Nodes.Clear();
                DataView dv = attendance.Category.DefaultView;
                //dv.RowFilter = "CategoryCode not like '%.%' ";

                Object[] rows = new DataRow[dv.Count];

                int idx = 0;
                foreach (DataRowView drv in dv)
                {
                    rows[idx++] = drv.Row;

                }

                System.Array.Sort(rows, (IComparer)new tComparer());



                ArrayList nl = new ArrayList();



                string prevcode = "";
                TreeNode prevnode = null;
                TreeNode newnode = null;
                foreach (Object o in rows)
                {
                    Application.DoEvents();

                    DataRow dr = (DataRow)o;
                    newnode = new TreeNode();
                    string code = dr["CategoryCode"].ToString();
                    newnode.Text = code + " " + dr["CategoryDescription"].ToString();
                    CategoryTag ct = new CategoryTag();
                    ct.Datarow = dr;
                    newnode.Tag = ct;
                    if (prevnode == null)
                    {
                        this.tv_categories.Nodes.Add(newnode);
                    }
                    else
                    {
                        bool binserted = false;
                        while (!binserted)
                        {
                            if (code.IndexOf((prevnode.Tag as CategoryTag).Datarow["categoryCode"].ToString()) == 0)
                            {
                                nl.Add(prevnode);
                                prevnode.Nodes.Add(newnode);
                                binserted = true;
                            }
                            else if (nl.Count > 0 && code.IndexOf(((nl[nl.Count - 1] as TreeNode).Tag as CategoryTag).Datarow["categoryCode"].ToString()) == 0)
                            {
                                (nl[nl.Count - 1] as TreeNode).Nodes.Add(newnode);
                                binserted = true;

                            }
                            else
                            {
                                if (nl.Count > 0)
                                    nl.RemoveAt(nl.Count - 1);
                                else
                                {
                                    this.tv_categories.Nodes.Add(newnode);
                                    binserted = true;
                                }

                            }
                        }



                    }
                    prevnode = newnode;


                }

                this.bCategoryTreeHierarchyReady = true;
                this.BuilCategoryTreeSortIndex();
                SaveCategoryDisplayOrder();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void SaveCategoryDisplayOrder()
        {
            int order =0;
            foreach (TreeNode tn in this.tv_categories.Nodes)
            {
                SaveTreeNodeOrder(tn, ref order, true);
            }



        }
        private void SaveTreeNodeOrder(TreeNode tn, ref int order,bool includeme)
        {
            if (includeme)
            {
                int cid=(int)(tn.Tag as CategoryTag).Datarow["Categoryid"];
                Vetting.Category.SaveCategoryOrder(MyConnection.GetConnection(),cid, order,tn.Nodes.Count );
                order++; 
            }
            if (tn.Nodes.Count > 0)
            {
                for (int i = 0; i < tn.Nodes.Count; i++)
                {
                    SaveTreeNodeOrder(tn.Nodes[i], ref order, true);
                }
            }
        }
        

        private void PrepareNotifierPanel()
        {
            
            panel_Notifier.Dock = DockStyle.Top;
            panel_Notifier.Visible = false;
            this.SpliVerical1.Panel1.Controls.Add(this.panel_Notifier);
            this.SpliVerical1.Panel1.Controls.SetChildIndex(this.panel_Notifier, 1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendance.QuestionnaireOrigin' table. You can move, or remove it, as needed.
           // this.questionnaireOriginTableAdapter.Fill(this.attendance.QuestionnaireOrigin);
            if (KANETONKINEZO)
            {
                DisableEverything();
                return;
             }

            //this.EncryptConnStrings();

            this.LoadEverything();
            TreeNode tn=new TreeNode("Questionnaire");
            tn.ImageIndex = 3;
            this.treeView1.Nodes.Add(tn);
            this.attendance.QuestionPoolNew.TableNewRow += new DataTableNewRowEventHandler(QuestionPoolNew_TableNewRow);
            this.CDragDrop = new DragDrop(this.treeView1);
           
            this.CDragDrop.OnDragEnded += new DragDrop.OnDragStoppedDelegate(CDragDrop_OnDragEnded);

            

            /*
            try
            {
                ApplicationInfo.userid=User.AuthenticateUser(MyConnection.GetConnection(), null, "Administrator", "ioniasoft");

                int roleid = User.GetUserRole(MyConnection.GetConnection(), null, ApplicationInfo.userid);
                if (roleid == 10000)
                    this.InitializeDesigner(true);
                else
                    this.InitializeDesigner(false);
            }
            catch (Exception e1)
            {
                this.Hide();
                Application.Exit();
            }
             */ 


            this.InitializeDesigner(false);
            ApplicationInfo.ActiveUserMode = ApplicationInfo.UserMode.NormalUser;
            this.PrepareNotifierPanel();

            this.BuildCategoryTreefromSortedDataset();
        }

        private void InitializeDesigner(bool yesno)
        {


            if (yesno)
            {
                this.panel_top.Height = 127;
                this.clearToolStripMenuItem.Visible = true;
                this.importToolStripMenuItem.Visible = true;
                this.importExcelFileToolStripMenuItem.Visible = true;
                this.importExcelQuestionnaireToolStripMenuItem.Visible = true;
                this.toolStripSeparator12.Visible = true;
                this.versionToolStripMenuItem.Visible = true;
                this.exportToTextToolStripMenuItem.Visible = true;
                this.briefCaseToolStripMenuItem.Visible = true;
                this.treeView1.Visible = true;
                this.saveToolStripMenuItem.Visible = true;
                
            }
            else
            {
                this.panel_top.Height = this.MainMenuStrip.Height;
                this.clearToolStripMenuItem.Visible = false;
                this.importToolStripMenuItem.Visible = false;
                this.importExcelFileToolStripMenuItem.Visible = false;
                this.importExcelQuestionnaireToolStripMenuItem.Visible = false;
                this.toolStripSeparator12.Visible = false;
                this.versionToolStripMenuItem.Visible = false;
                this.exportToTextToolStripMenuItem.Visible = false;
                this.briefCaseToolStripMenuItem.Visible = false;
                this.treeView1.Visible = false;
                this.saveToolStripMenuItem.Visible = false;
            }
            this.loadToolStripMenuItem.Visible = yesno;
                ToolStripItem anitem = GetItemFromTag(this.contextMenuStrip1,"CategoryUpdate");
                if (anitem!=null)
                anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip1, "CategoryCodeUpdate");
                if (anitem != null)
                anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip1, "CancelUpdatesSelection");
                if (anitem != null)
                anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip1, "CancelUpdates");
                if (anitem != null)
                anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip1, "ToQuestionnaire");
                if (anitem != null)
                anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip1, "SelectToChangeCategory");
                if (anitem != null)
                    anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip1, "SeparatorChanges");
                if (anitem != null)
                    anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip1, "SendToDesigner");
                if (anitem != null)
                    anitem.Visible = yesno;
                
               
                anitem = GetItemFromTag(this.contextMenuStrip2, "TargetCategorySelect");
                if (anitem != null)
                    anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip2, "ClearChangesCategory");
                if (anitem != null)
                    anitem.Visible = yesno;
                anitem = GetItemFromTag(this.contextMenuStrip2, "SendToDesigner");
                if (anitem != null)
                    anitem.Visible = yesno;

                this.bindingNavigatorAddNewCategory.Visible = yesno;
                this.bindingNavigatorDeleteCategory.Visible = yesno;
                this.saveToolStripButton_category.Visible = yesno;

                this.bindingNavigatorAddNewSireItem.Visible = yesno;
                this.bindingNavigatorDeleteSireQuestionItem.Visible = yesno;
                this.saveSireToolStripButton.Visible = yesno;

                this.BindingNavigator_CompanyInsertToolstripbutton.Visible = yesno;
                this.toolStripButton_deletecustomquestion.Visible = yesno;
                this.toolStripButton_savecustom.Visible = yesno;

                this.dataGridView_category.ReadOnly = !yesno;
                this.dataGridView_question.ReadOnly = !yesno;
                this.dataGrid_ourquestion.ReadOnly = !yesno;

                this.tb_sirequestion_comment.ReadOnly = !yesno;
                this.tb_historicaldata.ReadOnly = !yesno;
                this.tb_mngcomments.ReadOnly = !yesno;

                


                
            
        }

        private ToolStripItem GetItemFromTag(ContextMenuStrip astrip,string tag)
        {
            for (int i = 0; i < astrip.Items.Count; i++)
                {
                    if (astrip.Items[i].Tag!=null&&astrip.Items[i].Tag.ToString() == tag.ToString())
                        return astrip.Items[i];
                }
            return null;
        }
        private void LoadEverything()
        {
            //this.questionnaireOriginTableAdapter.Fill(this.attendance.QuestionnaireOrigin);
            // TODO: This line of code loads data into the 'attendance.QuestionPoolNew' table. You can move, or remove it, as needed.
#if DEBUGDETAILED
      MessageBox.Show("SM 7:Loading Origins");
#endif

            Vetting.QuestionnaireOrigin.Select(MyConnection.GetConnection(),this.attendance.QuestionnaireOrigin as DataTable);
#if DEBUGDETAILED
      MessageBox.Show("SM 7:Loaded");
#endif

#if DEBUGDETAILED
      MessageBox.Show("SM 8:Loading QuestionPool");
#endif

            //Vetting.QuestionPool.Select(MyConnection.GetConnection(),this.attendance.QuestionPoolNew as DataTable);
            Vetting.QuestionPool.SelectSP(MyConnection.GetConnection(), this.attendance.QuestionPoolNew as DataTable);
#if DEBUGDETAILED
      MessageBox.Show("SM 8:Loaded");
#endif

            // TODO: This line of code loads data into the 'attendance.Category' table. You can move, or remove it, as needed.
            //this.categoryTableAdapter.Fill(this.attendance.Category);
#if DEBUGDETAILED
      MessageBox.Show("SM 9:Loading Categories");
#endif


            Vetting.Category.Select(MyConnection.GetConnection(), this.attendance.Category as DataTable);
#if DEBUGDETAILED
      MessageBox.Show("SM 9:Loaded");
#endif



            //SOSOSOSOSOSOSOS SOSOS SOOSO SOSOSOSOSOSOSOSOSOSOOSSOSOSSSOSOSO SHOULD BE UNCOMMENTED AND DEBUGGED

#if DEBUGDETAILED
      MessageBox.Show("SM 10:Getting Adapter QuestionPool");
#endif

            daQuestionPoolNew = Vetting.QuestionPool.GetAdapter(MyConnection.GetConnection());
#if DEBUGDETAILED
      MessageBox.Show("SM 10: Done");
#endif


            daQuestionPoolNew.RowUpdating += new System.Data.SqlClient.SqlRowUpdatingEventHandler(AdapterQuestionPoolNew_RowUpdating);
            
            
            
            this.attendance.QuestionPoolNew.RowDeleting += new DataRowChangeEventHandler(QuestionPoolNew_RowDeleting);
#if DEBUGDETAILED
            MessageBox.Show("SM 11: Loading Ended");
#endif


        }
        void CDragDrop_OnDragEnded()
        {
            this.Text = this.CaptionOld;
        }

        



        protected void EncryptConnStrings() { // Get configuration information about Web.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration("");
            ConfigurationSection connectionStrings = config.GetSection("connectionStrings"); 
            if (connectionStrings != null) // Only encrypt the section if it is not already protected 
                 if (!connectionStrings.SectionInformation.IsProtected) { 
        // Encrypt the <connectionStrings> section using the 
        // DataProtectionConfigurationProvider provider 
                     if (!connectionStrings.SectionInformation.IsLocked)
                     {
                         connectionStrings.SectionInformation.ForceSave = true;
                    connectionStrings.SectionInformation.ProtectSection( "RsaProtectedConfigurationProvider"); 
                   config.Save(ConfigurationSaveMode.Full); // Refresh the Web.config display DisplayWebConfig(); 
                 }
                } 
            
            
         }

        protected void DecryptConnStrings()
        { // Get configuration information about Web.config 
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath+".config");
            ConfigurationSection connectionStrings = config.GetSection("connectionStrings");
            if (connectionStrings != null) // Only encrypt the section if it is not already protected 
                if (connectionStrings.SectionInformation.IsProtected)
                {
                    // Encrypt the <connectionStrings> section using the 
                    // DataProtectionConfigurationProvider provider 
                    if (!connectionStrings.SectionInformation.IsLocked)
                    {
                       // connectionStrings.SectionInformation.ForceSave = true;
                        connectionStrings.SectionInformation.UnprotectSection();
                        
                    }
                }


        }

        void Event_ValidateCategoryRow(DataRow dr)
        {
            try
            {
                if (dr.RowState == DataRowState.Modified)
                {
                    Guid oid = (Guid)dr["categorynewid"];
                    if (Category.CheckIfUsedInVetting(MyConnection.GetConnection(), oid))
                    {

                        throw new Exception("Category is already used in vetting(s)");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Bug found");
            }
            
            
        }

      
        void QuestionPoolNew_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
           
             e.Row["Origin"] = this.m_origin; //gets value from another event of insert button
           

            this.Text = e.Row["Origin"].ToString();
            e.Row["questionid"] = System.Guid.NewGuid();
            e.Row["CategoryNewId"] = (this.categoryBindingSource.CurrencyManager.Current as DataRowView)["CategoryNewid"];
        }

        void QuestionPoolNew_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            DataRow dr = this.DeletedQuestion.NewRow();
            dr.ItemArray = e.Row.ItemArray;
            this.DeletedQuestion.Rows.Add(dr);
        }

       

        void AdapterQuestionPoolNew_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
            if (e.Row.RowState == DataRowState.Added)
            {
                e.Row.BeginEdit();
                e.Row["questionid"] = Guid.NewGuid();
                e.Row.EndEdit();
                e.Command.Parameters[0].Value = e.Row["questionid"];
            }
            

        }
        private void FillCategories()
        {
            this.attendance.Category.DefaultView.Sort = "CategoryDescription ASC";


        }

        

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           /*
            DataRow[] drs=this.attendance.QuestionPoolNew.Select("", "", DataViewRowState.Deleted);
            if (drs.GetLength(0) > 0)
            {
                foreach (DataRow dr in drs) 
                {
                    this.DeleteRow(this.questionPoolNewTableAdapter.Adapter,dr,this.DeletedQuestion.Rows[0][0]);
                
                }
                this.DeletedQuestion.Clear(); 
            }
            */
            if (Utility.HasChanges(this.attendance.Category))
            {
                MessageBox.Show("<<category>>: Uncommited changes detected");
                return;
            }
            this.Event_SaveQuestionchanges();

             
        }

        private void Event_SaveQuestionchanges()
        {
            try
            {
                this.Validate();
                this.categoryQuestionPoolNewBindingSource.EndEdit();

                int num=daQuestionPoolNew.Update(this.attendance, "QuestionPoolNew");
                if (num>0)
                MessageBox.Show("Changes successfuly saved");
                else
                    MessageBox.Show("Nothing saved");


            }
            catch (Exception ce)
            {

                MessageBox.Show(ce.Message);
            }

        }

        private void dataGridView_question_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
      

        }

      
        private void DeleteRow(System.Data.SqlClient.SqlDataAdapter sqlad,DataRow dr, object delrowid)
        {
            DataRow[] drs = new DataRow[1];
            drs[0] = dr;
            sqlad.DeleteCommand.Parameters[0].Value = delrowid;
            try
            {
                sqlad.Update(drs);
            }
            catch (DBConcurrencyException dbce)
            {
                MessageBox.Show(dbce.Message);
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridView dgview = (DataGridView)(sender as ContextMenuStrip).SourceControl  ;

            object Categoryid = null;
            try{

                if ((String)e.ClickedItem.Tag == "CategoryUpdate")
                {
                    if (dgview.SelectedRows.Count ==0)
                    {
                        throw new Exception("Please select a category ID first");
                    }
                    DataRowView drv = (this.dataGridView_category.SelectedRows[0].DataBoundItem as DataRowView);
                    Categoryid = drv["CategoryId"];
                    if (Categoryid == DBNull.Value)
                    {
                        throw new Exception("Please select a category ID and repeat procedure");

                    }
                    foreach (DataGridViewRow dgdr in dgview.SelectedRows)
                    {
                        DataRowView crv = (dgdr.DataBoundItem as DataRowView);
                        crv.BeginEdit();
                        crv["CategoryId"] = Categoryid;
                        crv.EndEdit();

                    }
                }
                else if ((String)e.ClickedItem.Tag == "CategoryCodeUpdate")
                {
                    if (this.dataGridView_category.SelectedRows.Count ==0)
                    {
                        throw new Exception("Please select a category ID first");
                    }
                    DataRowView drv = (this.dataGridView_category.SelectedRows[0].DataBoundItem as DataRowView);
                    Categoryid = drv["CategoryCode"];
                    if (Categoryid == DBNull.Value)
                    {
                        throw new Exception("Please select a category ID and repeat procedure");

                    }
                    foreach (DataGridViewRow dgdr in dgview.SelectedRows)
                    {
                        DataRowView crv = (dgdr.DataBoundItem as DataRowView);
                        crv.BeginEdit();
                        crv["CategoryCode"] = Categoryid;
                        crv.EndEdit();

                    }
                }
                else if ((String)e.ClickedItem.Tag == "CancelUpdatesSelection")
                {
                    this.attendance.QuestionPoolNew.RejectChanges();
 
                    if (dgview.SelectedRows.Count == 0)
                    {
                        throw new Exception("Please select some questions first");
                    }
                    foreach (DataGridViewRow dgdr in dgview.SelectedRows)
                    {
                        DataRowView crv = (dgdr.DataBoundItem as DataRowView);
                        
                            crv.Row.RejectChanges(); 
                    }
                    

                }
                else if ((String)e.ClickedItem.Tag == "CancelUpdates")
                {
                    this.attendance.QuestionPoolNew.RejectChanges();

                    
                }
                else if ((String)e.ClickedItem.Tag == "ToQuestionnaire")
                {

                    this.TransferFromQuestionPool(dgview );

                }
                else if ((String)e.ClickedItem.Tag == "RelatedContext")
                {

                    this.Event_ShowContext(dgview);

                }
               }
               catch(Exception e1)
               {
                    MessageBox.Show(e1.Message);
                    return;
               }

                
                
            }


        private void Event_ShowContext(TreeView tv)
        {
            WindowsFormsApplication1.FormObjectContext frm = new FormObjectContext();
            try
            {
                if (tv.SelectedNode != null & tv.SelectedNode.Tag!=null)
                {
                    VIQObject vio=(tv.SelectedNode.Tag as VIQObject);
                    DataRow drv = vio.NodeDataRow;

                    if (vio.OType == VIQObject.VIQType.Question)
                    {
                        frm.ObjectId = (Guid)drv["QuestionId"];
                        frm.tb_comment.Text = drv["Comment"].ToString();
                        frm.tb_question.Text = drv["Question"].ToString();
                        frm.lb_defcode.Text = drv["QuestionCode"].ToString();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Related context for categories is not implemented");

                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }
        private void Event_ShowContext(DataGridView dgv)
        {
            WindowsFormsApplication1.FormObjectContext frm = new FormObjectContext();
            try
            {
                if (dgv.CurrentRow == null)
                    throw new Exception("Select a valid row");
                DataRowView drv=dgv.CurrentRow.DataBoundItem as DataRowView;
                frm.ObjectId= (Guid)drv["QuestionId"];
                frm.tb_comment.Text = drv["Comment"].ToString();
                frm.tb_question.Text = drv["Question"].ToString();
                frm.lb_defcode.Text = drv["QuestionCode"].ToString();
                frm.ShowDialog();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void Event_ShowDisplayCodes(bool yes)
        {
            this.Cursor = Cursors.WaitCursor;
            BuildNodeDisplayCode(this.treeView1.Nodes[0], "",yes);
            this.treeView1.Refresh();
            this.Cursor = Cursors.Default;
        }

        private void BuildNodeDisplayCode(TreeNode anode,string acode,bool yn)
        {
            VIQObject vi=anode.Tag as VIQObject;
            DataRow dr = null;
            
            if (vi!=null)
            dr=vi.NodeDataRow;
            

            VIQObject pvi=null;
            TreeNode pn = anode.Parent;
            

            DataRow pdr = null;
            
            if (pn!=null &&pn.Tag!=null)
            {
                pvi=pn.Tag as VIQObject;
                pdr=pvi.NodeDataRow;
            }

            if (vi != null)
            {
                if (acode ==null ||acode=="")
                acode = (anode.Index + 1).ToString(); 
                else
                acode = acode + "." + (anode.Index + 1);


                vi.InternalDisplayCode = acode;
                
                if (yn)
                {
                    if (anode.Level == 1 && vi.OType == VIQObject.VIQType.Category)
                        vi.DisplayCode = "Chapter " + acode;
                    else if (anode.Level > 3 && vi.OType == VIQObject.VIQType.Category)
                        vi.DisplayCode = "sub("+(anode.Level-2).ToString()+")-Section "+ acode;
                    else if (anode.Level > 2 && vi.OType == VIQObject.VIQType.Category)
                        vi.DisplayCode = "sub-Section " + acode;
                    
                    else if (anode.Level > 1 && vi.OType == VIQObject.VIQType.Category)
                        vi.DisplayCode = "Section " + acode;
                    else
                        vi.DisplayCode = acode;


                    /*
                    if (vi.OType == VIQObject.VIQType.Question)
                        anode.Text = vi.DisplayCode + "    {" + vi.DefaultCode + "} " + dr["Question"];
                    else
                        anode.Text = vi.DisplayCode + "    {" + vi.DefaultCode + "} " + dr["CategoryDescription"];
                     */
                }
                else
                {
                    vi.DisplayCode = "";
                    /*
                        if (vi.OType == VIQObject.VIQType.Question)
                            anode.Text = "{" + vi.DefaultCode + "} " + dr["Question"];
                        else
                            anode.Text = "{" + vi.DefaultCode + "} " + dr["CategoryDescription"];
                    */

                }

            }

            if (anode.Nodes.Count > 0)
            {

                for (int i = 0; i < anode.Nodes.Count; i++)
                {
                    BuildNodeDisplayCode(anode.Nodes[i], acode,yn);
                }
            }


            
            



        }


        private void TransferFromQuestionPool(DataGridView dgview)
        {
            TreeNode newnode = null;
          
            if (dgview == null)
            {
                MessageBox.Show("Cannot locate source control for context menu");
                return;
            }
            if (this.treeView1.SelectedNode == null)
            {
                MessageBox.Show("Select a node to transfer objects");
                return;
            }
            try
            {
                if (Utility.HasChanges(this.attendance.QuestionPoolNew))
                {
                    MessageBox.Show("Uncommited questions detected. Commit changes and repeat procedure.");
                    return;
                }

                //IEnumerator row_enum = dgview.SelectedRows.GetEnumerator();
                if (dgview.SelectedRows.Count == 0)
                    return;
                for (int j = dgview.SelectedRows.Count - 1; j >= 0;j--)
                {

                    newnode = new TreeNode();
                    newnode.ImageIndex = 2;

                    DataGridViewRow dgvr = dgview.SelectedRows[j] as DataGridViewRow;
                    if (dgvr.IsNewRow)
                        continue;
                    DataRowView drv = dgvr.DataBoundItem as DataRowView;
                    if (this.PrepareNode(newnode, VIQObject.VIQType.Question, drv.Row))
                    {
                        this.treeView1.SelectedNode.Nodes.Add(newnode);
                        dgvr.Selected = false;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        
        private bool PrepareNode(TreeNode anode,VIQObject.VIQType atype,DataRow dr)
        {
            VIQObject vio = new VIQObject(atype);
            anode.Tag = vio;
            vio.Node = anode;
            vio.DisplayIndex = anode.Index;
            vio.NodeDataRow = dr;

            
            if (atype==VIQObject.VIQType.Category)
            {
                anode.Text = "{"+dr["Categorycode"].ToString() + "} " + dr["CategoryDescription"];
                
                      
                vio.DefaultCode = dr["CategoryCode"].ToString();
                
                anode.ImageIndex = 1;
             if (dr["CategoryNewID"]!=DBNull.Value)
             {
              vio.Category =(System.Guid) dr["CategoryNewId"];
              vio.ObjectId = vio.Category;
              vio.CategoryId =(int) dr["categoryid"];
             }
             else
             vio.Category=Guid.Empty;
             
             vio.QuestionId =Guid.Empty;
            }
            else if (atype == VIQObject.VIQType.Question)
            {
                string prefix = "";
                if ((int)dr["Origin"] == 0)
                    anode.ImageIndex = 4; 
                else
                    anode.ImageIndex = 2; 
                anode.Text = prefix+"{"+dr["questioncode"].ToString() + "} " + dr["question"];

                vio.DefaultCode = dr["QuestionCode"].ToString();
                
                if (dr["questionid"] != DBNull.Value)
                {
                    vio.QuestionId = (System.Guid)dr["questionid"];
                    vio.ObjectId = vio.QuestionId; 
                }
                else
                    vio.QuestionId  = Guid.Empty;
            }

            if (!this.pool.ContainsKey(vio.ObjectId))
            {
                this.pool.Add(vio.ObjectId, anode);
                return true;
            }
            else
                return false;

        }



        private void Event_TransferHierarchicalCategories(TreeView tv)
        {
            ArrayList MyList = new ArrayList();
            ArrayList IdList = new ArrayList();


            //DataView dv = (this.categoryBindingSource.List as DataView).Table.DefaultView;

              


            for (int i = this.dataGridView_category.SelectedRows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow dgvr = this.dataGridView_category.SelectedRows[i];
                DataRowView drv = dgvr.DataBoundItem as DataRowView;
                TreeNode newnode = new TreeNode();
                
                
                            
                
                
                this.PrepareNode(newnode, VIQObject.VIQType.Category, drv.Row);

                string code = drv["CategoryCode"].ToString().Trim();

                int niter = IdList.Count;

                bool foundparent=false;
                for (int j = 0; j < niter; j++)
                {
                    if (code.IndexOf(IdList[IdList.Count - 1].ToString()) == 0)
                    {
                        if (code != IdList[IdList.Count - 1].ToString())
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
                        }
                    }
                    else
                    {
                        MyList.RemoveAt(MyList.Count - 1);
                        IdList.RemoveAt(IdList.Count - 1);

                    }

                    
                    
                }

                MyList.Add(newnode);
                IdList.Add(drv["CategoryCode"]);
                if (!foundparent)
                tv.Nodes[0].Nodes.Add(newnode);
                if (this.chb_cascade.Checked)
                this.TransferChildQuestions(newnode, drv);
                dgvr.Selected = false;
            }
            MyList.Clear();
            IdList.Clear();
            

        }


        private void Event_TransferCategories()
        {
            for (int i = this.dataGridView_category.SelectedRows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow dgvr = this.dataGridView_category.SelectedRows[i];
                DataRowView drv = dgvr.DataBoundItem as DataRowView;
                TreeNode newnode = new TreeNode();
                if (!this.bchildren)
                {
                    
                    if (this.treeView1.SelectedNode.Parent != null)
                        this.treeView1.SelectedNode.Parent.Nodes.Add(newnode);


                }
                else
                {
                    this.treeView1.SelectedNode.Nodes.Add(newnode);

                }
                this.PrepareNode(newnode, VIQObject.VIQType.Category, drv.Row);
            }

        }
        private void dataGridView_category_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    //this.Event_TransferCategories();
                    this.Event_TransferHierarchicalCategories(this.treeView1);

            
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F3)
                this.bchildren  = true;
            else if (e.KeyCode == Keys.F4)
                this.bchildren = false;
            DisplayShift();
        }
        private void DisplayShift()
        {
            
            if (this.bchildren)
            {
                this.rdb_children.Checked=true;
            }
            else
            {
                this.rdb_sibling.Checked=true ;
            }

        }


        private void DeleteNode(TreeNode nod)
        {
            ClearIds(nod);
            nod.Remove();
        }

        private void ClearIds(TreeNode nod)
        {
            if (nod.Tag == null)
                return;
            object id = (nod.Tag as VIQObject).ObjectId;
            pool.Remove(id);

            if (nod.Nodes.Count > 0)
            {
                for (int i = 0; i < nod.Nodes.Count; i++)
                {
                    ClearIds(nod.Nodes[i]);
                }
            }
  

        }
        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    var tv = (TreeView)sender;
                    
                    if (tv.SelectedNode.Parent == null)
                        return;
                    DeleteNode(tv.SelectedNode);
                }
                catch (Exception e2)
                {
                    int i = 0;
                }
            }
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            TreeNode cn = this.treeView1.SelectedNode;
            if (cn == null)
                return;
            TreeNode tn=(TreeNode) this.treeView1.SelectedNode.Clone();
            TreeNode pn = null;
            int anidx = 0;
            if (cn.PrevNode != null)
            {
                pn = cn.PrevNode.Parent;
                anidx = cn.PrevNode.Index; 
                pn.Nodes.Insert(anidx,tn);
                this.treeView1.SelectedNode = tn;
                cn.Remove();
            }
            else
            {
                return;
            }


        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            TreeNode cn = this.treeView1.SelectedNode;
            if (cn == null)
                return;
            TreeNode tn = (TreeNode)this.treeView1.SelectedNode.Clone();
            TreeNode pn = null;
            int anidx = 0;
            if (cn.NextNode != null)
            {
                pn = cn.NextNode.Parent;
                anidx = cn.NextNode.Index;
                cn.Remove();
                pn.Nodes.Insert(anidx, tn);
                this.treeView1.SelectedNode = tn;
                
            }
            else
            {
                return;
            }
        }

        private void bindingNavigatorCategory_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Add new")
            {
                Form_CategoryEditor frm = new Form_CategoryEditor();
                if (DialogResult.OK == frm.ShowDialog())
                {
                    DataRowView ndrv=(DataRowView)(((BindingNavigator)sender).BindingSource).AddNew();
                    ndrv["CategoryNewId"] = System.Guid.NewGuid();
                    ndrv["CategoryCode"] = frm.tb_categorycode.Text;
                    ndrv["CategoryDescription"] = frm.tb_categorydescription.Text;
                    ndrv.EndEdit();
                }
                
            }
            if ((String)e.ClickedItem.Tag == "SaveCategory")
            {
                try
                {
                    if (Utility.HasChanges(attendance.Category))
                    {
                    daCategory.Update(attendance.Category);
                    MessageBox.Show("Changes successfuly commited");
                    }
                    else
                    {
                        MessageBox.Show("Nothing to save");
                        return;

                    }

                }
                catch (Exception e1)
                {
                    MessageBox.Show("Save failed." + e1.Message);
                }
            }
        }

       
       

        

        private void toolStripButton_savecustom_Click(object sender, EventArgs e)
        {
            this.Event_SaveQuestionchanges();



        }

      
     
       


        private bool BriefcaseCreate(out string fpath)
        {
            fpath = "";
           // OpenFileDialog odlg=Vetting.Portable.OpenBriefcaseFile(true);
           // if (odlg==null)
            //    return false;

            FormBriefcaseFileNameInfo frmInfo = new FormBriefcaseFileNameInfo(MyConnection.GetConnection());
            if (frmInfo.ShowDialog() != DialogResult.OK)
            {
                return false;
            }

            string path = frmInfo.FilePath + frmInfo.FileName;
            if (!Vetting.Portable.SaveSchema(frmInfo.FilePath, frmInfo.FileName, this.m_password, frmInfo.FromDate, frmInfo.ToDate, frmInfo.UserName)) // a.goulielmos
            {
                MessageBox.Show("Briefcase file not created.");
                return false;
            }

            if (Vetting.Questionnaire.TransferRegistryInfoToBriefcase(MyConnection.GetConnection(), path, this.m_password))
            {

                MessageBox.Show("Briefcase created.");
                fpath = path;
                return true;
            }
            return false;


        }
        private void BriefcaseOpen()
        {

            System.Windows.Forms.OpenFileDialog ofdlg = new OpenFileDialog();
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                
                WindowsFormsApplication1.FormBriefcase frmbc = new FormBriefcase();
                frmbc.FilePath = ofdlg.FileName;
                frmbc.FilePassword = this.m_password;
                frmbc.ShowDialog();
                

            }
        }
        private void Event_OpenBriefcase(string fpath)
        {
                WindowsFormsApplication1.FormBriefcase frmbc = new FormBriefcase();
                frmbc.FilePath = fpath;
                frmbc.FilePassword = this.m_password;
                frmbc.ShowDialog();

        }

        private void SaveVIQ()
        {
            TreeView trv = this.treeView1;
            int viqid = -1;
            if (trv.Nodes[0].Nodes.Count < 1)
            {
                MessageBox.Show("Nothing to save");

            }
            else
            {
                DialogResult dr;
                WindowsFormsApplication1.QuestionnaireForm frm = new QuestionnaireForm();
                dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string title = "";
                    string author = "";
                    string comments = "";
                    try
                    {


                        //viqid = Convert.ToInt32(frm.tb_id.Text);
                        title = frm.tb_name.Text;
                        author = frm.tb_author.Text;
                        comments = frm.tb_description.Text;
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Invalid VIQ ID");
                        return;
                    }
                    /*
                    if (viqid < 0)
                    {
                        MessageBox.Show("Invalid VIQ ID");
                        return;
                    }*/

                    int rows = 0;
                    int row = 0;

                    System.Data.SqlClient.SqlConnection con = MyConnection.GetConnection();
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    System.Data.SqlClient.SqlTransaction trn = con.BeginTransaction();

                    try
                    {
                        bool bduplicate = false;
                       
                        /*
                        if (this.CheckIfVIQExists(viqid, trn))
                        {
                            if (MessageBox.Show("VIQ code already exists. Overwrite template?", "Saving template", MessageBoxButtons.OKCancel) != DialogResult.OK)
                                throw new Exception("Duplicate VIQ ID detected");
                            else bduplicate = true;

                        }

                        if (bduplicate)
                            this.UpdateVIQInfo(viqid, title, author, comments, trn);
                        else
                        */
                            Vetting.VIQInfo.SaveVIQInfo(out viqid, title, author, comments, trn);



                       // VIQObject.ClearPersistance(trn, viqid);
                        for (int i = 0; i < this.treeView1.Nodes[0].Nodes.Count; i++)
                        {
                            TreeNode n = this.treeView1.Nodes[0].Nodes[i];
                            rows += (n.Tag as VIQObject).SaveToPersistance(viqid, ref row, trn);

                        }
                        int qnum=VIQ.GetQuestionCount(con,trn,viqid);
                        VIQ.updateQuestionCount(con, trn,viqid,qnum);

                        trn.Commit();
                        con.Close();

                        MessageBox.Show("Stored Objects : " + rows);

                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                        trn.Rollback();
                    }

                }
            }


        }
        
        
       

       
        private void rdb_children_Click(object sender, EventArgs e)
        {
            this.bchildren = true;
        }

        private void rdb_sibling_Click(object sender, EventArgs e)
        {
            this.bchildren = false;
        }


     


        private void LoadQuestionnaire(int qid)
        {
            SqlDataAdapter SqlDa=Vetting.VIQ.GetAdapter(MyConnection.GetConnection());
            //bla.Connection.Open();
            try
            {
                this.pool.Clear();




                Vetting.VIQ.SetAdapterSelectParameter(SqlDa, qid);
                int rows = SqlDa.Fill(this.attendance.VIQ);
                MessageBox.Show("Retreived " + rows + " Objects");
                this.treeView1.Nodes.Clear();
                System.Data.DataTable dt = this.attendance.VIQ;
                TreeView tv = this.treeView1;
                VIQ viq = new VIQ();
                viq.Select(qid, MyConnection.GetConnection());

                tv.Nodes.Add("Questionnaire :" + viq.Title);
                TreeNode tn = null;
                TreeNode pn = null;
                TreeNode prnNode = null;
                bool bchildren = false;
                int children = 0;
                tv.Nodes[0].ImageIndex = 3;
                prnNode = tv.Nodes[0];
                System.Collections.ArrayList pl = new System.Collections.ArrayList(10);
                System.Collections.ArrayList cl = new System.Collections.ArrayList(10);




                int irow = 0;

                foreach (Attendance.VIQRow r in dt.Rows)
                {

                    try
                    {

                        irow++;
                        VIQObject vio = new VIQObject((VIQObject.VIQType)r.ObjectType);
                        vio.ObjectId = r.ObjectId;
                        Vetting.VIQObject.FillVIO(vio, MyConnection.GetConnection());

                        tn = new TreeNode();
                        if (vio.OType == VIQObject.VIQType.Category)
                        {
                            tn.ImageIndex = 1;
                            DataRow[] rs = this.attendance.Category.Select("CategoryNewId = '" + vio.ObjectId.ToString() + "'");
                            vio.NodeDataRow = rs[0];
                        }
                        else if (vio.OType == VIQObject.VIQType.Question)
                        {
                            DataRow[] rs = this.attendance.QuestionPoolNew.Select("QuestionId = '" + vio.ObjectId.ToString() + "'");
                            if (rs.GetLength(0) == 0)
                            {
                                throw new Exception("Procedure aborted:Question not found");
                                

                            }
                            vio.NodeDataRow = rs[0];
                            if (vio.Origin == 0)
                                tn.ImageIndex = 4;
                            else
                                tn.ImageIndex = 2;
                        }
                        this.pool.Add(vio.ObjectId, tn);



                        tn.Tag = vio;
                        tn.Text = "{" + vio.DefaultCode + "} " + vio.Content;
                        vio.Node = tn;

                        if (pl.Count > 0)
                        {
                            (pl[pl.Count - 1] as TreeNode).Nodes.Add(tn);
                            cl[cl.Count - 1] = (int)cl[cl.Count - 1] - 1;

                            if ((int)cl[cl.Count - 1] == 0)
                            {
                                cl.RemoveAt(cl.Count - 1);
                                pl.RemoveAt(pl.Count - 1);
                            }
                        }
                        else
                        {
                            prnNode.Nodes.Add(tn);
                            pn = tn;
                        }
                        if (r.Children > 0)
                        {
                            pl.Add(tn);
                            cl.Add(r.Children);

                        }
                    }
                    catch (Exception e1)
                    {
                        //MessageBox.Show(e1.Message);
                        if (pl.Count > 0)
                        {
                            (pl[pl.Count - 1] as TreeNode).Nodes.Add(tn);
                            cl[cl.Count - 1] = (int)cl[cl.Count - 1] - 1;

                            if ((int)cl[cl.Count - 1] == 0)
                            {
                                cl.RemoveAt(cl.Count - 1);
                                pl.RemoveAt(pl.Count - 1);
                            }
                        }
                        else
                        {
                            prnNode.Nodes.Add(tn);
                            pn = tn;
                        }
                        if (r.Children > 0)
                        {
                            pl.Add(tn);
                            cl.Add(r.Children);

                        }
                    }
                }
            
                    
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }
            // tbla.Connection.Close();
            BuildTemplate();
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form_QuestionnaireInfo frmq = new Form_QuestionnaireInfo();
            frmq.SQL_Connection = MyConnection.GetConnection();
           // WindowsFormsApplication1.AttendanceTableAdapters.VIQInfoTableAdapter viqadap = new WindowsFormsApplication1.AttendanceTableAdapters.VIQInfoTableAdapter();
           // inrows1=viqadap.Fill(this.attendance.VIQInfo);
            //frmq.Parent = this;
           // frmq.attendance = this.attendance;
           if ( frmq.ShowDialog()!=DialogResult.OK )
               return;

           int qid = -1;
           try { 
               qid = Convert.ToInt32(frmq.QID);
               this.LoadQuestionnaire(qid);
           }
           catch (Exception e1)
           {
               MessageBox.Show("Could not determine Questionnaire Id from selection");
               return;
           }
         
        }
        private void BuildTemplate()
        {

        }
        private void Event_ClearDesinger()
        {
            if (this.treeView1.Nodes[0].Nodes.Count > 0)
            {
                if (MessageBox.Show("Questionnaire will be removed from designer. Continue ?", "Questionnaire template deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.treeView1.Nodes.Clear();
                    this.treeView1.Nodes.Add("Questionnaire");
                    this.treeView1.Nodes[0].ImageIndex = 3;
                    this.pool.Clear();
                    this.chb_autodisplaycode.Checked = false;
                }

            }

        }


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Event_ClearDesinger();
                
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Form_QuestionnaireInfo frmq = new Form_QuestionnaireInfo();

            // WindowsFormsApplication1.AttendanceTableAdapters.VIQInfoTableAdapter viqadap = new WindowsFormsApplication1.AttendanceTableAdapters.VIQInfoTableAdapter();
            // int rows1=viqadap.Fill(this.attendance.VIQInfo);
            //frmq.Parent = this;
            // frmq.attendance = this.attendance;
            frmq.SQL_Connection = MyConnection.GetConnection();
            if (frmq.ShowDialog() != DialogResult.OK)
                return;

            int qid = -1;
            try { qid = Convert.ToInt32(frmq.QID); }
            catch (Exception e1)
            {
                MessageBox.Show("Could not determine Questionnaire Id from selection");
                return;
            }
            ShowQuestionnaire(qid);
        }

          private void ShowQuestionnaire(int qid)
        {
           try
              {

                  object  Title = "";
                  object  Author = "";
                  object  RegDate = DateTime.MinValue;
                  object NumQuestions=null;


                  if (!Questionnaire.FillTable(MyConnection.GetConnection(), qid, this.attendance.Questionnaire, out Title, out Author, out RegDate,out NumQuestions))
                  {
                      MessageBox.Show("Failed to retrieve data"); 
                  }

                WindowsFormsApplication1.FormQuestionnaire frm = new FormQuestionnaire();
                frm.QuestionnaireOrigin = FormQuestionnaire.BasicOrigin.Database;
                frm.Title =Title ;
                frm.Author =Author;
                frm.RegDate = RegDate;
                frm.QId = qid;


                frm.attendance = this.attendance;
                frm.Show();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            

        }


         



          private void TransferChildQuestions(TreeNode catnode,DataRowView drvcat)
          {
              DataView dv = drvcat.CreateChildView(this.attendance.Relations[0]);
              
              if (rdb_defaultorder.Checked)
              dv.Sort="DefaultDisplayindex asc";
              else if(rdb_companytop.Checked)
                  dv.Sort = "Origin asc , DefaultDisplayindex asc";

              else if(rdb_companybottom.Checked)
                  dv.Sort = "Origin desc ,DefaultDisplayindex asc";
              for (int i = 0; i < dv.Count; i++)
              {
                  DataRowView drv = (DataRowView)dv[i];
                  TreeNode newnode = new TreeNode();
                  if (this.PrepareNode(newnode, VIQObject.VIQType.Question, drv.Row))
                  {
                      catnode.Nodes.Add(newnode);
                      //newnode.ImageIndex = 2;
                      
                  }
                  else
                  {
                      continue;
                  }

              }

              
          }



          private void Event_TransferSelectedCategories()
          {
              try
              {


                  if (Utility.HasChanges(this.attendance.Category))
                  {
                      MessageBox.Show("Uncommited categories detected. Save changes and repeat procedure.");
                      return;
                  }

                  for (int i = this.dataGridView_category.SelectedRows.Count - 1; i >= 0; i--)
                  {
                      DataGridViewRow dgvr = this.dataGridView_category.SelectedRows[i];
                      DataRowView drv = dgvr.DataBoundItem as DataRowView;

                      TreeNode newnode = new TreeNode();




                      if (this.treeView1.SelectedNode == null)
                      {
                          MessageBox.Show("Please select a target Node");
                          return;
                      }

                      if (this.PrepareNode(newnode, VIQObject.VIQType.Category, drv.Row))
                      {
                          newnode.ImageIndex = 1;
                          if (!this.rdb_children.Checked)
                          {

                              
                              if (this.treeView1.SelectedNode.Parent != null)
                                  this.treeView1.SelectedNode.Parent.Nodes.Add(newnode);


                          }
                          else
                          {

                              
                              this.treeView1.SelectedNode.Nodes.Add(newnode);


                          }
                          if (this.chb_cascade.Checked)
                              this.TransferChildQuestions(newnode, drv);
                          dgvr.Selected = false;
                      }
                      else
                      {
                          continue;
                      }

                  }

              }
              catch (Exception e1)
              {
                  MessageBox.Show(e1.Message);
              }

          }

          private void sendToQuestionnaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

              if (this.chb_hierarchical.Checked)
                  this.Event_TransferHierarchicalCategories(this.treeView1);
              else
                 this.Event_TransferSelectedCategories();
            
              

        }


          private void ActivateRelation(bool yesno)
          {
              if (yesno)
              {
                  this.chb_cascade.Enabled = true;


                  this.dataGridView_question.DataSource = this.categoryQuestionPoolNewBindingSource;
                  this.dataGrid_ourquestion.DataSource = this.CategoryQuestionPoolNewCompanyBindingSource;
                  this.bindingNavigatorSireQuestion.Enabled = true;
                  this.bindingNavigatorQuestion.Enabled = true;
                  this.lb_relquestion_code.DataBindings.Clear();
                  this.lb_relquestion_code.DataBindings.Add(new Binding("Text", this.categoryQuestionPoolNewBindingSource, "questioncode"));
                  this.tb_sirequestion_comment.DataBindings.Clear();
                  this.tb_sirequestion_comment.DataBindings.Add(new Binding("Text", this.categoryQuestionPoolNewBindingSource, "comment"));
                  this.lb_activesire_category.Visible = true;
                  this.lb_activemng_category.Visible = true;


              }
              else
              {
                  this.chb_cascade.Checked = false;
                  this.chb_cascade.Enabled = false;

                  this.dataGridView_question.DataSource = this.questionPoolNewBindingSource;
                  this.dataGrid_ourquestion.DataSource = this.QuestionPoolNewCompanyBindingSource;
                  this.bindingNavigatorSireQuestion.Enabled = false;
                  this.bindingNavigatorQuestion.Enabled = false;

                  this.lb_relquestion_code.DataBindings.Clear();
                  this.lb_relquestion_code.DataBindings.Add(new Binding("Text", this.questionPoolNewBindingSource, "questioncode"));
                  this.tb_sirequestion_comment.DataBindings.Clear();
                  this.tb_sirequestion_comment.DataBindings.Add(new Binding("Text", this.questionPoolNewBindingSource, "comment"));
                  this.lb_activesire_category.Visible = false;
                  this.lb_activemng_category.Visible = false;


              }

          }

        private void chb_showrelation_CheckStateChanged(object sender, EventArgs e)
        {
            this.ActivateRelation((sender as System.Windows.Forms.CheckBox).Checked);
        }

        private void briefCaseToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag.ToString() == "NewBriefcase")
            {
                string fpath = "";
                if (this.BriefcaseCreate(out fpath))
                    this.Event_OpenBriefcase(fpath);
            }
            else if (e.ClickedItem.Tag.ToString() == "OpenBriefcase")
            {
                this.BriefcaseOpen();
               
            }

        }

        private void Attendance_DropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag.ToString() == "AttendanceView")
            {
                WindowsFormsApplication1.FormAttendance frm = new FormAttendance();
                frm.ShowDialog();

            }
            else if (e.ClickedItem.Tag.ToString() == "Vessels")
            {
                WindowsFormsApplication1.FormVesselRegistry frm = new FormVesselRegistry();
                frm.ShowDialog();

            }
            else if (e.ClickedItem.Tag.ToString() == "InspectionTypes")
            {
                WindowsFormsApplication1.FormInspectionType frm = new FormInspectionType();
                frm.ShowDialog();

            }
            else if (e.ClickedItem.Tag.ToString() == "DesignerClear")
            {
                this.Event_ClearDesinger();

            }
            

        }

        private void Event_ComboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.ActiveFont != null)
                this.ActiveFont.Dispose();
            System.Drawing.Font f = new System.Drawing.Font(this.dataGridView_category.DefaultCellStyle.Font.FontFamily, Convert.ToSingle((sender as ComboBox).SelectedItem));
            this.dataGridView_category.DefaultCellStyle.Font = f;
            this.dataGridView_question.DefaultCellStyle.Font = f;
            this.dataGrid_ourquestion.Font = f;
            this.treeView1.Font = f;
            this.tb_sirequestion_comment.Font = f;
            this.tb_mngcomments.Font = f;
            this.ActiveFont = f;
            
       

        }

        private void questionnaire_DropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag != null)
            {
                if ((string)e.ClickedItem.Tag == "SaveQuestionnaire")
                {
                    if (!this.chb_autodisplaycode.Checked)
                        MessageBox.Show("Display codes have not been set up");
                    else
                    this.SaveVIQ();
                }



            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.AboutBox1 absm = new AboutBox1();
            absm.Text = "About Attendance";
           
            absm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.attendance.HasChanges())
            {
                if (DialogResult.No==MessageBox.Show("Discard uncommited changes ? ","",MessageBoxButtons.YesNo))
                    e.Cancel=true;
            }
        }
        /// <summary>
        /// Should fire before Table New Row Add Event otherwise error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void bindingNavigatorSireQuestion_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.m_origin = 1;
            
        }

    

        private void Reports_DropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag!=null&&e.ClickedItem.Tag.ToString() == "CriticalReport")
            {
                
                WindowsFormsApplication1.Form_ReportCritical frm = new Form_ReportCritical();
                frm.ShowDialog();
            }
        }

        
        private void bindingNavigator_DeleteQuestion_Item_Click(object sender, EventArgs e)
        {
            var bn = (sender as ToolStripItem).Owner as BindingNavigator ;

            DataRowView drv = (DataRowView)bn.BindingSource.Current;

            if (drv == null) return;

            if (drv.Row.RowState != DataRowState.Detached&&drv.Row.RowState!=DataRowState.Added)
            {


                if (IsObjectUsedInDesigner((Guid)drv["questionid"]))
                {
                    MessageBox.Show("Object is already used in designer");
                    return;
                }


                if (!VIQ.IsVIQRelatedObject(MyConnection.GetConnection(), (Guid)drv["questionid"]))
                    bn.BindingSource.RemoveCurrent();
                else
                    MessageBox.Show("Question is already used in a Questionnaire");
            }
            else
            {
                //drv.BeginEdit();
               //I used list so to not trigger a validation event
                bn.BindingSource.RemoveCurrent();

            }
            
        }

        
        private bool IsObjectUsedInDesigner(Guid objectid)
        {
            if (pool.ContainsKey(objectid))
                return true;
            return false;

        }

        private void bindingNavigatorDeleteCategory_Click(object sender, EventArgs e)
        {
            var bn = (sender as ToolStripItem).Owner as BindingNavigator;

            DataRowView drv = (DataRowView)bn.BindingSource.Current;
            if (drv == null)
                return;

            if (IsObjectUsedInDesigner((Guid)drv["CategoryNewId"]))
            {
                MessageBox.Show("Object is already used in designer");

            }
            else if (VIQ.IsVIQRelatedObject(MyConnection.GetConnection(), (Guid)drv["CategoryNewId"]))
             
                MessageBox.Show("Category is already used in a Questionnaire");

            else if (VIQ.HasCategoryRelatedQuestionsInVIQ(MyConnection.GetConnection(),(Guid)drv["CategoryNewId"]))
            {
                MessageBox.Show("Category's related question(s) participate(s) into a Questionnaire");
            }
            else
                bn.BindingSource.RemoveCurrent();


        }

        private void Event_AddNewSireQuestion(object sender)
        {
            BindingNavigator bn = ((sender as ToolStripItem).Owner as BindingNavigator);
            if (bn.BindingSource.Current != null)
            {
                DataRowView drv = bn.BindingSource.Current as DataRowView;
                if (drv.Row.RowState == DataRowState.Detached)
                    return;
            }
            this.m_origin = 1;
            var  ndrv= (DataRowView) bn.BindingSource.AddNew();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Event_AddNewSireQuestion(sender);
        }

        private void BindingNavigator_CompanyInsertToolstripbutton_Click(object sender, EventArgs e)
        {
            BindingNavigator bn = ((sender as ToolStripItem).Owner as BindingNavigator);
            if (bn.BindingSource.Current != null)
            {
                DataRowView drv = bn.BindingSource.Current as DataRowView;
                if (drv.Row.RowState == DataRowState.Detached)
                    return;
            }
            this.m_origin = 0;
            var ndrv = (DataRowView)bn.BindingSource.AddNew();
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {

            /*
            RectangleF rf=RectangleF.FromLTRB(e.Bounds.Left, e.Bounds.Top, e.Bounds.Right, e.Bounds.Bottom);
            e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Near;
            if ( (e.State & TreeNodeStates.Focused) >0 && (e.State&TreeNodeStates.Selected)>0)
                e.Graphics.DrawString(e.Node.Text, e.Node.TreeView.Font, Brushes.White, rf, sf);
            else
            e.Graphics.DrawString(e.Node.Text,e.Node.TreeView.Font , Brushes.Black, rf,sf);
            */
            String Nodetext = null;
            if (e.Node.Tag != null)
            {
                if (!this.chb_autodisplaycode.Checked)
                {
                    Nodetext = e.Node.Text;
                }
                else
                {
                    Nodetext = (e.Node.Tag as VIQObject).DisplayCode + " " + e.Node.Text;
                }
            }
            else
                Nodetext = e.Node.Text;
            if (e.Node.TreeView.Font != null)
            {
                if ((e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected)
                    e.Graphics.DrawString(Nodetext, e.Node.TreeView.Font, Brushes.White, e.Bounds.X, e.Bounds.Y);
                else
                    e.Graphics.DrawString(Nodetext, e.Node.TreeView.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y);
            }
            
        }

       

        private void chb_autodisplaycode_CheckedChanged(object sender, EventArgs e)
        {

            this.Event_ShowDisplayCodes(((System.Windows.Forms.CheckBox)sender).Checked);
        }

        private void contextMenuStrip_Designer_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag.ToString()=="load_cat")
            {
                if (this.chb_hierarchical.Checked)
                    this.Event_TransferHierarchicalCategories(this.treeView1);
                else
                this.Event_TransferSelectedCategories();
            }
            else if (e.ClickedItem.Tag.ToString()=="load_sire")
            {
                this.TransferFromQuestionPool(this.dataGridView_question);

            }
            else if (e.ClickedItem.Tag.ToString() == "load_mng")
            {
                this.TransferFromQuestionPool(this.dataGrid_ourquestion);
            }
            else if (e.ClickedItem.Tag.ToString() == "view_ctx")
            {
                this.Event_ShowContext(this.treeView1);
            }
            else if (e.ClickedItem.Tag.ToString() == "DesignerClear")
            {
                this.Event_ClearDesinger();
            }




        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.KANETONKINEZO==false&&this.CDragDrop.CanStartDragDrop(e.X, e.Y))
            {
                this.CDragDrop.StartDrag();
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.KANETONKINEZO == false)
            this.CDragDrop.SetDragStart(e.X, e.Y);
        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.KANETONKINEZO == false)
            this.CDragDrop.CancelDrag();
        }

        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            System.Drawing.Point p = this.CDragDrop.ctrl.PointToClient(new System.Drawing.Point(e.X, e.Y));
            this.Text=(sender as TreeView).GetNodeAt(p).Text;
            if (CDragDrop.CanLand(e)!=null)
            {
               
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            this.CDragDrop.Event_DragDrop(sender, e);
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            int i = 0;
        }

        private void clearChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ResetCurrentItem(this.categoryBindingSource);
        }
        private void ResetCurrentItem(BindingSource bs)
        {
            try
            {
                (bs.Current as DataRowView).Row.RejectChanges();
                (bs.Current as DataRowView).Row.RowError = "";
                bs.ResetCurrentItem();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_category_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataRow dr = null;
            try
            {
                //fails when there is a row deletion to there is no need for validation here
                dr = (((DataGridView)sender).Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
            }
            catch (Exception e2)
            {
                return;
            }

            try
            {
                this.Event_ValidateCategoryRow(dr);

            }
            catch (Exception e1)
            {
                dr.RowError = e1.Message;
                MessageBox.Show(e1.Message);
                e.Cancel = true;
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

           
            dlg.Filter = "(*.xls)|*.xls";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
            
                
               // Microsoft.Office.Interop.Excel.Application Excelobject = null;
               // Excelobject = new Microsoft.Office.Interop.Excel.Application();
               // if (Excelobject == null)
               // {
               //     MessageBox.Show("Excel could not be started");
               //     return;
               // }
                //Excelobject.Visible = true;
                //Microsoft.Office.Interop.Excel.Workbook wkb = Excelobject.Workbooks.Open(dlg.FileName,0,true,5,"","",true,Microsoft.Office.Interop.Excel.XlPlatform.xlWindows,"\t",false,false,0,false,0,0);
                //Microsoft.Office.Interop.Excel.Sheets sheets= wkb.Sheets;


                

                //Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wkb.ActiveSheet;
               // Microsoft.Office.Interop.Excel.Range range_descr= ws.get_Range("$E8","$E40");
               // Microsoft.Office.Interop.Excel.Range range_codes = ws.get_Range("$d8", "$d40");
                /*
                string k = "";
                range_descr.Activate();
               
                System.Array ar=(System.Array)range_descr.Cells.Value2;

                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    DataRow dr=mytbl.NewRow();
                    dr["ObjectDescription"] = ar.GetValue(i+1,1);
                    mytbl.Rows.Add(dr);
                }
                range_codes.Activate();
                ar = (System.Array)range_codes.Cells.Value2;
                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    DataRow dr = mytbl.Rows[i];
                    dr["DisplayCode"] = ar.GetValue(i + 1, 1);
                    
                }
                fpump.
                 */ 
                WindowsFormsApplication1.FormExcelPump frm_pump=new FormExcelPump();
                try
                {
                    frm_pump.FilePath=dlg.FileName;
                    frm_pump.Text = "Pumping " + dlg.FileName;
                    frm_pump.Show();
                }
                catch(Exception e3)
                {
                    MessageBox.Show(e3.Message);
                }
                


               

            }

                
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // IDataObject o = Clipboard.GetDataObject();
            if (Utility.HasChanges(this.attendance.QuestionPoolNew))
            {
                MessageBox.Show("Paste operation prohibited due to pending changes");
                return;
            }
            ArrayList  o1 = (ArrayList)DeSerialize( (string)Clipboard.GetData("PumpGridView"));
            if (o1 == null)
                return;
            try
            {
                for (int i = o1.Count - 1;i>=0 ; i--)
                {

                    DataRowView drv = (DataRowView)this.categoryQuestionPoolNewBindingSource.AddNew();
                    drv["Origin"] = 1;


                    if ((o1[i] as object[])[0] != null)
                        drv["questioncode"] = (o1[i] as object[])[0];
                    else
                        drv["questioncode"] = " {?} ";

                    drv.Row["question"] = (o1[i] as object[])[1];

                }
                
            }
            catch (Exception e1)
            {
                MessageBox.Show("Paste procedure failed "+e1.Message);
                this.attendance.QuestionPoolNew.RejectChanges();

            }
            finally
            {
                Clipboard.Clear();
            }
            
        }
        private object DeSerialize(string SerializationString)
        {
            object deserialObject = null;
            if (SerializationString == null)
                return null;
            byte[] arrayByte = Convert.FromBase64String(SerializationString);
            using (System.IO.MemoryStream ms1 = new System.IO.MemoryStream(arrayByte))
            {
                BinaryFormatter b = new BinaryFormatter();
                deserialObject = b.Deserialize(ms1);
            }
            return deserialObject;
        }

        private void dataGridView_question_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.DataGridView)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void dataGridView_question_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_question_DragDrop(object sender, DragEventArgs e)
        {
           
                System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)e.Data.GetData(typeof(System.Windows.Forms.DataGridView));
                if (dgv != null)
                {
                    this.TransferSelectedRowsFromDataGrid(dgv, (int)this.frmImportQuestions.cmb_Origin.SelectedValue);
                }

        }


        
        private void TransferSelectedRowsFromDataGrid(DataGridView dgv,int origin)
        {
            int questioncode_idx = -1;
            int question_idx = -1;
            int comment_idx = -1;
            int CategoryId = (int)(this.categoryBindingSource.Current as DataRowView)["CategoryId"];

            if (dgv.Tag == "ImportQuestionnaire")
            {
                questioncode_idx=this.attendance.QuestionnaireObjects.Columns.IndexOf("ObjectCode");
                question_idx = this.attendance.QuestionnaireObjects.Columns.IndexOf("ObjectDescription");
                comment_idx = this.attendance.QuestionnaireObjects.Columns.IndexOf("ObjectComments");


            }
            else
            {
                questioncode_idx = 0;
                question_idx = 1;
                comment_idx = 2;
            }

                if (dgv.SelectedRows.Count > 0)
                {

                    for (int i = dgv.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        DataRowView drvsource = dgv.SelectedRows[i].DataBoundItem as DataRowView;
                        if (drvsource[question_idx] == DBNull.Value)
                            continue;
                        DataRowView drv = null;
                        try
                        {
                            
                            drv = (DataRowView)this.categoryQuestionPoolNewBindingSource.AddNew();
                       



                        drv["Origin"] = origin;

                        drv["CategoryId"] = CategoryId;

                        if (drvsource[questioncode_idx] != DBNull.Value)
                            drv["questioncode"] = drvsource[questioncode_idx];
                        else
                            drv["questioncode"] = " {?} ";


                        drv.Row["question"] = drvsource[question_idx];
                        drv.Row["comment"] = drvsource[comment_idx];
                        drv.EndEdit();

                        }
                        catch (Exception e1)
                        {
                            continue;
                        }


                    }
                }
                else
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        DataRowView drvsource = dgv.Rows[i].DataBoundItem as DataRowView;
                        if (drvsource[question_idx] == DBNull.Value)
                            continue;
                        DataRowView drv = (DataRowView)this.categoryQuestionPoolNewBindingSource.AddNew();



                        drv["Origin"] = origin;


                        if (drvsource[0] != DBNull.Value)
                            drv["questioncode"] = drvsource[questioncode_idx];
                        else
                            drv["questioncode"] = " {?} ";


                        drv.Row["question"] = drvsource[question_idx];
                        drv.Row["comment"] = drvsource[comment_idx];
                    }

                }
            
        }

        private void dataGrid_ourquestion_DragDrop(object sender, DragEventArgs e)
        {
                System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)e.Data.GetData(typeof(System.Windows.Forms.DataGridView));
                if (dgv != null)
                    this.TransferSelectedRowsFromDataGrid(dgv,0);



        }

        private void dataGrid_ourquestion_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.DataGridView)))
            {
                if (e.Data.GetDataPresent(typeof(System.Windows.Forms.DataGridView)))
                    e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;

        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            ((sender) as TreeView).Refresh();
        }

        private void treeView1_DragLeave(object sender, EventArgs e)
        {
            this.Text = this.CaptionOld;
        }

        private void chb_viewsire_CheckedChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.CheckBox)sender).Checked)
                ;
            

        }

        private void dataGridView_question_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                this.Event_ValidateQuestionRow(((DataGridView)sender).Rows[e.RowIndex]);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                e.Cancel = true;
            }

        }
        private void Event_ValidateQuestionRow(DataGridViewRow dgvr)
        {

            DataRowView drv = null;
            try
            {
                drv = dgvr.DataBoundItem as DataRowView;
            }
            catch (Exception e1)
            {
                return;
            }


           try
           {
            if (drv.Row.RowState != DataRowState.Unchanged)
                {
                    if (drv["QuestionCode"] == DBNull.Value)
                    {
                        throw new Exception("Default code is empty");
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void exportToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ExportTotext();
        }


        private void InsertQuestion(out Guid questionid, object questioncode,object question, object comment, int categoryid,string CategoryCode, int Origin,string OriginCode,Guid CategoryNewId,int DefaultDisplayIndex)
        {
            questionid = Guid.Empty;
            
            

            SqlConnection con = MyConnection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into QuestionPoolNew ("
            +" QuestionId,QuestionCode, question,"
                + " Comment ,categoryId,CategoryCode,Origin,OriginCOde,CategoryNewId,DefaultDisplayIndex )"
                + " values( @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
            cmd.Connection = con;

            //prepare unique identifier
            Guid guid = Guid.NewGuid(); ;

            cmd.Parameters.Add("@p0", SqlDbType.UniqueIdentifier).Value=guid;
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = questioncode;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = question;

            cmd.Parameters.Add("@p3", SqlDbType.VarChar).Value = comment;
            cmd.Parameters.Add("@p4", SqlDbType.Int).Value=categoryid;
            cmd.Parameters.Add("@p5", SqlDbType.VarChar).Value = CategoryCode;
            cmd.Parameters.Add("@p6", SqlDbType.Int).Value = Origin;
            cmd.Parameters.Add("@p7", SqlDbType.VarChar).Value = OriginCode;
            cmd.Parameters.Add("@p8", SqlDbType.UniqueIdentifier).Value = CategoryNewId;
            cmd.Parameters.Add("@p9", SqlDbType.Int).Value = DefaultDisplayIndex;


            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }


            try
            {

                cmd.ExecuteNonQuery();
                questionid = (Guid)cmd.Parameters[0].Value;

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
        private void importExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.ImportExcelFile();
            

            
        }
#if XLSGEN
        private void ImportExcelFile()
        {
            FormExcelPumpPlus frmplus = new FormExcelPumpPlus();
            if (DialogResult.Cancel == frmplus.ShowDialog())
            {
                return;
            }
            bool bnotify = frmplus.chb_feedback.Checked;
            xlsgen.CoXlsEngine engine = null;

            try
            {
                OpenFileDialog odlg = new OpenFileDialog();
                if (odlg.ShowDialog() == DialogResult.OK)
                {
                    engine = new xlsgen.CoXlsEngineClass();

                    this.DeleteCategories();
                    xlsgen.IXlsWorkbook wbk = engine.Open(odlg.FileName, odlg.FileName);
                    string maincategorycode = "";
                    string maincategory;





                    for (int i = 0; i < wbk.WorksheetCount; i++)
                    {
                        int cat_displayindex = 0;
                        int A_idx = 1;
                        int B_idx = 1;
                        int C_idx = 0;
                        bool Bstoped = false;
                        bool Cstoped = false;



                        IXlsWorksheet wsh = wbk.get_WorksheetByIndex(i + 1);
                        string name = wsh.Name;
                        int idx = name.IndexOf("_");
                        maincategory = name.Substring(idx + 1);
                        maincategory = wsh.get_Label(A_idx, 1);
                        string cat_comments = wsh.get_Label(B_idx, 5);
                        maincategorycode = name.Substring(0, idx);
                        if (bnotify)
                            MessageBox.Show(maincategorycode + "   " + maincategory);
                        Guid cat_gui = Guid.Empty;
                        int cat_id = -1;
                        InsertCategory(maincategorycode, maincategory, maincategorycode, out cat_id, cat_displayindex, out cat_gui, cat_comments);
                        cat_displayindex++;
                        int subcat_id = 1;

                        while (!Bstoped)
                        {
                            string B = wsh.get_Label(B_idx, 2);
                            string subcat_comments = wsh.get_Label(B_idx, 5);

                            if (B == "End")
                                Bstoped = true;
                            else if (B != "")
                            {

                                InsertCategory(maincategorycode + "." + subcat_id, B, maincategorycode, out cat_id, cat_displayindex, out cat_gui, subcat_comments);
                                subcat_id++;
                                cat_displayindex++;
                                C_idx = B_idx + 1;
                                int defidx = 0;
                                while (!Cstoped)
                                {
                                    string questioncode = wsh.get_Label(C_idx, 3);
                                    string question = wsh.get_Label(C_idx, 4);
                                    string comment = wsh.get_Label(C_idx, 5);
                                    Guid questionid = Guid.Empty;
                                    int Origin = 1;
                                    if (questioncode == "")
                                    {
                                        Origin = 0;
                                    }
                                    string OriginCode = "VIQ2008";
                                    if (question == "" || question == null)
                                        Cstoped = true;
                                    else
                                        InsertQuestion(out questionid, questioncode, question, comment, cat_id, "", Origin, OriginCode, cat_gui, defidx++);

                                    C_idx++;

                                }
                                Cstoped = false;
                            }
                            B_idx++;
                        }
                    }

                    wbk.Close();

                }
                this.Event_ClearDesinger();
                this.LoadEverything();
            }
            catch (Exception e1)
            {
            }
            finally
            {
                if (engine != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(engine);
                    engine = null;
                }
            }
        }
#endif

        private void ImportExcelFile()
        {
            FormExcelPumpPlus frmplus = new FormExcelPumpPlus();
            if (DialogResult.Cancel == frmplus.ShowDialog())
            {
                return;
            }
            bool bnotify = frmplus.chb_feedback.Checked;
            //xlsgen.CoXlsEngine engine = null;

            try
            {
                OpenFileDialog odlg = new OpenFileDialog();
                if (odlg.ShowDialog() == DialogResult.OK)
                {
                    

                    Vetting.Category.DeleteCategories();
                    //xlsgen.IXlsWorkbook wbk = engine.Open(odlg.FileName, odlg.FileName);

                    Aspose.Cells.Workbook wbk = new Aspose.Cells.Workbook();
                    wbk.Open(odlg.FileName);
                    
                    string maincategorycode = "";
                    string maincategory;





                    for (int i = 0; i < wbk.Worksheets.Count; i++)
                    {
                        int cat_displayindex = 0;
                        int A_idx = 1;
                        int B_idx = 1;
                        int C_idx = 0;
                        bool Bstoped = false;
                        bool Cstoped = false;



                        Aspose.Cells.Worksheet wsh = wbk.Worksheets[i];
                        string name = wsh.Name;
                        int idx = name.IndexOf("_");
                        maincategory = name.Substring(idx + 1);
                        maincategory = wsh.Cells[A_idx-1, 1-1].Value.ToString();
                        string cat_comments="";
                        if (wsh.Cells[B_idx-1, 5-1].Value!=null)
                         cat_comments= wsh.Cells[B_idx-1, 5-1].Value.ToString();
                        maincategorycode = name.Substring(0, idx);
                        if (bnotify)
                            MessageBox.Show(maincategorycode + "   " + maincategory);
                        Guid cat_gui = Guid.Empty;
                        int cat_id = -1;
                        Vetting.Category.InsertCategory(maincategorycode, maincategory, maincategorycode, out cat_id, cat_displayindex, out cat_gui, cat_comments);
                        cat_displayindex++;
                        int subcat_id = 1;

                        while (!Bstoped)
                        {
                            string B = "";
                            
                            if (wsh.Cells[B_idx - 1, 2 - 1].Value!=null)
                                B = wsh.Cells[B_idx - 1, 2 - 1].Value.ToString();

                            string subcat_comments = "";
                            if (wsh.Cells[B_idx-1, 5-1].Value!=null)
                            subcat_comments=wsh.Cells[B_idx-1, 5-1].Value.ToString();

                            if (B == "End")
                                Bstoped = true;
                            else if (B != "")
                            {

                                Vetting.Category.InsertCategory(maincategorycode + "." + subcat_id, B, maincategorycode, out cat_id, cat_displayindex, out cat_gui, subcat_comments);
                                subcat_id++;
                                cat_displayindex++;
                                C_idx = B_idx + 1;
                                int defidx = 0;
                                while (!Cstoped)
                                {

                                    string questioncode = ""; 
                                    if (wsh.Cells[C_idx - 1, 3 - 1].Value!=null)
                                    questioncode=wsh.Cells[C_idx - 1, 3 - 1].Value.ToString();
                                    string question = "";
                                    if (wsh.Cells[C_idx - 1, 4 - 1].Value!=null)
                                        question=wsh.Cells[C_idx - 1, 4 - 1].Value.ToString();
                                    string comment = "";
                                    if (wsh.Cells[C_idx-1, 5-1].Value!=null)
                                    comment=wsh.Cells[C_idx-1, 5-1].Value.ToString();
                                    Guid questionid = Guid.Empty;
                                    int Origin = 1;
                                    string OriginCode = "";
                                    if (questioncode == "")
                                    {
                                        Origin = 0;
                                    }
                                    else
                                       Origin = 1;
                                    if (question == "" || question == null)
                                        Cstoped = true;
                                    else
                                        InsertQuestion(out questionid, questioncode, question, comment, cat_id, "", Origin, OriginCode, cat_gui, defidx++);

                                    C_idx++;

                                }
                                Cstoped = false;
                            }
                            B_idx++;
                        }
                    }

                   

                }
                this.Event_ClearDesinger();
                this.LoadEverything();
            }
            catch (Exception e1)
            {
            }
            finally
            {
                
            }
        }

        private void chb_hierarchical_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_hierarchical.Checked)
            {
                this.gb_insert_hiermode.Enabled = true;
            }
            else
            {
                this.gb_insert_hiermode.Enabled = false;
            }
        }

        private void importExcelQuestionnaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.frmImportQuestions = new FormImportQuestionnaire();
                this.frmImportQuestions.FormClosed += new FormClosedEventHandler(frmImportQuestions_FormClosed);
                this.frmImportQuestions.Show();
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            

        }

        void frmImportQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmImportQuestions.Dispose();
            this.frmImportQuestions = null;
        }

        private void viewOriginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuestionnaireOrigin fqo = new FormQuestionnaireOrigin();
            fqo.attendance = this.attendance;
            fqo.ShowDialog();
        }

        private void comboBoxOrigin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            if (this.comboBoxOrigin.SelectedValue != null)
            {
                FilterOrigin= "origin=" + this.comboBoxOrigin.SelectedValue.ToString();
                this.ApplyFilters();
            }
        }
        private void ApplyFilters()
        {
            
                if (this.chb_OriginFilter.Checked)
                {
                    if (this.categoryQuestionPoolNewBindingSource.Filter != FilterOrigin)
                    {
                    if (this.FilterOrigin != null)
                        this.categoryQuestionPoolNewBindingSource.Filter = FilterOrigin;
                    }
                }
                else
                {
                    if (this.categoryQuestionPoolNewBindingSource.Filter != "")
                    {
                        this.categoryQuestionPoolNewBindingSource.Filter = "";
                    }
                }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                this.ApplyFilters();
        }

        private void dataGridView_question_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void selectToChangeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.HasChanges(this.attendance.Category))
            {
                MessageBox.Show("Cannot select to 'change category' while category has uncommitted changes");
                return;
            }
            this.RowsForRemoval.Clear();
            object o = ((sender as ToolStripDropDownItem).Owner as ContextMenuStrip);
            Control ocontrol = (o as ContextMenuStrip).SourceControl;

            if (ocontrol.Name==this.dataGridView_question.Name)
            {




           
            for (int i = 0; i < this.dataGridView_question.SelectedRows.Count; i++)
            {
                this.RowsForRemoval.Add((this.dataGridView_question.SelectedRows[i].DataBoundItem as DataRowView).Row);

            }
            }
            else if (ocontrol.Name==this.dataGrid_ourquestion.Name)
            {
                for (int i = 0; i < this.dataGrid_ourquestion.SelectedRows.Count; i++)
              {
                this.RowsForRemoval.Add((this.dataGrid_ourquestion.SelectedRows[i].DataBoundItem as DataRowView).Row);

             }

            }
        }

        private void categoryForSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool berrfound = false;
            if (this.RowsForRemoval.Count == 0)
            {
                MessageBox.Show("No rows selected");
                return;
            }
            else
            {
                Guid guid = (Guid)(this.categoryBindingSource.Current as DataRowView)["CategoryNewId"];
                int catid = (int)(this.categoryBindingSource.Current as DataRowView)["CategoryId"];
                for (int i = 0; i < RowsForRemoval.Count; i++)
                {
                    try
                    {
                        (RowsForRemoval[i] as DataRow).BeginEdit();
                        (RowsForRemoval[i] as DataRow)["CategoryNewId"] = guid;
                        (RowsForRemoval[i] as DataRow)["CategoryId"] = catid;

                        (RowsForRemoval[i] as DataRow).EndEdit();
                    }
                    catch (Exception e1)
                    {
                        berrfound = true;
                    }
                }
            }
            

        }

        private void tb_filtercode_TextChanged(object sender, EventArgs e)
        {
            FilterCategory = (sender as TextBox).Text;
            this.ApplyCategoryFilters();

        }
        private void ApplyCategoryFilters()
        {
            if (this.FilterCategory.Trim() == "")
                this.categoryBindingSource.Filter = "";
            else
                this.categoryBindingSource.Filter = "CategoryCode like '"+FilterCategory.Trim() + "%'";
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlg=new OpenFileDialog();

            if (DialogResult.OK==odlg.ShowDialog())
            {
                FormBriefcaseVLog frmvlog = new FormBriefcaseVLog();
                frmvlog.password = this.m_password;
                frmvlog.filepath = odlg.FileName;
                frmvlog.Show();
            }
        }

        private void activateRelationshipToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.activateRelationshipToolStripMenuItem.Checked)
            {
                this.ActivateRelation(true);
            }
            else
            {
                this.ActivateRelation(false);
            }
        }

        private void designerToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.designerToolStripMenuItem.Checked)
                this.InitializeDesigner(true);
            else
                this.InitializeDesigner(false);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;
            FormLogon frmlogon = new FormLogon();
            frmlogon.tb_password.Text = "";
            bool bconnected = false;
            while (counter < 3&&!bconnected)
            {
               
                if (DialogResult.OK == frmlogon.ShowDialog())
                {
                    try
                    {
                        ApplicationInfo.userid = User.AuthenticateUser(MyConnection.GetConnection(),null,frmlogon.tb_username.Text, frmlogon.tb_password.Text);
                        bconnected = true;
                    }
                    catch (Exception e2)
                    {
                        counter++;
                        frmlogon.tb_password.Text = "";
                        continue;
                    }

                    try
                    {
                        int roleid=User.GetUserRole(MyConnection.GetConnection(), null, ApplicationInfo.userid);
                        if ( roleid== 10000)
                        {
                            this.designerToolStripMenuItem.Enabled = true;
                            ApplicationInfo.ActiveUserMode = ApplicationInfo.UserMode.Administrator;
                        }
                        else if (roleid == 9000)
                        {
                            
                            ApplicationInfo.ActiveUserMode = ApplicationInfo.UserMode.EnterpriseManager;
                        }

                        PrepareInterfaceForRole();
                    }
                    catch (Exception e3)
                    {
                        return;
                    }

                }
                else
                {
                    return;

                }
            }
        }

        private void PrepareInterfaceForRole()
        {
            if (ApplicationInfo.ActiveUserMode==ApplicationInfo.UserMode.EnterpriseManager)
            {
                this.report_categoryAnalysisToolStripMenuItem.Visible = true;
                this.reportToolStripMenuItem.Enabled = true;
                this.bAllowCategoryTreeView = true;
                this.lb_reportfrom.Visible = true;
                this.lb_reportto.Visible = true;
                this.dtp_from.Enabled = true;
                this.dtp_to.Enabled = true;
                this.dtp_from.Visible = true;
                this.dtp_to.Visible = true;

                this.buildCategoryDisplayOrderToolStripMenuItem.Visible = false;
                this.chb_reportpercentage.Visible = false;
                
            }
            else if (ApplicationInfo.ActiveUserMode == ApplicationInfo.UserMode.Administrator)
            {
                this.report_categoryAnalysisToolStripMenuItem.Visible = true;
                this.reportToolStripMenuItem.Enabled = true;
                this.bAllowCategoryTreeView = true;
                this.lb_reportfrom.Visible = true;
                this.lb_reportto.Visible = true;
                this.dtp_from.Visible = true;
                this.dtp_to.Visible = true;
                this.dtp_from.Enabled = true;
                this.dtp_to.Enabled = true;
                this.chb_reportpercentage.Visible = true;
                this.buildCategoryDisplayOrderToolStripMenuItem.Visible = true;
            }

        }

        private void tbctrl_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbctrl_categories.SelectedIndex == 1)
            {
               //this.BuildCategoryTree();
                this.BuildCategoryTreefromSortedDataset();

               this.BuildReportVesselsTree();
               
            }
        }
        

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Report_CategoryAnalysis_Period()
        {


            if (bPreparingReport)
                return;
            try
            {
                this.bt_Report.Enabled = false;
                report_categoryAnalysisToolStripMenuItem.Enabled = false;
                bPreparingReport = true;
                DateTime dtReportFrom = DateTime.Parse("01-01-1900");
                DateTime dtReportTo = DateTime.MaxValue;

                if (this.dtp_from.Checked)
                    dtReportFrom = dtp_from.Value.Date;

                if (this.dtp_to.Checked)
                {
                    dtReportTo = dtp_to.Value.Date;
                    dtReportTo = dtReportTo.AddDays(1f).AddSeconds(-1f);
                }


                bool bViewsubcategories = this.chb_subcategories.Checked;
                bool bRanksort = this.chb_ranksort.Checked;
                bool bReportPercentage = this.chb_reportpercentage.Checked;

                if (dtReportFrom > dtReportTo)
                {
                    MessageBox.Show("Invalid reporting period entered");
                    return;
                }

                System.IO.FileStream fs = null;
                if (this.selected_reportnodes.Count == 0)
                {
                    MessageBox.Show("Select a group of categories to analyze");
                    return;
                }
                try
                {


                    this.Cursor = Cursors.WaitCursor;
                    string outfilename = "";
                    try
                    {

                        SaveFileDialog odlg = new SaveFileDialog();
                        odlg.Filter = "Excel 2003 files|*.xls";
                        odlg.FileName = Properties.Settings.Default.ReportFolder + "\\AttendanceDefaultReportExcelFile.xls";
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



                    fs = new System.IO.FileStream(outfilename, System.IO.FileMode.Create);
                    Aspose.Cells.Workbook wkb = new Aspose.Cells.Workbook();


                    wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                    wkb.Open(fs);

                    Aspose.Cells.Worksheet wsh = wkb.Worksheets.Add("Attendance Report");


                    int excel_rowcount = 0;


                    wsh.Cells[excel_rowcount, 0].PutValue("Negative analysis report : " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString());
                    wsh.Cells[excel_rowcount, 0].Style.Font.Color = Color.Blue;
                    wsh.Cells[excel_rowcount, 0].Style.Font.Size = 15;
                    wsh.AutoFitRow(excel_rowcount);

                    excel_rowcount += 2;
                    bool bHasPeriod = false;
                    bool bSameDate = false;

                    if (dtReportFrom == dtReportTo.Date)
                        bSameDate = true;
                    if (dtp_from.Checked && dtp_to.Checked)
                    {
                        if (!bSameDate)
                            wsh.Cells[excel_rowcount, 0].PutValue("Reporting Period  from : " + dtReportFrom.ToShortDateString() + " to " + dtReportTo.ToShortDateString());
                        bHasPeriod = true;
                    }
                    else if (dtp_from.Checked)
                    {
                        if (!bSameDate)

                            wsh.Cells[excel_rowcount, 0].PutValue("Reporting Period  from : " + dtReportFrom.ToShortDateString());
                        bHasPeriod = true;
                    }
                    else if (dtp_to.Checked)
                    {
                        if (!bSameDate)
                            wsh.Cells[excel_rowcount, 0].PutValue("Reporting Period  until : " + dtReportTo.ToShortDateString());
                        bHasPeriod = true;
                    }

                    if (bHasPeriod)
                    {
                        if (bSameDate)
                            wsh.Cells[excel_rowcount, 0].PutValue("Reporting Date as of : " + dtReportFrom.ToShortDateString());
                        wsh.Cells[excel_rowcount, 0].Style.Font.Color = Color.Blue;
                        wsh.Cells[excel_rowcount, 0].Style.Font.Size = 15;
                        wsh.AutoFitRow(excel_rowcount);
                        excel_rowcount += 2;
                    }

                    ArrayList CategoryDataRows = new ArrayList();
                    DataTable vessels = new DataTable();
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "Select vesselid,vesselname from vessel order by vesselname";

                        cmd.Connection = MyConnection.GetConnection();
                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        try
                        {
                            int num = da.Fill(vessels);
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }



                    string vesselfilter = "";
                    bool bVessel = false;
                    foreach (TreeNode tn in this.tv_vessels.Nodes)
                    {
                        if (tn.Checked)
                        {
                            bVessel = true;
                            if (vesselfilter != "")
                                vesselfilter += "," + (tn.Tag as DataRow)["VesselId"].ToString();
                            else
                                vesselfilter += "( " + (tn.Tag as DataRow)["VesselId"].ToString();

                        }
                    }
                    if (bVessel)
                        vesselfilter += " )";




                    DataTable category_consolidated = new DataTable();
                    category_consolidated.Columns.Add("CategoryName", typeof(string));
                    category_consolidated.Columns.Add("NegativeTotal", typeof(int));
                    category_consolidated.Columns.Add("NegativeRank", typeof(int));



                    DataTable category_consolidated_vessel = new DataTable();
                    category_consolidated_vessel.Columns.Add("VesselName", typeof(string));
                    category_consolidated_vessel.Columns.Add("CategoryName", typeof(string));
                    category_consolidated_vessel.Columns.Add("NegativeTotal", typeof(int));

                    int chartindex = -1;
                    int seridx = -1;
                    Aspose.Cells.Chart achart = null;


                    SortedList sl = new SortedList(this.selected_reportnodes, new CategorySelectionSort(true));


                    foreach (object o in sl.Values)
                    {

                        DataRow dr_category_consolidated = category_consolidated.NewRow();
                        category_consolidated.Rows.Add(dr_category_consolidated);

                        TreeNode tn = o as TreeNode;
                        DataRow categoryrow = (tn.Tag as CategoryTag).Datarow;
                        CategoryDataRows.Add(categoryrow);
                        //System.Console.WriteLine(((DataRow)tn.Tag)["CategoryCode"].ToString() + " " + ((DataRow)tn.Tag)["CategoryDescription"].ToString());
                        string categorycode = categoryrow["CategoryCode"].ToString();
                        string categoryname = categoryrow["CategoryDescription"].ToString();


                        dr_category_consolidated[0] = categoryname + " { " + categorycode + " }";
                        wsh.Cells[excel_rowcount, 0].PutValue("Reported Category :" + categorycode + " " + categoryname);
                        wsh.Cells[excel_rowcount, 0].Style.Font.Color = Color.Blue;
                        wsh.Cells[excel_rowcount, 0].Style.Font.Size = 15;
                        wsh.AutoFitRow(excel_rowcount);
                        excel_rowcount += 2;

                        SqlCommand cmd = new SqlCommand();

                        SqlDataAdapter da = null;
                        int num = 0;

                        cmd.Connection = MyConnection.GetConnection();
                        if (cmd.Connection.State != ConnectionState.Open)
                            cmd.Connection.Open();
                        da = new SqlDataAdapter(cmd);
                        cmd.Parameters.Add("@p0", SqlDbType.VarChar).Value = categorycode + ".%";

                        if (bViewsubcategories)
                        {
                            cmd.CommandText = "Select distinct CategoryDescription ,categorynewid,CategoryCode,CategoryDisplayIndex from category where categorycode = @p0  order by CategoryDisplayIndex ";
                            //cmd.Parameters.Add("@p0", SqlDbType.VarChar).Value = categorycode + ".%";

                            DataTable categories = new DataTable();
                            num = da.Fill(categories);
                            if (num > 0)
                            {

                                wsh.Cells[excel_rowcount++, 0].PutValue("Reported Sub Categories");
                                excel_rowcount++;
                                foreach (DataRow dr in categories.Rows)
                                {
                                    wsh.Cells[excel_rowcount, 0].PutValue(dr["CategoryCode"]);
                                    wsh.Cells[excel_rowcount++, 1].PutValue(dr["CategoryDescription"]);

                                }
                            }
                        }



                        DataTable questions = new DataTable();

                        cmd.CommandText = "Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0  or categorycode like @p1 )";
                        cmd.Parameters["@p0"].Value = categorycode;

                        //sm1965 08-2009 
                        cmd.Parameters.Add("@p1", DbType.String);
                        cmd.Parameters["@p1"].Value = categorycode + ".%";




                        num = da.Fill(questions);

                        excel_rowcount++;



                        cmd.Parameters.Add("@dtfrom", DbType.DateTime).Value = dtReportFrom;
                        cmd.Parameters.Add("@dtto", DbType.DateTime).Value = dtReportTo;


                        DataTable freport = new DataTable();

                        if (bVessel)

                            cmd.CommandText = string.Format("Select sum(convert(int,a.answer))'PositiveTotal' from Vetting a join VettingInfo b on a.vetid=b.vetid where  a.answer=1 and b.Vesselid in {0} and objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) )    and b.VetDate between @dtfrom and @dtto ", vesselfilter);
                        else
                            cmd.CommandText = "Select sum(convert(int,a.answer))'PositiveTotal' from Vetting a join VettingInfo b on a.vetid=b.vetid where  answer=1 and objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1 ) )   and b.VetDate between @dtfrom and @dtto ";

                        wsh.Cells[excel_rowcount, 0].PutValue("Total Answered");
                        wsh.Cells[excel_rowcount + 3, 0].PutValue("Perc.(%)");
                        wsh.Cells[excel_rowcount, 1].PutValue("Positive Answers ");

                        wsh.Cells[excel_rowcount, 2].PutValue("Negative Answers ");

                        wsh.Cells[excel_rowcount, 3].PutValue("Significance Rank ");
                        wsh.Cells[excel_rowcount, 4].PutValue("Significance (On average)");
                        excel_rowcount++;










                        int PosAnswers = 0;
                        int NegAnswers = 0;
                        int TotalAnswers = 0;
                        int perc_offset = 2;

                        da.Fill(freport);
                        try
                        {
                            PosAnswers = (int)freport.Rows[0][0];
                        }
                        catch (Exception e5)
                        {

                        }


                        wsh.Cells[excel_rowcount, 1].PutValue(PosAnswers);
                        wsh.Cells[excel_rowcount, 1].Style.Font.IsBold = true;
                        wsh.Cells[excel_rowcount, 1].Style.Font.Color = Color.Green;



                        freport.Clear();

                        if (bVessel)
                            cmd.CommandText = string.Format("Select count(*) 'NegativeTotal' ,isnull(sum(a.significance),0) 'NegativeRank'  from Vetting a join VettingInfo b on a.vetid=b.vetid  where  b.vesselid in {0} and a.answer=2 and a.objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) ) and b.vetdate between @dtfrom and @dtto ", vesselfilter);

                        else
                            cmd.CommandText = "Select count(*) 'NegativeTotal' ,isnull(sum(a.significance),0) 'NegativeRank'  from Vetting a  join VettingInfo b on a.vetid=b.vetid  where  answer=2 and objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) )  and b.vetdate between @dtfrom and @dtto ";



                        da.Fill(freport);


                        try
                        {
                            NegAnswers = (int)freport.Rows[0]["NegativeTotal"];
                        }
                        catch (Exception e5)
                        {

                        }

                        TotalAnswers = NegAnswers + PosAnswers;


                        float NegPerc = 0f;
                        float PosPerc = 0f;
                        if (TotalAnswers > 0)
                        {
                            NegPerc = (float)NegAnswers * 100f / (float)TotalAnswers;
                            PosPerc = (float)PosAnswers * 100f / (float)TotalAnswers;
                        }




                        int piechart_startrow = excel_rowcount;
                        wsh.Cells[excel_rowcount, 2].PutValue(NegAnswers);
                        wsh.Cells[excel_rowcount, 2].Style.Font.IsBold = true;
                        wsh.Cells[excel_rowcount, 2].Style.Font.Color = Color.Red;


                        //show percentages
                        wsh.Cells[excel_rowcount + 2, 2].PutValue(Math.Round(NegPerc, 2));//.ToString("#0.00"));
                        wsh.Cells[excel_rowcount + 2, 2].Style.HorizontalAlignment = Aspose.Cells.TextAlignmentType.Right;




                        wsh.Cells[excel_rowcount + 2, 1].PutValue(Math.Round(PosPerc, 2));//.ToString("#0.00"));
                        wsh.Cells[excel_rowcount + 2, 1].Style.HorizontalAlignment = Aspose.Cells.TextAlignmentType.Right;



                        wsh.Cells[excel_rowcount, 3].PutValue(freport.Rows[0]["NegativeRank"]);
                        try
                        {
                            wsh.Cells[excel_rowcount, 0].PutValue(TotalAnswers);
                        }
                        catch (Exception e1)
                        {
                            int i = 0;
                        }



                        int rank = (int)freport.Rows[0]["NegativeRank"];
                        dr_category_consolidated[1] = NegAnswers;
                        dr_category_consolidated[2] = rank;

                        if (NegAnswers != 0)
                        {



                            float f = ((float)rank / (float)NegAnswers) + 0.5f;

                            int fint = (int)f;


                            if (fint == 1)
                                wsh.Cells[excel_rowcount, 4].PutValue("Low");

                            else if (fint == 2)
                                wsh.Cells[excel_rowcount, 4].PutValue("Medium");
                            else if (fint == 3)
                                wsh.Cells[excel_rowcount, 4].PutValue("Important");
                            else if (fint == 4)
                                wsh.Cells[excel_rowcount, 4].PutValue("High");
                            else if (fint == 5)
                                wsh.Cells[excel_rowcount, 4].PutValue("Critical");
                        }
                        else
                        {
                            if (PosAnswers > 0)
                                wsh.Cells[excel_rowcount, 4].PutValue("Excellent");

                        }

                        excel_rowcount += 4;

                        chartindex = wsh.Charts.Add(Aspose.Cells.ChartType.Pie, excel_rowcount, 0, excel_rowcount + 10, 10);
                        achart = wsh.Charts[chartindex];
                        achart.Title.Text = categorycode + " " + categoryname;


                        string DataString = "";
                        if (bReportPercentage)
                        {
                            int perc_row = piechart_startrow + 1 + perc_offset;
                            DataString = "B" + (perc_row).ToString().Trim() + ":C" + (perc_row).ToString().Trim();

                        }
                        else
                        {
                            DataString = "B" + (piechart_startrow + 1).ToString().Trim() + ":C" + (piechart_startrow + 1).ToString().Trim();
                        }
                        seridx = achart.NSeries.Add(DataString, false);
                        //achart.NSeries[0].DataLabels..Name = "Neg Answers";
                        //achart.NSeries[1].Name = "Pos Answers";

                        //string DataString = "B" + (piechart_startrow + 1).ToString().Trim() ;
                        //seridx = achart.NSeries.Add(DataString , true);
                        //DataString = "C" + (piechart_startrow + 1).ToString().Trim();
                        //seridx = achart.NSeries.Add(DataString, true);

                        //seridx = achart.NSeries.Add("B" + (excel_rowcount - 1).ToString().Trim() + ":B" + (excel_rowcount - 1).ToString().Trim(), true);
                        //seridx = achart.NSeries.Add("C" + (excel_rowcount - 1).ToString().Trim() + ":C" + (excel_rowcount - 1).ToString().Trim(), true);
                        //achart.Legend.LegendEntries[0]

                        excel_rowcount += 12;

                        //----------------------------------------------------------------------------------

                        freport.Clear();


                        if (bVessel)

                            cmd.CommandText = String.Format("select v.vesselid,v.vesselname,w.NegativeTotal,w.NegativeRank from vessel v join ( Select c.vesselid,count(*) 'NegativeTotal' ,isnull(sum(a.significance),0) 'NegativeRank'  from Vetting a join VettingINfo b on a.vetid=b.vetid join vessel c on b.vesselid=c.vesselid  where b.vetdate between @dtfrom and @dtto  and a.answer=2 and a.objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) ) group by  c.vesselid ) w on v.vesselid=w.vesselid where v.vesselid in {0} ", vesselfilter);
                        else

                            cmd.CommandText = "select v.vesselid,v.vesselname,w.NegativeTotal,w.NegativeRank from vessel v join ( Select c.vesselid,count(*) 'NegativeTotal' ,isnull(sum(a.significance),0) 'NegativeRank'  from Vetting a join VettingINfo b on a.vetid=b.vetid join vessel c on b.vesselid=c.vesselid  where  b.vetdate between @dtfrom and @dtto and  a.answer=2 and a.objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) ) group by  c.vesselid ) w on v.vesselid=w.vesselid";
                        // cmd.Parameters.Add("@p1", SqlDbType.Int);
                        da.Fill(freport);


                        if (!bRanksort)
                            freport.DefaultView.Sort = "NegativeTotal desc";
                        else
                            freport.DefaultView.Sort = "NegativeRank desc";


                        if (NegAnswers != 0)
                        {
                            wsh.Cells[excel_rowcount, 0].PutValue("Analysis per vessel");
                            wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;

                            excel_rowcount += 2;

                            wsh.Cells[excel_rowcount, 1].PutValue("Vessel Name");
                            wsh.Cells[excel_rowcount, 2].PutValue("Negative Total");
                            wsh.Cells[excel_rowcount, 3].PutValue("Negative Rank");
                        }
                        excel_rowcount++;

                        int pershipstartrow = excel_rowcount;
                        int idx1 = 0;



                        if (bReportPercentage)
                        {
                            foreach (DataRowView drr in freport.DefaultView)
                            {

                                idx1++;
                                wsh.Cells[excel_rowcount, 0].PutValue(idx1);
                                wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;

                                wsh.Cells[excel_rowcount, 1].PutValue(drr["vesselname"]);
                                decimal percneg = Convert.ToDecimal(drr["NegativeTotal"]) * 100.0m / NegAnswers;
                                decimal percnegrank = Convert.ToDecimal(drr["NegativeRank"]) * 100.0m / rank;
                                wsh.Cells[excel_rowcount, 2].PutValue(Math.Round(percneg, 2));
                                wsh.Cells[excel_rowcount, 3].PutValue(Math.Round(percnegrank, 2));
                                excel_rowcount++;
                            }

                        }
                        else
                        {

                            foreach (DataRowView drr in freport.DefaultView)
                            {

                                idx1++;
                                wsh.Cells[excel_rowcount, 0].PutValue(idx1);
                                wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;

                                wsh.Cells[excel_rowcount, 1].PutValue(drr["vesselname"]);
                                wsh.Cells[excel_rowcount, 2].PutValue(drr["NegativeTotal"]);
                                wsh.Cells[excel_rowcount, 3].PutValue(drr["NegativeRank"]);
                                excel_rowcount++;
                            }
                        }

                        int pershipendingrow = excel_rowcount - 1;

                        excel_rowcount += 2;
                        if (NegAnswers != 0)
                        {
                            chartindex = wsh.Charts.Add(Aspose.Cells.ChartType.Bar, excel_rowcount, 0, excel_rowcount + 10, 10);
                            achart = wsh.Charts[chartindex];
                            achart.Title.Text = categorycode + " " + categoryname + "  /per vessel";

                            seridx = achart.NSeries.Add("C" + (pershipstartrow + 1).ToString().Trim() + ":C" + (pershipendingrow + 1).ToString().Trim(), true);
                            achart.NSeries[seridx].Name = "Neg. Answers";

                            seridx = achart.NSeries.Add("D" + (pershipstartrow + 1).ToString().Trim() + ":D" + (pershipendingrow + 1).ToString().Trim(), true);
                            achart.NSeries[seridx].Name = "Neg. Ranking";
                            achart.CategoryAxis.TickLabelSpacing = 1;




                            excel_rowcount += 12;
                        }







                    }
                    excel_rowcount++;
                    wsh.Cells[excel_rowcount, 0].PutValue("Negative Answers Consolidated /per category");
                    wsh.Cells[excel_rowcount, 0].Style.Font.Size = 12;
                    wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;
                    wsh.Cells[excel_rowcount, 0].Style.Font.Underline = Aspose.Cells.FontUnderlineType.Single;


                    excel_rowcount += 2;
                    wsh.Cells[excel_rowcount, 1].PutValue("Vessel");
                    wsh.Cells[excel_rowcount, 2].PutValue("Negative Total");
                    wsh.Cells[excel_rowcount, 3].PutValue("Negative Rank Total");
                    excel_rowcount += 1;

                    int start_row = excel_rowcount;
                    int idx = 0;
                    if (bRanksort)
                        category_consolidated.DefaultView.Sort = "NegativeRank desc";

                    else
                        category_consolidated.DefaultView.Sort = "NegativeTotal desc";



                    if (bReportPercentage)
                    {
                        double catnegtotal = 0d;
                        double catnegrank = 0d;
                        foreach (DataRowView cdr in category_consolidated.DefaultView)
                        {
                            catnegtotal += Convert.ToDouble(cdr[1]);
                            catnegrank += Convert.ToDouble(cdr[2]);
                        }

                        foreach (DataRowView cdr in category_consolidated.DefaultView)
                        {
                            idx++;
                            wsh.Cells[excel_rowcount, 0].PutValue(idx);
                            wsh.Cells[excel_rowcount, 1].PutValue(cdr[0]);
                            wsh.Cells[excel_rowcount, 2].PutValue(Math.Round(Convert.ToDouble(cdr[1]) * 100d / catnegtotal, 2));
                            wsh.Cells[excel_rowcount, 3].PutValue(Math.Round(Convert.ToDouble(cdr[2]) * 100d / catnegrank, 2));
                            excel_rowcount++;

                        }
                    }
                    else
                    {
                        foreach (DataRowView cdr in category_consolidated.DefaultView)
                        {
                            idx++;
                            wsh.Cells[excel_rowcount, 0].PutValue(idx);
                            wsh.Cells[excel_rowcount, 1].PutValue(cdr[0]);
                            wsh.Cells[excel_rowcount, 2].PutValue(cdr[1]);
                            wsh.Cells[excel_rowcount, 3].PutValue(cdr[2]);
                            excel_rowcount++;

                        }
                    }
                    excel_rowcount++;
                    chartindex = wsh.Charts.Add(Aspose.Cells.ChartType.Bar, excel_rowcount, 0, excel_rowcount + 20, 10);
                    achart = wsh.Charts[chartindex];
                    achart.CategoryAxis.MinorUnit = 1;
                    seridx = achart.NSeries.Add("C" + (start_row + 1).ToString().Trim() + ":C" + (excel_rowcount).ToString().Trim(), true);
                    achart.CategoryAxis.TickLabelSpacing = 1;
                    achart.NSeries[seridx].Name = "Negative Answers/ Consolidated per category";

                    seridx = achart.NSeries.Add("D" + (start_row + 1).ToString().Trim() + ":D" + (excel_rowcount).ToString().Trim(), true);
                    achart.NSeries[seridx].Name = "Negative Rank/ Consolidated per category";

                    wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                    fs.Close();
                    if (DialogResult.Yes == MessageBox.Show("Excel file was created. Do you want to open it?", "Excel creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        System.Diagnostics.Process.Start(outfilename);
                    }

                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                    if (fs != null)
                        fs.Close();
                }
            }
            finally
            {

                bPreparingReport = false;
                bt_Report.Enabled = true;
                report_categoryAnalysisToolStripMenuItem.Enabled = true;
            }
        }
       
        private void Report_CategoryAnalysis()
        {


            DateTime dtReportFrom = DateTime.MinValue;
            DateTime dtReportTo = DateTime.MaxValue;

            
            

            bool bViewsubcategories = this.chb_subcategories.Checked;
            bool bRanksort = this.chb_ranksort.Checked;
            bool bReportPercentage = this.chb_reportpercentage.Checked;
            


            System.IO.FileStream fs = null;
            if (this.selected_reportnodes.Count == 0)
            {
                MessageBox.Show("Select a group of categories to analyze");
                return;
            }
            try
            {


                this.Cursor = Cursors.WaitCursor;
                string outfilename = "";
                try
                {

                    SaveFileDialog odlg = new SaveFileDialog();
                    odlg.Filter = "Excel 2003 files|*.xls";
                    odlg.FileName = Properties.Settings.Default.ReportFolder+"\\AttendanceDefaultReportExcelFile.xls";
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



                fs = new System.IO.FileStream(outfilename, System.IO.FileMode.Create);
                Aspose.Cells.Workbook wkb = new Aspose.Cells.Workbook();


                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                wkb.Open(fs);

                Aspose.Cells.Worksheet wsh = wkb.Worksheets.Add("Attendance Report");


                int excel_rowcount = 0;


                wsh.Cells[excel_rowcount, 0].PutValue("Negative analysis report : " +DateTime.Now.ToLongDateString()+" "+DateTime.Now.ToShortTimeString());
                wsh.Cells[excel_rowcount, 0].Style.Font.Color = Color.Blue;
                wsh.Cells[excel_rowcount, 0].Style.Font.Size = 15;
                wsh.AutoFitRow(excel_rowcount);

                excel_rowcount+=2;

                ArrayList CategoryDataRows = new ArrayList();
                DataTable vessels = new DataTable();
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Select vesselid,vesselname from vessel order by vesselname";

                    cmd.Connection = MyConnection.GetConnection();
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    try
                    {
                        int num = da.Fill(vessels);
                    }
                    finally
                    {
                        cmd.Connection.Close();
                    }
                }



                string vesselfilter = "";
                bool bVessel = false;
                foreach (TreeNode tn in this.tv_vessels.Nodes)
                {
                    if (tn.Checked)
                    {
                        bVessel = true;
                        if (vesselfilter!="")
                        vesselfilter += ","+(tn.Tag as DataRow)["VesselId"].ToString();
                        else
                            vesselfilter += "( "+ (tn.Tag as DataRow)["VesselId"].ToString();

                    }
                }
                if (bVessel)
                vesselfilter += " )";




                DataTable category_consolidated = new DataTable();
                category_consolidated.Columns.Add("CategoryName", typeof(string));
                category_consolidated.Columns.Add("NegativeTotal", typeof(int));
                category_consolidated.Columns.Add("NegativeRank", typeof(int));



                DataTable category_consolidated_vessel = new DataTable();
                category_consolidated_vessel.Columns.Add("VesselName", typeof(string));
                category_consolidated_vessel.Columns.Add("CategoryName", typeof(string));
                category_consolidated_vessel.Columns.Add("NegativeTotal", typeof(int));

                int chartindex = -1;
                int seridx = -1;
                Aspose.Cells.Chart achart = null;


                SortedList sl = new SortedList(this.selected_reportnodes, new CategorySelectionSort(true));


                foreach (object o in sl.Values)
                {

                    DataRow dr_category_consolidated = category_consolidated.NewRow();
                    category_consolidated.Rows.Add(dr_category_consolidated);

                    TreeNode tn = o as TreeNode;
                    DataRow categoryrow = (tn.Tag as CategoryTag).Datarow;
                    CategoryDataRows.Add( categoryrow);
                    //System.Console.WriteLine(((DataRow)tn.Tag)["CategoryCode"].ToString() + " " + ((DataRow)tn.Tag)["CategoryDescription"].ToString());
                    string categorycode = categoryrow["CategoryCode"].ToString();
                    string categoryname = categoryrow["CategoryDescription"].ToString();


                    dr_category_consolidated[0] = categoryname+" { "+categorycode + " }" ;
                    wsh.Cells[excel_rowcount, 0].PutValue("Reported Category :" + categorycode + " " + categoryname);
                    wsh.Cells[excel_rowcount, 0].Style.Font.Color = Color.Blue;
                    wsh.Cells[excel_rowcount, 0].Style.Font.Size = 15;
                    wsh.AutoFitRow(excel_rowcount);
                    excel_rowcount += 2;

                    SqlCommand cmd = new SqlCommand();

                    SqlDataAdapter da = null;
                    int num = 0;

                    cmd.Connection = MyConnection.GetConnection();
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();
                    da = new SqlDataAdapter(cmd);
                    cmd.Parameters.Add("@p0", SqlDbType.VarChar).Value = categorycode + ".%";
                       
                    if (bViewsubcategories)
                    {
                        cmd.CommandText = "Select distinct CategoryDescription ,categorynewid,CategoryCode,CategoryDisplayIndex from category where categorycode = @p0  order by CategoryDisplayIndex ";
                        //cmd.Parameters.Add("@p0", SqlDbType.VarChar).Value = categorycode + ".%";
                       
                        DataTable categories = new DataTable();
                        num = da.Fill(categories);
                        if (num > 0)
                        {

                            wsh.Cells[excel_rowcount++, 0].PutValue("Reported Sub Categories");
                            excel_rowcount++;
                            foreach (DataRow dr in categories.Rows)
                            {
                                wsh.Cells[excel_rowcount, 0].PutValue(dr["CategoryCode"]);
                                wsh.Cells[excel_rowcount++, 1].PutValue(dr["CategoryDescription"]);

                            }
                        }
                    }



                    DataTable questions = new DataTable();

                    cmd.CommandText = "Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0)";
                    cmd.Parameters["@p0"].Value = categorycode ;
                    
                    //sm1965 08-2009 
                    cmd.Parameters.Add("@p1",DbType.String);
                    cmd.Parameters["@p1"].Value = categorycode + ".%";

                    num = da.Fill(questions);

                    excel_rowcount++;



                    DataTable freport = new DataTable();
                    
                    if (bVessel)

                        cmd.CommandText = string.Format("Select sum(convert(int,a.answer))'PositiveTotal' from Vetting a join VettingInfo b on a.vetid=b.vetid where  a.answer=1 and b.Vesselid in {0} and objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) )   ",vesselfilter);
                    else
                    cmd.CommandText = "Select sum(convert(int,answer))'PositiveTotal' from Vetting where  answer=1 and objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1 ) )";

                    wsh.Cells[excel_rowcount, 0].PutValue("Total Answered");
                    wsh.Cells[excel_rowcount+3, 0].PutValue("Perc.(%)");
                    wsh.Cells[excel_rowcount, 1].PutValue("Positive Answers ");

                    wsh.Cells[excel_rowcount, 2].PutValue("Negative Answers ");

                    wsh.Cells[excel_rowcount, 3].PutValue("Significance Rank ");
                    wsh.Cells[excel_rowcount, 4].PutValue("Significance (On average)");
                    excel_rowcount++;








                    
                    
                    int PosAnswers=0;
                    int NegAnswers = 0;
                    int TotalAnswers = 0;
                    int perc_offset = 2;

                    da.Fill(freport);
                    try
                    {
                        PosAnswers = (int)freport.Rows[0][0];
                    }
                    catch (Exception e5)
                    {
                        
                    }

                    
                    wsh.Cells[excel_rowcount, 1].PutValue(PosAnswers);
                    wsh.Cells[excel_rowcount, 1].Style.Font.IsBold = true;
                    wsh.Cells[excel_rowcount, 1].Style.Font.Color = Color.Green;



                    freport.Clear();

                    if (bVessel)
                        cmd.CommandText = string.Format("Select count(*) 'NegativeTotal' ,isnull(sum(a.significance),0) 'NegativeRank'  from Vetting a join VettingInfo b on a.vetid=b.vetid  where  b.vesselid in {0} and a.answer=2 and a.objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) )",vesselfilter);
                        
                    else
                    cmd.CommandText = "Select count(*) 'NegativeTotal' ,isnull(sum(significance),0) 'NegativeRank'  from Vetting where  answer=2 and objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) )";
                    
                    
                    
                    da.Fill(freport);


                    try
                    {
                        NegAnswers = (int)freport.Rows[0]["NegativeTotal"];
                    }
                    catch (Exception e5)
                    {

                    }

                    TotalAnswers = NegAnswers + PosAnswers;


                    float NegPerc = 0f;
                    float PosPerc = 0f;
                    if (TotalAnswers > 0)
                    {
                        NegPerc = (float)NegAnswers *100f/ (float)TotalAnswers;
                        PosPerc = (float)PosAnswers *100f/ (float)TotalAnswers;
                    }
                    
                    


                    int piechart_startrow = excel_rowcount;
                    wsh.Cells[excel_rowcount, 2].PutValue(NegAnswers);
                    wsh.Cells[excel_rowcount, 2].Style.Font.IsBold = true;
                    wsh.Cells[excel_rowcount, 2].Style.Font.Color = Color.Red;


                    //show percentages
                    wsh.Cells[excel_rowcount+2, 2].PutValue(Math.Round(NegPerc,2));//.ToString("#0.00"));
                    wsh.Cells[excel_rowcount + 2, 2].Style.HorizontalAlignment = Aspose.Cells.TextAlignmentType.Right;

                   


                    wsh.Cells[excel_rowcount + 2, 1].PutValue(Math.Round(PosPerc,2));//.ToString("#0.00"));
                    wsh.Cells[excel_rowcount + 2, 1].Style.HorizontalAlignment = Aspose.Cells.TextAlignmentType.Right;



                    wsh.Cells[excel_rowcount, 3].PutValue(freport.Rows[0]["NegativeRank"]);
                    try
                    {
                        wsh.Cells[excel_rowcount, 0].PutValue(TotalAnswers);
                    }
                    catch (Exception e1)
                    {
                        int i = 0;
                    }


                    
                    int rank = (int)freport.Rows[0]["NegativeRank"];
                    dr_category_consolidated[1] = NegAnswers;
                    dr_category_consolidated[2] = rank;

                    if (NegAnswers != 0)
                    {



                        float f = ((float)rank / (float)NegAnswers) + 0.5f;

                        int fint = (int)f;


                        if (fint == 1)
                            wsh.Cells[excel_rowcount, 4].PutValue("Low");

                        else if (fint == 2)
                            wsh.Cells[excel_rowcount, 4].PutValue("Medium");
                        else if (fint == 3)
                            wsh.Cells[excel_rowcount, 4].PutValue("Important");
                        else if (fint == 4)
                            wsh.Cells[excel_rowcount, 4].PutValue("High");
                        else if (fint == 5)
                            wsh.Cells[excel_rowcount, 4].PutValue("Critical");
                    }
                    else
                    {
                        if (PosAnswers>0)
                        wsh.Cells[excel_rowcount, 4].PutValue("Excellent");
                        
                    }

                    excel_rowcount += 4;
                    
                    chartindex = wsh.Charts.Add(Aspose.Cells.ChartType.Pie, excel_rowcount, 0, excel_rowcount + 10, 10);
                    achart = wsh.Charts[chartindex];
                    achart.Title.Text = categorycode + " " + categoryname;


                    string DataString = "";
                    if (bReportPercentage)
                    {
                       int perc_row=piechart_startrow+1+perc_offset;
                       DataString="B" + (perc_row).ToString().Trim() + ":C" + (perc_row).ToString().Trim();

                    }
                    else
                    {
                    DataString="B" + (piechart_startrow + 1).ToString().Trim() + ":C" + (piechart_startrow + 1).ToString().Trim();
                    }
                    seridx = achart.NSeries.Add(DataString , false);
                    //achart.NSeries[0].DataLabels..Name = "Neg Answers";
                    //achart.NSeries[1].Name = "Pos Answers";

                    //string DataString = "B" + (piechart_startrow + 1).ToString().Trim() ;
                    //seridx = achart.NSeries.Add(DataString , true);
                    //DataString = "C" + (piechart_startrow + 1).ToString().Trim();
                    //seridx = achart.NSeries.Add(DataString, true);

                    //seridx = achart.NSeries.Add("B" + (excel_rowcount - 1).ToString().Trim() + ":B" + (excel_rowcount - 1).ToString().Trim(), true);
                    //seridx = achart.NSeries.Add("C" + (excel_rowcount - 1).ToString().Trim() + ":C" + (excel_rowcount - 1).ToString().Trim(), true);
                    //achart.Legend.LegendEntries[0]

                    excel_rowcount += 12;

                    //----------------------------------------------------------------------------------

                    freport.Clear();


                    if (bVessel)

                        cmd.CommandText = String.Format("select v.vesselid,v.vesselname,w.NegativeTotal,w.NegativeRank from vessel v join ( Select c.vesselid,count(*) 'NegativeTotal' ,isnull(sum(a.significance),0) 'NegativeRank'  from Vetting a join VettingINfo b on a.vetid=b.vetid join vessel c on b.vesselid=c.vesselid  where   a.answer=2 and a.objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) ) group by  c.vesselid ) w on v.vesselid=w.vesselid where v.vesselid in {0} ",vesselfilter);
                    else

                    cmd.CommandText = "select v.vesselid,v.vesselname,w.NegativeTotal,w.NegativeRank from vessel v join ( Select c.vesselid,count(*) 'NegativeTotal' ,isnull(sum(a.significance),0) 'NegativeRank'  from Vetting a join VettingINfo b on a.vetid=b.vetid join vessel c on b.vesselid=c.vesselid  where   a.answer=2 and a.objectid in ( Select questionid from QuestionPoolNew where categorynewid in (Select distinct categorynewid from category where categorycode like @p0 or categorycode like @p1) ) group by  c.vesselid ) w on v.vesselid=w.vesselid";
                    // cmd.Parameters.Add("@p1", SqlDbType.Int);
                    da.Fill(freport);


                    if (!bRanksort)
                    freport.DefaultView.Sort = "NegativeTotal desc";
                    else
                        freport.DefaultView.Sort = "NegativeRank desc";


                    if (NegAnswers != 0)
                    {
                        wsh.Cells[excel_rowcount, 0].PutValue("Analysis per vessel");
                        wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;

                        excel_rowcount += 2;

                        wsh.Cells[excel_rowcount, 1].PutValue("Vessel Name");
                        wsh.Cells[excel_rowcount, 2].PutValue("Negative Total");
                        wsh.Cells[excel_rowcount, 3].PutValue("Negative Rank");
                    }
                    excel_rowcount++;

                    int pershipstartrow = excel_rowcount;
                    int idx1 = 0;



                    if (bReportPercentage)
                    {
                        foreach (DataRowView drr in freport.DefaultView)
                        {

                            idx1++;
                            wsh.Cells[excel_rowcount, 0].PutValue(idx1);
                            wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;

                            wsh.Cells[excel_rowcount, 1].PutValue(drr["vesselname"]);
                            decimal percneg = Convert.ToDecimal(drr["NegativeTotal"])*100.0m / NegAnswers;
                            decimal percnegrank = Convert.ToDecimal(drr["NegativeRank"])*100.0m / rank;
                            wsh.Cells[excel_rowcount, 2].PutValue(Math.Round(percneg,2));
                            wsh.Cells[excel_rowcount, 3].PutValue(Math.Round(percnegrank, 2));
                            excel_rowcount++;
                        }

                    }
                    else
                    {

                        foreach (DataRowView drr in freport.DefaultView)
                        {

                            idx1++;
                            wsh.Cells[excel_rowcount, 0].PutValue(idx1);
                            wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;

                            wsh.Cells[excel_rowcount, 1].PutValue(drr["vesselname"]);
                            wsh.Cells[excel_rowcount, 2].PutValue(drr["NegativeTotal"]);
                            wsh.Cells[excel_rowcount, 3].PutValue(drr["NegativeRank"]);
                            excel_rowcount++;
                        }
                    }

                    int pershipendingrow = excel_rowcount - 1;

                    excel_rowcount += 2;
                    if (NegAnswers != 0)
                    {
                        chartindex = wsh.Charts.Add(Aspose.Cells.ChartType.Bar, excel_rowcount, 0, excel_rowcount + 10, 10);
                        achart = wsh.Charts[chartindex];
                        achart.Title.Text = categorycode + " " + categoryname + "  /per vessel";

                        seridx = achart.NSeries.Add("C" + (pershipstartrow + 1).ToString().Trim() + ":C" + (pershipendingrow + 1).ToString().Trim(), true);
                        achart.NSeries[seridx].Name = "Neg. Answers";

                        seridx = achart.NSeries.Add("D" + (pershipstartrow + 1).ToString().Trim() + ":D" + (pershipendingrow + 1).ToString().Trim(), true);
                        achart.NSeries[seridx].Name = "Neg. Ranking";
                        achart.CategoryAxis.TickLabelSpacing = 1;




                        excel_rowcount += 12;
                    }







                }
                excel_rowcount++;
                wsh.Cells[excel_rowcount, 0].PutValue("Negative Answers Consolidated /per category");
                wsh.Cells[excel_rowcount, 0].Style.Font.Size = 12;
                wsh.Cells[excel_rowcount, 0].Style.Font.IsBold = true;
                wsh.Cells[excel_rowcount, 0].Style.Font.Underline = Aspose.Cells.FontUnderlineType.Single;

                
                excel_rowcount += 2;
                wsh.Cells[excel_rowcount, 1].PutValue("Vessel");
                wsh.Cells[excel_rowcount, 2].PutValue("Negative Total");
                wsh.Cells[excel_rowcount, 3].PutValue("Negative Rank Total");
                excel_rowcount += 1;

                int start_row = excel_rowcount;
                int idx = 0;
                if (bRanksort)
                    category_consolidated.DefaultView.Sort = "NegativeRank desc";

                else
                category_consolidated.DefaultView.Sort = "NegativeTotal desc";



                if (bReportPercentage)
                {
                    double catnegtotal = 0d;
                    double catnegrank = 0d;
                    foreach (DataRowView cdr in category_consolidated.DefaultView)
                    {
                        catnegtotal += Convert.ToDouble(cdr[1]);
                        catnegrank += Convert.ToDouble(cdr[2]);
                    }

                    foreach (DataRowView cdr in category_consolidated.DefaultView)
                    {
                        idx++;
                        wsh.Cells[excel_rowcount, 0].PutValue(idx);
                        wsh.Cells[excel_rowcount, 1].PutValue(cdr[0]);
                        wsh.Cells[excel_rowcount, 2].PutValue(Math.Round(Convert.ToDouble(cdr[1])*100d/catnegtotal,2));
                        wsh.Cells[excel_rowcount, 3].PutValue(Math.Round(Convert.ToDouble(cdr[2]) * 100d / catnegrank,2));
                        excel_rowcount++;

                    }
                }
                else
                {
                    foreach (DataRowView cdr in category_consolidated.DefaultView)
                    {
                        idx++;
                        wsh.Cells[excel_rowcount, 0].PutValue(idx);
                        wsh.Cells[excel_rowcount, 1].PutValue(cdr[0]);
                        wsh.Cells[excel_rowcount, 2].PutValue(cdr[1]);
                        wsh.Cells[excel_rowcount, 3].PutValue(cdr[2]);
                        excel_rowcount++;

                    }
                }
                excel_rowcount++;
                chartindex = wsh.Charts.Add(Aspose.Cells.ChartType.Bar, excel_rowcount, 0, excel_rowcount + 20, 10);
                achart = wsh.Charts[chartindex];
                achart.CategoryAxis.MinorUnit = 1;
                seridx = achart.NSeries.Add("C" + (start_row+1).ToString().Trim()+":C" + (excel_rowcount).ToString().Trim() , true);
                achart.CategoryAxis.TickLabelSpacing = 1;   
                achart.NSeries[seridx].Name = "Negative Answers/ Consolidated per category";
                
                seridx = achart.NSeries.Add("D" + (start_row + 1).ToString().Trim() + ":D" + (excel_rowcount).ToString().Trim(), true);
                achart.NSeries[seridx].Name = "Negative Rank/ Consolidated per category";
               
                wkb.Save(fs, Aspose.Cells.FileFormatType.Excel2003);
                fs.Close();
                if (DialogResult.Yes == MessageBox.Show("Excel file was created. Do you want to open it?", "Excel creation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    System.Diagnostics.Process.Start(outfilename);
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (fs != null)
                    fs.Close();
            }
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Report_CategoryAnalysis();
            this.Report_CategoryAnalysis_Period();
            
        }

        private void tv_categories_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Checked)
                {

                    this.selected_reportnodes.Add(e.Node, e.Node);

                }
                else
                {
                    this.selected_reportnodes.Remove(e.Node);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private bool HasChildrenChecked(TreeNode anode)
        {
            foreach (TreeNode n in anode.Nodes)
            {
                if (n.Checked)
                    return true;
                if (n.Nodes.Count > 0)
                {
                    return HasChildrenChecked(n);
                }
            }
            return false;
        }

        private void tv_categories_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            bool bparentchecked = false;
            TreeNode pn=e.Node.Parent;
            while (pn != null)
            {

                if (pn.Checked)
                {
                    bparentchecked = true;
                    break;
                }
                pn = pn.Parent;
            }
            e.Cancel = bparentchecked;

            if (!e.Cancel)
            {
                e.Cancel = HasChildrenChecked(e.Node);

            }
          

        }

        private void tv_categories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            return;
        }

        
        private void report_categoryAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Report_CategoryAnalysis();
            this.Report_CategoryAnalysis_Period();
            
        }

        private void tbctrl_categories_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!this.bAllowCategoryTreeView)
                e.Cancel = true;
            if (e.TabPageIndex == 1)
            {
                this.report_categoryAnalysisToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.report_categoryAnalysisToolStripMenuItem.Enabled = false;
            }

        }

        private void UncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tv_vessels.Focused)
            {
                Utility.TreeViewUncheckAll(this.tv_vessels);
            }
            else if (this.tv_categories.Focused)
            {
                Utility.TreeViewUncheckAll(this.tv_categories);
                //this.selected_reportnodes.Clear();
            }
        }

        private void checkAllSubnodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tn = null;
            if (this.tv_vessels.Focused)
            {
                tn = this.tv_vessels.SelectedNode;
                if (tn == null)
                    return;
                Utility.TreeNodeCheckAll(tn);
            }
            else if (this.tv_categories.Focused)
            {
                tn = this.tv_categories.SelectedNode;
                if (tn == null)
                    return;
                Utility.TreeNodeCheckAll(tn);
            }
        }

        private void cmb_fleetselection_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.tv_vessels.Nodes.Count; i++)
            {
                DataRow dr= (DataRow) this.tv_vessels.Nodes[i].Tag;
                int intSelection = (sender as ComboBox).SelectedIndex;
                try
                {
                    int fleetid = Convert.ToInt32(dr["FleetId"]);

                    if (intSelection == 0)
                    {
                        this.tv_vessels.Nodes[i].Checked = true;
                    }
                    else
                    {
                        if (fleetid == intSelection)
                            this.tv_vessels.Nodes[i].Checked = true;
                        else
                            this.tv_vessels.Nodes[i].Checked = false;
                    }
                }
                catch(Exception e1)
                {
                    int i1 = 0;
                }
            }
        }

        private void showRegistrationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel_Notifier.Visible = !this.panel_Notifier.Visible;
            if (this.panel_Notifier.Visible)
            {
                if (!NewRegistrationNotirfier.MainThread.IsAlive)
                NewRegistrationNotirfier.MainThread.Start();
            }
            else
                NewRegistrationNotirfier.MainThread.Suspend();
        }

        private void tv_categories_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (IsSubNodeChecked(e.Node,false))
                e.Cancel = true;
        }

        private bool IsSubNodeChecked(TreeNode tn,bool bIncludefirst)
        {

            if (bIncludefirst)
            {
                if ( tn.Checked)
                    return true;
            }

            TreeNodeCollection tncol = tn.Nodes;

            if (tncol.Count > 0)
            {
                foreach (TreeNode tnn in tncol)
                {
                    if (IsSubNodeChecked(tnn, true))
                        return true;
                        
                }
            }
            
            return false;
        }

        private void buildCategoryDisplayOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildCategoryTree();
        }

        private void checkAllTopNodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tv_vessels.Focused)
            {
                Utility.TreeViewCheckTop(this.tv_vessels);
            }
            else if (this.tv_categories.Focused)
            {
                Utility.TreeViewCheckTop(this.tv_categories);
                //this.selected_reportnodes.Clear();
            }
            
        }

        private void vettingRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVettingRequest frm_vettingrequest = new FormVettingRequest();
            frm_vettingrequest.ShowDialog();
        }

        private void bt_Report_Click(object sender, EventArgs e)
        {
            Report_CategoryAnalysis_Period();
        }

        







    }


    class DragDrop
    {
        public int X;
        public int Y;
        public int _threshold = 5;
        public bool bStarted;
        public bool bMouseDown;
        public Control ctrl;
        private object databus;

        public delegate void OnStartDragDelegate();
        public event OnStartDragDelegate OnDragStarted;
        public delegate void OnDragStoppedDelegate();
        public event OnDragStoppedDelegate OnDragEnded;



        public void Event_DragDrop(object sender, DragEventArgs e)
        {
            TreeView tv = this.ctrl as TreeView;
            TreeNode tn = tv.GetNodeAt(this.ctrl.PointToClient(new System.Drawing.Point(e.X, e.Y)));
            (this.databus as TreeNode).Remove();
            tn.Nodes.Add(this.databus as TreeNode);
            this.bStarted = false;
            tv.SelectedNode = (this.databus as TreeNode);
            if (this.OnDragEnded != null)
                OnDragEnded();
        }
        public DragDrop()
        {
            this.X = 0;
            this.Y = 0;
            bStarted = false;
        }
        public DragDrop(TreeView tv)
        {
            this.X = 0;
            this.Y = 0;
            bStarted = false;
            this.ctrl = tv;
            this.bMouseDown = false;
        }
        public bool HasNLevelParent(TreeNode anode,TreeNode maybeparent)
        {
            while (anode != null)
            {
                if (anode.Parent == maybeparent)
                    return true;
                else
                    anode = anode.Parent;
            }
            return false;

        }
        public TreeNode CanLand(DragEventArgs e)
        {
            
            TreeNode anode=null;
            anode = (this.ctrl as TreeView).GetNodeAt(this.ctrl.PointToClient(new System.Drawing.Point(e.X, e.Y)));
             TreeNode snode = (TreeNode)databus;
             if (anode != null )
             {
                 if (anode.Equals(snode))
                     e.Effect=DragDropEffects.None;
                 else if (snode.Parent!=null&&snode.Parent.Equals(anode))
                     e.Effect = DragDropEffects.None;

                 else if (!anode.Equals(anode.TreeView.TopNode)&&HasNLevelParent(anode,snode))
                     e.Effect = DragDropEffects.None;

                 else if ((snode.Tag as VIQObject).OType == VIQObject.VIQType.Category && (anode.Tag as VIQObject).OType == VIQObject.VIQType.Question)
                     e.Effect = DragDropEffects.None;
                 else
                 e.Effect = DragDropEffects.Copy;
             }
             else
                 e.Effect = DragDropEffects.None;
            return anode;
        }
        public void CancelDrag()
        {
            this.bStarted = false;
            this.databus = null;
            this.bMouseDown = false;
            if (this.OnDragEnded != null)
                this.OnDragEnded();
        }
        public void SetDragStart(int x1, int y1)
        {
            X = x1;
            Y = y1;
            try
            {
                databus = ((TreeView)ctrl).GetNodeAt(x1, y1) as TreeNode;
                (this.ctrl as TreeView).SelectedNode = databus as TreeNode;
                this.bMouseDown = true;
                this.bStarted = false;
            }
            catch
            {
                databus = null;
                this.bMouseDown = false;
                this.bStarted = false;
            }
        }
        public bool CanStartDragDrop(int x1,int y1)
        {
            if (!bStarted&&bMouseDown)
            {
                if (Math.Abs(x1 - X) > _threshold || Math.Abs(y1 - Y) > _threshold)
                {
                    return true;

                }
                return false;
            }
           
            return false;
            

        }
        public void StartDrag()
        {
            if (ctrl is TreeView)
            {
                TreeView tv=(TreeView) ctrl;
                if (databus != null)
                {
                    this.bStarted = true;
                    if (this.OnDragStarted != null)
                        OnDragStarted();
                    ctrl.DoDragDrop(this.databus, DragDropEffects.Copy);
          
                }
            }
        }


    }
    


    

    public class ApplicationInfo
    {
        public enum UserMode { NormalUser, Editor, Designer, Administrator,EnterpriseManager }
        public static UserMode ActiveUserMode;
        public static int userid;
        public static string bfpassword;

    }


  

    
     public class Portable
    {

        public static DataTable GetVisitLog(string filepath,string password)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "select  ValidFromDate,ValidTodate,LastDate,VisitNumberLimit,VettingNumberLimit,QuestionnaireLimit,VettingNumber,QuestionnaireNumber,VisitNumber from [VisitLog]";

            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.SelectCommand = cmd;
            
            DataTable tbl = new System.Data.DataTable();
            try
            {

                int num = da.Fill(tbl);
                return tbl;

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot load briefcase's v-log. " + e2.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }

        public static void UpdateVisitLogInfo(string filepath, string password,DataTable tbl)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update visitlog set ValidFromDate=@p0,ValidTodate=@p1,LastDate=@p2,"+
                              "VisitNumberLimit=@p3,VettingNumberLimit=@p4,QuestionnaireLimit=@p5,VettingNumber=@p6,"+
                              "QuestionnaireNumber=@p7,VisitNumber=@p8";
            cmd.Parameters.Add("@p0", SqlDbType.DateTime,0,"ValidFromdate");
            cmd.Parameters.Add("@p1", SqlDbType.DateTime,0,"ValidToDate");
            cmd.Parameters.Add("@p2", SqlDbType.DateTime, 0, "LastDate");
            cmd.Parameters.Add("@p3", SqlDbType.Int, 4, "VisitNumberLimit");
            cmd.Parameters.Add("@p4", SqlDbType.Int, 4, "VettingNumberLimit");
            cmd.Parameters.Add("@p5", SqlDbType.Int, 4, "QuestionnaireLimit");
            cmd.Parameters.Add("@p6", SqlDbType.Int, 4, "VettingNumber");
            cmd.Parameters.Add("@p7", SqlDbType.Int, 4, "QuestionnaireNumber");
            cmd.Parameters.Add("@p8", SqlDbType.Int, 4, "VisitNumber");

            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.UpdateCommand = cmd;

            
            try
            {

                int num = da.Update(tbl);
                if (num == 0)
                    throw new Exception("Nothing updated");

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot update briefcase's v-log. " + e2.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
            }

        }
        public static DataTable GetVersion(string filepath, string password)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "select  Versioncode from [Version]";

            
            SqlCeDataAdapter da=new SqlCeDataAdapter();
            da.SelectCommand=cmd;
            try
            {
                DataTable tbl = new DataTable();
                int num=da.Fill(tbl);
                return tbl;

            }
            catch (Exception e2)
            {
                throw new Exception("Cannot load briefcase's version. " + e2.Message);
            }
            finally
            {
                con.Close();
            
            }

        }
        public static void UpdateVersion(string filepath, string password,DataTable tbl)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath, password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update Version set Versioncode =@p0";
            cmd.Parameters.Add("@p0", SqlDbType.NVarChar, 256,"VersionCode");
            SqlCeDataAdapter da=new SqlCeDataAdapter();
            da.UpdateCommand=cmd;
            tbl.Rows[0].SetModified();

            try
            {

                int num = da.Update(tbl);
                if (num == 0)
                    throw new Exception("Nothing updated");
            }
            catch (Exception e2)
            {
                throw new Exception("Briefcase's version update failed. " + e2.Message);
            }
            finally
            {
                con.Close();

            }

        }


        public static void FillVesselTable(string filepath,string password, System.Data.DataTable tbl)
        {
            SqlCeConnection con = Portable.ConnectionFromFile(filepath,password);
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Vessel order by vesselname ";

            SqlCeDataAdapter da = new SqlCeDataAdapter();
            da.SelectCommand = cmd;


            try
            {

                int num = da.Fill(tbl);
                
            }
            catch (Exception e2)
            {
                throw new Exception("Cannot load briefcase vessels. " + e2.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public static bool CheckVesselExists(string filepath,string password,int vesselid)
        {
            SqlCeConnection con=Portable.ConnectionFromFile(filepath,password);
            if (con.State!=ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd=new SqlCeCommand();
            cmd.Connection=con;
            cmd.CommandText="select top 1 vesselid from Vessels where vesselid=@p0 ";
            cmd.Parameters.Add("@p0",SqlDbType.Int);
                

            cmd.Parameters[0].Value=vesselid;
                
                
            try{

                int num=(int)cmd.ExecuteScalar();
                return true;
            }
            catch(Exception e2)
            {
                return false;
            }
            finally
            {
                con.Close();
            }



        }


        public static void InsertVessel(string dbpath,string password,int vesselid,string vesselname,string imo,string flag,float gton,float dwt,object deldate)
        {
            SqlCeConnection con=Portable.ConnectionFromFile(dbpath,password);
            if (con.State!=ConnectionState.Open)
                con.Open();
            SqlCeCommand cmd=new SqlCeCommand();
            cmd.Connection=con;
            cmd.CommandText="Insert into Vessels (vesselid,vesselname,imo,flag,grosstonage,deadweight,deliverydate) "+
                            " values (@p_vid,@p_vname,@p_imo,@p_flag,@p_gton,@p_dwt,@p_deldate) ";
            cmd.Parameters.Add("@p_vid",SqlDbType.Int);
                cmd.Parameters.Add("@p_vname",SqlDbType.NVarChar,64);
                    cmd.Parameters.Add("@p_imo",SqlDbType.NVarChar,30);
                        cmd.Parameters.Add("@p_flag",SqlDbType.NVarChar,64);
                            cmd.Parameters.Add("@p_gton",SqlDbType.Float);
                                cmd.Parameters.Add("@p_dwt",SqlDbType.Float);
                                    cmd.Parameters.Add("@p_deldate",SqlDbType.DateTime);


            cmd.Parameters[0].Value=vesselid;
                cmd.Parameters[1].Value=vesselname;
                cmd.Parameters[2].Value=imo;
                cmd.Parameters[3].Value=flag;
                cmd.Parameters[4].Value=gton;
                cmd.Parameters[5].Value=dwt;
                cmd.Parameters[6].Value=deldate;
                
            try{

                int num=cmd.ExecuteNonQuery();
            }
            catch(Exception e2)
            {
                throw new Exception("Insertion failed. "+e2.Message);
            }
            finally
            {
                con.Close();
            }



        }

        public static VettingInfo GetVettingInfo(SqlCeConnection cecon, int vetid)
        {
            VettingInfo vi = new VettingInfo();
            SqlCeDataReader dr = Portable.GetVettingInfoReader(cecon, vetid);
            //cmd.CommandText = "Select QId,VesselName,InspectorName,CompanyRepresentativeName,VettingCode,VetGUI,port,vettingdate,comments from VettingInfo where vetid=@p0";
            while (dr.Read())
            {
                vi.Qid = dr.GetInt32(0);
                vi.VesselName = dr.GetString(1);
                vi.InspectorName = dr.GetString(2);
                vi.CompanyRepresentativeName=dr.GetString(3);
                vi.VettingCode = dr.GetString(4);
                vi.VetGUI = dr.GetGuid(5);
                vi.Port = dr.GetString(6);
                vi.VettingDate = dr.GetDateTime(7);
                vi.Comments = dr.GetString(8);
                vi.ViqGUI = (Guid)dr.GetValue(9);
                vi.InspectionType = dr.GetString(10);
            //    vi.InspectionTypeId = dr.GetInt32(10);
                try
                {
                    vi.InspectionTypeId = (int)dr.GetValue(11);
                }
                catch
                {
                    vi.InspectionTypeId = -1;
                }
                vi.VesselId = (int)dr.GetValue(12);

                

            }
            dr.Close();
            return vi;
        }

        
        public static SqlCeConnection ConnectionFromFile(string filepath, string password)
        {
            try{

            return new SqlCeConnection(Portable.ConnectionStringFromFile(filepath,password)); 
            }
            catch(Exception e1)
            {
                return null;
            }

        }

        public static bool CreateVettingContext(SqlCeConnection SourceConnection,SqlCeTransaction trans,int VetId,int QId)
        {
            if (SourceConnection.State != ConnectionState.Open)
            {
                SourceConnection.Open();
            }


            
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "INSERT INTO SMVETTING (VETID,QUESTIONID) SELECT " + VetId + " as  VetId ,OBJECTID FROM SMQUESTIONNAIRE WHERE QID=@p_qid and OBJECTTYPE=0";
            cmd.Parameters.Add("@p_qid", SqlDbType.Int);
            cmd.Connection = SourceConnection;
            if (trans != null)
                cmd.Transaction = trans;
            try
            {

                cmd.ExecuteNonQuery(); 
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message); 
                return false; 
            }
            finally
            {
                if (trans==null)
                SourceConnection.Close();
            }

        }


        public static int GetID(SqlCeConnection SourceConnection)
        {
            SqlCeCommand cmd = new SqlCeCommand("Select COUNT(*) FROM VETTINGINFO", SourceConnection);
            return Convert.ToInt32(cmd.ExecuteScalar())+1;

        }
        public static bool VettingInfoInsert(SqlCeConnection SourceConnection,
            SqlCeTransaction trans,string sdfpassword,out object vetid,out System.Guid vetgui,
            object qid, object inspectorname,object inspectorsirname,object companyrepresentativename,
            object portid, object port, object countryid, object countryname,
            object vetdate, object vettime, object password, object comments,
            object vesselid, object vesselname, object vetcode,object vettypeid)
        {
            vetid = null;
            vetgui = System.Guid.NewGuid();
            if (trans==null&&SourceConnection == null)
            {
                System.Windows.Forms.OpenFileDialog dlg = Portable.OpenBriefcaseFile(false);
                if (dlg != null)
                {
                    SourceConnection = Portable.ConnectionFromFile(dlg.FileName, sdfpassword);
                }
                else
                {
                    MessageBox.Show("Connection not established");
                    return false;
                }
            }
            if (SourceConnection.State != ConnectionState.Open)
            {
                SourceConnection.Open();
            }

            
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "INSERT INTO VETTINGINFO "
                +"(vetid,QId,InspectorName,CompanyRepresentativeName,InspectorSirname,Portid,Port,"
                +" CountryId,Country,Vetdate,vettime, "
                +" password,comments,vesselid,vesselname,vettingcode,vetGUI,InspectionTypeId) "
                +"values (@p_vetid,@p_qid,@p_inspname,@p_cmprepresentativename,@p_inspsirname,@p_portid,@p_port,@p_countryid,@p_country,@p_vetdate,@p_vettime,@p_pswd,"
                +" @p_comments,@p_vesselid,@p_vesselname,@p_vetcode,@p_vetgui,@p_InspTypeId) ";
            cmd.Parameters.Add("@p_vetid", SqlDbType.Int);
            cmd.Parameters.Add("@p_qid", SqlDbType.Int);
            cmd.Parameters.Add("@p_inspname", SqlDbType.NVarChar,64 );
            cmd.Parameters.Add("@p_cmprepresentativename", SqlDbType.NVarChar, 64);

            cmd.Parameters.Add("@p_inspsirname", SqlDbType.NVarChar,64 );
            cmd.Parameters.Add("@p_portid", SqlDbType.UniqueIdentifier );
            cmd.Parameters.Add("@p_port", SqlDbType.NVarChar,64 );
            cmd.Parameters.Add("@p_countryid", SqlDbType.UniqueIdentifier );
            cmd.Parameters.Add("@p_country", SqlDbType.NVarChar,64 );
            cmd.Parameters.Add("@p_vetdate", SqlDbType.DateTime );
            cmd.Parameters.Add("@p_vettime", SqlDbType.DateTime);
            cmd.Parameters.Add("@p_pswd", SqlDbType.NVarChar,128);
            cmd.Parameters.Add("@p_comments", SqlDbType.NVarChar,4000);
            cmd.Parameters.Add("@p_vesselid", SqlDbType.UniqueIdentifier );
            cmd.Parameters.Add("@p_vesselname", SqlDbType.NVarChar,64 );
            cmd.Parameters.Add("@p_vetcode", SqlDbType.NVarChar,64);
            cmd.Parameters.Add("@p_vetgui", SqlDbType.UniqueIdentifier);
            cmd.Parameters.Add("@p_InspTypeId", SqlDbType.Int);




            if (vetid == null)
                vetid = Portable.GetID(SourceConnection);



            cmd.Parameters["@p_vetid"].Value = vetid;
                cmd.Parameters["@p_qid"].Value = qid;
            cmd.Parameters["@p_inspname"].Value=inspectorname;
            cmd.Parameters["@p_cmprepresentativename"].Value = companyrepresentativename;

            cmd.Parameters["@p_inspsirname"].Value=inspectorsirname;
            cmd.Parameters["@p_portid"].Value=portid;
            cmd.Parameters["@p_port"].Value=port;
            cmd.Parameters["@p_countryid"].Value=countryid;
            cmd.Parameters["@p_country"].Value=countryname ;
            cmd.Parameters["@p_vetdate"].Value=vetdate ;
            cmd.Parameters["@p_vettime"].Value=vettime;
            cmd.Parameters["@p_pswd"].Value=password;
            cmd.Parameters["@p_comments"].Value=comments;
            cmd.Parameters["@p_vesselid"].Value=vesselid;
            cmd.Parameters["@p_vesselname"].Value=vesselname;
            cmd.Parameters["@p_vetcode"].Value=vetcode;
            cmd.Parameters["@p_vetgui"].Value =vetgui ;
            cmd.Parameters["@p_InspTypeId"].Value=vettypeid;
            
            if (trans!=null)
            cmd.Transaction = trans;
            cmd.Connection = SourceConnection;


            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                    return false;
            }
            finally
            {
                if (trans == null)
                    SourceConnection.Close();
            }


        }

        public static bool CreateVettingContextSlowVersion(SqlCeConnection SourceConnection,SqlCeTransaction trans, int VetId, int QId)
        {

            

            if (SourceConnection == null)
            {
                string password = "";
                System.Windows.Forms.OpenFileDialog dlg = Portable.OpenBriefcaseFile(false);
                if (dlg != null)
                {
                    SourceConnection = Portable.ConnectionFromFile(dlg.FileName,password);
                }
                else
                {
                    MessageBox.Show("Connection not established");
                    return false;
                }
            }
            if (SourceConnection.State != ConnectionState.Open)
            {
                SourceConnection.Open();
            }

            SqlCeTransaction tr = null;
            
            if (trans==null)
                tr=SourceConnection.BeginTransaction(); 
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT objectid FROM SMQUESTIONNAIRE WHERE QID=@p_qid and OBJECTTYPE=0 ORDER BY GLOBALDISPLAYINDEX";
            cmd.Parameters.Add("@p_qid", SqlDbType.Int);
            if (trans == null)
                cmd.Transaction = tr;
            else
                cmd.Transaction = trans;
            cmd.Connection = SourceConnection;


            SqlCeCommand cmd_ins = new SqlCeCommand();
            cmd_ins.CommandText = "INSERT INTO SMVETTING (VETID,OBJECTID) VALUES (@P0,@P1)";
            cmd_ins.Parameters.Add("@P0", SqlDbType.Int);
            cmd_ins.Parameters.Add("@P1", SqlDbType.UniqueIdentifier);
            if (trans == null)
                cmd_ins.Transaction = tr;
            else
                cmd_ins.Transaction = trans;

            cmd_ins.Connection = SourceConnection;

            cmd_ins.Parameters[0].Value = VetId; 
            try
            {
                cmd.Parameters[0].Value = QId; 
                System.Data.SqlServerCe.SqlCeDataReader dr= cmd.ExecuteReader();


                while (dr.Read())
                {
                    cmd_ins.Parameters[1].Value = dr.GetGuid(0); 
                    cmd_ins.ExecuteNonQuery(); 
                    
                }


                dr.Close();
                if (trans==null)
                tr.Commit();
                return true;
            }
            catch (Exception e1)
            {
                if (trans == null)
                    tr.Rollback();
                else
                    trans.Rollback();
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                if (trans == null) 
                SourceConnection.Close();
            }

        }
        public static string ConnectionStringFromFile(string FilePath, string password)
        {
            return string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
        }
        public static System.Windows.Forms.OpenFileDialog OpenBriefcaseFile(bool create)
        {
            System.Windows.Forms.OpenFileDialog fdlg = new OpenFileDialog();
            if (create)
            {
                fdlg.Title = "Create Briefcase File";
                fdlg.CheckFileExists = false;
            
            }
            else
                fdlg.Title = "Open Briefcase File";
            fdlg.AddExtension = true;
            fdlg.Filter = "(Briefcase files *.sdf)|*.sdf";
            fdlg.ShowDialog();
            if (fdlg.FileName != "")
                return fdlg;
            else
            {
                return null;
            }
        }

         public static SqlCeDataReader GetVettingInfoReader(SqlCeConnection cecon, int vetid)
        {

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = cecon;

            cmd.CommandText = "Select a.QId,a.VesselName,a.InspectorName,a.CompanyRepresentativeName,a.VettingCode,a.VetGUI,a.Port,a.Vetdate,a.comments,b.VIQGUI,c.InspectionType,c.InspectionTypeId,a.VesselId from VettingInfo  a join VIQInfo b on a.qid=b.qid join INSPECTIONTYPES c on a.inspectiontypeid=c.inspectiontypeid where vetid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = vetid;

            SqlCeDataReader dtr = cmd.ExecuteReader();
            return dtr;

        }
       

        public static SqlCeDataAdapter GetVettingAdapter(SqlCeConnection cecon, int vetid)
        {

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = cecon;

            cmd.CommandText = "Select b.objectid,b.answer,b.significance,b.comments from  SMVetting b where b.vetid=@p1";//unsorted


            cmd.Parameters.Add("@p1", SqlDbType.Int);

            cmd.Parameters[0].Value = vetid;
            SqlCeDataAdapter ceda=new SqlCeDataAdapter(cmd);
            return ceda;
        }


        public static bool LoadVetting(string filepath,string password,int VetId,out System.Guid VetGUI,out int QId,out Guid VIQGUI,System.Data.DataTable target,out string  VesselName,out string Inspectorname,out string CompanyRepresentativeName,out string VettingCode)

        {
            QId = -1;
            VetGUI = System.Guid.Empty;
            VIQGUI = System.Guid.Empty;
            VesselName=null;
            Inspectorname = null;
            VettingCode = null;
            CompanyRepresentativeName = null;
            SqlCeConnection cecon = Portable.ConnectionFromFile(filepath, password);
            if (cecon.State != ConnectionState.Open)
            {
                cecon.Open();
            }



            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = cecon;

            cmd.CommandText = "Select a.QId,a.VetGUI,a.VesselName,a.InspectorName,a.CompanyRepresentativeName,a.VettingCode,b.VIQGUI from VettingInfo a join VIQInfo b on a.qid=b.qid where a.vetid=@p0";
            cmd.Parameters.Add("@p0", SqlDbType.Int);
            cmd.Parameters[0].Value = VetId;

            SqlCeDataReader dtr = cmd.ExecuteReader();
            
            if (dtr.Read())
            {
                QId= Convert.ToInt32(dtr.GetValue(0));
                VetGUI = (System.Guid) dtr.GetValue(1);
                VesselName = dtr.GetValue(2).ToString();
                Inspectorname = dtr.GetValue(3).ToString();
                CompanyRepresentativeName = dtr.GetValue(4).ToString();
                VettingCode = dtr.GetValue(5).ToString();
                VIQGUI = (System.Guid)dtr.GetValue(6);

            }
            dtr.Close();


            cmd.CommandText="Select a.* ,b.answer,b.significance,b.comments from SMQuestionnaire a  LEFT JOIN SMVetting b on a.objectid=b.objectid where (b.vetid is null OR b.vetid=@p0) and a.qid=@p1 order by a.globaldisplayindex";
            cmd.Parameters.Add("@p1",SqlDbType.Int);

            cmd.Parameters[1].Value = QId;
            SqlCeDataAdapter ceda=new SqlCeDataAdapter(cmd);
            
            try
            {
             int num=ceda.Fill(target);
                return true;
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                return false;
            }


        }



        public static bool SaveVetting(System.Data.SqlServerCe.SqlCeConnection  SourceConnection,
            int VetId,int QId,
            WindowsFormsApplication1.Attendance.VettingInfoDataTable tblinfo,
            WindowsFormsApplication1.Attendance.QuestionnaireDataTable tblvet )
        {

            if (SourceConnection == null)
            {
                string password = "";
                OpenFileDialog dlg=Portable.OpenBriefcaseFile(false);
                if (dlg == null)
                {
                    MessageBox.Show("Cannot connect to a briefcase file");
                    return false;
                }
                SourceConnection = Portable.ConnectionFromFile(dlg.FileName,password); 
            }

            if (SourceConnection.State != ConnectionState.Open)
                SourceConnection.Open();
            System.Data.SqlServerCe.SqlCeTransaction trans = SourceConnection.BeginTransaction();
            System.Data.SqlServerCe.SqlCeDataAdapter da = new SqlCeDataAdapter();




            if (SourceConnection == null)
            {
                Portable.OpenBriefcaseFile(false);
            }

            //var vinforow=(WindowsFormsApplication1.Attendance.VettingInfoRow  );

           System.Data.SqlServerCe.SqlCeCommand   cmd_ins=new SqlCeCommand();
           System.Data.SqlServerCe.SqlCeCommand cmd_upd = new SqlCeCommand();
           cmd_ins.Connection = SourceConnection;
           cmd_upd.Connection = SourceConnection;




           if (trans != null)
           {
               cmd_ins.Transaction = trans;
               cmd_upd.Transaction = trans;
           }
           if (cmd_ins.Connection.State != ConnectionState.Open)
           {
               cmd_ins.Connection.Open();
               cmd_upd.Connection.Open();
           }
            /*
           cmd_ins.Parameters.Add("@p_vetid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_qid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_insname", SqlDbType.NVarChar,64);
           cmd_ins.Parameters.Add("@p_insname2", SqlDbType.NVarChar, 64);
           cmd_ins.Parameters.Add("@p_portid", SqlDbType.Int );
           cmd_ins.Parameters.Add("@p_port", SqlDbType.NVarChar,64);
           cmd_ins.Parameters.Add("@p_countryid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_country", SqlDbType.NVarChar,64 );
           cmd_ins.Parameters.Add("@p_vetdate", SqlDbType.DateTime);
           cmd_ins.Parameters.Add("@p_vettime", SqlDbType.DateTime);
           cmd_ins.Parameters.Add("@p_pass", SqlDbType.NVarChar,128);
           cmd_ins.Parameters.Add("@p_comm", SqlDbType.NVarChar,4000);
           cmd_ins.Parameters.Add("@p_vessid", SqlDbType.Int);
           cmd_ins.Parameters.Add("@p_vess", SqlDbType.NVarChar,64);
           cmd_ins.Parameters.Add("@p_vetcode", SqlDbType.NVarChar, 64);
 
             */




            /*
           cmd_ins.CommandText = "INSERT INTO VETTING (VETID,OBJECTID,ANSWER,SIGNIFICANCE,COMMENTS) " +
               " VALUES (@p_vetid,@p_objid,@p_answer,@p_signif,@p_comm) ";
           cmd_ins.Parameters.Add("@p_vetid", SqlDbType.Int,4);
           cmd_ins.Parameters.Add("@p_objid", SqlDbType.UniqueIdentifier,4,"ObjectId");
           cmd_ins.Parameters.Add("@p_answer", SqlDbType.Int,4,"answer");
           cmd_ins.Parameters.Add("@p_signif", SqlDbType.Int,4,"significance");
           cmd_ins.Parameters.Add("@p_comm", SqlDbType.NVarChar,4000,"comments");


           cmd_ins.Parameters[0].Value = 100;    
            */

           cmd_upd.CommandText = "UPDATE VETTING SET ANSWER=@p_answer "+
                  ",SIGNIFICANCE=@p_signif,COMMENTS=@p_comm where OBJECTID=@p_objid and " +
              "  VETID=@p_vetid ";
           cmd_upd.Parameters.Add("@p_vetid", SqlDbType.Int, 4);
           cmd_upd.Parameters.Add("@p_objid", SqlDbType.UniqueIdentifier , 4, "ObjectId");
           cmd_upd.Parameters.Add("@p_answer", SqlDbType.Int, 4, "answer");
           cmd_upd.Parameters.Add("@p_signif", SqlDbType.Int, 4, "significance");
           cmd_upd.Parameters.Add("@p_comm", SqlDbType.NVarChar, 4000, "comments");




           cmd_upd.Parameters[0].Value = VetId;
           
            //da.InsertCommand = cmd_ins;
           da.UpdateCommand = cmd_upd;

           try
           {

               /*
               foreach (WindowsFormsApplication1.Attendance.VettingRow vtrow in tblvet.Rows)
               {



                   cmd_ins.Parameters[0].value = VETId;
                   cmd_ins.Parameters[1].Value = vtrow.ObjectId;
                   cmd_ins.Parameters[2].Value = vtrow.Answer;
                   cmd_ins.Parameters[3].Value = vtrow.Significance;
                   cmd_ins.Parameters[4].Value = vtrow.Comments;
               }
                */

               int num = da.Update(tblvet);

               trans.Commit();
               if (num>0)
               return true;
               return false;

           }
           catch (Exception e1)
           {
               trans.Rollback();
               return false;
           }
           finally
           {
               SourceConnection.Close();
           }




          
        }





        public static bool TransferQuestionnaireTemplate(System.Data.SqlClient.SqlConnection SourceConnection,int QId,string FilePath, string password)
        {
            
            string Title="";
            string Author="";
            DateTime RegistrationDate=DateTime.MinValue ;
            
            System.Data.SqlClient.SqlCommand sourcecmd = new System.Data.SqlClient.SqlCommand();
            sourcecmd.CommandText = "SELECT * FROM VIQInfo where QId =@p0";
            sourcecmd.Parameters.Add("@p0", SqlDbType.Int);
            sourcecmd.Parameters[0].Value = QId;
            sourcecmd.Connection = SourceConnection;
            if (SourceConnection.State != ConnectionState.Open)
                SourceConnection.Open();
            System.Data.SqlClient.SqlDataReader sqldr_info=sourcecmd.ExecuteReader();

            if (sqldr_info.Read())
            {
                //QId = sqldr_info.GetValue(sqldr_info.GetOrdinal("QId"));
                Title = (string)sqldr_info.GetValue(sqldr_info.GetOrdinal("Title"));
                Author = (string)sqldr_info.GetValue(sqldr_info.GetOrdinal("Author"));
                RegistrationDate = (DateTime)sqldr_info.GetValue(sqldr_info.GetOrdinal("RegistrationDate"));
            }
                





            
            
            
            
            
            
            
            string ConnectionString;





            
            ConnectionString = string.Format ("DataSource=\"{0}\";Password='{1}'",FilePath,password);
            

            System.Data.SqlServerCe.SqlCeConnection con=new SqlCeConnection (ConnectionString );
            con.Open();

            SqlCeCommand cmd=new SqlCeCommand();
            
            System.Data.SqlServerCe.SqlCeTransaction CETRANS = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = CETRANS; 
            try{ 
            
            cmd.CommandText = "INSERT INTO VIQINFO (QID,Title,Author,Finalized,Registrationdate,comments,viqgui,NumOfQuestions) "+
                "VALUES (@p_qid,@p_title,@p_author,@p_final,@p_regdate,@p_comment,@p_viqgui,@p_numofq)";


                    cmd.Parameters.Add ("@p_qid",SqlDbType.Int ); 
                    cmd.Parameters.Add ("@p_title",SqlDbType.NVarChar,128); 
                    cmd.Parameters.Add ("@p_author",SqlDbType.NVarChar,128); 
                    cmd.Parameters.Add ("@p_final",SqlDbType.SmallInt); 
                    cmd.Parameters.Add ("@p_regdate",SqlDbType.DateTime);
                    cmd.Parameters.Add("@p_comment", SqlDbType.NVarChar,4000 );
                    cmd.Parameters.Add("@p_viqgui", SqlDbType.UniqueIdentifier);
                    cmd.Parameters.Add("@p_numofq", SqlDbType.Int); 


                        cmd.Parameters["@p_qid"].Value = QId ;
                        cmd.Parameters["@p_title"].Value = Title ;
                        cmd.Parameters["@p_author"].Value = Author ; 
                        cmd.Parameters["@p_final"].Value = DBNull.Value;
                        cmd.Parameters["@p_regdate"].Value = RegistrationDate ;
                        cmd.Parameters["@p_comment"].Value = sqldr_info.GetValue(sqldr_info.GetOrdinal("Comments"));
                        cmd.Parameters["@p_viqgui"].Value = sqldr_info.GetValue(sqldr_info.GetOrdinal("VIQGUI"));
                        cmd.Parameters["@p_numofq"].Value = sqldr_info.GetValue(sqldr_info.GetOrdinal("NumOfQuestions"));
                        
             
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e2)
                    {
                        if (e2.Message.IndexOf("duplicate") >= 0)
                        {
                            throw new Exception(string.Format ("Questionnaire {0} Author {1} @{2} hase been already transferred",Title,Author,RegistrationDate  ));

                        }
                    
                        throw e2;
                    }









                    sqldr_info.Close();    



                    System.Data.SqlClient.SqlCommand sourcecmd_viq = new System.Data.SqlClient.SqlCommand();
                    sourcecmd_viq.Connection = SourceConnection;
                    sourcecmd_viq.CommandText = "SELECT * FROM VIQ where QId =@p0";
                    sourcecmd_viq.Parameters.Add("@p0", SqlDbType.Int);
                    sourcecmd_viq.Parameters[0].Value = QId;

                   object sp_Title="";
                    object  sp_Author = "";
                    object sp_RegDate = "";
                    object sp_Numquestions = null;

                    System.Data.SqlClient.SqlDataReader sqldr_viq = Questionnaire.GetServerReader(SourceConnection,QId,out sp_Title,out sp_Author, out sp_RegDate,out sp_Numquestions )   ;




                    cmd.Parameters.Clear();
            
            
           
                cmd.CommandText =
                 "INSERT INTO [SMQuestionnaire] ( " +
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
                "[DefaultCode],"+
                "[ParentId],"+
                "[InternalDisplayCode] ) VALUES (@p_qid,@p_objid,@p_objtype,@p_catid,@p_parcatid,@p_glbidx,@p_dl,@p_children,@p_objdescr,@p_comm,@p_displcode,@p_defcode,@p_parentid,@p_intdisplaycode)";


                
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
                    cmd.Parameters.Add("@p_parentid", SqlDbType.UniqueIdentifier);
                    cmd.Parameters.Add("@p_intdisplaycode", SqlDbType.NVarChar, 64);
                    
                
                while (sqldr_viq.Read ())
                {

                    cmd.Parameters["@p_qid"].Value = QId ;
                    cmd.Parameters["@p_objid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectId"));
                    cmd.Parameters["@p_objtype"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectType")); 
                    cmd.Parameters["@p_catid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("categoryId")); 
                    cmd.Parameters["@p_parcatid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ParentCategoryId")); 
                    cmd.Parameters["@p_glbidx"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("GlobalDisplayIndex"));
                    cmd.Parameters["@p_dl"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("DisplayLevel")); 
                    cmd.Parameters["@p_children"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("Children")); 
                    cmd.Parameters["@p_objdescr"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectDescription"));
                    cmd.Parameters["@p_comm"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ObjectComments")); 
                    cmd.Parameters["@p_displcode"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("DisplayCode")); 
                    cmd.Parameters["@p_defcode"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("DefaultCode"));
                    cmd.Parameters["@p_parentid"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("ParentId"));
                    cmd.Parameters["@p_intdisplaycode"].Value = sqldr_viq.GetValue(sqldr_viq.GetOrdinal("InternalDisplayCode")); 
                    
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


                MessageBox.Show(string.Format("Questionnaire {0} Author {1} @{2} successfuly transferred.", Title, Author, RegistrationDate));
                CETRANS.Commit(); 
                return true;
            }
            catch (Exception e1)
            {
                CETRANS.Rollback();
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                SourceConnection.Close();
                con.Close();

            }



        

        }


        public static bool RemoveQuestionnaire(int qid,string FilePath, string password)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "DELETE  FROM VIQINFO WHERE QID=@pqid";

            cmd.Connection = con;
            cmd.Parameters.Add("@pqid", SqlDbType.Int);
            cmd.Parameters[0].Value = qid;
            try
            {
                cmd.ExecuteNonQuery(); 
                return true;
            }
            catch (Exception e1)
            {

                if (e1.Message.IndexOf("VettingInfo_FK") > 0)
                {
                    MessageBox.Show("Questionnaire cannot be deleted. Relevant atttendances were detected");
                }
                else
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        public static bool LoadQuestionnaires(string FilePath,string password,System.Data.DataTable target)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            try
            {
                con.Open();
            }
            catch (Exception e3)
            {
                throw new Exception("Cannot open Briefcase file { " + FilePath + " }. Invalid or corrupted file");
                
            }
                
                
                SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT * FROM VIQINFO order by registrationdate";

            cmd.Connection = con;
            SqlCeDataAdapter sqlceadap = new SqlCeDataAdapter(cmd);

            try
            {
                int num = 0;
                num=sqlceadap.Fill(target);
                return true;
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        public static bool LoadAllVettingInfos(string FilePath, string password, System.Data.DataTable target)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            try
            {
                con.Open();
            }
            catch (Exception e3)
            {
                throw new Exception("Cannot establish connection. Invalid or corrupted file");
            }
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "SELECT A.*,B.NUMANSWER FROM (SELECT a.*,b.title as QuestionnaireTitle FROM VETTINGINFO a left join VIQInfo b on a.qid=b.qid  )AS A  LEFT JOIN (SELECT VETID,COUNT(*) as NUMANSWER FROM SMVETTING WHERE ANSWER IS NOT NULL GROUP BY VETID) as B ON A.VETID=B.VETID ORDER BY A.VETDATE";

            cmd.Connection = con;
            SqlCeDataAdapter sqlceadap = new SqlCeDataAdapter(cmd);

            try
            {
                int num = 0;
                num = sqlceadap.Fill(target);
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }


        public static int GetVettingStatistics(string FilePath, string password, int vetid,out int total,out float perc_compl)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);
             int answers =0;
             total = 0;
             perc_compl = 0;

            con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = string.Format(" select count(*) from SMVETTING where VETID = {0} and answer is not null", vetid);

            cmd.Connection = con;
            

            try
            {
                
                answers = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.CommandText = string.Format(" select count(*) from SMVETTING where VETID = {0}", vetid);
                total = Convert.ToInt32(cmd.ExecuteScalar());
                perc_compl = (float)answers / (float)total;
                return answers;



                
            }
            catch (Exception e1)
            {
                MessageBox.Show("Cannot retrieve count of answers : "+e1.Message);
                throw e1;
            }
            finally
            {
                con.Close();
            }

        }
        public static bool LoadVettingInfo(string FilePath, string password, System.Data.DataTable target,int vetid)
        {
            string LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", FilePath, password);
            SqlCeConnection con = new SqlCeConnection(LocalConnectionString);

            con.Open();
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = string.Format(" select * from VETTINGINFO where VETID = {0}",vetid);

            cmd.Connection = con;
            SqlCeDataAdapter sqlceadap = new SqlCeDataAdapter(cmd);

            try
            {
                int num = 0;
                num = sqlceadap.Fill(target);
                return true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }


        public static bool SaveSchema(string filepath,string password)
        {
            string connectionstring;
            
            

            
          

            System.Data.SqlServerCe.SqlCeEngine sqlce = new SqlCeEngine();
            sqlce.LocalConnectionString = string.Format("DataSource=\"{0}\";Password='{1}'", filepath,password);
            try
            {
                FileInfo fi = new FileInfo(filepath);
                if (fi.Exists)
                {
                    if (DialogResult.Yes != MessageBox.Show("File already exists. Overwrite ?", "Create briefcase", MessageBoxButtons.YesNo))
                    {
                        return false;

                    }
                    else
                        fi.Delete();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Cannot delete file." +e2.Message);
                return false;
            }

            try
            {
                sqlce.CreateDatabase();
            }
            catch (Exception e3)
            {
                MessageBox.Show("Cannot create new briefcase file."+e3.Message);
                return false;
            }
            //sqlce.Dispose();


            SqlCeConnection con = new SqlCeConnection(sqlce.LocalConnectionString);
            con.Open();

            SqlCeCommand cmd = new SqlCeCommand();
            try
            {



                cmd.CommandText =
                  "CREATE TABLE [Version]( " +
                  "[VersionCode] [nvarchar](1000) NOT NULL " +
                ") ";
                cmd.Connection = con;

                cmd.ExecuteNonQuery(); //create version table

                cmd.CommandText = "Insert into version (VersionCode) values('NullVersion 2009')";
                cmd.ExecuteNonQuery();
                cmd.CommandText =
                "CREATE TABLE [VisitLog]( " +
                "[ValidFromDate] [datetime] ," +
                "[ValidToDate] [datetime] ," +
                "[LastDate] [datetime] ," +
                
                "[VisitNumberLimit] [int], " +
                "[VettingNumberLimit] [int] ," +
                "[QuestionnaireLimit] [int] ," +
                "[VettingNumber] [int] ," +
                "[QuestionnaireNumber] [int] ," +
                "[VisitNumber] [int] " +

                ") ";
                cmd.Connection = con;//create visit log table
                cmd.ExecuteNonQuery();


                cmd.CommandText="Insert into VisitLog (ValidFromdate,ValidToDate,VisitNumber,VisitNumberLimit,VettingNumberLimit)"+
                    "values (@p0,@p1,@p2,@p3,3)";
                DateTime adate = DateTime.Now;
                cmd.Parameters.Add("@p0",SqlDbType.DateTime).Value=adate;
                cmd.Parameters.Add("@p1", SqlDbType.DateTime).Value = adate.AddMonths(1);
                cmd.Parameters.Add("@p2", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@p3", SqlDbType.Int).Value = 30;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();



                cmd.CommandText =
                "CREATE TABLE [SMVetting]( " +
                "[VETId] [int] NOT NULL, " +
                "[ObjectId] [uniqueidentifier] NOT NULL, " +
                "[answer] [nvarchar](5)  NULL, " +
                "[significance] [nvarchar](5)  NULL, " +
                "[comments] [nvarchar](4000) NULL, " +
                "[WithAttachment] [bit] NULL " +
                ") ";
                cmd.Connection = con;

                cmd.ExecuteNonQuery(); //create vetting table

                cmd.CommandText =
                "CREATE TABLE [SMQuestionnaire]( " +
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
                "[DefaultCode] [nvarchar](64) NULL, " +
                "[ParentId] [uniqueidentifier] NULL, " +
                "[InternalDisplayCode] [nvarchar](64)  NULL " +
                ") ";

                cmd.ExecuteNonQuery();
                cmd.CommandText =
                    "ALTER TABLE [SMQuestionnaire] ADD CONSTRAINT QUESTIONNAIRE_PK PRIMARY KEY ([Qid],[ObjectId])";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
                    "CREATE TABLE [VIQInfo](" +
                    "[QId] [int]  PRIMARY KEY," +
                    "[VIQGUI][uniqueidentifier] NULL ,"+
                    "[Title] [nvarchar](128)  NOT NULL," +
                    "[Comments] [nvarchar](4000)  NULL," +
                    "[Author] [nvarchar](256)    NULL," +
                    "[Finalized] [smallint] NULL," +
                    "[RegistrationDate] [datetime] NULL, " +
                    "[NumOfQuestions] [int] NULL "+
                    " )";
                
                cmd.ExecuteNonQuery();


                cmd.CommandText =
                    "ALTER TABLE [SMQuestionnaire] ADD CONSTRAINT QUESTIONNAIRE_FK FOREIGN KEY ([Qid]) REFERENCES VIQINFO (QID) ON DELETE CASCADE";
                cmd.ExecuteNonQuery();


                cmd.CommandText =
                "CREATE TABLE [VettingInfo]( " +
                "[VetId] [int] PRIMARY KEY," +
                "[QId] [int] ," +
                "[InspectorName] [Nvarchar](50) NULL," +
                "[InspectorSirName] [Nvarchar](50) NULL," +
                "[CompanyRepresentativeName] [Nvarchar](64) NOT NULL," +
                "[PortId] [int] NULL," +
                "[Port] [Nvarchar](64) NOT NULL," +
                "[CountryId] [int] NULL," +
                "[Country] [Nvarchar](64) NULL," +
                "[VetDate] [datetime] NOT NULL," +
                "[VetTime] [datetime] NULL," +
                "[Password] [Nvarchar](128) NULL," +
                "[Comments] [Nvarchar](4000) NULL," +
                "[VesselId] [int] NULL," +
                "[VesselName] [Nvarchar](64) NOT NULL," +
                "[VettingCode] [Nvarchar](64) NULL,"+
                "[VetGUI] [uniqueidentifier] NULL," +
                "[InspectionTypeId] [int] NULL"+

                ")"; 
                
                cmd.ExecuteNonQuery();


                cmd.CommandText =
                    "ALTER TABLE [VettingInfo] ADD CONSTRAINT VettingInfo_FK FOREIGN KEY ([Qid]) REFERENCES VIQINFO (QID)";
                cmd.ExecuteNonQuery();

                cmd.CommandText =
               "ALTER TABLE [SMVetting] ADD CONSTRAINT Vetting_VettingInfo_FK FOREIGN KEY ([Vetid]) REFERENCES VETTINGINFO (VETID) ON DELETE CASCADE";
                cmd.ExecuteNonQuery();


                cmd.CommandText =
            "CREATE TABLE [Vessel]( " +
            "[VesselId] [int] PRIMARY KEY," +
            "[VesselName] [Nvarchar](64)NOT NULL," +
            "[IMO] [Nvarchar](32) NULL," +
            "[FLAG][Nvarchar](64) NULL," +
            "[DeliveryDate] [datetime] NULL," +
            "[GrossTonage] [float] NULL," +
            "[DeadWeight] [float]  NULL" +
            ")";

                cmd.ExecuteNonQuery();


                cmd.CommandText =
           "CREATE TABLE [InspectionTypes]( " +
           "[InspectionTypeId] [int] PRIMARY KEY," +
           "[InspectionType] [Nvarchar](64)NOT NULL" +
           ")";

                cmd.ExecuteNonQuery();



                cmd.CommandText =
          "CREATE TABLE [Attachment]( " +
          "[AttachmentId] [uniqueidentifier] PRIMARY KEY," +
          "[AttachmentFileName] [Nvarchar](64)NOT NULL," +
          "[AttachmentPath] [Nvarchar](2000)NOT NULL," +
          "[AttachmentType] [Nvarchar](64)NULL," +
          "[AttachmentFileExtension] [Nvarchar](8) NULL,"+
          "[AttachmentSizeInBytes] [int] NULL"+
          ")";

                cmd.ExecuteNonQuery();

                /*   SOS SOS SOS UNCOMMENT TO CREATE UNIQUE FILE CONSTRAINT
                 * OBSOLETE AS LONG AS EACH ATTACHMENT BY DEFAULT GETS A NEW ID
           cmd.CommandText =
           "ALTER TABLE [Attachment] ADD CONSTRAINT Attachment_UK  UNIQUE ([AttachmentPath])";
          cmd.ExecuteNonQuery();
                */


                cmd.CommandText =
       "CREATE TABLE [ObjectAttachment]( " +
       "[AttachmentId] [uniqueidentifier] not null," +
       "[ObjectId] [uniqueidentifier] NOT NULL," +
       "[VetId] [int] NOT NULL," +
       "[VetGui] [uniqueidentifier] NULL" +
       ")";

                cmd.ExecuteNonQuery();



         cmd.CommandText =
         "ALTER TABLE [ObjectAttachment] ADD CONSTRAINT ObjectAttachment_UK  UNIQUE ([AttachmentId],[ObjectId],[VetId])";
         cmd.ExecuteNonQuery();



                cmd.CommandText =
       "CREATE TABLE [AttachmentInfo]( " +
       "[MainPath] [NVarchar](4000) not null" +
       ")";

                cmd.ExecuteNonQuery();





                return true;


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return false;
            }
            finally
            {

                con.Close();

            }


        }

    }
  
    class tComparer : IComparer
    {
        public static int CountDots(string code)
        {
            int cnt = 0;
            int lidx = code.IndexOf(".");
            while (lidx >= 0)
            {
                cnt++;
                lidx = code.IndexOf(".", lidx + 1);
            }
            return cnt;
        }
        public static string GetlastSection(string code)
        {
            int idx = code.LastIndexOf(".");
            if (idx < 0)
                return code;
            else
                return code.Substring(idx + 1);
        }


        public static int OccuranceOf(string str,char c,int startindex, int count)
        {

            int found = 0;
            int lastidx = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    found++;
                    lastidx = i;
                }
                if (count == found)
                    return lastidx;
            }
            return -1;
        }

        public static int GetSubSection(string section)
        {
            int lidx=-1;
            for (int i = 0; i < section.Length; i++)
            {
                if (!Char.IsNumber(section[i]))
                {
                    lidx = i;
                    break;
                }
            }
            if (lidx == -1)
                return Convert.ToInt32(section);
            return Convert.ToInt32(section.Substring(0,lidx));
        }
        public static string GetSection(string code, int ids)
        {

            int startidx =-1;
            if (ids==1)
                startidx=0;
            else
                startidx=OccuranceOf(code,'.',0,ids-1)+1;
            
            int lastidx=-1;
            if (ids == 1)
            {
                lastidx = OccuranceOf(code,'.', 0, ids);
                if (lastidx < 0)
                    lastidx = code.Length;
            }
            else
            {
                lastidx = OccuranceOf(code,'.', 0, ids);
                if (lastidx < 0)
                    lastidx = code.Length;
            }

            lastidx -=  1;

            return code.Substring(startidx, lastidx +1- startidx);

        }


        public static int GetBase24Int(string acode)
        {
            int sum=0;
            for (int i = 0; i < acode.Length; i++)
            {
                sum += (int)(    (  ((int)acode[acode.Length - (i + 1)] )-48) * Math.Pow(24.0, (double)i));
            }
            return sum;
        }


        public int CompareSection(string sectionx, string sectiony)
        {
            
            try
            {
                int thiscode = Convert.ToInt32(sectionx);
                int othercode = Convert.ToInt32(sectiony);
                if (thiscode < othercode)
                {
                    System.Console.WriteLine(sectionx + Symbol(-1) + sectiony);
                    return -1;
                }
                else if (thiscode == othercode)
                {
                    //System.Console.WriteLine(sectionx + Symbol(0) + sectiony);
                    return 0;
                }
                else
                {
                    System.Console.WriteLine(sectionx + Symbol(1) + sectiony);
                    return 1;
                }
            }
            catch (Exception e1)
            {

                int subsecx = GetSubSection(sectionx);
                int subsecy = GetSubSection(sectiony);

                if (subsecx < subsecy)
                    return -1;
                else if (subsecx > subsecy)
                    return 1;



                if (sectionx.Length > sectiony.Length)
                    sectiony=sectiony.PadRight(sectionx.Length, '0');
                else if (sectiony.Length>sectionx.Length)
                    sectionx=sectionx.PadRight(sectiony.Length, '0');

                int thiscode = GetBase24Int(sectionx);
                int othercode = GetBase24Int(sectiony);
                if (thiscode < othercode)
                {
                    System.Console.WriteLine(sectionx + Symbol(-1) + sectiony);
                    return -1;
                }
                else if (thiscode == othercode)
                {

                    return 0;
                }
                else
                {
                    System.Console.WriteLine(sectionx + Symbol(1) + sectiony);
                    return 1;
                }

            }
        }

        public string Symbol(int result)
        {
            if (result == -1)
                return " < ";
            else if (result == 0)
                return " == ";
            else
                return " > ";
        }
        public int Compare(object x1, object y1)


        {
            DataRow x= (DataRow)x1;
            DataRow y = (DataRow)y1;

            int cntthis = CountDots(x["CategoryCode"].ToString());
            int cntother = CountDots(y["categorycode"].ToString());
            string sectionx = "";
            string sectiony = "";
            string s1 = x["CategoryCode"].ToString();
            string s2 = y["CategoryCode"].ToString();
            if (s1 == "2.1" && s2 == "8C")
            {
                int i = 0;
            }
            
            if (cntthis < cntother)
            {
                bool bsectioncompleted = false;

                int idx = 0;
                while (!bsectioncompleted)
                {
                    if (idx > cntthis)
                        break;
                    sectionx = GetSection(x["CategoryCode"].ToString(), idx + 1);
                    sectiony = GetSection(y["CategoryCode"].ToString(), idx + 1);

                    int compresult = CompareSection(sectionx, sectiony);

                    if (compresult == 0)
                        idx++;
                    else
                    {
                        
                        //System.Console.WriteLine(s1 + Symbol(compresult) + s2);
                        return compresult;
                    }

                }
                System.Console.WriteLine(s1 + Symbol(-1) + s2);
                return -1;
            }
            else if (cntthis == cntother)
            {

                bool bsectioncompleted = false;

                int idx = 0;
                while (!bsectioncompleted)
                {
                    if (idx > cntthis)
                        break;
                    sectionx = GetSection(x["CategoryCode"].ToString(), idx + 1);
                    sectiony = GetSection(y["CategoryCode"].ToString(), idx + 1);

                    int compresult = CompareSection(sectionx, sectiony);

                    if (compresult == 0)
                        idx++;
                    else
                    {
                    //    System.Console.WriteLine(s1 + Symbol(compresult) + s2);
                        return compresult;
                    }

                }
                //System.Console.WriteLine(s1 + Symbol(0) + s2);
                return 0;

                /*
                if (thiscode < othercode)
                    return -1;
                else if (thiscode == othercode)
                    return 0;
                else
                    return 1;
                 */
            }
            else
            {
                bool bsectioncompleted = false;

                int idx = 0;
                while (!bsectioncompleted)
                {
                    if (idx > cntother)
                        break;
                    sectionx = GetSection(x["CategoryCode"].ToString(), idx +1);
                    sectiony = GetSection(y["CategoryCode"].ToString(), idx + 1);

                    int compresult = CompareSection(sectionx, sectiony);

                    if (compresult == 0)
                        idx++;
                    else
                    {
                        //System.Console.WriteLine(s1 + Symbol(compresult) + s2);
                        return compresult;
                    }

                }
                //System.Console.WriteLine(s1 + Symbol(1) + s2);
                return 1;
            }


        }
    }


    class CategoryTag
    {

        public int sortindex { get; set; }
        public DataRow Datarow{get;set;}
       
    }
    public class CategorySelectionSort : IComparer
    {    
        bool IsAscendingOrder = true; 
        #region IComparer Members    
        public int Compare(object x, object y)
        {
            int i = 0;
            if (!IsAscendingOrder)
                return (((y as TreeNode).Tag as CategoryTag).sortindex - ((x as TreeNode).Tag as CategoryTag).sortindex);
            else
                return (((x as TreeNode).Tag as CategoryTag).sortindex - ((y as TreeNode).Tag as CategoryTag).sortindex);
        }    
        public CategorySelectionSort(bool blnIsAscendingOrder)    
        {        IsAscendingOrder = blnIsAscendingOrder;    
        }    
        #endregion
    }

    class CompareDataRow : IComparable<CompareDataRow>
    {
        public DataRow Row;
        public static int CountDots(string code)
        {
            int cnt = 0;
            int lidx = code.IndexOf(".");
            while (lidx >= 0)
            {
                cnt++;
                lidx = code.IndexOf(".",lidx+1);
            }
            return cnt;
        }
        public static string GetlastSection(string code)
        {
            int idx = code.LastIndexOf(".");
            if (idx < 0)
                return code;
            else
                return code.Substring(idx + 1);
        }
        public int CompareTo(CompareDataRow other)
        {



            int cntthis=CountDots(this.Row["CategoryCode"].ToString());
            int cntother=CountDots(other.Row["categorycode"].ToString());
            if (cntthis < cntother)
                return -1;
            else if (cntthis == cntother)
            {
                int thiscode = Convert.ToInt32(GetlastSection(this.Row["CategoryCode"].ToString()));
                int othercode = Convert.ToInt32(GetlastSection(other.Row["CategoryCode"].ToString()));
                if (thiscode < othercode)
                    return -1;
                else if (thiscode == othercode)
                    return 0;
                else
                    return 1;
            }
            else
                return cntother;


            

            

            int level = -1;
            int parentid = -1;
            int gparentid = -1;
            int ggparentid = -1;
            int gggparentid = -1;
        }
    }
        
    }


 



