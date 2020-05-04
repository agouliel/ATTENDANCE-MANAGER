namespace WindowsFormsApplication1
{
    partial class Form_QuestionnaireInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewVIQRegistry = new System.Windows.Forms.DataGridView();
            this.qIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NumQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIQInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
this.tb_comments = new System.Windows.Forms.TextBox();
            this.lb_comments = new System.Windows.Forms.Label();
            this.lb_viqtitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToBriefcaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVIQRegistry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVIQRegistry
            // 
            this.dataGridViewVIQRegistry.AllowUserToResizeRows = false;
            this.dataGridViewVIQRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVIQRegistry.AutoGenerateColumns = false;
            this.dataGridViewVIQRegistry.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVIQRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVIQRegistry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.Version,
            this.EffectiveDate,
            this.finalizedDataGridViewTextBoxColumn,
            this.NumQuestions,
            this.authorDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridViewVIQRegistry.DataSource = this.vIQInfoBindingSource;
            this.dataGridViewVIQRegistry.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVIQRegistry.MultiSelect = false;
            this.dataGridViewVIQRegistry.Name = "dataGridViewVIQRegistry";
            this.dataGridViewVIQRegistry.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewVIQRegistry.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVIQRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVIQRegistry.Size = new System.Drawing.Size(1043, 355);
            this.dataGridViewVIQRegistry.StandardTab = true;
            this.dataGridViewVIQRegistry.TabIndex = 0;
            this.dataGridViewVIQRegistry.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewVIQRegistry_CellMouseDoubleClick);
            // 
            // qIdDataGridViewTextBoxColumn
            // 
            this.qIdDataGridViewTextBoxColumn.DataPropertyName = "QId";
            this.qIdDataGridViewTextBoxColumn.Frozen = true;
            this.qIdDataGridViewTextBoxColumn.HeaderText = "QId";
            this.qIdDataGridViewTextBoxColumn.Name = "qIdDataGridViewTextBoxColumn";
            this.qIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.Frozen = true;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 300;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.Frozen = true;
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // EffectiveDate
            // 
            this.EffectiveDate.DataPropertyName = "EffectiveDate";
            this.EffectiveDate.Frozen = true;
            this.EffectiveDate.HeaderText = "Eff. Date";
            this.EffectiveDate.Name = "EffectiveDate";
            this.EffectiveDate.ReadOnly = true;
            // 
            // finalizedDataGridViewTextBoxColumn
            // 
            this.finalizedDataGridViewTextBoxColumn.DataPropertyName = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.FalseValue = "0";
            this.finalizedDataGridViewTextBoxColumn.Frozen = true;
            this.finalizedDataGridViewTextBoxColumn.HeaderText = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.Name = "finalizedDataGridViewTextBoxColumn";
            this.finalizedDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalizedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.finalizedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.finalizedDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // NumQuestions
            // 
            this.NumQuestions.DataPropertyName = "NumOfQuestions";
            this.NumQuestions.HeaderText = "Num. of Questions";
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.ReadOnly = true;
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
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Visible = false;
            this.commentsDataGridViewTextBoxColumn.Width = 300;
            // 
            // vIQInfoBindingSource
            // 
            this.vIQInfoBindingSource.AllowNew = false;
            this.vIQInfoBindingSource.DataMember = "VIQInfo";
            this.vIQInfoBindingSource.DataSource = this.attendanceBindingSource;
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
            // bt_ok
            // 
            this.bt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ok.Location = new System.Drawing.Point(980, 468);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "&Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_delete.Location = new System.Drawing.Point(27, 468);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(78, 20);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.Location = new System.Drawing.Point(888, 468);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "&Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
           
            // 
            // tb_comments
            // 
            this.tb_comments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_comments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_comments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIQInfoBindingSource, "Comments", true));
            this.tb_comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comments.Location = new System.Drawing.Point(12, 385);
            this.tb_comments.Multiline = true;
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.ReadOnly = true;
            this.tb_comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_comments.Size = new System.Drawing.Size(697, 61);
            this.tb_comments.TabIndex = 4;
            this.tb_comments.TabStop = false;
            // 
            // lb_comments
            // 
            this.lb_comments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_comments.AutoSize = true;
            this.lb_comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_comments.Location = new System.Drawing.Point(12, 370);
            this.lb_comments.Name = "lb_comments";
            this.lb_comments.Size = new System.Drawing.Size(64, 13);
            this.lb_comments.TabIndex = 5;
            this.lb_comments.Text = "Comments";
            // 
            // lb_viqtitle
            // 
            this.lb_viqtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_viqtitle.AutoSize = true;
            this.lb_viqtitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIQInfoBindingSource, "Title", true));
            this.lb_viqtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_viqtitle.ForeColor = System.Drawing.Color.Blue;
            this.lb_viqtitle.Location = new System.Drawing.Point(117, 370);
            this.lb_viqtitle.Name = "lb_viqtitle";
            this.lb_viqtitle.Size = new System.Drawing.Size(116, 13);
            this.lb_viqtitle.TabIndex = 6;
            this.lb_viqtitle.Text = "comments asdfaafd";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToBriefcaseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // exportToBriefcaseToolStripMenuItem
            // 
            this.exportToBriefcaseToolStripMenuItem.Name = "exportToBriefcaseToolStripMenuItem";
            this.exportToBriefcaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToBriefcaseToolStripMenuItem.Text = "Export to briefcase...";
            this.exportToBriefcaseToolStripMenuItem.Click += new System.EventHandler(this.exportToBriefcaseToolStripMenuItem_Click);
            // 
            // Form_QuestionnaireInfo
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 503);
            this.Controls.Add(this.lb_viqtitle);
            this.Controls.Add(this.lb_comments);
            this.Controls.Add(this.tb_comments);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.dataGridViewVIQRegistry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_QuestionnaireInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Questionnaire";
            this.Load += new System.EventHandler(this.Form_QuestionnaireInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVIQRegistry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVIQRegistry;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private System.Windows.Forms.BindingSource vIQInfoBindingSource;
        public Attendance attendance;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox tb_comments;
        private System.Windows.Forms.Label lb_comments;
        private System.Windows.Forms.Label lb_viqtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn finalizedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToBriefcaseToolStripMenuItem;
    }
}