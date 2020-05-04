namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            {
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigatorAddNewCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_deletecustomquestion = new System.Windows.Forms.ToolStripButton();
            this.lb_activemng_category = new System.Windows.Forms.Label();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ModeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpliVerical1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbctrl_categories = new System.Windows.Forms.TabControl();
            this.tabPageCategoryList = new System.Windows.Forms.TabPage();
            this.dataGridView_category = new System.Windows.Forms.DataGridView();
            this.categoryCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDisplayCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDisplayIndexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendToQuestionnaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryForSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_filtercode = new System.Windows.Forms.TextBox();
            this.bindingNavigatorCategory = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteCategory = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton_category = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageCategoryTree = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Report = new System.Windows.Forms.Button();
            this.lb_reportfrom = new System.Windows.Forms.Label();
            this.cmb_fleetselection = new System.Windows.Forms.ComboBox();
            this.chb_ranksort = new System.Windows.Forms.CheckBox();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.chb_reportpercentage = new System.Windows.Forms.CheckBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.lb_reportto = new System.Windows.Forms.Label();
            this.chb_subcategories = new System.Windows.Forms.CheckBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tv_vessels = new System.Windows.Forms.TreeView();
            this.contextMenuStripClearTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllSubnodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllTopNodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tv_categories = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip_Designer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSIREQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadManagQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.viewContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.clearDesignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_Notifier = new System.Windows.Forms.Panel();
            this.chb_autoupdate = new System.Windows.Forms.CheckBox();
            this.lb_registrationreporttime = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_lastregistrationinfo = new System.Windows.Forms.Label();
            this.gb_insert_hiermode = new System.Windows.Forms.GroupBox();
            this.rdb_defaultorder = new System.Windows.Forms.RadioButton();
            this.rdb_companytop = new System.Windows.Forms.RadioButton();
            this.rdb_companybottom = new System.Windows.Forms.RadioButton();
            this.chb_viewmanag = new System.Windows.Forms.CheckBox();
            this.chb_viewsire = new System.Windows.Forms.CheckBox();
            this.chb_autodisplaycode = new System.Windows.Forms.CheckBox();
            this.gb_inserttodesignermode = new System.Windows.Forms.GroupBox();
            this.chb_hierarchical = new System.Windows.Forms.CheckBox();
            this.chb_cascade = new System.Windows.Forms.CheckBox();
            this.rdb_sibling = new System.Windows.Forms.RadioButton();
            this.rdb_children = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_fontsize = new System.Windows.Forms.ComboBox();
            this.lb_movenode = new System.Windows.Forms.Label();
            this.chb_showrelation = new System.Windows.Forms.CheckBox();
            this.bt_down = new System.Windows.Forms.Button();
            this.bt_up = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Attendance_DropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.AttendanceView_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vesselsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionnaire_DropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExcelQuestionnaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.viewOriginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.briefCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Reports_DropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.CriticalReport_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report_categoryAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateRelationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.showRegistrationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildCategoryDisplayOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerQuestions = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.chb_OriginFilter = new System.Windows.Forms.CheckBox();
            this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
            this.questionnaireOriginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_activesire_category = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_question = new System.Windows.Forms.DataGridView();
            this.questionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questioncodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryNewIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorChanges = new System.Windows.Forms.ToolStripSeparator();
            this.toQuestionnaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.relatedContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToChangeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryQuestionPoolNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_historicaldata = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sirequestion_comment = new System.Windows.Forms.TextBox();
            this.lb_relquestion_code = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingNavigatorSireQuestion = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewSireItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteSireQuestionItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveSireToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGrid_ourquestion = new System.Windows.Forms.DataGridView();
            this.questionidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questioncodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCodeDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNewIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryQuestionPoolNewCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_rel_questioncompany_code = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mngcomments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorQuestion = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigator_CompanyInsertToolstripbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_savecustom = new System.Windows.Forms.ToolStripButton();
            this.cmenu_report = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView_Category = new System.Windows.Forms.TreeView();
            this.dataGrid_Questions = new System.Windows.Forms.DataGridView();
            this.categoryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDisplayCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDisplayIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionPoolNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.QuestionPoolNewCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SpliVerical1.Panel1.SuspendLayout();
            this.SpliVerical1.Panel2.SuspendLayout();
            this.SpliVerical1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tbctrl_categories.SuspendLayout();
            this.tabPageCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCategory)).BeginInit();
            this.bindingNavigatorCategory.SuspendLayout();
            this.tabPageCategoryTree.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.contextMenuStripClearTree.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip_Designer.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_Notifier.SuspendLayout();
            this.gb_insert_hiermode.SuspendLayout();
            this.gb_inserttodesignermode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.splitContainerQuestions.Panel1.SuspendLayout();
            this.splitContainerQuestions.Panel2.SuspendLayout();
            this.splitContainerQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireOriginBindingSource)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_question)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryQuestionPoolNewBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSireQuestion)).BeginInit();
            this.bindingNavigatorSireQuestion.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ourquestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryQuestionPoolNewCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorQuestion)).BeginInit();
            this.bindingNavigatorQuestion.SuspendLayout();
            this.cmenu_report.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionPoolNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPoolNewCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorAddNewCategory
            // 
            this.bindingNavigatorAddNewCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewCategory.Image")));
            this.bindingNavigatorAddNewCategory.Name = "bindingNavigatorAddNewCategory";
            this.bindingNavigatorAddNewCategory.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewCategory.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewCategory.Text = "Add new";
            // 
            // toolStripButton_deletecustomquestion
            // 
            this.toolStripButton_deletecustomquestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_deletecustomquestion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_deletecustomquestion.Image")));
            this.toolStripButton_deletecustomquestion.Name = "toolStripButton_deletecustomquestion";
            this.toolStripButton_deletecustomquestion.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_deletecustomquestion.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_deletecustomquestion.Text = "Delete";
            this.toolStripButton_deletecustomquestion.Click += new System.EventHandler(this.bindingNavigator_DeleteQuestion_Item_Click);
            // 
            // lb_activemng_category
            // 
            this.lb_activemng_category.AutoSize = true;
            this.lb_activemng_category.BackColor = System.Drawing.Color.White;
            this.lb_activemng_category.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "CategoryDescription", true));
            this.lb_activemng_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activemng_category.Location = new System.Drawing.Point(235, 27);
            this.lb_activemng_category.Name = "lb_activemng_category";
            this.lb_activemng_category.Size = new System.Drawing.Size(104, 13);
            this.lb_activemng_category.TabIndex = 10;
            this.lb_activemng_category.Text = "Related category";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.attendanceBindingSource;
            this.categoryBindingSource.Sort = "";
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataSource = this.attendance;
            this.attendanceBindingSource.Position = 0;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 782);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ModeLabel
            // 
            this.ModeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // SpliVerical1
            // 
            this.SpliVerical1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpliVerical1.Location = new System.Drawing.Point(0, 0);
            this.SpliVerical1.Name = "SpliVerical1";
            this.SpliVerical1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpliVerical1.Panel1
            // 
            this.SpliVerical1.Panel1.Controls.Add(this.splitContainer2);
            this.SpliVerical1.Panel1.Controls.Add(this.panel_top);
            this.SpliVerical1.Panel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // SpliVerical1.Panel2
            // 
            this.SpliVerical1.Panel2.Controls.Add(this.splitContainerQuestions);
            this.SpliVerical1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.SpliVerical1.Size = new System.Drawing.Size(1067, 782);
            this.SpliVerical1.SplitterDistance = 501;
            this.SpliVerical1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(5, 107);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbctrl_categories);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeView1);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Size = new System.Drawing.Size(1057, 394);
            this.splitContainer2.SplitterDistance = 1021;
            this.splitContainer2.TabIndex = 1;
            // 
            // tbctrl_categories
            // 
            this.tbctrl_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctrl_categories.Controls.Add(this.tabPageCategoryList);
            this.tbctrl_categories.Controls.Add(this.tabPageCategoryTree);
            this.tbctrl_categories.Location = new System.Drawing.Point(6, 39);
            this.tbctrl_categories.Name = "tbctrl_categories";
            this.tbctrl_categories.SelectedIndex = 0;
            this.tbctrl_categories.Size = new System.Drawing.Size(1018, 350);
            this.tbctrl_categories.TabIndex = 10;
            this.tbctrl_categories.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbctrl_categories_Selecting);
            this.tbctrl_categories.SelectedIndexChanged += new System.EventHandler(this.tbctrl_categories_SelectedIndexChanged);
            // 
            // tabPageCategoryList
            // 
            this.tabPageCategoryList.Controls.Add(this.dataGridView_category);
            this.tabPageCategoryList.Controls.Add(this.label9);
            this.tabPageCategoryList.Controls.Add(this.tb_filtercode);
            this.tabPageCategoryList.Controls.Add(this.bindingNavigatorCategory);
            this.tabPageCategoryList.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategoryList.Name = "tabPageCategoryList";
            this.tabPageCategoryList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategoryList.Size = new System.Drawing.Size(1010, 324);
            this.tabPageCategoryList.TabIndex = 0;
            this.tabPageCategoryList.Text = "List";
            this.tabPageCategoryList.UseVisualStyleBackColor = true;
            // 
            // dataGridView_category
            // 
            this.dataGridView_category.AllowUserToAddRows = false;
            this.dataGridView_category.AllowUserToResizeRows = false;
            this.dataGridView_category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_category.AutoGenerateColumns = false;
            this.dataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryCodeDataGridViewTextBoxColumn1,
            this.categoryDescriptionDataGridViewTextBoxColumn1,
            this.categoryDisplayCodeDataGridViewTextBoxColumn1,
            this.categoryIDDataGridViewTextBoxColumn1,
            this.categoryDisplayIndexDataGridViewTextBoxColumn1});
            this.dataGridView_category.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView_category.DataSource = this.categoryBindingSource;
            this.dataGridView_category.Location = new System.Drawing.Point(11, 40);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.Size = new System.Drawing.Size(993, 278);
            this.dataGridView_category.StandardTab = true;
            this.dataGridView_category.TabIndex = 1;
            this.dataGridView_category.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_category_RowValidating);
            // 
            // categoryCodeDataGridViewTextBoxColumn1
            // 
            this.categoryCodeDataGridViewTextBoxColumn1.DataPropertyName = "CategoryCode";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCodeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.categoryCodeDataGridViewTextBoxColumn1.Frozen = true;
            this.categoryCodeDataGridViewTextBoxColumn1.HeaderText = "Def.Code";
            this.categoryCodeDataGridViewTextBoxColumn1.Name = "categoryCodeDataGridViewTextBoxColumn1";
            // 
            // categoryDescriptionDataGridViewTextBoxColumn1
            // 
            this.categoryDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "CategoryDescription";
            this.categoryDescriptionDataGridViewTextBoxColumn1.HeaderText = "CategoryDescription";
            this.categoryDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 300;
            this.categoryDescriptionDataGridViewTextBoxColumn1.Name = "categoryDescriptionDataGridViewTextBoxColumn1";
            this.categoryDescriptionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.categoryDescriptionDataGridViewTextBoxColumn1.Width = 400;
            // 
            // categoryDisplayCodeDataGridViewTextBoxColumn1
            // 
            this.categoryDisplayCodeDataGridViewTextBoxColumn1.DataPropertyName = "CategoryDisplayCode";
            this.categoryDisplayCodeDataGridViewTextBoxColumn1.HeaderText = "Display Code";
            this.categoryDisplayCodeDataGridViewTextBoxColumn1.Name = "categoryDisplayCodeDataGridViewTextBoxColumn1";
            this.categoryDisplayCodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.categoryDisplayCodeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryIDDataGridViewTextBoxColumn1
            // 
            this.categoryIDDataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn1.Name = "categoryIDDataGridViewTextBoxColumn1";
            this.categoryIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.categoryIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryDisplayIndexDataGridViewTextBoxColumn1
            // 
            this.categoryDisplayIndexDataGridViewTextBoxColumn1.DataPropertyName = "CategoryDisplayIndex";
            this.categoryDisplayIndexDataGridViewTextBoxColumn1.HeaderText = "CategoryDisplayIndex";
            this.categoryDisplayIndexDataGridViewTextBoxColumn1.Name = "categoryDisplayIndexDataGridViewTextBoxColumn1";
            this.categoryDisplayIndexDataGridViewTextBoxColumn1.Visible = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToQuestionnaireToolStripMenuItem,
            this.clearChangesToolStripMenuItem,
            this.categoryForSelectionToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(195, 70);
            // 
            // sendToQuestionnaireToolStripMenuItem
            // 
            this.sendToQuestionnaireToolStripMenuItem.Name = "sendToQuestionnaireToolStripMenuItem";
            this.sendToQuestionnaireToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.sendToQuestionnaireToolStripMenuItem.Tag = "SendToDesigner";
            this.sendToQuestionnaireToolStripMenuItem.Text = "Send To Questionnaire";
            this.sendToQuestionnaireToolStripMenuItem.Click += new System.EventHandler(this.sendToQuestionnaireToolStripMenuItem_Click);
            // 
            // clearChangesToolStripMenuItem
            // 
            this.clearChangesToolStripMenuItem.Name = "clearChangesToolStripMenuItem";
            this.clearChangesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.clearChangesToolStripMenuItem.Tag = "ClearChangesCategory";
            this.clearChangesToolStripMenuItem.Text = "Clear Changes";
            this.clearChangesToolStripMenuItem.Click += new System.EventHandler(this.clearChangesToolStripMenuItem_Click);
            // 
            // categoryForSelectionToolStripMenuItem
            // 
            this.categoryForSelectionToolStripMenuItem.Name = "categoryForSelectionToolStripMenuItem";
            this.categoryForSelectionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.categoryForSelectionToolStripMenuItem.Tag = "TargetCategorySelect";
            this.categoryForSelectionToolStripMenuItem.Text = "Category for selection";
            this.categoryForSelectionToolStripMenuItem.Click += new System.EventHandler(this.categoryForSelectionToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Filter Def. Code";
            // 
            // tb_filtercode
            // 
            this.tb_filtercode.Location = new System.Drawing.Point(412, 3);
            this.tb_filtercode.Name = "tb_filtercode";
            this.tb_filtercode.Size = new System.Drawing.Size(107, 20);
            this.tb_filtercode.TabIndex = 8;
            this.tb_filtercode.TextChanged += new System.EventHandler(this.tb_filtercode_TextChanged);
            // 
            // bindingNavigatorCategory
            // 
            this.bindingNavigatorCategory.AddNewItem = null;
            this.bindingNavigatorCategory.BindingSource = this.categoryBindingSource;
            this.bindingNavigatorCategory.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorCategory.DeleteItem = null;
            this.bindingNavigatorCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewCategory,
            this.bindingNavigatorDeleteCategory,
            this.saveToolStripButton_category,
            this.toolStripSeparator6});
            this.bindingNavigatorCategory.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigatorCategory.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorCategory.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorCategory.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorCategory.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorCategory.Name = "bindingNavigatorCategory";
            this.bindingNavigatorCategory.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorCategory.Size = new System.Drawing.Size(1004, 25);
            this.bindingNavigatorCategory.TabIndex = 2;
            this.bindingNavigatorCategory.Text = "bindingNavigator2";
            this.bindingNavigatorCategory.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bindingNavigatorCategory_ItemClicked);
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteCategory
            // 
            this.bindingNavigatorDeleteCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteCategory.Image")));
            this.bindingNavigatorDeleteCategory.Name = "bindingNavigatorDeleteCategory";
            this.bindingNavigatorDeleteCategory.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteCategory.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteCategory.Text = "Delete";
            this.bindingNavigatorDeleteCategory.Click += new System.EventHandler(this.bindingNavigatorDeleteCategory_Click);
            // 
            // saveToolStripButton_category
            // 
            this.saveToolStripButton_category.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton_category.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton_category.Image")));
            this.saveToolStripButton_category.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton_category.Name = "saveToolStripButton_category";
            this.saveToolStripButton_category.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton_category.Tag = "SaveCategory";
            this.saveToolStripButton_category.Text = "&Save";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageCategoryTree
            // 
            this.tabPageCategoryTree.Controls.Add(this.panel6);
            this.tabPageCategoryTree.Controls.Add(this.splitter3);
            this.tabPageCategoryTree.Controls.Add(this.panel4);
            this.tabPageCategoryTree.Controls.Add(this.splitter2);
            this.tabPageCategoryTree.Controls.Add(this.panel3);
            this.tabPageCategoryTree.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategoryTree.Name = "tabPageCategoryTree";
            this.tabPageCategoryTree.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tabPageCategoryTree.Size = new System.Drawing.Size(1010, 324);
            this.tabPageCategoryTree.TabIndex = 1;
            this.tabPageCategoryTree.Text = "Tree";
            this.tabPageCategoryTree.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(632, 10);
            this.panel6.MinimumSize = new System.Drawing.Size(351, 304);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(378, 304);
            this.panel6.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Report Settings";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Report);
            this.groupBox1.Controls.Add(this.lb_reportfrom);
            this.groupBox1.Controls.Add(this.cmb_fleetselection);
            this.groupBox1.Controls.Add(this.chb_ranksort);
            this.groupBox1.Controls.Add(this.dtp_from);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.chb_reportpercentage);
            this.groupBox1.Controls.Add(this.dtp_to);
            this.groupBox1.Controls.Add(this.lb_reportto);
            this.groupBox1.Controls.Add(this.chb_subcategories);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bt_Report
            // 
            this.bt_Report.Location = new System.Drawing.Point(125, 167);
            this.bt_Report.Name = "bt_Report";
            this.bt_Report.Size = new System.Drawing.Size(75, 23);
            this.bt_Report.TabIndex = 10;
            this.bt_Report.Text = "View Report ";
            this.bt_Report.UseVisualStyleBackColor = true;
            this.bt_Report.Click += new System.EventHandler(this.bt_Report_Click);
            // 
            // lb_reportfrom
            // 
            this.lb_reportfrom.AutoSize = true;
            this.lb_reportfrom.Location = new System.Drawing.Point(11, 57);
            this.lb_reportfrom.Name = "lb_reportfrom";
            this.lb_reportfrom.Size = new System.Drawing.Size(108, 13);
            this.lb_reportfrom.TabIndex = 3;
            this.lb_reportfrom.Text = "Reporting period from";
            this.lb_reportfrom.Visible = false;
            // 
            // cmb_fleetselection
            // 
            this.cmb_fleetselection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fleetselection.FormattingEnabled = true;
            this.cmb_fleetselection.Items.AddRange(new object[] {
            "Both",
            "IONIA",
            "GRACE"});
            this.cmb_fleetselection.Location = new System.Drawing.Point(124, 30);
            this.cmb_fleetselection.Name = "cmb_fleetselection";
            this.cmb_fleetselection.Size = new System.Drawing.Size(88, 21);
            this.cmb_fleetselection.TabIndex = 2;
            this.cmb_fleetselection.SelectedIndexChanged += new System.EventHandler(this.cmb_fleetselection_SelectedIndexChanged);
            // 
            // chb_ranksort
            // 
            this.chb_ranksort.AutoSize = true;
            this.chb_ranksort.Location = new System.Drawing.Point(125, 111);
            this.chb_ranksort.Name = "chb_ranksort";
            this.chb_ranksort.Size = new System.Drawing.Size(72, 17);
            this.chb_ranksort.TabIndex = 7;
            this.chb_ranksort.Text = "Rank sort";
            this.chb_ranksort.UseVisualStyleBackColor = true;
            // 
            // dtp_from
            // 
            this.dtp_from.Checked = false;
            this.dtp_from.CustomFormat = "dd/MM/yyyy";
            this.dtp_from.Enabled = false;
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from.Location = new System.Drawing.Point(124, 57);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.ShowCheckBox = true;
            this.dtp_from.Size = new System.Drawing.Size(96, 20);
            this.dtp_from.TabIndex = 5;
            this.dtp_from.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fast  Vessel select";
            // 
            // chb_reportpercentage
            // 
            this.chb_reportpercentage.AutoSize = true;
            this.chb_reportpercentage.Location = new System.Drawing.Point(125, 134);
            this.chb_reportpercentage.Name = "chb_reportpercentage";
            this.chb_reportpercentage.Size = new System.Drawing.Size(116, 17);
            this.chb_reportpercentage.TabIndex = 8;
            this.chb_reportpercentage.Text = "Report Percentage";
            this.chb_reportpercentage.UseVisualStyleBackColor = true;
            this.chb_reportpercentage.Visible = false;
            // 
            // dtp_to
            // 
            this.dtp_to.Checked = false;
            this.dtp_to.CustomFormat = "dd/MM/yyyy";
            this.dtp_to.Enabled = false;
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(249, 57);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.ShowCheckBox = true;
            this.dtp_to.Size = new System.Drawing.Size(96, 20);
            this.dtp_to.TabIndex = 4;
            this.dtp_to.Visible = false;
            // 
            // lb_reportto
            // 
            this.lb_reportto.AutoSize = true;
            this.lb_reportto.Location = new System.Drawing.Point(227, 57);
            this.lb_reportto.Name = "lb_reportto";
            this.lb_reportto.Size = new System.Drawing.Size(16, 13);
            this.lb_reportto.TabIndex = 9;
            this.lb_reportto.Text = "to";
            this.lb_reportto.Visible = false;
            // 
            // chb_subcategories
            // 
            this.chb_subcategories.AutoSize = true;
            this.chb_subcategories.Location = new System.Drawing.Point(125, 92);
            this.chb_subcategories.Name = "chb_subcategories";
            this.chb_subcategories.Size = new System.Drawing.Size(118, 17);
            this.chb_subcategories.TabIndex = 6;
            this.chb_subcategories.Text = "View subcategories";
            this.chb_subcategories.UseVisualStyleBackColor = true;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.Silver;
            this.splitter3.Location = new System.Drawing.Point(629, 10);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 304);
            this.splitter3.TabIndex = 17;
            this.splitter3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.tv_vessels);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(345, 10);
            this.panel4.MinimumSize = new System.Drawing.Size(120, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.panel4.Size = new System.Drawing.Size(284, 304);
            this.panel4.TabIndex = 16;
            // 
            // tv_vessels
            // 
            this.tv_vessels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tv_vessels.CheckBoxes = true;
            this.tv_vessels.ContextMenuStrip = this.contextMenuStripClearTree;
            this.tv_vessels.Cursor = System.Windows.Forms.Cursors.Default;
            this.tv_vessels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_vessels.Location = new System.Drawing.Point(5, 20);
            this.tv_vessels.Name = "tv_vessels";
            this.tv_vessels.Size = new System.Drawing.Size(274, 284);
            this.tv_vessels.TabIndex = 0;
            // 
            // contextMenuStripClearTree
            // 
            this.contextMenuStripClearTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UncheckAllToolStripMenuItem,
            this.checkAllSubnodesToolStripMenuItem,
            this.checkAllTopNodesToolStripMenuItem});
            this.contextMenuStripClearTree.Name = "contextMenuStripClearTree";
            this.contextMenuStripClearTree.Size = new System.Drawing.Size(186, 70);
            // 
            // UncheckAllToolStripMenuItem
            // 
            this.UncheckAllToolStripMenuItem.Name = "UncheckAllToolStripMenuItem";
            this.UncheckAllToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.UncheckAllToolStripMenuItem.Text = "Uncheck All";
            this.UncheckAllToolStripMenuItem.Click += new System.EventHandler(this.UncheckAllToolStripMenuItem_Click);
            // 
            // checkAllSubnodesToolStripMenuItem
            // 
            this.checkAllSubnodesToolStripMenuItem.Name = "checkAllSubnodesToolStripMenuItem";
            this.checkAllSubnodesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.checkAllSubnodesToolStripMenuItem.Text = "Check All subnodes";
            this.checkAllSubnodesToolStripMenuItem.Visible = false;
            this.checkAllSubnodesToolStripMenuItem.Click += new System.EventHandler(this.checkAllSubnodesToolStripMenuItem_Click);
            // 
            // checkAllTopNodesToolStripMenuItem
            // 
            this.checkAllTopNodesToolStripMenuItem.Name = "checkAllTopNodesToolStripMenuItem";
            this.checkAllTopNodesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.checkAllTopNodesToolStripMenuItem.Text = "Check All Top Nodes";
            this.checkAllTopNodesToolStripMenuItem.Click += new System.EventHandler(this.checkAllTopNodesToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Vessels";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Silver;
            this.splitter2.Location = new System.Drawing.Point(342, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 304);
            this.splitter2.TabIndex = 15;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.tv_categories);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 20, 10, 0);
            this.panel3.Size = new System.Drawing.Size(342, 304);
            this.panel3.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Categories";
            // 
            // tv_categories
            // 
            this.tv_categories.CheckBoxes = true;
            this.tv_categories.ContextMenuStrip = this.contextMenuStripClearTree;
            this.tv_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_categories.Location = new System.Drawing.Point(10, 20);
            this.tv_categories.Name = "tv_categories";
            this.tv_categories.Size = new System.Drawing.Size(322, 284);
            this.tv_categories.TabIndex = 0;
            this.tv_categories.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_categories_NodeMouseDoubleClick);
            this.tv_categories.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_categories_AfterCheck);
            this.tv_categories.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_categories_BeforeCollapse);
            this.tv_categories.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_categories_BeforeCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categories";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip_Designer;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 3;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(5, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(22, 384);
            this.treeView1.TabIndex = 0;
            this.treeView1.Visible = false;
            this.treeView1.DragLeave += new System.EventHandler(this.treeView1_DragLeave);
            this.treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeView1_DrawNode);
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseUp);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
            // 
            // contextMenuStrip_Designer
            // 
            this.contextMenuStrip_Designer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCategoriesToolStripMenuItem,
            this.loadSIREQuestionsToolStripMenuItem,
            this.loadManagQuestionsToolStripMenuItem,
            this.toolStripSeparator8,
            this.viewContextToolStripMenuItem,
            this.toolStripSeparator9,
            this.clearDesignerToolStripMenuItem});
            this.contextMenuStrip_Designer.Name = "contextMenuStrip_Designer";
            this.contextMenuStrip_Designer.Size = new System.Drawing.Size(201, 126);
            this.contextMenuStrip_Designer.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_Designer_ItemClicked);
            // 
            // loadCategoriesToolStripMenuItem
            // 
            this.loadCategoriesToolStripMenuItem.Name = "loadCategoriesToolStripMenuItem";
            this.loadCategoriesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.loadCategoriesToolStripMenuItem.Tag = "load_cat";
            this.loadCategoriesToolStripMenuItem.Text = "Insert Categories";
            // 
            // loadSIREQuestionsToolStripMenuItem
            // 
            this.loadSIREQuestionsToolStripMenuItem.Name = "loadSIREQuestionsToolStripMenuItem";
            this.loadSIREQuestionsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.loadSIREQuestionsToolStripMenuItem.Tag = "load_sire";
            this.loadSIREQuestionsToolStripMenuItem.Text = "Insert SIRE questions";
            // 
            // loadManagQuestionsToolStripMenuItem
            // 
            this.loadManagQuestionsToolStripMenuItem.Name = "loadManagQuestionsToolStripMenuItem";
            this.loadManagQuestionsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.loadManagQuestionsToolStripMenuItem.Tag = "load_mng";
            this.loadManagQuestionsToolStripMenuItem.Text = "Insert Manag. questions";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(197, 6);
            // 
            // viewContextToolStripMenuItem
            // 
            this.viewContextToolStripMenuItem.Name = "viewContextToolStripMenuItem";
            this.viewContextToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.viewContextToolStripMenuItem.Tag = "view_ctx";
            this.viewContextToolStripMenuItem.Text = "View Context ...";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(197, 6);
            // 
            // clearDesignerToolStripMenuItem
            // 
            this.clearDesignerToolStripMenuItem.Name = "clearDesignerToolStripMenuItem";
            this.clearDesignerToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.clearDesignerToolStripMenuItem.Tag = "DesignerClear";
            this.clearDesignerToolStripMenuItem.Text = "Clear Designer";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Ionia.jpeg");
            this.imageList1.Images.SetKeyName(1, "category-folder.png");
            this.imageList1.Images.SetKeyName(2, "question.jpg");
            this.imageList1.Images.SetKeyName(3, "global.png");
            this.imageList1.Images.SetKeyName(4, "ourquestion.JPG");
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_top.Controls.Add(this.panel_Notifier);
            this.panel_top.Controls.Add(this.gb_insert_hiermode);
            this.panel_top.Controls.Add(this.chb_viewmanag);
            this.panel_top.Controls.Add(this.chb_viewsire);
            this.panel_top.Controls.Add(this.chb_autodisplaycode);
            this.panel_top.Controls.Add(this.gb_inserttodesignermode);
            this.panel_top.Controls.Add(this.label8);
            this.panel_top.Controls.Add(this.cmb_fontsize);
            this.panel_top.Controls.Add(this.lb_movenode);
            this.panel_top.Controls.Add(this.chb_showrelation);
            this.panel_top.Controls.Add(this.bt_down);
            this.panel_top.Controls.Add(this.bt_up);
            this.panel_top.Controls.Add(this.menuStrip1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(5, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1057, 107);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // panel_Notifier
            // 
            this.panel_Notifier.Controls.Add(this.chb_autoupdate);
            this.panel_Notifier.Controls.Add(this.lb_registrationreporttime);
            this.panel_Notifier.Controls.Add(this.label16);
            this.panel_Notifier.Controls.Add(this.label15);
            this.panel_Notifier.Controls.Add(this.lb_lastregistrationinfo);
            this.panel_Notifier.Location = new System.Drawing.Point(241, 41);
            this.panel_Notifier.Name = "panel_Notifier";
            this.panel_Notifier.Size = new System.Drawing.Size(298, 43);
            this.panel_Notifier.TabIndex = 16;
            this.panel_Notifier.Visible = false;
            // 
            // chb_autoupdate
            // 
            this.chb_autoupdate.AutoSize = true;
            this.chb_autoupdate.Location = new System.Drawing.Point(225, 3);
            this.chb_autoupdate.Name = "chb_autoupdate";
            this.chb_autoupdate.Size = new System.Drawing.Size(48, 17);
            this.chb_autoupdate.TabIndex = 4;
            this.chb_autoupdate.Text = "Auto";
            this.chb_autoupdate.UseVisualStyleBackColor = true;
            // 
            // lb_registrationreporttime
            // 
            this.lb_registrationreporttime.BackColor = System.Drawing.Color.White;
            this.lb_registrationreporttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lb_registrationreporttime.Location = new System.Drawing.Point(90, 3);
            this.lb_registrationreporttime.Name = "lb_registrationreporttime";
            this.lb_registrationreporttime.Size = new System.Drawing.Size(128, 15);
            this.lb_registrationreporttime.TabIndex = 3;
            this.lb_registrationreporttime.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Last registration";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Report time :";
            // 
            // lb_lastregistrationinfo
            // 
            this.lb_lastregistrationinfo.AutoSize = true;
            this.lb_lastregistrationinfo.BackColor = System.Drawing.Color.White;
            this.lb_lastregistrationinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lb_lastregistrationinfo.Location = new System.Drawing.Point(90, 24);
            this.lb_lastregistrationinfo.Name = "lb_lastregistrationinfo";
            this.lb_lastregistrationinfo.Size = new System.Drawing.Size(48, 13);
            this.lb_lastregistrationinfo.TabIndex = 0;
            this.lb_lastregistrationinfo.Text = "label15";
            // 
            // gb_insert_hiermode
            // 
            this.gb_insert_hiermode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gb_insert_hiermode.Controls.Add(this.rdb_defaultorder);
            this.gb_insert_hiermode.Controls.Add(this.rdb_companytop);
            this.gb_insert_hiermode.Controls.Add(this.rdb_companybottom);
            this.gb_insert_hiermode.Enabled = false;
            this.gb_insert_hiermode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_insert_hiermode.Location = new System.Drawing.Point(228, 46);
            this.gb_insert_hiermode.Name = "gb_insert_hiermode";
            this.gb_insert_hiermode.Size = new System.Drawing.Size(353, 38);
            this.gb_insert_hiermode.TabIndex = 14;
            this.gb_insert_hiermode.TabStop = false;
            this.gb_insert_hiermode.Text = "Import Mode";
            // 
            // rdb_defaultorder
            // 
            this.rdb_defaultorder.AutoSize = true;
            this.rdb_defaultorder.Checked = true;
            this.rdb_defaultorder.Location = new System.Drawing.Point(269, 15);
            this.rdb_defaultorder.Name = "rdb_defaultorder";
            this.rdb_defaultorder.Size = new System.Drawing.Size(59, 17);
            this.rdb_defaultorder.TabIndex = 14;
            this.rdb_defaultorder.TabStop = true;
            this.rdb_defaultorder.Text = "Default";
            this.rdb_defaultorder.UseVisualStyleBackColor = true;
            // 
            // rdb_companytop
            // 
            this.rdb_companytop.AutoSize = true;
            this.rdb_companytop.Location = new System.Drawing.Point(13, 15);
            this.rdb_companytop.Name = "rdb_companytop";
            this.rdb_companytop.Size = new System.Drawing.Size(111, 17);
            this.rdb_companytop.TabIndex = 12;
            this.rdb_companytop.Text = "Company\'s On top";
            this.rdb_companytop.UseVisualStyleBackColor = true;
            // 
            // rdb_companybottom
            // 
            this.rdb_companybottom.AutoSize = true;
            this.rdb_companybottom.Location = new System.Drawing.Point(130, 15);
            this.rdb_companybottom.Name = "rdb_companybottom";
            this.rdb_companybottom.Size = new System.Drawing.Size(133, 17);
            this.rdb_companybottom.TabIndex = 13;
            this.rdb_companybottom.Text = "Company\'s underneath";
            this.rdb_companybottom.UseVisualStyleBackColor = true;
            // 
            // chb_viewmanag
            // 
            this.chb_viewmanag.AutoSize = true;
            this.chb_viewmanag.Checked = true;
            this.chb_viewmanag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_viewmanag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_viewmanag.Location = new System.Drawing.Point(68, 50);
            this.chb_viewmanag.Name = "chb_viewmanag";
            this.chb_viewmanag.Size = new System.Drawing.Size(58, 17);
            this.chb_viewmanag.TabIndex = 15;
            this.chb_viewmanag.Text = "MNG.";
            this.chb_viewmanag.UseVisualStyleBackColor = true;
            // 
            // chb_viewsire
            // 
            this.chb_viewsire.AutoSize = true;
            this.chb_viewsire.Checked = true;
            this.chb_viewsire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_viewsire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_viewsire.Location = new System.Drawing.Point(7, 50);
            this.chb_viewsire.Name = "chb_viewsire";
            this.chb_viewsire.Size = new System.Drawing.Size(55, 17);
            this.chb_viewsire.TabIndex = 14;
            this.chb_viewsire.Text = "SIRE";
            this.chb_viewsire.UseVisualStyleBackColor = true;
            this.chb_viewsire.CheckedChanged += new System.EventHandler(this.chb_viewsire_CheckedChanged);
            // 
            // chb_autodisplaycode
            // 
            this.chb_autodisplaycode.AutoSize = true;
            this.chb_autodisplaycode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_autodisplaycode.Location = new System.Drawing.Point(7, 67);
            this.chb_autodisplaycode.Name = "chb_autodisplaycode";
            this.chb_autodisplaycode.Size = new System.Drawing.Size(140, 17);
            this.chb_autodisplaycode.TabIndex = 13;
            this.chb_autodisplaycode.Text = "Auto Display Coding";
            this.chb_autodisplaycode.UseVisualStyleBackColor = true;
            this.chb_autodisplaycode.CheckedChanged += new System.EventHandler(this.chb_autodisplaycode_CheckedChanged);
            // 
            // gb_inserttodesignermode
            // 
            this.gb_inserttodesignermode.Controls.Add(this.chb_hierarchical);
            this.gb_inserttodesignermode.Controls.Add(this.chb_cascade);
            this.gb_inserttodesignermode.Controls.Add(this.rdb_sibling);
            this.gb_inserttodesignermode.Controls.Add(this.rdb_children);
            this.gb_inserttodesignermode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_inserttodesignermode.Location = new System.Drawing.Point(587, 32);
            this.gb_inserttodesignermode.Name = "gb_inserttodesignermode";
            this.gb_inserttodesignermode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_inserttodesignermode.Size = new System.Drawing.Size(267, 52);
            this.gb_inserttodesignermode.TabIndex = 12;
            this.gb_inserttodesignermode.TabStop = false;
            this.gb_inserttodesignermode.Text = "Insert Mode";
            // 
            // chb_hierarchical
            // 
            this.chb_hierarchical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_hierarchical.AutoSize = true;
            this.chb_hierarchical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_hierarchical.Location = new System.Drawing.Point(81, 9);
            this.chb_hierarchical.Name = "chb_hierarchical";
            this.chb_hierarchical.Size = new System.Drawing.Size(94, 17);
            this.chb_hierarchical.TabIndex = 11;
            this.chb_hierarchical.Text = "Hierarchical";
            this.chb_hierarchical.UseVisualStyleBackColor = true;
            this.chb_hierarchical.CheckedChanged += new System.EventHandler(this.chb_hierarchical_CheckedChanged);
            // 
            // chb_cascade
            // 
            this.chb_cascade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_cascade.AutoSize = true;
            this.chb_cascade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_cascade.Location = new System.Drawing.Point(81, 24);
            this.chb_cascade.Name = "chb_cascade";
            this.chb_cascade.Size = new System.Drawing.Size(75, 17);
            this.chb_cascade.TabIndex = 10;
            this.chb_cascade.Text = "Cascade";
            this.chb_cascade.UseVisualStyleBackColor = true;
            // 
            // rdb_sibling
            // 
            this.rdb_sibling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_sibling.AutoSize = true;
            this.rdb_sibling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_sibling.Location = new System.Drawing.Point(181, 27);
            this.rdb_sibling.Name = "rdb_sibling";
            this.rdb_sibling.Size = new System.Drawing.Size(63, 17);
            this.rdb_sibling.TabIndex = 4;
            this.rdb_sibling.Text = "Sibling";
            this.rdb_sibling.UseVisualStyleBackColor = true;
            this.rdb_sibling.Click += new System.EventHandler(this.rdb_sibling_Click);
            // 
            // rdb_children
            // 
            this.rdb_children.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdb_children.AutoSize = true;
            this.rdb_children.Checked = true;
            this.rdb_children.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_children.Location = new System.Drawing.Point(181, 10);
            this.rdb_children.Name = "rdb_children";
            this.rdb_children.Size = new System.Drawing.Size(71, 17);
            this.rdb_children.TabIndex = 3;
            this.rdb_children.TabStop = true;
            this.rdb_children.Text = "Children";
            this.rdb_children.UseVisualStyleBackColor = true;
            this.rdb_children.Click += new System.EventHandler(this.rdb_children_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Font size";
            // 
            // cmb_fontsize
            // 
            this.cmb_fontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fontsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fontsize.FormattingEnabled = true;
            this.cmb_fontsize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmb_fontsize.Location = new System.Drawing.Point(517, 3);
            this.cmb_fontsize.Name = "cmb_fontsize";
            this.cmb_fontsize.Size = new System.Drawing.Size(50, 21);
            this.cmb_fontsize.TabIndex = 8;
            this.cmb_fontsize.SelectedIndexChanged += new System.EventHandler(this.Event_ComboBoxFont_SelectedIndexChanged);
            // 
            // lb_movenode
            // 
            this.lb_movenode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_movenode.AutoSize = true;
            this.lb_movenode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_movenode.Location = new System.Drawing.Point(985, 27);
            this.lb_movenode.Name = "lb_movenode";
            this.lb_movenode.Size = new System.Drawing.Size(72, 13);
            this.lb_movenode.TabIndex = 7;
            this.lb_movenode.Text = "Move Node";
            // 
            // chb_showrelation
            // 
            this.chb_showrelation.Checked = true;
            this.chb_showrelation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_showrelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_showrelation.Location = new System.Drawing.Point(7, 29);
            this.chb_showrelation.Name = "chb_showrelation";
            this.chb_showrelation.Size = new System.Drawing.Size(208, 24);
            this.chb_showrelation.TabIndex = 5;
            this.chb_showrelation.Text = "Category-question relation";
            this.chb_showrelation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chb_showrelation.UseVisualStyleBackColor = true;
            this.chb_showrelation.CheckStateChanged += new System.EventHandler(this.chb_showrelation_CheckStateChanged);
            // 
            // bt_down
            // 
            this.bt_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_down.BackgroundImage")));
            this.bt_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_down.Location = new System.Drawing.Point(1024, 41);
            this.bt_down.Name = "bt_down";
            this.bt_down.Size = new System.Drawing.Size(30, 30);
            this.bt_down.TabIndex = 1;
            this.bt_down.UseVisualStyleBackColor = true;
            this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
            // 
            // bt_up
            // 
            this.bt_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_up.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_up.BackgroundImage")));
            this.bt_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_up.Location = new System.Drawing.Point(988, 42);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(33, 30);
            this.bt_up.TabIndex = 0;
            this.bt_up.UseVisualStyleBackColor = false;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Attendance_DropDown,
            this.questionnaire_DropDown,
            this.briefCaseToolStripMenuItem,
            this.Reports_DropDown,
            this.functionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Attendance_DropDown
            // 
            this.Attendance_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AttendanceView_MenuItem,
            this.vesselsToolStripMenuItem,
            this.typesToolStripMenuItem});
            this.Attendance_DropDown.Name = "Attendance_DropDown";
            this.Attendance_DropDown.Size = new System.Drawing.Size(80, 20);
            this.Attendance_DropDown.Text = "&Attendance";
            this.Attendance_DropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Attendance_DropDown_DropDownItemClicked);
            // 
            // AttendanceView_MenuItem
            // 
            this.AttendanceView_MenuItem.Name = "AttendanceView_MenuItem";
            this.AttendanceView_MenuItem.Size = new System.Drawing.Size(120, 22);
            this.AttendanceView_MenuItem.Tag = "AttendanceView";
            this.AttendanceView_MenuItem.Text = "&View ...";
            // 
            // vesselsToolStripMenuItem
            // 
            this.vesselsToolStripMenuItem.Name = "vesselsToolStripMenuItem";
            this.vesselsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.vesselsToolStripMenuItem.Tag = "Vessels";
            this.vesselsToolStripMenuItem.Text = "Ve&ssels...";
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.typesToolStripMenuItem.Tag = "InspectionTypes";
            this.typesToolStripMenuItem.Text = "Types ...";
            // 
            // questionnaire_DropDown
            // 
            this.questionnaire_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator7,
            this.clearToolStripMenuItem,
            this.importToolStripMenuItem,
            this.importExcelFileToolStripMenuItem,
            this.importExcelQuestionnaireToolStripMenuItem,
            this.toolStripSeparator12,
            this.viewOriginsToolStripMenuItem});
            this.questionnaire_DropDown.Name = "questionnaire_DropDown";
            this.questionnaire_DropDown.Size = new System.Drawing.Size(93, 20);
            this.questionnaire_DropDown.Text = "&Questionnaire";
            this.questionnaire_DropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.questionnaire_DropDown_DropDownItemClicked);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showToolStripMenuItem.Text = "&View ...";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saveToolStripMenuItem.Tag = "SaveQuestionnaire";
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.loadToolStripMenuItem.Text = "&Load ...";
            this.loadToolStripMenuItem.Visible = false;
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(213, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.clearToolStripMenuItem.Text = "&Clear Designer";
            this.clearToolStripMenuItem.Visible = false;
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.importToolStripMenuItem.Text = "Import objects...";
            this.importToolStripMenuItem.Visible = false;
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // importExcelFileToolStripMenuItem
            // 
            this.importExcelFileToolStripMenuItem.Name = "importExcelFileToolStripMenuItem";
            this.importExcelFileToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.importExcelFileToolStripMenuItem.Text = "Import Excel File...";
            this.importExcelFileToolStripMenuItem.Visible = false;
            this.importExcelFileToolStripMenuItem.Click += new System.EventHandler(this.importExcelFileToolStripMenuItem_Click);
            // 
            // importExcelQuestionnaireToolStripMenuItem
            // 
            this.importExcelQuestionnaireToolStripMenuItem.Name = "importExcelQuestionnaireToolStripMenuItem";
            this.importExcelQuestionnaireToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.importExcelQuestionnaireToolStripMenuItem.Text = "Import Excel Questionnaire";
            this.importExcelQuestionnaireToolStripMenuItem.Visible = false;
            this.importExcelQuestionnaireToolStripMenuItem.Click += new System.EventHandler(this.importExcelQuestionnaireToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(213, 6);
            // 
            // viewOriginsToolStripMenuItem
            // 
            this.viewOriginsToolStripMenuItem.Name = "viewOriginsToolStripMenuItem";
            this.viewOriginsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.viewOriginsToolStripMenuItem.Text = "View Origins ...";
            this.viewOriginsToolStripMenuItem.Click += new System.EventHandler(this.viewOriginsToolStripMenuItem_Click);
            // 
            // briefCaseToolStripMenuItem
            // 
            this.briefCaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.versionToolStripMenuItem});
            this.briefCaseToolStripMenuItem.Name = "briefCaseToolStripMenuItem";
            this.briefCaseToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.briefCaseToolStripMenuItem.Text = "&Briefcase";
            this.briefCaseToolStripMenuItem.Visible = false;
            this.briefCaseToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.briefCaseToolStripMenuItem_DropDownItemClicked);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem.Tag = "NewBriefcase";
            this.openToolStripMenuItem.Text = "&New ...";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.openToolStripMenuItem1.Tag = "OpenBriefcase";
            this.openToolStripMenuItem1.Text = "&Open ...";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.versionToolStripMenuItem.Tag = "versioninfo";
            this.versionToolStripMenuItem.Text = "Version...";
            this.versionToolStripMenuItem.Visible = false;
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // Reports_DropDown
            // 
            this.Reports_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CriticalReport_MenuItem,
            this.report_categoryAnalysisToolStripMenuItem});
            this.Reports_DropDown.Name = "Reports_DropDown";
            this.Reports_DropDown.Size = new System.Drawing.Size(59, 20);
            this.Reports_DropDown.Text = "&Reports";
            this.Reports_DropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Reports_DropDown_DropDownItemClicked);
            // 
            // CriticalReport_MenuItem
            // 
            this.CriticalReport_MenuItem.Name = "CriticalReport_MenuItem";
            this.CriticalReport_MenuItem.Size = new System.Drawing.Size(193, 22);
            this.CriticalReport_MenuItem.Tag = "CriticalReport";
            this.CriticalReport_MenuItem.Text = "&Critical";
            // 
            // report_categoryAnalysisToolStripMenuItem
            // 
            this.report_categoryAnalysisToolStripMenuItem.Enabled = false;
            this.report_categoryAnalysisToolStripMenuItem.Name = "report_categoryAnalysisToolStripMenuItem";
            this.report_categoryAnalysisToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.report_categoryAnalysisToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.report_categoryAnalysisToolStripMenuItem.Text = "Category Analysis";
            this.report_categoryAnalysisToolStripMenuItem.Visible = false;
            this.report_categoryAnalysisToolStripMenuItem.Click += new System.EventHandler(this.report_categoryAnalysisToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToTextToolStripMenuItem,
            this.activateRelationshipToolStripMenuItem,
            this.designerToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.toolStripSeparator10,
            this.showRegistrationInfoToolStripMenuItem,
            this.buildCategoryDisplayOrderToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // exportToTextToolStripMenuItem
            // 
            this.exportToTextToolStripMenuItem.Name = "exportToTextToolStripMenuItem";
            this.exportToTextToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.exportToTextToolStripMenuItem.Text = "Export to text";
            this.exportToTextToolStripMenuItem.Visible = false;
            this.exportToTextToolStripMenuItem.Click += new System.EventHandler(this.exportToTextToolStripMenuItem_Click);
            // 
            // activateRelationshipToolStripMenuItem
            // 
            this.activateRelationshipToolStripMenuItem.Checked = true;
            this.activateRelationshipToolStripMenuItem.CheckOnClick = true;
            this.activateRelationshipToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activateRelationshipToolStripMenuItem.Name = "activateRelationshipToolStripMenuItem";
            this.activateRelationshipToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.activateRelationshipToolStripMenuItem.Text = "Activate Relationship";
            this.activateRelationshipToolStripMenuItem.CheckedChanged += new System.EventHandler(this.activateRelationshipToolStripMenuItem_CheckedChanged);
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.CheckOnClick = true;
            this.designerToolStripMenuItem.Enabled = false;
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.designerToolStripMenuItem.Text = "Designer";
            this.designerToolStripMenuItem.CheckedChanged += new System.EventHandler(this.designerToolStripMenuItem_CheckedChanged);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.connectToolStripMenuItem.Text = "Connect...";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(223, 6);
            // 
            // showRegistrationInfoToolStripMenuItem
            // 
            this.showRegistrationInfoToolStripMenuItem.Name = "showRegistrationInfoToolStripMenuItem";
            this.showRegistrationInfoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.showRegistrationInfoToolStripMenuItem.Text = "Show Registration Info";
            this.showRegistrationInfoToolStripMenuItem.Click += new System.EventHandler(this.showRegistrationInfoToolStripMenuItem_Click);
            // 
            // buildCategoryDisplayOrderToolStripMenuItem
            // 
            this.buildCategoryDisplayOrderToolStripMenuItem.Name = "buildCategoryDisplayOrderToolStripMenuItem";
            this.buildCategoryDisplayOrderToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.buildCategoryDisplayOrderToolStripMenuItem.Text = "Build Category Display Order";
            this.buildCategoryDisplayOrderToolStripMenuItem.Visible = false;
            this.buildCategoryDisplayOrderToolStripMenuItem.Click += new System.EventHandler(this.buildCategoryDisplayOrderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "Abo&ut";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainerQuestions
            // 
            this.splitContainerQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerQuestions.Location = new System.Drawing.Point(5, 5);
            this.splitContainerQuestions.Name = "splitContainerQuestions";
            this.splitContainerQuestions.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerQuestions.Panel1
            // 
            this.splitContainerQuestions.Panel1.Controls.Add(this.label7);
            this.splitContainerQuestions.Panel1.Controls.Add(this.chb_OriginFilter);
            this.splitContainerQuestions.Panel1.Controls.Add(this.comboBoxOrigin);
            this.splitContainerQuestions.Panel1.Controls.Add(this.lb_activesire_category);
            this.splitContainerQuestions.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainerQuestions.Panel1.Controls.Add(this.label2);
            this.splitContainerQuestions.Panel1.Controls.Add(this.bindingNavigatorSireQuestion);
            // 
            // splitContainerQuestions.Panel2
            // 
            this.splitContainerQuestions.Panel2.Controls.Add(this.label10);
            this.splitContainerQuestions.Panel2.Controls.Add(this.lb_activemng_category);
            this.splitContainerQuestions.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainerQuestions.Panel2.Controls.Add(this.label1);
            this.splitContainerQuestions.Panel2.Controls.Add(this.bindingNavigatorQuestion);
            this.splitContainerQuestions.Size = new System.Drawing.Size(1057, 267);
            this.splitContainerQuestions.SplitterDistance = 135;
            this.splitContainerQuestions.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Category:";
            // 
            // chb_OriginFilter
            // 
            this.chb_OriginFilter.AutoSize = true;
            this.chb_OriginFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_OriginFilter.Location = new System.Drawing.Point(343, 6);
            this.chb_OriginFilter.Name = "chb_OriginFilter";
            this.chb_OriginFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chb_OriginFilter.Size = new System.Drawing.Size(91, 17);
            this.chb_OriginFilter.TabIndex = 11;
            this.chb_OriginFilter.Text = "Filter Origin";
            this.chb_OriginFilter.UseVisualStyleBackColor = true;
            this.chb_OriginFilter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.DataSource = this.questionnaireOriginBindingSource;
            this.comboBoxOrigin.DisplayMember = "OriginTitle";
            this.comboBoxOrigin.FormattingEnabled = true;
            this.comboBoxOrigin.Location = new System.Drawing.Point(440, 4);
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(228, 21);
            this.comboBoxOrigin.TabIndex = 10;
            this.comboBoxOrigin.ValueMember = "OriginNo";
            this.comboBoxOrigin.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOrigin_SelectionChangeCommitted);
            // 
            // questionnaireOriginBindingSource
            // 
            this.questionnaireOriginBindingSource.DataMember = "QuestionnaireOrigin";
            this.questionnaireOriginBindingSource.DataSource = this.attendance;
            // 
            // lb_activesire_category
            // 
            this.lb_activesire_category.AutoSize = true;
            this.lb_activesire_category.BackColor = System.Drawing.Color.White;
            this.lb_activesire_category.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryBindingSource, "CategoryDescription", true));
            this.lb_activesire_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activesire_category.Location = new System.Drawing.Point(235, 25);
            this.lb_activesire_category.Name = "lb_activesire_category";
            this.lb_activesire_category.Size = new System.Drawing.Size(104, 13);
            this.lb_activesire_category.TabIndex = 9;
            this.lb_activesire_category.Text = "Related category";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(3, 37);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView_question);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel2);
            this.splitContainer3.Panel2.Controls.Add(this.splitter1);
            this.splitContainer3.Panel2.Controls.Add(this.panel1);
            this.splitContainer3.Size = new System.Drawing.Size(1049, 95);
            this.splitContainer3.SplitterDistance = 742;
            this.splitContainer3.TabIndex = 8;
            // 
            // dataGridView_question
            // 
            this.dataGridView_question.AllowDrop = true;
            this.dataGridView_question.AllowUserToAddRows = false;
            this.dataGridView_question.AllowUserToDeleteRows = false;
            this.dataGridView_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_question.AutoGenerateColumns = false;
            this.dataGridView_question.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_question.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionidDataGridViewTextBoxColumn,
            this.questioncodeDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn2,
            this.categoryCodeDataGridViewTextBoxColumn2,
            this.originDataGridViewTextBoxColumn,
            this.categoryNewIDDataGridViewTextBoxColumn});
            this.dataGridView_question.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_question.DataSource = this.categoryQuestionPoolNewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_question.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_question.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_question.Name = "dataGridView_question";
            this.dataGridView_question.Size = new System.Drawing.Size(735, 88);
            this.dataGridView_question.TabIndex = 4;
            this.dataGridView_question.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_question_RowValidating);
            this.dataGridView_question.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView_question_DragEnter);
            this.dataGridView_question.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_question_DataError);
            this.dataGridView_question.DragLeave += new System.EventHandler(this.dataGridView_question_DragLeave);
            this.dataGridView_question.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView_question_DragDrop);
            // 
            // questionidDataGridViewTextBoxColumn
            // 
            this.questionidDataGridViewTextBoxColumn.DataPropertyName = "questionid";
            this.questionidDataGridViewTextBoxColumn.HeaderText = "questionid";
            this.questionidDataGridViewTextBoxColumn.Name = "questionidDataGridViewTextBoxColumn";
            this.questionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionidDataGridViewTextBoxColumn.Visible = false;
            // 
            // questioncodeDataGridViewTextBoxColumn
            // 
            this.questioncodeDataGridViewTextBoxColumn.DataPropertyName = "questioncode";
            this.questioncodeDataGridViewTextBoxColumn.HeaderText = "Def. Code";
            this.questioncodeDataGridViewTextBoxColumn.Name = "questioncodeDataGridViewTextBoxColumn";
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.Width = 400;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIDDataGridViewTextBoxColumn2
            // 
            this.categoryIDDataGridViewTextBoxColumn2.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn2.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn2.Name = "categoryIDDataGridViewTextBoxColumn2";
            this.categoryIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // categoryCodeDataGridViewTextBoxColumn2
            // 
            this.categoryCodeDataGridViewTextBoxColumn2.DataPropertyName = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn2.HeaderText = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn2.Name = "categoryCodeDataGridViewTextBoxColumn2";
            this.categoryCodeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.DataSource = this.questionnaireOriginBindingSource;
            this.originDataGridViewTextBoxColumn.DisplayMember = "OriginCode";
            this.originDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.originDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.originDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.originDataGridViewTextBoxColumn.ValueMember = "OriginNo";
            // 
            // categoryNewIDDataGridViewTextBoxColumn
            // 
            this.categoryNewIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryNewID";
            this.categoryNewIDDataGridViewTextBoxColumn.HeaderText = "CategoryNewID";
            this.categoryNewIDDataGridViewTextBoxColumn.Name = "categoryNewIDDataGridViewTextBoxColumn";
            this.categoryNewIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryNewIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.cancelUpdatesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripSeparatorChanges,
            this.toQuestionnaireToolStripMenuItem,
            this.toolStripSeparator11,
            this.relatedContextToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectToChangeCategoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(216, 192);
            this.contextMenuStrip1.Tag = "";
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItem1.Tag = "CategoryUpdate";
            this.toolStripMenuItem1.Text = "Change Category";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItem2.Tag = "CategoryCodeUpdate";
            this.toolStripMenuItem2.Text = "Change Category Code";
            // 
            // cancelUpdatesToolStripMenuItem
            // 
            this.cancelUpdatesToolStripMenuItem.Name = "cancelUpdatesToolStripMenuItem";
            this.cancelUpdatesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cancelUpdatesToolStripMenuItem.Tag = "CancelUpdatesSelection";
            this.cancelUpdatesToolStripMenuItem.Text = "Cancel Updates {Selection}";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItem3.Tag = "CancelUpdates";
            this.toolStripMenuItem3.Text = "Cancel Updates";
            // 
            // toolStripSeparatorChanges
            // 
            this.toolStripSeparatorChanges.Name = "toolStripSeparatorChanges";
            this.toolStripSeparatorChanges.Size = new System.Drawing.Size(212, 6);
            this.toolStripSeparatorChanges.Tag = "SeparatorChanges";
            // 
            // toQuestionnaireToolStripMenuItem
            // 
            this.toQuestionnaireToolStripMenuItem.Name = "toQuestionnaireToolStripMenuItem";
            this.toQuestionnaireToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.toQuestionnaireToolStripMenuItem.Tag = "ToQuestionnaire";
            this.toQuestionnaireToolStripMenuItem.Text = "To Questionnaire";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(212, 6);
            // 
            // relatedContextToolStripMenuItem
            // 
            this.relatedContextToolStripMenuItem.Name = "relatedContextToolStripMenuItem";
            this.relatedContextToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.relatedContextToolStripMenuItem.Tag = "RelatedContext";
            this.relatedContextToolStripMenuItem.Text = "Related Context ...";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.pasteToolStripMenuItem.Tag = "PasteClipboardSire";
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Visible = false;
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectToChangeCategoryToolStripMenuItem
            // 
            this.selectToChangeCategoryToolStripMenuItem.Name = "selectToChangeCategoryToolStripMenuItem";
            this.selectToChangeCategoryToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.selectToChangeCategoryToolStripMenuItem.Tag = "SelectToChangeCategory";
            this.selectToChangeCategoryToolStripMenuItem.Text = "Select to change category";
            this.selectToChangeCategoryToolStripMenuItem.Click += new System.EventHandler(this.selectToChangeCategoryToolStripMenuItem_Click);
            // 
            // categoryQuestionPoolNewBindingSource
            // 
            this.categoryQuestionPoolNewBindingSource.DataMember = "Category_QuestionPoolNew";
            this.categoryQuestionPoolNewBindingSource.DataSource = this.categoryBindingSource;
            this.categoryQuestionPoolNewBindingSource.Filter = "origin <> 0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_historicaldata);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 23);
            this.panel2.TabIndex = 13;
            // 
            // tb_historicaldata
            // 
            this.tb_historicaldata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_historicaldata.BackColor = System.Drawing.Color.White;
            this.tb_historicaldata.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryQuestionPoolNewBindingSource, "CreationInfo", true));
            this.tb_historicaldata.Location = new System.Drawing.Point(4, 0);
            this.tb_historicaldata.Multiline = true;
            this.tb_historicaldata.Name = "tb_historicaldata";
            this.tb_historicaldata.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_historicaldata.Size = new System.Drawing.Size(297, 20);
            this.tb_historicaldata.TabIndex = 11;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Red;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 68);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(303, 4);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_sirequestion_comment);
            this.panel1.Controls.Add(this.lb_relquestion_code);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 68);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Historical Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comment";
            // 
            // tb_sirequestion_comment
            // 
            this.tb_sirequestion_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sirequestion_comment.BackColor = System.Drawing.Color.White;
            this.tb_sirequestion_comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryQuestionPoolNewBindingSource, "comment", true));
            this.tb_sirequestion_comment.Location = new System.Drawing.Point(4, 16);
            this.tb_sirequestion_comment.Multiline = true;
            this.tb_sirequestion_comment.Name = "tb_sirequestion_comment";
            this.tb_sirequestion_comment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_sirequestion_comment.Size = new System.Drawing.Size(297, 33);
            this.tb_sirequestion_comment.TabIndex = 7;
            // 
            // lb_relquestion_code
            // 
            this.lb_relquestion_code.AutoSize = true;
            this.lb_relquestion_code.BackColor = System.Drawing.Color.Transparent;
            this.lb_relquestion_code.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoryQuestionPoolNewBindingSource, "questioncode", true));
            this.lb_relquestion_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_relquestion_code.ForeColor = System.Drawing.Color.Blue;
            this.lb_relquestion_code.Location = new System.Drawing.Point(67, 0);
            this.lb_relquestion_code.Name = "lb_relquestion_code";
            this.lb_relquestion_code.Size = new System.Drawing.Size(58, 13);
            this.lb_relquestion_code.TabIndex = 10;
            this.lb_relquestion_code.Text = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SIRE Question Pool";
            // 
            // bindingNavigatorSireQuestion
            // 
            this.bindingNavigatorSireQuestion.AddNewItem = null;
            this.bindingNavigatorSireQuestion.BindingSource = this.categoryQuestionPoolNewBindingSource;
            this.bindingNavigatorSireQuestion.CountItem = null;
            this.bindingNavigatorSireQuestion.DeleteItem = null;
            this.bindingNavigatorSireQuestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewSireItem,
            this.bindingNavigatorDeleteSireQuestionItem,
            this.toolStripSeparator1,
            this.saveSireToolStripButton});
            this.bindingNavigatorSireQuestion.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorSireQuestion.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorSireQuestion.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorSireQuestion.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorSireQuestion.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorSireQuestion.Name = "bindingNavigatorSireQuestion";
            this.bindingNavigatorSireQuestion.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorSireQuestion.Size = new System.Drawing.Size(1057, 25);
            this.bindingNavigatorSireQuestion.TabIndex = 3;
            this.bindingNavigatorSireQuestion.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewSireItem
            // 
            this.bindingNavigatorAddNewSireItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewSireItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewSireItem.Image")));
            this.bindingNavigatorAddNewSireItem.Name = "bindingNavigatorAddNewSireItem";
            this.bindingNavigatorAddNewSireItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewSireItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewSireItem.Text = "Add new";
            this.bindingNavigatorAddNewSireItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteSireQuestionItem
            // 
            this.bindingNavigatorDeleteSireQuestionItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteSireQuestionItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteSireQuestionItem.Image")));
            this.bindingNavigatorDeleteSireQuestionItem.Name = "bindingNavigatorDeleteSireQuestionItem";
            this.bindingNavigatorDeleteSireQuestionItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteSireQuestionItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteSireQuestionItem.Text = "DeleteSIREquestion";
            this.bindingNavigatorDeleteSireQuestionItem.Click += new System.EventHandler(this.bindingNavigator_DeleteQuestion_Item_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // saveSireToolStripButton
            // 
            this.saveSireToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveSireToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveSireToolStripButton.Image")));
            this.saveSireToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveSireToolStripButton.Name = "saveSireToolStripButton";
            this.saveSireToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveSireToolStripButton.Text = "&Save";
            this.saveSireToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(168, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Category:";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(3, 43);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGrid_ourquestion);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.lb_rel_questioncompany_code);
            this.splitContainer4.Panel2.Controls.Add(this.label5);
            this.splitContainer4.Panel2.Controls.Add(this.tb_mngcomments);
            this.splitContainer4.Size = new System.Drawing.Size(1054, 85);
            this.splitContainer4.SplitterDistance = 741;
            this.splitContainer4.TabIndex = 7;
            // 
            // dataGrid_ourquestion
            // 
            this.dataGrid_ourquestion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGrid_ourquestion.AllowDrop = true;
            this.dataGrid_ourquestion.AllowUserToAddRows = false;
            this.dataGrid_ourquestion.AllowUserToDeleteRows = false;
            this.dataGrid_ourquestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_ourquestion.AutoGenerateColumns = false;
            this.dataGrid_ourquestion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_ourquestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ourquestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionidDataGridViewTextBoxColumn1,
            this.questioncodeDataGridViewTextBoxColumn1,
            this.questionDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn1,
            this.categoryIDDataGridViewTextBoxColumn3,
            this.categoryCodeDataGridViewTextBoxColumn3,
            this.originDataGridViewTextBoxColumn1,
            this.originCodeDataGridViewTextBoxColumn1,
            this.categoryNewIDDataGridViewTextBoxColumn1});
            this.dataGrid_ourquestion.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGrid_ourquestion.DataSource = this.CategoryQuestionPoolNewCompanyBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_ourquestion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_ourquestion.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_ourquestion.Name = "dataGrid_ourquestion";
            this.dataGrid_ourquestion.Size = new System.Drawing.Size(735, 79);
            this.dataGrid_ourquestion.TabIndex = 6;
            this.dataGrid_ourquestion.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGrid_ourquestion_DragEnter);
            this.dataGrid_ourquestion.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGrid_ourquestion_DragDrop);
            // 
            // questionidDataGridViewTextBoxColumn1
            // 
            this.questionidDataGridViewTextBoxColumn1.DataPropertyName = "questionid";
            this.questionidDataGridViewTextBoxColumn1.HeaderText = "questionid";
            this.questionidDataGridViewTextBoxColumn1.Name = "questionidDataGridViewTextBoxColumn1";
            this.questionidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // questioncodeDataGridViewTextBoxColumn1
            // 
            this.questioncodeDataGridViewTextBoxColumn1.DataPropertyName = "questioncode";
            this.questioncodeDataGridViewTextBoxColumn1.HeaderText = "Def. Code";
            this.questioncodeDataGridViewTextBoxColumn1.Name = "questioncodeDataGridViewTextBoxColumn1";
            // 
            // questionDataGridViewTextBoxColumn1
            // 
            this.questionDataGridViewTextBoxColumn1.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn1.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn1.MinimumWidth = 400;
            this.questionDataGridViewTextBoxColumn1.Name = "questionDataGridViewTextBoxColumn1";
            this.questionDataGridViewTextBoxColumn1.Width = 400;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryIDDataGridViewTextBoxColumn3
            // 
            this.categoryIDDataGridViewTextBoxColumn3.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn3.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn3.Name = "categoryIDDataGridViewTextBoxColumn3";
            this.categoryIDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // categoryCodeDataGridViewTextBoxColumn3
            // 
            this.categoryCodeDataGridViewTextBoxColumn3.DataPropertyName = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn3.HeaderText = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn3.Name = "categoryCodeDataGridViewTextBoxColumn3";
            this.categoryCodeDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn1
            // 
            this.originDataGridViewTextBoxColumn1.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn1.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn1.Name = "originDataGridViewTextBoxColumn1";
            this.originDataGridViewTextBoxColumn1.Visible = false;
            // 
            // originCodeDataGridViewTextBoxColumn1
            // 
            this.originCodeDataGridViewTextBoxColumn1.DataPropertyName = "OriginCode";
            this.originCodeDataGridViewTextBoxColumn1.HeaderText = "OriginCode";
            this.originCodeDataGridViewTextBoxColumn1.Name = "originCodeDataGridViewTextBoxColumn1";
            this.originCodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.originCodeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryNewIDDataGridViewTextBoxColumn1
            // 
            this.categoryNewIDDataGridViewTextBoxColumn1.DataPropertyName = "CategoryNewID";
            this.categoryNewIDDataGridViewTextBoxColumn1.HeaderText = "CategoryNewID";
            this.categoryNewIDDataGridViewTextBoxColumn1.Name = "categoryNewIDDataGridViewTextBoxColumn1";
            this.categoryNewIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // CategoryQuestionPoolNewCompanyBindingSource
            // 
            this.CategoryQuestionPoolNewCompanyBindingSource.DataMember = "Category_QuestionPoolNew";
            this.CategoryQuestionPoolNewCompanyBindingSource.DataSource = this.categoryBindingSource;
            this.CategoryQuestionPoolNewCompanyBindingSource.Filter = "Origin = 0";
            // 
            // lb_rel_questioncompany_code
            // 
            this.lb_rel_questioncompany_code.AutoSize = true;
            this.lb_rel_questioncompany_code.BackColor = System.Drawing.Color.Transparent;
            this.lb_rel_questioncompany_code.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoryQuestionPoolNewCompanyBindingSource, "questioncode", true));
            this.lb_rel_questioncompany_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rel_questioncompany_code.ForeColor = System.Drawing.Color.Blue;
            this.lb_rel_questioncompany_code.Location = new System.Drawing.Point(71, 3);
            this.lb_rel_questioncompany_code.Name = "lb_rel_questioncompany_code";
            this.lb_rel_questioncompany_code.Size = new System.Drawing.Size(58, 13);
            this.lb_rel_questioncompany_code.TabIndex = 11;
            this.lb_rel_questioncompany_code.Text = "Comment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Comment";
            // 
            // tb_mngcomments
            // 
            this.tb_mngcomments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mngcomments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_mngcomments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoryQuestionPoolNewCompanyBindingSource, "comment", true));
            this.tb_mngcomments.Location = new System.Drawing.Point(3, 16);
            this.tb_mngcomments.Multiline = true;
            this.tb_mngcomments.Name = "tb_mngcomments";
            this.tb_mngcomments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_mngcomments.Size = new System.Drawing.Size(298, 66);
            this.tb_mngcomments.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Management Question Pool";
            // 
            // bindingNavigatorQuestion
            // 
            this.bindingNavigatorQuestion.AddNewItem = null;
            this.bindingNavigatorQuestion.BindingSource = this.CategoryQuestionPoolNewCompanyBindingSource;
            this.bindingNavigatorQuestion.CountItem = null;
            this.bindingNavigatorQuestion.DeleteItem = null;
            this.bindingNavigatorQuestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4,
            this.BindingNavigator_CompanyInsertToolstripbutton,
            this.toolStripButton_deletecustomquestion,
            this.toolStripSeparator5,
            this.toolStripButton_savecustom});
            this.bindingNavigatorQuestion.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorQuestion.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigatorQuestion.MoveLastItem = this.toolStripButton6;
            this.bindingNavigatorQuestion.MoveNextItem = this.toolStripButton5;
            this.bindingNavigatorQuestion.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigatorQuestion.Name = "bindingNavigatorQuestion";
            this.bindingNavigatorQuestion.PositionItem = this.toolStripTextBox1;
            this.bindingNavigatorQuestion.Size = new System.Drawing.Size(1057, 25);
            this.bindingNavigatorQuestion.TabIndex = 4;
            this.bindingNavigatorQuestion.Text = "bindingNavigator1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigator_CompanyInsertToolstripbutton
            // 
            this.BindingNavigator_CompanyInsertToolstripbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigator_CompanyInsertToolstripbutton.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigator_CompanyInsertToolstripbutton.Image")));
            this.BindingNavigator_CompanyInsertToolstripbutton.Name = "BindingNavigator_CompanyInsertToolstripbutton";
            this.BindingNavigator_CompanyInsertToolstripbutton.RightToLeftAutoMirrorImage = true;
            this.BindingNavigator_CompanyInsertToolstripbutton.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigator_CompanyInsertToolstripbutton.Text = "Add new";
            this.BindingNavigator_CompanyInsertToolstripbutton.Click += new System.EventHandler(this.BindingNavigator_CompanyInsertToolstripbutton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_savecustom
            // 
            this.toolStripButton_savecustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_savecustom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_savecustom.Image")));
            this.toolStripButton_savecustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_savecustom.Name = "toolStripButton_savecustom";
            this.toolStripButton_savecustom.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_savecustom.Text = "&Save";
            this.toolStripButton_savecustom.Click += new System.EventHandler(this.toolStripButton_savecustom_Click);
            // 
            // cmenu_report
            // 
            this.cmenu_report.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.cmenu_report.Name = "cmenu_report";
            this.cmenu_report.Size = new System.Drawing.Size(119, 26);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.reportToolStripMenuItem.Text = "Report...";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_Category);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid_Questions);
            this.splitContainer1.Size = new System.Drawing.Size(479, 219);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView_Category
            // 
            this.treeView_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_Category.Location = new System.Drawing.Point(3, 6);
            this.treeView_Category.Name = "treeView_Category";
            this.treeView_Category.Size = new System.Drawing.Size(228, 210);
            this.treeView_Category.TabIndex = 0;
            // 
            // dataGrid_Questions
            // 
            this.dataGrid_Questions.AutoGenerateColumns = false;
            this.dataGrid_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryCodeDataGridViewTextBoxColumn,
            this.categoryDescriptionDataGridViewTextBoxColumn,
            this.categoryDisplayCodeDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.categoryDisplayIndexDataGridViewTextBoxColumn});
            this.dataGrid_Questions.DataMember = "Category";
            this.dataGrid_Questions.DataSource = this.attendanceBindingSource;
            this.dataGrid_Questions.Location = new System.Drawing.Point(14, 14);
            this.dataGrid_Questions.Name = "dataGrid_Questions";
            this.dataGrid_Questions.Size = new System.Drawing.Size(475, 155);
            this.dataGrid_Questions.TabIndex = 0;
            // 
            // categoryCodeDataGridViewTextBoxColumn
            // 
            this.categoryCodeDataGridViewTextBoxColumn.DataPropertyName = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.HeaderText = "CategoryCode";
            this.categoryCodeDataGridViewTextBoxColumn.Name = "categoryCodeDataGridViewTextBoxColumn";
            // 
            // categoryDescriptionDataGridViewTextBoxColumn
            // 
            this.categoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CategoryDescription";
            this.categoryDescriptionDataGridViewTextBoxColumn.HeaderText = "CategoryDescription";
            this.categoryDescriptionDataGridViewTextBoxColumn.Name = "categoryDescriptionDataGridViewTextBoxColumn";
            // 
            // categoryDisplayCodeDataGridViewTextBoxColumn
            // 
            this.categoryDisplayCodeDataGridViewTextBoxColumn.DataPropertyName = "CategoryDisplayCode";
            this.categoryDisplayCodeDataGridViewTextBoxColumn.HeaderText = "CategoryDisplayCode";
            this.categoryDisplayCodeDataGridViewTextBoxColumn.Name = "categoryDisplayCodeDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDisplayIndexDataGridViewTextBoxColumn
            // 
            this.categoryDisplayIndexDataGridViewTextBoxColumn.DataPropertyName = "CategoryDisplayIndex";
            this.categoryDisplayIndexDataGridViewTextBoxColumn.HeaderText = "CategoryDisplayIndex";
            this.categoryDisplayIndexDataGridViewTextBoxColumn.Name = "categoryDisplayIndexDataGridViewTextBoxColumn";
            // 
            // questionPoolNewBindingSource
            // 
            this.questionPoolNewBindingSource.DataMember = "QuestionPoolNew";
            this.questionPoolNewBindingSource.DataSource = this.attendance;
            this.questionPoolNewBindingSource.Filter = "Origin  <>  0";
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataSource = this.attendance;
            this.attendanceBindingSource1.Position = 0;
            // 
            // QuestionPoolNewCompanyBindingSource
            // 
            this.QuestionPoolNewCompanyBindingSource.DataMember = "QuestionPoolNew";
            this.QuestionPoolNewCompanyBindingSource.DataSource = this.attendance;
            this.QuestionPoolNewCompanyBindingSource.Filter = "Origin =  0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 804);
            this.Controls.Add(this.SpliVerical1);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance V 1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.SpliVerical1.Panel1.ResumeLayout(false);
            this.SpliVerical1.Panel2.ResumeLayout(false);
            this.SpliVerical1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tbctrl_categories.ResumeLayout(false);
            this.tabPageCategoryList.ResumeLayout(false);
            this.tabPageCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCategory)).EndInit();
            this.bindingNavigatorCategory.ResumeLayout(false);
            this.bindingNavigatorCategory.PerformLayout();
            this.tabPageCategoryTree.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.contextMenuStripClearTree.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStrip_Designer.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_Notifier.ResumeLayout(false);
            this.panel_Notifier.PerformLayout();
            this.gb_insert_hiermode.ResumeLayout(false);
            this.gb_insert_hiermode.PerformLayout();
            this.gb_inserttodesignermode.ResumeLayout(false);
            this.gb_inserttodesignermode.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerQuestions.Panel1.ResumeLayout(false);
            this.splitContainerQuestions.Panel1.PerformLayout();
            this.splitContainerQuestions.Panel2.ResumeLayout(false);
            this.splitContainerQuestions.Panel2.PerformLayout();
            this.splitContainerQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireOriginBindingSource)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_question)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryQuestionPoolNewBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSireQuestion)).EndInit();
            this.bindingNavigatorSireQuestion.ResumeLayout(false);
            this.bindingNavigatorSireQuestion.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ourquestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryQuestionPoolNewCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorQuestion)).EndInit();
            this.bindingNavigatorQuestion.ResumeLayout(false);
            this.bindingNavigatorQuestion.PerformLayout();
            this.cmenu_report.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionPoolNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPoolNewCompanyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer SpliVerical1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView_Category;
        private System.Windows.Forms.DataGridView dataGrid_Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDisplayCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDisplayIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Attendance attendance;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        
        private System.Windows.Forms.BindingSource questionPoolNewBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_category;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem toQuestionnaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ModeLabel;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Button bt_down;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCategory;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteCategory;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.SplitContainer splitContainerQuestions;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSireQuestion;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewSireItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteSireQuestionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton saveSireToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView_question;
        private System.Windows.Forms.DataGridView dataGrid_ourquestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigatorQuestion;
        private System.Windows.Forms.ToolStripButton BindingNavigator_CompanyInsertToolstripbutton;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton_savecustom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource CategoryQuestionPoolNewCompanyBindingSource;
        private System.Windows.Forms.ToolStripButton saveToolStripButton_category;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionnaire_DropDown;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdb_sibling;
        private System.Windows.Forms.RadioButton rdb_children;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sendToQuestionnaireToolStripMenuItem;
        private System.Windows.Forms.BindingSource categoryQuestionPoolNewBindingSource;
        private System.Windows.Forms.CheckBox chb_showrelation;
        private System.Windows.Forms.BindingSource QuestionPoolNewCompanyBindingSource;
        private System.Windows.Forms.ToolStripMenuItem briefCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Attendance_DropDown;
        private System.Windows.Forms.ToolStripMenuItem AttendanceView_MenuItem;
        private System.Windows.Forms.TextBox tb_sirequestion_comment;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_relquestion_code;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mngcomments;
        private System.Windows.Forms.Label lb_rel_questioncompany_code;
        private System.Windows.Forms.Label lb_movenode;
        private System.Windows.Forms.ToolStripMenuItem Reports_DropDown;
        private System.Windows.Forms.ToolStripMenuItem CriticalReport_MenuItem;
        private System.Windows.Forms.ComboBox cmb_fontsize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem vesselsToolStripMenuItem;
        private System.Windows.Forms.CheckBox chb_cascade;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatedContextToolStripMenuItem;
        private System.Windows.Forms.CheckBox chb_hierarchical;
        private System.Windows.Forms.GroupBox gb_inserttodesignermode;
        private System.Windows.Forms.CheckBox chb_autodisplaycode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Designer;
        private System.Windows.Forms.ToolStripMenuItem loadCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSIREQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadManagQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem clearDesignerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorChanges;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem clearChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Label lb_activesire_category;
        private System.Windows.Forms.Label lb_activemng_category;
        private System.Windows.Forms.CheckBox chb_viewmanag;
        private System.Windows.Forms.CheckBox chb_viewsire;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importExcelFileToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdb_companytop;
        private System.Windows.Forms.GroupBox gb_insert_hiermode;
        private System.Windows.Forms.RadioButton rdb_companybottom;
        private System.Windows.Forms.RadioButton rdb_defaultorder;
        private System.Windows.Forms.ToolStripMenuItem importExcelQuestionnaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem viewOriginsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxOrigin;
        private System.Windows.Forms.BindingSource questionnaireOriginBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn questionidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questioncodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCodeDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn originCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNewIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questioncodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNewIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chb_OriginFilter;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_historicaldata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem selectToChangeCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryForSelectionToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_filtercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDisplayCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDisplayIndexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateRelationshipToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewCategory;
        private System.Windows.Forms.ToolStripButton toolStripButton_deletecustomquestion;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.TabControl tbctrl_categories;
        private System.Windows.Forms.TabPage tabPageCategoryList;
        private System.Windows.Forms.TabPage tabPageCategoryTree;
        private System.Windows.Forms.TreeView tv_categories;
        private System.Windows.Forms.ContextMenuStrip cmenu_report;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report_categoryAnalysisToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClearTree;
        private System.Windows.Forms.ToolStripMenuItem UncheckAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllSubnodesToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Notifier;
        private System.Windows.Forms.Label lb_lastregistrationinfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem showRegistrationInfoToolStripMenuItem;
        private System.Windows.Forms.Label lb_registrationreporttime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chb_autoupdate;
        private System.Windows.Forms.ToolStripMenuItem buildCategoryDisplayOrderToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.TreeView tv_vessels;
        private System.Windows.Forms.ComboBox cmb_fleetselection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_reportto;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.CheckBox chb_ranksort;
        private System.Windows.Forms.CheckBox chb_reportpercentage;
        private System.Windows.Forms.CheckBox chb_subcategories;
        private System.Windows.Forms.Label lb_reportfrom;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem checkAllTopNodesToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_Report;
        private System.Windows.Forms.Label label14;
    }
}

