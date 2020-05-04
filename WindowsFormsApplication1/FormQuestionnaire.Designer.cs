namespace WindowsFormsApplication1
{
    partial class FormQuestionnaire
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.CheckBox chb_remarksfilter;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestionnaire));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_questionnaire = new System.Windows.Forms.DataGridView();
            this.displayCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalDisplayIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.significanceColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.objectCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnboundImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.no1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.no2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.no3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.no4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.no5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectAllChangesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectChangesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource_questionnaire = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.tb_comments = new System.Windows.Forms.TextBox();
            this.tb_usercomments = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_filterlabel = new System.Windows.Forms.Panel();
            this.label_Filterlabel = new System.Windows.Forms.Label();
            this.panel_vettinginfo = new System.Windows.Forms.Panel();
            this.lb_companyrepresentative = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_attendancecode = new System.Windows.Forms.Label();
            this.lb_inspectorname = new System.Windows.Forms.Label();
            this.lb_vesselname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Attendance_DropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.new_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_Menuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.Template_DropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToPortable_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_Search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRemarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGenericCommentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lb_objectcode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelR_TOP = new System.Windows.Forms.Panel();
            this.chb_positive = new System.Windows.Forms.CheckBox();
            this.chb_negativefilter = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView_category = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            chb_remarksfilter = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionnaire)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_questionnaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_filterlabel.SuspendLayout();
            this.panel_vettinginfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelR_TOP.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chb_remarksfilter
            // 
            chb_remarksfilter.AutoSize = true;
            chb_remarksfilter.Location = new System.Drawing.Point(223, 3);
            chb_remarksfilter.Name = "chb_remarksfilter";
            chb_remarksfilter.Size = new System.Drawing.Size(63, 17);
            chb_remarksfilter.TabIndex = 6;
            chb_remarksfilter.Text = "Remark";
            chb_remarksfilter.UseVisualStyleBackColor = true;
            chb_remarksfilter.CheckedChanged += new System.EventHandler(this.chb_remark_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelFilePath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1198, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabelFilePath
            // 
            this.toolStripStatusLabelFilePath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelFilePath.Name = "toolStripStatusLabelFilePath";
            this.toolStripStatusLabelFilePath.Size = new System.Drawing.Size(0, 17);
            // 
            // dgv_questionnaire
            // 
            this.dgv_questionnaire.AllowUserToAddRows = false;
            this.dgv_questionnaire.AllowUserToDeleteRows = false;
            this.dgv_questionnaire.AutoGenerateColumns = false;
            this.dgv_questionnaire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_questionnaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questionnaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.displayCodeDataGridViewTextBoxColumn,
            this.defaultCodeDataGridViewTextBoxColumn,
            this.objectIdDataGridViewTextBoxColumn,
            this.objectTypeDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.globalDisplayIndexDataGridViewTextBoxColumn,
            this.parentCategoryDataGridViewTextBoxColumn,
            this.displayLevelDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.objectDescriptionDataGridViewTextBoxColumn,
            this.answerColumn,
            this.significanceColumn,
            this.objectCommentsDataGridViewTextBoxColumn,
            this.UnboundImageColumn});
            this.dgv_questionnaire.ContextMenuStrip = this.contextMenuStrip2;
            this.dgv_questionnaire.DataSource = this.bindingSource_questionnaire;
            this.dgv_questionnaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_questionnaire.Location = new System.Drawing.Point(10, 10);
            this.dgv_questionnaire.Name = "dgv_questionnaire";
            this.dgv_questionnaire.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_questionnaire.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_questionnaire.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_questionnaire.Size = new System.Drawing.Size(838, 416);
            this.dgv_questionnaire.TabIndex = 1;
            this.dgv_questionnaire.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_questionnaire_RowValidating);
            this.dgv_questionnaire.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_questionnaire_CellPainting);
            // 
            // displayCodeDataGridViewTextBoxColumn
            // 
            this.displayCodeDataGridViewTextBoxColumn.DataPropertyName = "DisplayCode";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            this.displayCodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.displayCodeDataGridViewTextBoxColumn.Frozen = true;
            this.displayCodeDataGridViewTextBoxColumn.HeaderText = "DisplayCode";
            this.displayCodeDataGridViewTextBoxColumn.Name = "displayCodeDataGridViewTextBoxColumn";
            this.displayCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultCodeDataGridViewTextBoxColumn
            // 
            this.defaultCodeDataGridViewTextBoxColumn.DataPropertyName = "DefaultCode";
            this.defaultCodeDataGridViewTextBoxColumn.HeaderText = "DefaultCode";
            this.defaultCodeDataGridViewTextBoxColumn.Name = "defaultCodeDataGridViewTextBoxColumn";
            this.defaultCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectIdDataGridViewTextBoxColumn
            // 
            this.objectIdDataGridViewTextBoxColumn.DataPropertyName = "ObjectId";
            this.objectIdDataGridViewTextBoxColumn.HeaderText = "ObjectId";
            this.objectIdDataGridViewTextBoxColumn.Name = "objectIdDataGridViewTextBoxColumn";
            this.objectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // objectTypeDataGridViewTextBoxColumn
            // 
            this.objectTypeDataGridViewTextBoxColumn.DataPropertyName = "ObjectType";
            this.objectTypeDataGridViewTextBoxColumn.HeaderText = "ObjectType";
            this.objectTypeDataGridViewTextBoxColumn.Name = "objectTypeDataGridViewTextBoxColumn";
            this.objectTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // globalDisplayIndexDataGridViewTextBoxColumn
            // 
            this.globalDisplayIndexDataGridViewTextBoxColumn.DataPropertyName = "GlobalDisplayIndex";
            this.globalDisplayIndexDataGridViewTextBoxColumn.HeaderText = "GlobalDisplayIndex";
            this.globalDisplayIndexDataGridViewTextBoxColumn.Name = "globalDisplayIndexDataGridViewTextBoxColumn";
            this.globalDisplayIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.globalDisplayIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentCategoryDataGridViewTextBoxColumn
            // 
            this.parentCategoryDataGridViewTextBoxColumn.DataPropertyName = "ParentCategory";
            this.parentCategoryDataGridViewTextBoxColumn.HeaderText = "ParentCategory";
            this.parentCategoryDataGridViewTextBoxColumn.Name = "parentCategoryDataGridViewTextBoxColumn";
            this.parentCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentCategoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // displayLevelDataGridViewTextBoxColumn
            // 
            this.displayLevelDataGridViewTextBoxColumn.DataPropertyName = "DisplayLevel";
            this.displayLevelDataGridViewTextBoxColumn.HeaderText = "DisplayLevel";
            this.displayLevelDataGridViewTextBoxColumn.Name = "displayLevelDataGridViewTextBoxColumn";
            this.displayLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayLevelDataGridViewTextBoxColumn.Visible = false;
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "Children";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Children";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            this.childrenDataGridViewTextBoxColumn.ReadOnly = true;
            this.childrenDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // objectDescriptionDataGridViewTextBoxColumn
            // 
            this.objectDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ObjectDescription";
            this.objectDescriptionDataGridViewTextBoxColumn.HeaderText = "Category/Question";
            this.objectDescriptionDataGridViewTextBoxColumn.MinimumWidth = 400;
            this.objectDescriptionDataGridViewTextBoxColumn.Name = "objectDescriptionDataGridViewTextBoxColumn";
            this.objectDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectDescriptionDataGridViewTextBoxColumn.Width = 400;
            // 
            // answerColumn
            // 
            this.answerColumn.DataPropertyName = "Answer";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.answerColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.answerColumn.HeaderText = "Answer";
            this.answerColumn.Name = "answerColumn";
            this.answerColumn.ReadOnly = true;
            this.answerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.answerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // significanceColumn
            // 
            this.significanceColumn.DataPropertyName = "Significance";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.significanceColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.significanceColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.significanceColumn.HeaderText = "Significance";
            this.significanceColumn.Name = "significanceColumn";
            this.significanceColumn.ReadOnly = true;
            this.significanceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.significanceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // objectCommentsDataGridViewTextBoxColumn
            // 
            this.objectCommentsDataGridViewTextBoxColumn.DataPropertyName = "ObjectComments";
            this.objectCommentsDataGridViewTextBoxColumn.HeaderText = "ObjectComments";
            this.objectCommentsDataGridViewTextBoxColumn.Name = "objectCommentsDataGridViewTextBoxColumn";
            this.objectCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectCommentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // UnboundImageColumn
            // 
            this.UnboundImageColumn.HeaderText = "...";
            this.UnboundImageColumn.MinimumWidth = 30;
            this.UnboundImageColumn.Name = "UnboundImageColumn";
            this.UnboundImageColumn.ReadOnly = true;
            this.UnboundImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnboundImageColumn.Width = 30;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewContextToolStripMenuItem,
            this.yesMenuItem,
            this.no1MenuItem,
            this.no2MenuItem,
            this.no3MenuItem,
            this.no4MenuItem,
            this.no5MenuItem,
            this.rejectAllChangesMenuItem,
            this.rejectChangesMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(173, 202);
            this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // viewContextToolStripMenuItem
            // 
            this.viewContextToolStripMenuItem.Name = "viewContextToolStripMenuItem";
            this.viewContextToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewContextToolStripMenuItem.Tag = "ContextView";
            this.viewContextToolStripMenuItem.Text = "View context ...";
            // 
            // yesMenuItem
            // 
            this.yesMenuItem.Name = "yesMenuItem";
            this.yesMenuItem.Size = new System.Drawing.Size(172, 22);
            this.yesMenuItem.Text = "YES";
            // 
            // no1MenuItem
            // 
            this.no1MenuItem.Name = "no1MenuItem";
            this.no1MenuItem.Size = new System.Drawing.Size(172, 22);
            this.no1MenuItem.Text = "NO 1.";
            // 
            // no2MenuItem
            // 
            this.no2MenuItem.Name = "no2MenuItem";
            this.no2MenuItem.Size = new System.Drawing.Size(172, 22);
            this.no2MenuItem.Text = "NO 2.";
            // 
            // no3MenuItem
            // 
            this.no3MenuItem.Name = "no3MenuItem";
            this.no3MenuItem.Size = new System.Drawing.Size(172, 22);
            this.no3MenuItem.Text = "NO 3.";
            // 
            // no4MenuItem
            // 
            this.no4MenuItem.Name = "no4MenuItem";
            this.no4MenuItem.Size = new System.Drawing.Size(172, 22);
            this.no4MenuItem.Text = "NO 4.";
            // 
            // no5MenuItem
            // 
            this.no5MenuItem.Name = "no5MenuItem";
            this.no5MenuItem.Size = new System.Drawing.Size(172, 22);
            this.no5MenuItem.Text = "NO 5.";
            // 
            // rejectAllChangesMenuItem
            // 
            this.rejectAllChangesMenuItem.Name = "rejectAllChangesMenuItem";
            this.rejectAllChangesMenuItem.Size = new System.Drawing.Size(172, 22);
            this.rejectAllChangesMenuItem.Text = "Reject All Changes";
            // 
            // rejectChangesMenuItem
            // 
            this.rejectChangesMenuItem.Name = "rejectChangesMenuItem";
            this.rejectChangesMenuItem.Size = new System.Drawing.Size(172, 22);
            this.rejectChangesMenuItem.Text = "Reject Changes";
            // 
            // bindingSource_questionnaire
            // 
            this.bindingSource_questionnaire.AllowNew = false;
            this.bindingSource_questionnaire.DataMember = "Questionnaire";
            this.bindingSource_questionnaire.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_comments
            // 
            this.tb_comments.AcceptsReturn = true;
            this.tb_comments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_comments.BackColor = System.Drawing.Color.White;
            this.tb_comments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_questionnaire, "ObjectComments", true));
            this.tb_comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comments.Location = new System.Drawing.Point(0, 19);
            this.tb_comments.Multiline = true;
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.ReadOnly = true;
            this.tb_comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_comments.ShortcutsEnabled = false;
            this.tb_comments.Size = new System.Drawing.Size(253, 92);
            this.tb_comments.TabIndex = 2;
            this.tb_comments.TabStop = false;
            // 
            // tb_usercomments
            // 
            this.tb_usercomments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_usercomments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_usercomments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_questionnaire, "Comments", true));
            this.tb_usercomments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usercomments.Location = new System.Drawing.Point(0, 22);
            this.tb_usercomments.Multiline = true;
            this.tb_usercomments.Name = "tb_usercomments";
            this.tb_usercomments.ReadOnly = true;
            this.tb_usercomments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_usercomments.Size = new System.Drawing.Size(256, 122);
            this.tb_usercomments.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel_vettinginfo);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.panelR_TOP);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1198, 543);
            this.splitContainer1.SplitterDistance = 878;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_filterlabel);
            this.panel3.Controls.Add(this.dgv_questionnaire);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 97);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(858, 436);
            this.panel3.TabIndex = 4;
            // 
            // panel_filterlabel
            // 
            this.panel_filterlabel.Controls.Add(this.label_Filterlabel);
            this.panel_filterlabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_filterlabel.Location = new System.Drawing.Point(10, 10);
            this.panel_filterlabel.Name = "panel_filterlabel";
            this.panel_filterlabel.Size = new System.Drawing.Size(838, 17);
            this.panel_filterlabel.TabIndex = 3;
            this.panel_filterlabel.Visible = false;
            // 
            // label_Filterlabel
            // 
            this.label_Filterlabel.AutoSize = true;
            this.label_Filterlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_Filterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filterlabel.Location = new System.Drawing.Point(3, 2);
            this.label_Filterlabel.Name = "label_Filterlabel";
            this.label_Filterlabel.Size = new System.Drawing.Size(41, 13);
            this.label_Filterlabel.TabIndex = 2;
            this.label_Filterlabel.Text = "label7";
            // 
            // panel_vettinginfo
            // 
            this.panel_vettinginfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_vettinginfo.Controls.Add(this.lb_companyrepresentative);
            this.panel_vettinginfo.Controls.Add(this.label9);
            this.panel_vettinginfo.Controls.Add(this.lb_attendancecode);
            this.panel_vettinginfo.Controls.Add(this.lb_inspectorname);
            this.panel_vettinginfo.Controls.Add(this.lb_vesselname);
            this.panel_vettinginfo.Controls.Add(this.label5);
            this.panel_vettinginfo.Controls.Add(this.label4);
            this.panel_vettinginfo.Controls.Add(this.label3);
            this.panel_vettinginfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_vettinginfo.Location = new System.Drawing.Point(10, 37);
            this.panel_vettinginfo.Name = "panel_vettinginfo";
            this.panel_vettinginfo.Size = new System.Drawing.Size(858, 60);
            this.panel_vettinginfo.TabIndex = 3;
            this.panel_vettinginfo.Visible = false;
            // 
            // lb_companyrepresentative
            // 
            this.lb_companyrepresentative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_companyrepresentative.BackColor = System.Drawing.Color.White;
            this.lb_companyrepresentative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_companyrepresentative.Location = new System.Drawing.Point(141, 36);
            this.lb_companyrepresentative.Name = "lb_companyrepresentative";
            this.lb_companyrepresentative.Size = new System.Drawing.Size(281, 21);
            this.lb_companyrepresentative.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Comp. Representative";
            // 
            // lb_attendancecode
            // 
            this.lb_attendancecode.BackColor = System.Drawing.Color.Black;
            this.lb_attendancecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_attendancecode.ForeColor = System.Drawing.Color.Yellow;
            this.lb_attendancecode.Location = new System.Drawing.Point(543, 37);
            this.lb_attendancecode.Name = "lb_attendancecode";
            this.lb_attendancecode.Size = new System.Drawing.Size(195, 18);
            this.lb_attendancecode.TabIndex = 6;
            this.lb_attendancecode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_inspectorname
            // 
            this.lb_inspectorname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_inspectorname.BackColor = System.Drawing.Color.White;
            this.lb_inspectorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inspectorname.Location = new System.Drawing.Point(542, 10);
            this.lb_inspectorname.Name = "lb_inspectorname";
            this.lb_inspectorname.Size = new System.Drawing.Size(306, 21);
            this.lb_inspectorname.TabIndex = 4;
            // 
            // lb_vesselname
            // 
            this.lb_vesselname.BackColor = System.Drawing.Color.White;
            this.lb_vesselname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vesselname.Location = new System.Drawing.Point(141, 10);
            this.lb_vesselname.Name = "lb_vesselname";
            this.lb_vesselname.Size = new System.Drawing.Size(281, 21);
            this.lb_vesselname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Inspector";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vessel Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inspection Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Attendance_DropDown,
            this.Template_DropDown,
            this.toolStripTextBox1,
            this.toolStripTextBox_Search,
            this.toolStripTextBox2,
            this.toolStripComboBoxFont,
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Attendance_DropDown
            // 
            this.Attendance_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_MenuItem,
            this.Open_MenuItem,
            this.Save_Menuitem});
            this.Attendance_DropDown.Name = "Attendance_DropDown";
            this.Attendance_DropDown.Size = new System.Drawing.Size(80, 23);
            this.Attendance_DropDown.Text = "Attendance";
            this.Attendance_DropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.attendanceToolStripMenuItem_DropDownItemClicked);
            // 
            // new_MenuItem
            // 
            this.new_MenuItem.Name = "new_MenuItem";
            this.new_MenuItem.Size = new System.Drawing.Size(103, 22);
            this.new_MenuItem.Tag = "NewAttendance";
            this.new_MenuItem.Text = "&New";
            // 
            // Open_MenuItem
            // 
            this.Open_MenuItem.Enabled = false;
            this.Open_MenuItem.Name = "Open_MenuItem";
            this.Open_MenuItem.Size = new System.Drawing.Size(103, 22);
            this.Open_MenuItem.Text = "&Open";
            // 
            // Save_Menuitem
            // 
            this.Save_Menuitem.Enabled = false;
            this.Save_Menuitem.Name = "Save_Menuitem";
            this.Save_Menuitem.Size = new System.Drawing.Size(103, 22);
            this.Save_Menuitem.Tag = "SaveVetting";
            this.Save_Menuitem.Text = "&Save";
            // 
            // Template_DropDown
            // 
            this.Template_DropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToPortable_MenuItem});
            this.Template_DropDown.Name = "Template_DropDown";
            this.Template_DropDown.Size = new System.Drawing.Size(69, 23);
            this.Template_DropDown.Text = "Template";
            this.Template_DropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Template_DropDown_DropDownItemClicked);
            // 
            // sendToPortable_MenuItem
            // 
            this.sendToPortable_MenuItem.Name = "sendToPortable_MenuItem";
            this.sendToPortable_MenuItem.Size = new System.Drawing.Size(164, 22);
            this.sendToPortable_MenuItem.Tag = "SendPortable";
            this.sendToPortable_MenuItem.Text = "Send To Portable";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(60, 23);
            this.toolStripTextBox1.Text = "Search";
            // 
            // toolStripTextBox_Search
            // 
            this.toolStripTextBox_Search.Name = "toolStripTextBox_Search";
            this.toolStripTextBox_Search.Size = new System.Drawing.Size(200, 23);
            this.toolStripTextBox_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox_Search_KeyDown);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(54, 23);
            this.toolStripTextBox2.Text = "Font";
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.AutoSize = false;
            this.toolStripComboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxFont.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripComboBoxFont.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "13",
            "14"});
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(40, 21);
            this.toolStripComboBoxFont.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxFont_SelectedIndexChanged);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToExcelToolStripMenuItem,
            this.exportRemarksToolStripMenuItem,
            this.editToolStripMenuItem,
            this.editGenericCommentsMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Enabled = false;
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export to Excel...";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // exportRemarksToolStripMenuItem
            // 
            this.exportRemarksToolStripMenuItem.Name = "exportRemarksToolStripMenuItem";
            this.exportRemarksToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.exportRemarksToolStripMenuItem.Text = "Export Remarks...";
            this.exportRemarksToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelRemarks_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // editGenericCommentsMenuItem
            // 
            this.editGenericCommentsMenuItem.Enabled = false;
            this.editGenericCommentsMenuItem.Name = "editGenericCommentsMenuItem";
            this.editGenericCommentsMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editGenericCommentsMenuItem.Text = "Edit Generic Comments";
            this.editGenericCommentsMenuItem.Click += new System.EventHandler(this.editGenericCommentsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 161);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(296, 372);
            this.panel1.TabIndex = 6;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(10, 10);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.lb_objectcode);
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            this.splitContainer3.Panel1.Controls.Add(this.tb_question);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.splitContainer3.Size = new System.Drawing.Size(276, 352);
            this.splitContainer3.SplitterDistance = 86;
            this.splitContainer3.TabIndex = 6;
            // 
            // lb_objectcode
            // 
            this.lb_objectcode.AutoSize = true;
            this.lb_objectcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_questionnaire, "DisplayCode", true));
            this.lb_objectcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_objectcode.ForeColor = System.Drawing.Color.Blue;
            this.lb_objectcode.Location = new System.Drawing.Point(77, 3);
            this.lb_objectcode.Name = "lb_objectcode";
            this.lb_objectcode.Size = new System.Drawing.Size(35, 13);
            this.lb_objectcode.TabIndex = 4;
            this.lb_objectcode.Text = "code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Object";
            // 
            // tb_question
            // 
            this.tb_question.AcceptsReturn = true;
            this.tb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_question.BackColor = System.Drawing.Color.White;
            this.tb_question.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_questionnaire, "ObjectDescription", true));
            this.tb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_question.Location = new System.Drawing.Point(8, 19);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_question.ShortcutsEnabled = false;
            this.tb_question.Size = new System.Drawing.Size(258, 54);
            this.tb_question.TabIndex = 3;
            this.tb_question.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(10, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.tb_comments);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.tb_usercomments);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.splitContainer2.Size = new System.Drawing.Size(256, 262);
            this.splitContainer2.SplitterDistance = 114;
            this.splitContainer2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inspector\'s comment";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(10, 151);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(296, 10);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panelR_TOP
            // 
            this.panelR_TOP.Controls.Add(chb_remarksfilter);
            this.panelR_TOP.Controls.Add(this.chb_positive);
            this.panelR_TOP.Controls.Add(this.chb_negativefilter);
            this.panelR_TOP.Controls.Add(this.label6);
            this.panelR_TOP.Controls.Add(this.treeView_category);
            this.panelR_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelR_TOP.Location = new System.Drawing.Point(10, 10);
            this.panelR_TOP.Name = "panelR_TOP";
            this.panelR_TOP.Size = new System.Drawing.Size(296, 141);
            this.panelR_TOP.TabIndex = 4;
            // 
            // chb_positive
            // 
            this.chb_positive.AutoSize = true;
            this.chb_positive.Location = new System.Drawing.Point(163, 3);
            this.chb_positive.Name = "chb_positive";
            this.chb_positive.Size = new System.Drawing.Size(63, 17);
            this.chb_positive.TabIndex = 5;
            this.chb_positive.Text = "Positive";
            this.chb_positive.UseVisualStyleBackColor = true;
            this.chb_positive.CheckedChanged += new System.EventHandler(this.chb_positive_CheckedChanged);
            // 
            // chb_negativefilter
            // 
            this.chb_negativefilter.AutoSize = true;
            this.chb_negativefilter.Location = new System.Drawing.Point(88, 3);
            this.chb_negativefilter.Name = "chb_negativefilter";
            this.chb_negativefilter.Size = new System.Drawing.Size(69, 17);
            this.chb_negativefilter.TabIndex = 4;
            this.chb_negativefilter.Text = "Negative";
            this.chb_negativefilter.UseVisualStyleBackColor = true;
            this.chb_negativefilter.CheckedChanged += new System.EventHandler(this.chb_negativefilter_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apply Filter";
            // 
            // treeView_category
            // 
            this.treeView_category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_category.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView_category.ImageIndex = 0;
            this.treeView_category.ImageList = this.imageList1;
            this.treeView_category.Location = new System.Drawing.Point(10, 25);
            this.treeView_category.Name = "treeView_category";
            this.treeView_category.SelectedImageIndex = 3;
            this.treeView_category.Size = new System.Drawing.Size(276, 110);
            this.treeView_category.TabIndex = 0;
            this.treeView_category.DoubleClick += new System.EventHandler(this.treeView_category_DoubleClick);
            this.treeView_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_category_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.removeFilterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.filterToolStripMenuItem.Tag = "FilterObjects";
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // removeFilterToolStripMenuItem
            // 
            this.removeFilterToolStripMenuItem.Name = "removeFilterToolStripMenuItem";
            this.removeFilterToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeFilterToolStripMenuItem.Tag = "FilterRemove";
            this.removeFilterToolStripMenuItem.Text = "Remove Filter";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "global.png");
            this.imageList1.Images.SetKeyName(1, "category-folder.png");
            this.imageList1.Images.SetKeyName(2, "section.png");
            this.imageList1.Images.SetKeyName(3, "Ionia.jpeg");
            this.imageList1.Images.SetKeyName(4, "Notes.png");
            this.imageList1.Images.SetKeyName(5, "watchme_2.png");
            // 
            // FormQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 565);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQuestionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionnaire";
            this.Load += new System.EventHandler(this.FormQuestionnaire_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionnaire)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_questionnaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_filterlabel.ResumeLayout(false);
            this.panel_filterlabel.PerformLayout();
            this.panel_vettinginfo.ResumeLayout(false);
            this.panel_vettinginfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.panelR_TOP.ResumeLayout(false);
            this.panelR_TOP.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgv_questionnaire;
        private System.Windows.Forms.BindingSource bindingSource_questionnaire;
        public Attendance attendance;
        private System.Windows.Forms.TextBox tb_comments;
        private System.Windows.Forms.TextBox tb_usercomments;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelR_TOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Attendance_DropDown;
        private System.Windows.Forms.ToolStripMenuItem new_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_Menuitem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_vettinginfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_inspectorname;
        private System.Windows.Forms.Label lb_vesselname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFilePath;
        private System.Windows.Forms.Label lb_attendancecode;
        private System.Windows.Forms.ToolStripMenuItem Template_DropDown;
        private System.Windows.Forms.ToolStripMenuItem sendToPortable_MenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView_category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.Label label_Filterlabel;
        private System.Windows.Forms.Panel panel_filterlabel;
        private System.Windows.Forms.ToolStripMenuItem removeFilterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem viewContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Search;
        private System.Windows.Forms.CheckBox chb_negativefilter;
        private System.Windows.Forms.CheckBox chb_positive;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label lb_objectcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.Label lb_companyrepresentative;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRemarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn globalDisplayIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn answerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn significanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn UnboundImageColumn;
        private System.Windows.Forms.ToolStripMenuItem yesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem no1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem no2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem no3MenuItem;
        private System.Windows.Forms.ToolStripMenuItem no4MenuItem;
        private System.Windows.Forms.ToolStripMenuItem no5MenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectAllChangesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectChangesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGenericCommentsMenuItem;
    }
}