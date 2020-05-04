namespace WindowsFormsApplication1
{
    partial class Form_ReportCritical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReportCritical));
            this.dataGridView_CriticalQuestions = new System.Windows.Forms.DataGridView();
            this.Category_crit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VesselId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VesselName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNewId_crit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisplayOrderQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripNegAnswers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultSortNegAnswersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            this.vetDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vettingCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.significanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyRepresentativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesselNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyRepresentativeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalDisplayIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_relvet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewVettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_ReportCritical = new WindowsFormsApplication1.DataSet_ReportCritical();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Vessels = new System.Windows.Forms.DataGridView();
            this.vesselNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_Vessels = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart = new Nevron.Chart.WinForm.NChartControl();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_seentotalperc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_totalseen = new System.Windows.Forms.Label();
            this.lb_vesselname = new System.Windows.Forms.Label();
            this.chb_vesselspecific = new System.Windows.Forms.CheckBox();
            this.chb_autostatistics = new System.Windows.Forms.CheckBox();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.lb_perc = new System.Windows.Forms.Label();
            this.lb_negativenum = new System.Windows.Forms.Label();
            this.lb_totalnum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_shipname_question = new System.Windows.Forms.Label();
            this.chb_categoryrel = new System.Windows.Forms.CheckBox();
            this.lb_category = new System.Windows.Forms.Label();
            this.lb_catneg = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ChartCategory = new Nevron.Chart.WinForm.NChartControl();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgview_negative_categories = new System.Windows.Forms.DataGridView();
            this.CategoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryNewId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.defaultSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chb_fleetwise = new System.Windows.Forms.CheckBox();
            this.lb_shipname_categories = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_objectcomment = new System.Windows.Forms.TextBox();
            this.negativeQuestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usercomments = new System.Windows.Forms.TextBox();
            this.ChartHistory = new Nevron.Chart.WinForm.NChartControl();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel_bot_right_left = new System.Windows.Forms.Panel();
            this.lb_sig_1 = new System.Windows.Forms.Label();
            this.lb_sig_2 = new System.Windows.Forms.Label();
            this.lb_sig_3 = new System.Windows.Forms.Label();
            this.lb_sig_4 = new System.Windows.Forms.Label();
            this.lb_sig_5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_VesselQuestionVetting = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_sig_bot_5 = new System.Windows.Forms.Label();
            this.lb_sig_bot_4 = new System.Windows.Forms.Label();
            this.lb_sig_bot_3 = new System.Windows.Forms.Label();
            this.lb_sig_bot_2 = new System.Windows.Forms.Label();
            this.lb_sig_bot_1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CriticalQuestions)).BeginInit();
            this.contextMenuStripNegAnswers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            this.contextMenuStrip_relvet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vettingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ReportCritical)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vessels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Vessels)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview_negative_categories)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.negativeQuestionsBindingSource)).BeginInit();
            this.panel_bot_right_left.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_VesselQuestionVetting.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_CriticalQuestions
            // 
            this.dataGridView_CriticalQuestions.AllowUserToAddRows = false;
            this.dataGridView_CriticalQuestions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_CriticalQuestions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_CriticalQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CriticalQuestions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_CriticalQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_CriticalQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CriticalQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_crit,
            this.QuestionCode,
            this.ObjectDescription,
            this.ObjectComments,
            this.ObjectId,
            this.VesselId,
            this.VesselName,
            this.CategoryNewId_crit,
            this.colDisplayOrderQuestions});
            this.dataGridView_CriticalQuestions.ContextMenuStrip = this.contextMenuStripNegAnswers;
            this.dataGridView_CriticalQuestions.Location = new System.Drawing.Point(5, 21);
            this.dataGridView_CriticalQuestions.MultiSelect = false;
            this.dataGridView_CriticalQuestions.Name = "dataGridView_CriticalQuestions";
            this.dataGridView_CriticalQuestions.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CriticalQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_CriticalQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CriticalQuestions.Size = new System.Drawing.Size(568, 74);
            this.dataGridView_CriticalQuestions.TabIndex = 1;
            this.dataGridView_CriticalQuestions.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CriticalQuestions_CellMouseClick);
            this.dataGridView_CriticalQuestions.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CriticalQuestions_CellMouseDoubleClick);
            this.dataGridView_CriticalQuestions.SelectionChanged += new System.EventHandler(this.dataGridView_CriticalQuestions_SelectionChanged);
            // 
            // Category_crit
            // 
            this.Category_crit.DataPropertyName = "Category";
            this.Category_crit.HeaderText = "Category";
            this.Category_crit.Name = "Category_crit";
            this.Category_crit.ReadOnly = true;
            // 
            // QuestionCode
            // 
            this.QuestionCode.DataPropertyName = "QuestionCode";
            this.QuestionCode.HeaderText = "Ques. Code";
            this.QuestionCode.Name = "QuestionCode";
            this.QuestionCode.ReadOnly = true;
            // 
            // ObjectDescription
            // 
            this.ObjectDescription.DataPropertyName = "ObjectDescription";
            this.ObjectDescription.HeaderText = "ObjectDescription";
            this.ObjectDescription.MinimumWidth = 100;
            this.ObjectDescription.Name = "ObjectDescription";
            this.ObjectDescription.ReadOnly = true;
            this.ObjectDescription.Width = 300;
            // 
            // ObjectComments
            // 
            this.ObjectComments.DataPropertyName = "ObjectComments";
            this.ObjectComments.HeaderText = "ObjectComments";
            this.ObjectComments.Name = "ObjectComments";
            this.ObjectComments.ReadOnly = true;
            this.ObjectComments.Visible = false;
            // 
            // ObjectId
            // 
            this.ObjectId.DataPropertyName = "ObjectId";
            this.ObjectId.HeaderText = "ObjectId";
            this.ObjectId.Name = "ObjectId";
            this.ObjectId.ReadOnly = true;
            this.ObjectId.Visible = false;
            // 
            // VesselId
            // 
            this.VesselId.DataPropertyName = "VesselId";
            this.VesselId.HeaderText = "VesselId";
            this.VesselId.Name = "VesselId";
            this.VesselId.ReadOnly = true;
            this.VesselId.Visible = false;
            // 
            // VesselName
            // 
            this.VesselName.DataPropertyName = "VesselName";
            this.VesselName.HeaderText = "VesselName";
            this.VesselName.Name = "VesselName";
            this.VesselName.ReadOnly = true;
            // 
            // CategoryNewId_crit
            // 
            this.CategoryNewId_crit.DataPropertyName = "CategoryNewId";
            this.CategoryNewId_crit.HeaderText = "CategoryNewId";
            this.CategoryNewId_crit.Name = "CategoryNewId_crit";
            this.CategoryNewId_crit.ReadOnly = true;
            this.CategoryNewId_crit.Visible = false;
            // 
            // colDisplayOrderQuestions
            // 
            this.colDisplayOrderQuestions.DataPropertyName = "DisplayOrder";
            this.colDisplayOrderQuestions.HeaderText = "Display Order";
            this.colDisplayOrderQuestions.Name = "colDisplayOrderQuestions";
            this.colDisplayOrderQuestions.ReadOnly = true;
            this.colDisplayOrderQuestions.Visible = false;
            // 
            // contextMenuStripNegAnswers
            // 
            this.contextMenuStripNegAnswers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewContextToolStripMenuItem,
            this.defaultSortNegAnswersToolStripMenuItem1});
            this.contextMenuStripNegAnswers.Name = "contextMenuStripNegAnswers";
            this.contextMenuStripNegAnswers.Size = new System.Drawing.Size(156, 48);
            // 
            // viewContextToolStripMenuItem
            // 
            this.viewContextToolStripMenuItem.Name = "viewContextToolStripMenuItem";
            this.viewContextToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.viewContextToolStripMenuItem.Text = "View Context ...";
            this.viewContextToolStripMenuItem.Click += new System.EventHandler(this.viewContextToolStripMenuItem_Click);
            // 
            // defaultSortNegAnswersToolStripMenuItem1
            // 
            this.defaultSortNegAnswersToolStripMenuItem1.Name = "defaultSortNegAnswersToolStripMenuItem1";
            this.defaultSortNegAnswersToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.defaultSortNegAnswersToolStripMenuItem1.Text = "Default Sort";
            this.defaultSortNegAnswersToolStripMenuItem1.Click += new System.EventHandler(this.defaultSortNegAnswersToolStripMenuItem1_Click);
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.AllowUserToAddRows = false;
            this.dataGridView_Results.AllowUserToDeleteRows = false;
            this.dataGridView_Results.AllowUserToResizeRows = false;
            this.dataGridView_Results.AutoGenerateColumns = false;
            this.dataGridView_Results.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vetDateDataGridViewTextBoxColumn,
            this.vettingCodeDataGridViewTextBoxColumn,
            this.significanceDataGridViewTextBoxColumn,
            this.MajorName,
            this.commentsDataGridViewTextBoxColumn,
            this.CompanyRepresentativeName,
            this.Inspector,
            this.vesselNameDataGridViewTextBoxColumn1,
            this.companyRepresentativeNameDataGridViewTextBoxColumn,
            this.globalDisplayIndexDataGridViewTextBoxColumn,
            this.objectIdDataGridViewTextBoxColumn,
            this.inspectorNameDataGridViewTextBoxColumn});
            this.dataGridView_Results.ContextMenuStrip = this.contextMenuStrip_relvet;
            this.dataGridView_Results.DataSource = this.vettingBindingSource;
            this.dataGridView_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Results.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Results.MultiSelect = false;
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.ReadOnly = true;
            this.dataGridView_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Results.Size = new System.Drawing.Size(395, 91);
            this.dataGridView_Results.TabIndex = 2;
            this.dataGridView_Results.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Results_MouseDoubleClick);
            this.dataGridView_Results.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_Results_CellFormatting);
            this.dataGridView_Results.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_Results_CellPainting);
            // 
            // vetDateDataGridViewTextBoxColumn
            // 
            this.vetDateDataGridViewTextBoxColumn.DataPropertyName = "VetDate";
            this.vetDateDataGridViewTextBoxColumn.HeaderText = "Vet. Date";
            this.vetDateDataGridViewTextBoxColumn.Name = "vetDateDataGridViewTextBoxColumn";
            this.vetDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vettingCodeDataGridViewTextBoxColumn
            // 
            this.vettingCodeDataGridViewTextBoxColumn.DataPropertyName = "VettingCode";
            this.vettingCodeDataGridViewTextBoxColumn.HeaderText = "Vet. Code";
            this.vettingCodeDataGridViewTextBoxColumn.Name = "vettingCodeDataGridViewTextBoxColumn";
            this.vettingCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // significanceDataGridViewTextBoxColumn
            // 
            this.significanceDataGridViewTextBoxColumn.DataPropertyName = "Significance";
            this.significanceDataGridViewTextBoxColumn.HeaderText = "Significance";
            this.significanceDataGridViewTextBoxColumn.Name = "significanceDataGridViewTextBoxColumn";
            this.significanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MajorName
            // 
            this.MajorName.DataPropertyName = "MajorName";
            this.MajorName.HeaderText = "Major";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CompanyRepresentativeName
            // 
            this.CompanyRepresentativeName.DataPropertyName = "CompanyRepresentativeName";
            this.CompanyRepresentativeName.HeaderText = "Company\'s Repr.";
            this.CompanyRepresentativeName.Name = "CompanyRepresentativeName";
            this.CompanyRepresentativeName.ReadOnly = true;
            this.CompanyRepresentativeName.Width = 150;
            // 
            // Inspector
            // 
            this.Inspector.DataPropertyName = "InspectorName";
            this.Inspector.HeaderText = "InspectorName";
            this.Inspector.MinimumWidth = 150;
            this.Inspector.Name = "Inspector";
            this.Inspector.ReadOnly = true;
            this.Inspector.Width = 150;
            // 
            // vesselNameDataGridViewTextBoxColumn1
            // 
            this.vesselNameDataGridViewTextBoxColumn1.DataPropertyName = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn1.HeaderText = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn1.Name = "vesselNameDataGridViewTextBoxColumn1";
            this.vesselNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vesselNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // companyRepresentativeNameDataGridViewTextBoxColumn
            // 
            this.companyRepresentativeNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyRepresentativeName";
            this.companyRepresentativeNameDataGridViewTextBoxColumn.HeaderText = "CompanyRepresentativeName";
            this.companyRepresentativeNameDataGridViewTextBoxColumn.Name = "companyRepresentativeNameDataGridViewTextBoxColumn";
            this.companyRepresentativeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // globalDisplayIndexDataGridViewTextBoxColumn
            // 
            this.globalDisplayIndexDataGridViewTextBoxColumn.DataPropertyName = "GlobalDisplayIndex";
            this.globalDisplayIndexDataGridViewTextBoxColumn.HeaderText = "GlobalDisplayIndex";
            this.globalDisplayIndexDataGridViewTextBoxColumn.Name = "globalDisplayIndexDataGridViewTextBoxColumn";
            this.globalDisplayIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.globalDisplayIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // objectIdDataGridViewTextBoxColumn
            // 
            this.objectIdDataGridViewTextBoxColumn.DataPropertyName = "ObjectId";
            this.objectIdDataGridViewTextBoxColumn.HeaderText = "ObjectId";
            this.objectIdDataGridViewTextBoxColumn.Name = "objectIdDataGridViewTextBoxColumn";
            this.objectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // inspectorNameDataGridViewTextBoxColumn
            // 
            this.inspectorNameDataGridViewTextBoxColumn.DataPropertyName = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.HeaderText = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.Name = "inspectorNameDataGridViewTextBoxColumn";
            this.inspectorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip_relvet
            // 
            this.contextMenuStrip_relvet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewVettingToolStripMenuItem});
            this.contextMenuStrip_relvet.Name = "contextMenuStrip_relvet";
            this.contextMenuStrip_relvet.Size = new System.Drawing.Size(109, 26);
            // 
            // viewVettingToolStripMenuItem
            // 
            this.viewVettingToolStripMenuItem.Name = "viewVettingToolStripMenuItem";
            this.viewVettingToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.viewVettingToolStripMenuItem.Text = "View...";
            this.viewVettingToolStripMenuItem.Click += new System.EventHandler(this.viewVettingToolStripMenuItem_Click);
            // 
            // vettingBindingSource
            // 
            this.vettingBindingSource.DataMember = "Vetting";
            this.vettingBindingSource.DataSource = this.DataSet_ReportCritical;
            // 
            // DataSet_ReportCritical
            // 
            this.DataSet_ReportCritical.DataSetName = "DataSet_ReportCritical";
            this.DataSet_ReportCritical.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_Vessels);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 480);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView_Vessels
            // 
            this.dataGridView_Vessels.AllowUserToAddRows = false;
            this.dataGridView_Vessels.AllowUserToDeleteRows = false;
            this.dataGridView_Vessels.AllowUserToResizeRows = false;
            this.dataGridView_Vessels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Vessels.AutoGenerateColumns = false;
            this.dataGridView_Vessels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Vessels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vesselNameDataGridViewTextBoxColumn});
            this.dataGridView_Vessels.DataSource = this.bindingSource_Vessels;
            this.dataGridView_Vessels.Location = new System.Drawing.Point(12, 11);
            this.dataGridView_Vessels.MultiSelect = false;
            this.dataGridView_Vessels.Name = "dataGridView_Vessels";
            this.dataGridView_Vessels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Vessels.Size = new System.Drawing.Size(380, 268);
            this.dataGridView_Vessels.TabIndex = 2;
            // 
            // vesselNameDataGridViewTextBoxColumn
            // 
            this.vesselNameDataGridViewTextBoxColumn.DataPropertyName = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn.HeaderText = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.vesselNameDataGridViewTextBoxColumn.Name = "vesselNameDataGridViewTextBoxColumn";
            this.vesselNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // bindingSource_Vessels
            // 
            this.bindingSource_Vessels.DataMember = "Vessels";
            this.bindingSource_Vessels.DataSource = this.DataSet_ReportCritical;
            this.bindingSource_Vessels.PositionChanged += new System.EventHandler(this.bindingSource_Vessels_PositionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chart);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lb_seentotalperc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_totalseen);
            this.groupBox1.Controls.Add(this.lb_vesselname);
            this.groupBox1.Controls.Add(this.chb_vesselspecific);
            this.groupBox1.Controls.Add(this.chb_autostatistics);
            this.groupBox1.Controls.Add(this.bt_calculate);
            this.groupBox1.Controls.Add(this.lb_perc);
            this.groupBox1.Controls.Add(this.lb_negativenum);
            this.groupBox1.Controls.Add(this.lb_totalnum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_total);
            this.groupBox1.Controls.Add(this.dtp_to);
            this.groupBox1.Controls.Add(this.dtp_from);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question\'s Statistics";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.AutoRefresh = false;
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            this.chart.InputKeys = new System.Windows.Forms.Keys[0];
            this.chart.Location = new System.Drawing.Point(266, 37);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(108, 135);
            this.chart.State = ((Nevron.Chart.WinForm.NState)(resources.GetObject("chart.State")));
            this.chart.TabIndex = 12;
            this.chart.Text = "nChartControl1";
            this.chart.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Negative";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "% ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Answered ";
            // 
            // lb_seentotalperc
            // 
            this.lb_seentotalperc.BackColor = System.Drawing.Color.Yellow;
            this.lb_seentotalperc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_seentotalperc.Location = new System.Drawing.Point(150, 75);
            this.lb_seentotalperc.Name = "lb_seentotalperc";
            this.lb_seentotalperc.Size = new System.Drawing.Size(49, 13);
            this.lb_seentotalperc.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total seen";
            // 
            // lb_totalseen
            // 
            this.lb_totalseen.BackColor = System.Drawing.Color.Yellow;
            this.lb_totalseen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalseen.Location = new System.Drawing.Point(78, 80);
            this.lb_totalseen.Name = "lb_totalseen";
            this.lb_totalseen.Size = new System.Drawing.Size(43, 13);
            this.lb_totalseen.TabIndex = 14;
            // 
            // lb_vesselname
            // 
            this.lb_vesselname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_vesselname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Vessels, "VesselName", true));
            this.lb_vesselname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_vesselname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vesselname.ForeColor = System.Drawing.Color.Blue;
            this.lb_vesselname.Location = new System.Drawing.Point(3, 16);
            this.lb_vesselname.Name = "lb_vesselname";
            this.lb_vesselname.Size = new System.Drawing.Size(374, 13);
            this.lb_vesselname.TabIndex = 13;
            this.lb_vesselname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_vesselname.Visible = false;
            // 
            // chb_vesselspecific
            // 
            this.chb_vesselspecific.AutoSize = true;
            this.chb_vesselspecific.Location = new System.Drawing.Point(37, 155);
            this.chb_vesselspecific.Name = "chb_vesselspecific";
            this.chb_vesselspecific.Size = new System.Drawing.Size(96, 17);
            this.chb_vesselspecific.TabIndex = 12;
            this.chb_vesselspecific.Text = "Vessel specific";
            this.chb_vesselspecific.UseVisualStyleBackColor = true;
            this.chb_vesselspecific.CheckedChanged += new System.EventHandler(this.chb_vesselspecific_CheckedChanged);
            // 
            // chb_autostatistics
            // 
            this.chb_autostatistics.AutoSize = true;
            this.chb_autostatistics.Location = new System.Drawing.Point(37, 129);
            this.chb_autostatistics.Name = "chb_autostatistics";
            this.chb_autostatistics.Size = new System.Drawing.Size(48, 17);
            this.chb_autostatistics.TabIndex = 11;
            this.chb_autostatistics.Text = "Auto";
            this.chb_autostatistics.UseVisualStyleBackColor = true;
            this.chb_autostatistics.CheckedChanged += new System.EventHandler(this.chb_autostatistics_CheckedChanged);
            // 
            // bt_calculate
            // 
            this.bt_calculate.Location = new System.Drawing.Point(144, 152);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(71, 21);
            this.bt_calculate.TabIndex = 10;
            this.bt_calculate.Text = "&Calculate";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // lb_perc
            // 
            this.lb_perc.BackColor = System.Drawing.Color.Red;
            this.lb_perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_perc.ForeColor = System.Drawing.Color.Black;
            this.lb_perc.Location = new System.Drawing.Point(151, 110);
            this.lb_perc.Name = "lb_perc";
            this.lb_perc.Size = new System.Drawing.Size(46, 13);
            this.lb_perc.TabIndex = 9;
            // 
            // lb_negativenum
            // 
            this.lb_negativenum.BackColor = System.Drawing.Color.Red;
            this.lb_negativenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_negativenum.ForeColor = System.Drawing.Color.Black;
            this.lb_negativenum.Location = new System.Drawing.Point(79, 107);
            this.lb_negativenum.Name = "lb_negativenum";
            this.lb_negativenum.Size = new System.Drawing.Size(42, 13);
            this.lb_negativenum.TabIndex = 8;
            // 
            // lb_totalnum
            // 
            this.lb_totalnum.BackColor = System.Drawing.Color.Yellow;
            this.lb_totalnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalnum.Location = new System.Drawing.Point(78, 60);
            this.lb_totalnum.Name = "lb_totalnum";
            this.lb_totalnum.Size = new System.Drawing.Size(43, 13);
            this.lb_totalnum.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "% ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Negative";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(35, 60);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(31, 13);
            this.lb_total.TabIndex = 4;
            this.lb_total.Text = "Total";
            // 
            // dtp_to
            // 
            this.dtp_to.Checked = false;
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(165, 31);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.ShowCheckBox = true;
            this.dtp_to.Size = new System.Drawing.Size(95, 20);
            this.dtp_to.TabIndex = 3;
            this.dtp_to.Value = new System.DateTime(2008, 6, 5, 0, 0, 0, 0);
            // 
            // dtp_from
            // 
            this.dtp_from.Checked = false;
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(38, 31);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.ShowCheckBox = true;
            this.dtp_from.Size = new System.Drawing.Size(95, 20);
            this.dtp_from.TabIndex = 2;
            this.dtp_from.Value = new System.DateTime(2008, 6, 5, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "from";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            this.splitContainer2.Panel1.Controls.Add(this.splitter1);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(578, 480);
            this.splitContainer2.SplitterDistance = 223;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_shipname_question);
            this.panel2.Controls.Add(this.chb_categoryrel);
            this.panel2.Controls.Add(this.lb_category);
            this.panel2.Controls.Add(this.lb_catneg);
            this.panel2.Controls.Add(this.dataGridView_CriticalQuestions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(578, 100);
            this.panel2.TabIndex = 5;
            // 
            // lb_shipname_question
            // 
            this.lb_shipname_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_shipname_question.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Vessels, "VesselName", true));
            this.lb_shipname_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_shipname_question.Location = new System.Drawing.Point(294, 5);
            this.lb_shipname_question.Name = "lb_shipname_question";
            this.lb_shipname_question.Size = new System.Drawing.Size(187, 13);
            this.lb_shipname_question.TabIndex = 7;
            this.lb_shipname_question.Text = "label19";
            // 
            // chb_categoryrel
            // 
            this.chb_categoryrel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_categoryrel.AutoSize = true;
            this.chb_categoryrel.Location = new System.Drawing.Point(487, 3);
            this.chb_categoryrel.Name = "chb_categoryrel";
            this.chb_categoryrel.Size = new System.Drawing.Size(90, 17);
            this.chb_categoryrel.TabIndex = 6;
            this.chb_categoryrel.Text = "Category Rel.";
            this.chb_categoryrel.UseVisualStyleBackColor = true;
            this.chb_categoryrel.CheckedChanged += new System.EventHandler(this.chb_categoryrel_CheckedChanged);
            // 
            // lb_category
            // 
            this.lb_category.AutoSize = true;
            this.lb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_category.Location = new System.Drawing.Point(209, 5);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(48, 13);
            this.lb_category.TabIndex = 5;
            this.lb_category.Text = "label19";
            this.lb_category.Visible = false;
            // 
            // lb_catneg
            // 
            this.lb_catneg.AutoSize = true;
            this.lb_catneg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_catneg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_catneg.Location = new System.Drawing.Point(5, 5);
            this.lb_catneg.Name = "lb_catneg";
            this.lb_catneg.Size = new System.Drawing.Size(193, 13);
            this.lb_catneg.TabIndex = 4;
            this.lb_catneg.Text = "Questions with negative answers";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 115);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(578, 3);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.chb_fleetwise);
            this.panel1.Controls.Add(this.lb_shipname_categories);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(578, 110);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ChartCategory);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(391, 18);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(182, 87);
            this.panel4.TabIndex = 12;
            // 
            // ChartCategory
            // 
            this.ChartCategory.AutoRefresh = false;
            this.ChartCategory.BackColor = System.Drawing.SystemColors.Control;
            this.ChartCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartCategory.InputKeys = new System.Windows.Forms.Keys[0];
            this.ChartCategory.Location = new System.Drawing.Point(10, 0);
            this.ChartCategory.Name = "ChartCategory";
            this.ChartCategory.Size = new System.Drawing.Size(172, 87);
            this.ChartCategory.State = ((Nevron.Chart.WinForm.NState)(resources.GetObject("ChartCategory.State")));
            this.ChartCategory.TabIndex = 9;
            this.ChartCategory.Text = "nChartControl1";
            this.ChartCategory.Visible = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(388, 18);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 87);
            this.splitter3.TabIndex = 11;
            this.splitter3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgview_negative_categories);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(5, 18);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(383, 87);
            this.panel3.TabIndex = 10;
            // 
            // dgview_negative_categories
            // 
            this.dgview_negative_categories.AllowUserToAddRows = false;
            this.dgview_negative_categories.AllowUserToDeleteRows = false;
            this.dgview_negative_categories.AllowUserToResizeRows = false;
            this.dgview_negative_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview_negative_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryCode,
            this.CategoryDescription,
            this.CategoryId,
            this.CategoryNewId,
            this.DisplayOrder});
            this.dgview_negative_categories.ContextMenuStrip = this.contextMenuStrip1;
            this.dgview_negative_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgview_negative_categories.Location = new System.Drawing.Point(0, 0);
            this.dgview_negative_categories.MultiSelect = false;
            this.dgview_negative_categories.Name = "dgview_negative_categories";
            this.dgview_negative_categories.ReadOnly = true;
            this.dgview_negative_categories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview_negative_categories.Size = new System.Drawing.Size(373, 87);
            this.dgview_negative_categories.TabIndex = 2;
            // 
            // CategoryCode
            // 
            this.CategoryCode.DataPropertyName = "CategoryCode";
            this.CategoryCode.HeaderText = "Code";
            this.CategoryCode.Name = "CategoryCode";
            this.CategoryCode.ReadOnly = true;
            this.CategoryCode.Width = 50;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.DataPropertyName = "CategoryDescription";
            this.CategoryDescription.HeaderText = "Category";
            this.CategoryDescription.MinimumWidth = 150;
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            this.CategoryDescription.Width = 250;
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "CategoryId";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.Visible = false;
            // 
            // CategoryNewId
            // 
            this.CategoryNewId.DataPropertyName = "CategoryNewId";
            this.CategoryNewId.HeaderText = "Column1";
            this.CategoryNewId.Name = "CategoryNewId";
            this.CategoryNewId.ReadOnly = true;
            this.CategoryNewId.Visible = false;
            // 
            // DisplayOrder
            // 
            this.DisplayOrder.DataPropertyName = "DisplayOrder";
            this.DisplayOrder.HeaderText = "Display Order";
            this.DisplayOrder.Name = "DisplayOrder";
            this.DisplayOrder.ReadOnly = true;
            this.DisplayOrder.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultSortToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // defaultSortToolStripMenuItem
            // 
            this.defaultSortToolStripMenuItem.Name = "defaultSortToolStripMenuItem";
            this.defaultSortToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.defaultSortToolStripMenuItem.Text = "Default Sort";
            this.defaultSortToolStripMenuItem.Click += new System.EventHandler(this.defaultSortToolStripMenuItem_Click);
            // 
            // chb_fleetwise
            // 
            this.chb_fleetwise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_fleetwise.AutoSize = true;
            this.chb_fleetwise.Location = new System.Drawing.Point(503, 2);
            this.chb_fleetwise.Name = "chb_fleetwise";
            this.chb_fleetwise.Size = new System.Drawing.Size(70, 17);
            this.chb_fleetwise.TabIndex = 8;
            this.chb_fleetwise.Text = "Fleetwise";
            this.chb_fleetwise.UseVisualStyleBackColor = true;
            this.chb_fleetwise.Visible = false;
            this.chb_fleetwise.CheckedChanged += new System.EventHandler(this.chb_fleetwise_CheckedChanged);
            // 
            // lb_shipname_categories
            // 
            this.lb_shipname_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_shipname_categories.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_Vessels, "VesselName", true));
            this.lb_shipname_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_shipname_categories.Location = new System.Drawing.Point(303, 3);
            this.lb_shipname_categories.Name = "lb_shipname_categories";
            this.lb_shipname_categories.Size = new System.Drawing.Size(194, 15);
            this.lb_shipname_categories.TabIndex = 8;
            this.lb_shipname_categories.Text = "label19";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(282, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Categories/subcategories with negative answers";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ChartHistory);
            this.splitContainer3.Panel2.Controls.Add(this.splitter2);
            this.splitContainer3.Panel2.Controls.Add(this.panel_bot_right_left);
            this.splitContainer3.Panel2.Controls.Add(this.lb_sig_1);
            this.splitContainer3.Panel2.Controls.Add(this.lb_sig_2);
            this.splitContainer3.Panel2.Controls.Add(this.lb_sig_3);
            this.splitContainer3.Panel2.Controls.Add(this.lb_sig_4);
            this.splitContainer3.Panel2.Controls.Add(this.lb_sig_5);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer3.Size = new System.Drawing.Size(578, 253);
            this.splitContainer3.SplitterDistance = 138;
            this.splitContainer3.TabIndex = 6;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(10, 10);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.tb_objectcomment);
            this.splitContainer4.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.label1);
            this.splitContainer4.Panel2.Controls.Add(this.tb_usercomments);
            this.splitContainer4.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer4.Size = new System.Drawing.Size(558, 118);
            this.splitContainer4.SplitterDistance = 52;
            this.splitContainer4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question";
            // 
            // tb_objectcomment
            // 
            this.tb_objectcomment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_objectcomment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_objectcomment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.negativeQuestionsBindingSource, "ObjectDescription", true));
            this.tb_objectcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_objectcomment.Location = new System.Drawing.Point(10, 16);
            this.tb_objectcomment.Multiline = true;
            this.tb_objectcomment.Name = "tb_objectcomment";
            this.tb_objectcomment.ReadOnly = true;
            this.tb_objectcomment.Size = new System.Drawing.Size(539, 26);
            this.tb_objectcomment.TabIndex = 5;
            this.tb_objectcomment.TabStop = false;
            // 
            // negativeQuestionsBindingSource
            // 
            this.negativeQuestionsBindingSource.DataMember = "NegativeQuestions";
            this.negativeQuestionsBindingSource.DataSource = this.DataSet_ReportCritical;
            this.negativeQuestionsBindingSource.PositionChanged += new System.EventHandler(this.negativeQuestionsBindingSource_PositionChanged);
            this.negativeQuestionsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.negativeQuestionsBindingSource_ListChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inspector\'s Remark";
            // 
            // tb_usercomments
            // 
            this.tb_usercomments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_usercomments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_usercomments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vettingBindingSource, "Comments", true));
            this.tb_usercomments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usercomments.Location = new System.Drawing.Point(10, 13);
            this.tb_usercomments.Multiline = true;
            this.tb_usercomments.Name = "tb_usercomments";
            this.tb_usercomments.ReadOnly = true;
            this.tb_usercomments.Size = new System.Drawing.Size(539, 39);
            this.tb_usercomments.TabIndex = 4;
            // 
            // ChartHistory
            // 
            this.ChartHistory.AutoRefresh = false;
            this.ChartHistory.BackColor = System.Drawing.SystemColors.Control;
            this.ChartHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartHistory.InputKeys = new System.Windows.Forms.Keys[0];
            this.ChartHistory.Location = new System.Drawing.Point(413, 10);
            this.ChartHistory.Name = "ChartHistory";
            this.ChartHistory.Size = new System.Drawing.Size(155, 91);
            this.ChartHistory.State = ((Nevron.Chart.WinForm.NState)(resources.GetObject("ChartHistory.State")));
            this.ChartHistory.TabIndex = 14;
            this.ChartHistory.Text = "nChartControl1";
            this.ChartHistory.Visible = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(410, 10);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 91);
            this.splitter2.TabIndex = 13;
            this.splitter2.TabStop = false;
            // 
            // panel_bot_right_left
            // 
            this.panel_bot_right_left.Controls.Add(this.dataGridView_Results);
            this.panel_bot_right_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_bot_right_left.Location = new System.Drawing.Point(10, 10);
            this.panel_bot_right_left.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.panel_bot_right_left.Name = "panel_bot_right_left";
            this.panel_bot_right_left.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panel_bot_right_left.Size = new System.Drawing.Size(400, 91);
            this.panel_bot_right_left.TabIndex = 12;
            // 
            // lb_sig_1
            // 
            this.lb_sig_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_1.Location = new System.Drawing.Point(182, 77);
            this.lb_sig_1.Name = "lb_sig_1";
            this.lb_sig_1.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_1.TabIndex = 11;
            this.lb_sig_1.Text = "1";
            this.lb_sig_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_2
            // 
            this.lb_sig_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_2.Location = new System.Drawing.Point(182, 63);
            this.lb_sig_2.Name = "lb_sig_2";
            this.lb_sig_2.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_2.TabIndex = 10;
            this.lb_sig_2.Text = "2";
            this.lb_sig_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_3
            // 
            this.lb_sig_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_3.Location = new System.Drawing.Point(182, 49);
            this.lb_sig_3.Name = "lb_sig_3";
            this.lb_sig_3.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_3.TabIndex = 9;
            this.lb_sig_3.Text = "3";
            this.lb_sig_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_4
            // 
            this.lb_sig_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_4.Location = new System.Drawing.Point(182, 35);
            this.lb_sig_4.Name = "lb_sig_4";
            this.lb_sig_4.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_4.TabIndex = 8;
            this.lb_sig_4.Text = "4";
            this.lb_sig_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_5
            // 
            this.lb_sig_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_5.Location = new System.Drawing.Point(182, 21);
            this.lb_sig_5.Name = "lb_sig_5";
            this.lb_sig_5.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_5.TabIndex = 7;
            this.lb_sig_5.Text = "5";
            this.lb_sig_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Related Vettings";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_VesselQuestionVetting);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 598);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_VesselQuestionVetting
            // 
            this.tabPage_VesselQuestionVetting.Controls.Add(this.label17);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.label16);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.label15);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.label14);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.label13);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.lb_sig_bot_5);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.lb_sig_bot_4);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.lb_sig_bot_3);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.lb_sig_bot_2);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.lb_sig_bot_1);
            this.tabPage_VesselQuestionVetting.Controls.Add(this.splitContainer1);
            this.tabPage_VesselQuestionVetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_VesselQuestionVetting.Name = "tabPage_VesselQuestionVetting";
            this.tabPage_VesselQuestionVetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_VesselQuestionVetting.Size = new System.Drawing.Size(996, 572);
            this.tabPage_VesselQuestionVetting.TabIndex = 0;
            this.tabPage_VesselQuestionVetting.Text = "Vessel- Question - Vetting";
            this.tabPage_VesselQuestionVetting.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(670, 546);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 14);
            this.label17.TabIndex = 21;
            this.label17.Text = "critical";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(468, 546);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 14);
            this.label16.TabIndex = 20;
            this.label16.Text = "important";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(576, 546);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 14);
            this.label15.TabIndex = 19;
            this.label15.Text = "high";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(365, 546);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 14);
            this.label14.TabIndex = 18;
            this.label14.Text = "medium";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(294, 546);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 14);
            this.label13.TabIndex = 17;
            this.label13.Text = "low";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_bot_5
            // 
            this.lb_sig_bot_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sig_bot_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_bot_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_bot_5.Location = new System.Drawing.Point(648, 546);
            this.lb_sig_bot_5.Name = "lb_sig_bot_5";
            this.lb_sig_bot_5.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_bot_5.TabIndex = 16;
            this.lb_sig_bot_5.Text = "5";
            this.lb_sig_bot_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_bot_4
            // 
            this.lb_sig_bot_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sig_bot_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_bot_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_bot_4.Location = new System.Drawing.Point(554, 546);
            this.lb_sig_bot_4.Name = "lb_sig_bot_4";
            this.lb_sig_bot_4.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_bot_4.TabIndex = 15;
            this.lb_sig_bot_4.Text = "4";
            this.lb_sig_bot_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_sig_bot_4.Click += new System.EventHandler(this.label16_Click);
            // 
            // lb_sig_bot_3
            // 
            this.lb_sig_bot_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sig_bot_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_bot_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_bot_3.Location = new System.Drawing.Point(445, 546);
            this.lb_sig_bot_3.Name = "lb_sig_bot_3";
            this.lb_sig_bot_3.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_bot_3.TabIndex = 14;
            this.lb_sig_bot_3.Text = "3";
            this.lb_sig_bot_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_bot_2
            // 
            this.lb_sig_bot_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sig_bot_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_bot_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_bot_2.Location = new System.Drawing.Point(343, 546);
            this.lb_sig_bot_2.Name = "lb_sig_bot_2";
            this.lb_sig_bot_2.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_bot_2.TabIndex = 13;
            this.lb_sig_bot_2.Text = "2";
            this.lb_sig_bot_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sig_bot_1
            // 
            this.lb_sig_bot_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_sig_bot_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sig_bot_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sig_bot_1.Location = new System.Drawing.Point(272, 546);
            this.lb_sig_bot_1.Name = "lb_sig_bot_1";
            this.lb_sig_bot_1.Size = new System.Drawing.Size(16, 14);
            this.lb_sig_bot_1.TabIndex = 12;
            this.lb_sig_bot_1.Text = "1";
            this.lb_sig_bot_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Question History";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(990, 98);
            this.label4.TabIndex = 0;
            this.label4.Text = "NOT IMPLEMENTED";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_ReportCritical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 615);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_ReportCritical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negative Results";
            this.Load += new System.EventHandler(this.Form_ReportCritical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CriticalQuestions)).EndInit();
            this.contextMenuStripNegAnswers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            this.contextMenuStrip_relvet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vettingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_ReportCritical)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vessels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Vessels)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgview_negative_categories)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.negativeQuestionsBindingSource)).EndInit();
            this.panel_bot_right_left.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_VesselQuestionVetting.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet_ReportCritical DataSet_ReportCritical;
        private System.Windows.Forms.BindingSource bindingSource_Vessels;
        private System.Windows.Forms.DataGridView dataGridView_CriticalQuestions;
        private System.Windows.Forms.BindingSource negativeQuestionsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_Results;
        private System.Windows.Forms.BindingSource vettingBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_VesselQuestionVetting;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_usercomments;
        private System.Windows.Forms.TextBox tb_objectcomment;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_sig_1;
        private System.Windows.Forms.Label lb_sig_2;
        private System.Windows.Forms.Label lb_sig_3;
        private System.Windows.Forms.Label lb_sig_4;
        private System.Windows.Forms.Label lb_sig_5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Label lb_perc;
        private System.Windows.Forms.Label lb_negativenum;
        private System.Windows.Forms.Label lb_totalnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.CheckBox chb_autostatistics;
        private System.Windows.Forms.CheckBox chb_vesselspecific;
        private System.Windows.Forms.Label lb_vesselname;
        private System.Windows.Forms.DataGridView dataGridView_Vessels;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_totalseen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_seentotalperc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_sig_bot_5;
        private System.Windows.Forms.Label lb_sig_bot_4;
        private System.Windows.Forms.Label lb_sig_bot_3;
        private System.Windows.Forms.Label lb_sig_bot_2;
        private System.Windows.Forms.Label lb_sig_bot_1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgview_negative_categories;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_catneg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_category;
        private System.Windows.Forms.CheckBox chb_categoryrel;
        private System.Windows.Forms.Label lb_shipname_categories;
        private System.Windows.Forms.Label lb_shipname_question;
        private System.Windows.Forms.CheckBox chb_fleetwise;
        private System.Windows.Forms.Panel panel_bot_right_left;
        private Nevron.Chart.WinForm.NChartControl ChartHistory;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNegAnswers;
        private System.Windows.Forms.ToolStripMenuItem viewContextToolStripMenuItem;
        private Nevron.Chart.WinForm.NChartControl ChartCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panel3;
        private Nevron.Chart.WinForm.NChartControl chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vettingCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn significanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyRepresentativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyRepresentativeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn globalDisplayIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem defaultSortToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_relvet;
        private System.Windows.Forms.ToolStripMenuItem viewVettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultSortNegAnswersToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNewId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_crit;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VesselId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VesselName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryNewId_crit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisplayOrderQuestions;


    }
}