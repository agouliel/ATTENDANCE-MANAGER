namespace WindowsFormsApplication1
{
    partial class FormBriefcase
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewQuestionnaires = new System.Windows.Forms.DataGridView();
            this.qIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIQInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.bt_removequestionnaire = new System.Windows.Forms.Button();
            this.bt_OpenQuestionnaire = new System.Windows.Forms.Button();
            this.bt_Addquestionnaire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_transfervetting = new System.Windows.Forms.Button();
            this.bt_openattendance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVettings = new System.Windows.Forms.DataGridView();
            this.vetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vettingCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesselNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorSirnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionnaireTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vettingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vesselsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionnaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vettingInfoBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewQuestionnaires);
            this.splitContainer1.Panel1.Controls.Add(this.bt_removequestionnaire);
            this.splitContainer1.Panel1.Controls.Add(this.bt_OpenQuestionnaire);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Addquestionnaire);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bt_transfervetting);
            this.splitContainer1.Panel2.Controls.Add(this.bt_openattendance);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewVettings);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(1044, 481);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewQuestionnaires
            // 
            this.dataGridViewQuestionnaires.AllowUserToAddRows = false;
            this.dataGridViewQuestionnaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewQuestionnaires.AutoGenerateColumns = false;
            this.dataGridViewQuestionnaires.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewQuestionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestionnaires.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.finalizedDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.NumOfQuestions});
            this.dataGridViewQuestionnaires.DataSource = this.vIQInfoBindingSource;
            this.dataGridViewQuestionnaires.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewQuestionnaires.Name = "dataGridViewQuestionnaires";
            this.dataGridViewQuestionnaires.ReadOnly = true;
            this.dataGridViewQuestionnaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuestionnaires.Size = new System.Drawing.Size(946, 171);
            this.dataGridViewQuestionnaires.TabIndex = 2;
            this.dataGridViewQuestionnaires.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuestionnaires_CellDoubleClick);
            // 
            // qIdDataGridViewTextBoxColumn
            // 
            this.qIdDataGridViewTextBoxColumn.DataPropertyName = "QId";
            this.qIdDataGridViewTextBoxColumn.HeaderText = "QId";
            this.qIdDataGridViewTextBoxColumn.Name = "qIdDataGridViewTextBoxColumn";
            this.qIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 300;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 250;
            // 
            // finalizedDataGridViewTextBoxColumn
            // 
            this.finalizedDataGridViewTextBoxColumn.DataPropertyName = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.HeaderText = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.Name = "finalizedDataGridViewTextBoxColumn";
            this.finalizedDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalizedDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "Reg. Date";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NumOfQuestions
            // 
            this.NumOfQuestions.DataPropertyName = "NumOfQuestions";
            this.NumOfQuestions.HeaderText = "Num .Questions";
            this.NumOfQuestions.Name = "NumOfQuestions";
            this.NumOfQuestions.ReadOnly = true;
            this.NumOfQuestions.Width = 150;
            // 
            // vIQInfoBindingSource
            // 
            this.vIQInfoBindingSource.DataMember = "VIQInfo";
            this.vIQInfoBindingSource.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_removequestionnaire
            // 
            this.bt_removequestionnaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_removequestionnaire.Location = new System.Drawing.Point(432, 198);
            this.bt_removequestionnaire.Name = "bt_removequestionnaire";
            this.bt_removequestionnaire.Size = new System.Drawing.Size(135, 25);
            this.bt_removequestionnaire.TabIndex = 2;
            this.bt_removequestionnaire.Text = "Remove Questionnaires";
            this.bt_removequestionnaire.UseVisualStyleBackColor = true;
            this.bt_removequestionnaire.Click += new System.EventHandler(this.bt_removequestionnaire_Click);
            // 
            // bt_OpenQuestionnaire
            // 
            this.bt_OpenQuestionnaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_OpenQuestionnaire.Location = new System.Drawing.Point(818, 198);
            this.bt_OpenQuestionnaire.Name = "bt_OpenQuestionnaire";
            this.bt_OpenQuestionnaire.Size = new System.Drawing.Size(128, 25);
            this.bt_OpenQuestionnaire.TabIndex = 3;
            this.bt_OpenQuestionnaire.Text = "Open Questionnaire";
            this.bt_OpenQuestionnaire.UseVisualStyleBackColor = true;
            this.bt_OpenQuestionnaire.Click += new System.EventHandler(this.bt_OpenQuestionnaire_Click);
            // 
            // bt_Addquestionnaire
            // 
            this.bt_Addquestionnaire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Addquestionnaire.Location = new System.Drawing.Point(602, 198);
            this.bt_Addquestionnaire.Name = "bt_Addquestionnaire";
            this.bt_Addquestionnaire.Size = new System.Drawing.Size(135, 25);
            this.bt_Addquestionnaire.TabIndex = 1;
            this.bt_Addquestionnaire.Text = "Add Questionnaires";
            this.bt_Addquestionnaire.UseVisualStyleBackColor = true;
            this.bt_Addquestionnaire.Click += new System.EventHandler(this.bt_Addquestionnaire_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registered Questionnaires";
            // 
            // bt_transfervetting
            // 
            this.bt_transfervetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_transfervetting.Location = new System.Drawing.Point(609, 225);
            this.bt_transfervetting.Name = "bt_transfervetting";
            this.bt_transfervetting.Size = new System.Drawing.Size(128, 25);
            this.bt_transfervetting.TabIndex = 5;
            this.bt_transfervetting.Text = "Transfer To Database";
            this.bt_transfervetting.UseVisualStyleBackColor = true;
            this.bt_transfervetting.Click += new System.EventHandler(this.bt_transfervetting_Click);
            // 
            // bt_openattendance
            // 
            this.bt_openattendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_openattendance.Location = new System.Drawing.Point(818, 225);
            this.bt_openattendance.Name = "bt_openattendance";
            this.bt_openattendance.Size = new System.Drawing.Size(128, 25);
            this.bt_openattendance.TabIndex = 4;
            this.bt_openattendance.Text = "Open Attendance";
            this.bt_openattendance.UseVisualStyleBackColor = true;
            this.bt_openattendance.Click += new System.EventHandler(this.bt_openattendance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registered Attendances";
            // 
            // dataGridViewVettings
            // 
            this.dataGridViewVettings.AllowUserToAddRows = false;
            this.dataGridViewVettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVettings.AutoGenerateColumns = false;
            this.dataGridViewVettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewVettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vetIdDataGridViewTextBoxColumn,
            this.vettingCodeDataGridViewTextBoxColumn,
            this.qIdDataGridViewTextBoxColumn1,
            this.vesselNameDataGridViewTextBoxColumn,
            this.vetDateDataGridViewTextBoxColumn,
            this.inspectorNameDataGridViewTextBoxColumn,
            this.inspectorSirnameDataGridViewTextBoxColumn,
            this.vetTimeDataGridViewTextBoxColumn,
            this.NumAnswer,
            this.passwordDataGridViewTextBoxColumn,
            this.QuestionnaireTitle,
            this.commentsDataGridViewTextBoxColumn1});
            this.dataGridViewVettings.DataSource = this.vettingInfoBindingSource;
            this.dataGridViewVettings.Location = new System.Drawing.Point(1, 26);
            this.dataGridViewVettings.Name = "dataGridViewVettings";
            this.dataGridViewVettings.ReadOnly = true;
            this.dataGridViewVettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVettings.Size = new System.Drawing.Size(1043, 198);
            this.dataGridViewVettings.TabIndex = 0;
            this.dataGridViewVettings.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVettings_CellMouseDoubleClick);
            // 
            // vetIdDataGridViewTextBoxColumn
            // 
            this.vetIdDataGridViewTextBoxColumn.DataPropertyName = "VetId";
            this.vetIdDataGridViewTextBoxColumn.Frozen = true;
            this.vetIdDataGridViewTextBoxColumn.HeaderText = "Vet. Id";
            this.vetIdDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.vetIdDataGridViewTextBoxColumn.Name = "vetIdDataGridViewTextBoxColumn";
            this.vetIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // vettingCodeDataGridViewTextBoxColumn
            // 
            this.vettingCodeDataGridViewTextBoxColumn.DataPropertyName = "VettingCode";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            this.vettingCodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vettingCodeDataGridViewTextBoxColumn.Frozen = true;
            this.vettingCodeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.vettingCodeDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.vettingCodeDataGridViewTextBoxColumn.Name = "vettingCodeDataGridViewTextBoxColumn";
            this.vettingCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vettingCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // qIdDataGridViewTextBoxColumn1
            // 
            this.qIdDataGridViewTextBoxColumn1.DataPropertyName = "QId";
            this.qIdDataGridViewTextBoxColumn1.Frozen = true;
            this.qIdDataGridViewTextBoxColumn1.HeaderText = "QId";
            this.qIdDataGridViewTextBoxColumn1.Name = "qIdDataGridViewTextBoxColumn1";
            this.qIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qIdDataGridViewTextBoxColumn1.Width = 50;
            // 
            // vesselNameDataGridViewTextBoxColumn
            // 
            this.vesselNameDataGridViewTextBoxColumn.DataPropertyName = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn.Frozen = true;
            this.vesselNameDataGridViewTextBoxColumn.HeaderText = "Vessel Name";
            this.vesselNameDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.vesselNameDataGridViewTextBoxColumn.Name = "vesselNameDataGridViewTextBoxColumn";
            this.vesselNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vesselNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // vetDateDataGridViewTextBoxColumn
            // 
            this.vetDateDataGridViewTextBoxColumn.DataPropertyName = "VetDate";
            this.vetDateDataGridViewTextBoxColumn.Frozen = true;
            this.vetDateDataGridViewTextBoxColumn.HeaderText = "VetDate";
            this.vetDateDataGridViewTextBoxColumn.Name = "vetDateDataGridViewTextBoxColumn";
            this.vetDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorNameDataGridViewTextBoxColumn
            // 
            this.inspectorNameDataGridViewTextBoxColumn.DataPropertyName = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.HeaderText = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.inspectorNameDataGridViewTextBoxColumn.Name = "inspectorNameDataGridViewTextBoxColumn";
            this.inspectorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectorNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // inspectorSirnameDataGridViewTextBoxColumn
            // 
            this.inspectorSirnameDataGridViewTextBoxColumn.DataPropertyName = "InspectorSirname";
            this.inspectorSirnameDataGridViewTextBoxColumn.HeaderText = "InspectorSirname";
            this.inspectorSirnameDataGridViewTextBoxColumn.Name = "inspectorSirnameDataGridViewTextBoxColumn";
            this.inspectorSirnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectorSirnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // vetTimeDataGridViewTextBoxColumn
            // 
            this.vetTimeDataGridViewTextBoxColumn.DataPropertyName = "VetTime";
            this.vetTimeDataGridViewTextBoxColumn.HeaderText = "VetTime";
            this.vetTimeDataGridViewTextBoxColumn.Name = "vetTimeDataGridViewTextBoxColumn";
            this.vetTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // NumAnswer
            // 
            this.NumAnswer.DataPropertyName = "NumAnswer";
            this.NumAnswer.HeaderText = "Answered";
            this.NumAnswer.Name = "NumAnswer";
            this.NumAnswer.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // QuestionnaireTitle
            // 
            this.QuestionnaireTitle.DataPropertyName = "QuestionnaireTitle";
            this.QuestionnaireTitle.HeaderText = "Template";
            this.QuestionnaireTitle.Name = "QuestionnaireTitle";
            this.QuestionnaireTitle.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn1
            // 
            this.commentsDataGridViewTextBoxColumn1.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn1.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn1.Name = "commentsDataGridViewTextBoxColumn1";
            this.commentsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vettingInfoBindingSource
            // 
            this.vettingInfoBindingSource.DataMember = "VettingInfo";
            this.vettingInfoBindingSource.DataSource = this.attendance;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vesselsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vesselsToolStripMenuItem
            // 
            this.vesselsToolStripMenuItem.Name = "vesselsToolStripMenuItem";
            this.vesselsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.vesselsToolStripMenuItem.Text = "&Vessels";
            this.vesselsToolStripMenuItem.Click += new System.EventHandler(this.vesselsToolStripMenuItem_Click);
            // 
            // FormBriefcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 547);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBriefcase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Briefcase";
            this.Load += new System.EventHandler(this.FormBriefcase_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestionnaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vettingInfoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewVettings;
        private System.Windows.Forms.DataGridView dataGridViewQuestionnaires;
        private System.Windows.Forms.Label label2;
        private Attendance attendance;
        private System.Windows.Forms.BindingSource vIQInfoBindingSource;
        private System.Windows.Forms.BindingSource vettingInfoBindingSource;
        private System.Windows.Forms.Button bt_Addquestionnaire;
        private System.Windows.Forms.Button bt_removequestionnaire;
        private System.Windows.Forms.Button bt_OpenQuestionnaire;
        private System.Windows.Forms.Button bt_openattendance;
        private System.Windows.Forms.Button bt_transfervetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalizedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vettingCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorSirnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionnaireTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vesselsToolStripMenuItem;
    }
}