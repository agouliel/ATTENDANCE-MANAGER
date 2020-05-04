namespace WindowsFormsApplication1
{
    partial class FormAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridView_Attendances = new System.Windows.Forms.DataGridView();
            this.vetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesselNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InspectionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MajorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vettingCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyRepresentativeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorSirnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionnaireTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetGUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vettingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.bt_openvetting = new System.Windows.Forms.Button();
            this.tb_vetcomments = new System.Windows.Forms.TextBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Attendances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vettingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.panel_top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView_Attendances
            // 
            this.dataGridView_Attendances.AllowUserToAddRows = false;
            this.dataGridView_Attendances.AllowUserToDeleteRows = false;
            this.dataGridView_Attendances.AllowUserToResizeRows = false;
            this.dataGridView_Attendances.AutoGenerateColumns = false;
            this.dataGridView_Attendances.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Attendances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Attendances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vetIdDataGridViewTextBoxColumn,
            this.vesselNameDataGridViewTextBoxColumn,
            this.vetDateDataGridViewTextBoxColumn,
            this.InspectionType,
            this.MajorName,
            this.vettingCodeDataGridViewTextBoxColumn,
            this.CompanyRepresentativeName,
            this.portPlaceDataGridViewTextBoxColumn,
            this.inspectorNameDataGridViewTextBoxColumn,
            this.inspectorSirnameDataGridViewTextBoxColumn,
            this.QuestionnaireTitle,
            this.Version,
            this.vetTimeDataGridViewTextBoxColumn,
            this.RegistrationDate,
            this.passwordDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.qIdDataGridViewTextBoxColumn,
            this.numAnswerDataGridViewTextBoxColumn,
            this.vetGUIDataGridViewTextBoxColumn});
            this.dataGridView_Attendances.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_Attendances.DataSource = this.vettingInfoBindingSource;
            this.dataGridView_Attendances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Attendances.Location = new System.Drawing.Point(5, 5);
            this.dataGridView_Attendances.MultiSelect = false;
            this.dataGridView_Attendances.Name = "dataGridView_Attendances";
            this.dataGridView_Attendances.ReadOnly = true;
            this.dataGridView_Attendances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Attendances.Size = new System.Drawing.Size(962, 318);
            this.dataGridView_Attendances.TabIndex = 1;
            this.dataGridView_Attendances.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Attendances_CellMouseDoubleClick);
            // 
            // vetIdDataGridViewTextBoxColumn
            // 
            this.vetIdDataGridViewTextBoxColumn.DataPropertyName = "VetId";
            this.vetIdDataGridViewTextBoxColumn.Frozen = true;
            this.vetIdDataGridViewTextBoxColumn.HeaderText = "VetId";
            this.vetIdDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.vetIdDataGridViewTextBoxColumn.Name = "vetIdDataGridViewTextBoxColumn";
            this.vetIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // vesselNameDataGridViewTextBoxColumn
            // 
            this.vesselNameDataGridViewTextBoxColumn.DataPropertyName = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn.Frozen = true;
            this.vesselNameDataGridViewTextBoxColumn.HeaderText = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.vesselNameDataGridViewTextBoxColumn.Name = "vesselNameDataGridViewTextBoxColumn";
            this.vesselNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.vesselNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // vetDateDataGridViewTextBoxColumn
            // 
            this.vetDateDataGridViewTextBoxColumn.DataPropertyName = "VetDate";
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            dataGridViewCellStyle7.NullValue = null;
            this.vetDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.vetDateDataGridViewTextBoxColumn.Frozen = true;
            this.vetDateDataGridViewTextBoxColumn.HeaderText = "VetDate";
            this.vetDateDataGridViewTextBoxColumn.Name = "vetDateDataGridViewTextBoxColumn";
            this.vetDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InspectionType
            // 
            this.InspectionType.DataPropertyName = "InspectionType";
            this.InspectionType.Frozen = true;
            this.InspectionType.HeaderText = "InspectionType";
            this.InspectionType.Name = "InspectionType";
            this.InspectionType.ReadOnly = true;
            // 
            // MajorName
            // 
            this.MajorName.DataPropertyName = "MajorName";
            this.MajorName.Frozen = true;
            this.MajorName.HeaderText = "Major";
            this.MajorName.Name = "MajorName";
            this.MajorName.ReadOnly = true;
            // 
            // vettingCodeDataGridViewTextBoxColumn
            // 
            this.vettingCodeDataGridViewTextBoxColumn.DataPropertyName = "VettingCode";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Yellow;
            this.vettingCodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.vettingCodeDataGridViewTextBoxColumn.Frozen = true;
            this.vettingCodeDataGridViewTextBoxColumn.HeaderText = "VettingCode";
            this.vettingCodeDataGridViewTextBoxColumn.Name = "vettingCodeDataGridViewTextBoxColumn";
            this.vettingCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vettingCodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // CompanyRepresentativeName
            // 
            this.CompanyRepresentativeName.DataPropertyName = "CompanyRepresentativeName";
            this.CompanyRepresentativeName.Frozen = true;
            this.CompanyRepresentativeName.HeaderText = "Company\'s Repr.";
            this.CompanyRepresentativeName.MinimumWidth = 150;
            this.CompanyRepresentativeName.Name = "CompanyRepresentativeName";
            this.CompanyRepresentativeName.ReadOnly = true;
            this.CompanyRepresentativeName.Width = 150;
            // 
            // portPlaceDataGridViewTextBoxColumn
            // 
            this.portPlaceDataGridViewTextBoxColumn.DataPropertyName = "Port/Place";
            this.portPlaceDataGridViewTextBoxColumn.HeaderText = "Port/Place";
            this.portPlaceDataGridViewTextBoxColumn.Name = "portPlaceDataGridViewTextBoxColumn";
            this.portPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.portPlaceDataGridViewTextBoxColumn.Width = 200;
            // 
            // inspectorNameDataGridViewTextBoxColumn
            // 
            this.inspectorNameDataGridViewTextBoxColumn.DataPropertyName = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.HeaderText = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.Name = "inspectorNameDataGridViewTextBoxColumn";
            this.inspectorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // inspectorSirnameDataGridViewTextBoxColumn
            // 
            this.inspectorSirnameDataGridViewTextBoxColumn.DataPropertyName = "InspectorSirname";
            this.inspectorSirnameDataGridViewTextBoxColumn.HeaderText = "InspectorSirname";
            this.inspectorSirnameDataGridViewTextBoxColumn.Name = "inspectorSirnameDataGridViewTextBoxColumn";
            this.inspectorSirnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectorSirnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // QuestionnaireTitle
            // 
            this.QuestionnaireTitle.DataPropertyName = "QuestionnaireTitle";
            this.QuestionnaireTitle.HeaderText = "QuestionnaireTitle";
            this.QuestionnaireTitle.Name = "QuestionnaireTitle";
            this.QuestionnaireTitle.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "Version";
            this.Version.HeaderText = "Quest. Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // vetTimeDataGridViewTextBoxColumn
            // 
            this.vetTimeDataGridViewTextBoxColumn.DataPropertyName = "VetTime";
            this.vetTimeDataGridViewTextBoxColumn.HeaderText = "VetTime";
            this.vetTimeDataGridViewTextBoxColumn.Name = "vetTimeDataGridViewTextBoxColumn";
            this.vetTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.HeaderText = "Reg. Date";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Visible = false;
            this.commentsDataGridViewTextBoxColumn.Width = 250;
            // 
            // qIdDataGridViewTextBoxColumn
            // 
            this.qIdDataGridViewTextBoxColumn.DataPropertyName = "QId";
            this.qIdDataGridViewTextBoxColumn.HeaderText = "QId";
            this.qIdDataGridViewTextBoxColumn.Name = "qIdDataGridViewTextBoxColumn";
            this.qIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numAnswerDataGridViewTextBoxColumn
            // 
            this.numAnswerDataGridViewTextBoxColumn.DataPropertyName = "NumAnswer";
            this.numAnswerDataGridViewTextBoxColumn.HeaderText = "NumAnswer";
            this.numAnswerDataGridViewTextBoxColumn.Name = "numAnswerDataGridViewTextBoxColumn";
            this.numAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vetGUIDataGridViewTextBoxColumn
            // 
            this.vetGUIDataGridViewTextBoxColumn.DataPropertyName = "VetGUI";
            this.vetGUIDataGridViewTextBoxColumn.HeaderText = "VetGUI";
            this.vetGUIDataGridViewTextBoxColumn.Name = "vetGUIDataGridViewTextBoxColumn";
            this.vetGUIDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetGUIDataGridViewTextBoxColumn.Visible = false;
            // 
            // vettingInfoBindingSource
            // 
            this.vettingInfoBindingSource.DataMember = "VettingInfo";
            this.vettingInfoBindingSource.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_openvetting
            // 
            this.bt_openvetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_openvetting.Location = new System.Drawing.Point(859, 19);
            this.bt_openvetting.Name = "bt_openvetting";
            this.bt_openvetting.Size = new System.Drawing.Size(110, 29);
            this.bt_openvetting.TabIndex = 2;
            this.bt_openvetting.Text = "Open Attendance";
            this.bt_openvetting.UseVisualStyleBackColor = true;
            this.bt_openvetting.Click += new System.EventHandler(this.bt_openvetting_Click);
            // 
            // tb_vetcomments
            // 
            this.tb_vetcomments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_vetcomments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_vetcomments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vettingInfoBindingSource, "Comments", true));
            this.tb_vetcomments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vetcomments.Location = new System.Drawing.Point(5, 19);
            this.tb_vetcomments.Multiline = true;
            this.tb_vetcomments.Name = "tb_vetcomments";
            this.tb_vetcomments.ReadOnly = true;
            this.tb_vetcomments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_vetcomments.Size = new System.Drawing.Size(848, 99);
            this.tb_vetcomments.TabIndex = 3;
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.dataGridView_Attendances);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(5);
            this.panel_top.Size = new System.Drawing.Size(972, 328);
            this.panel_top.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 328);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(972, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_vetcomments);
            this.panel1.Controls.Add(this.bt_openvetting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 130);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vettingInfoBindingSource, "VettingCode", true));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "vetting code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vetting Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "General comments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAttendanceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // viewAttendanceToolStripMenuItem
            // 
            this.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            this.viewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewAttendanceToolStripMenuItem.Text = "View ...";
            this.viewAttendanceToolStripMenuItem.Click += new System.EventHandler(this.viewAttendanceToolStripMenuItem_Click);
            // 
            // FormAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Registry";
            this.Load += new System.EventHandler(this.FormAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Attendances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vettingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView_Attendances;
        private System.Windows.Forms.BindingSource vettingInfoBindingSource;
        private Attendance attendance;
        private System.Windows.Forms.Button bt_openvetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tb_vetcomments;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InspectionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MajorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vettingCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyRepresentativeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn portPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorSirnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionnaireTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetGUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewAttendanceToolStripMenuItem;
    }
}