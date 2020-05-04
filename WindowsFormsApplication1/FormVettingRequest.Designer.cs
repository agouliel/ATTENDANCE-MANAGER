namespace WindowsFormsApplication1
{
    partial class FormVettingRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_vettingrequest = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_download = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_schedule = new System.Windows.Forms.DataGridView();
            this.dgvcol_VesselId_cmb = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcol_InspectionTypeCmb = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcol_VetDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcol_InspectionTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colRequestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBriefcaseFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGranted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colVetRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vettingrequest)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vettingrequest
            // 
            this.dgv_vettingrequest.AllowUserToAddRows = false;
            this.dgv_vettingrequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_vettingrequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vettingrequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequestCode,
            this.ComputerName,
            this.colUserName,
            this.colRequestDate,
            this.colBriefcaseFile,
            this.colGranted,
            this.colVetRequestId});
            this.dgv_vettingrequest.Location = new System.Drawing.Point(24, 20);
            this.dgv_vettingrequest.Name = "dgv_vettingrequest";
            this.dgv_vettingrequest.Size = new System.Drawing.Size(879, 162);
            this.dgv_vettingrequest.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_vettingrequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 210);
            this.panel1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(5, 215);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(925, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.bt_download);
            this.panel2.Controls.Add(this.bt_submit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgv_schedule);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lb_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 218);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 199);
            this.panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 177);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(925, 22);
            this.statusStrip1.TabIndex = 7;
            // 
            // statMessage
            // 
            this.statMessage.Name = "statMessage";
            this.statMessage.Size = new System.Drawing.Size(910, 17);
            this.statMessage.Spring = true;
            // 
            // bt_download
            // 
            this.bt_download.Enabled = false;
            this.bt_download.Location = new System.Drawing.Point(56, 82);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(75, 23);
            this.bt_download.TabIndex = 6;
            this.bt_download.Text = "&Download";
            this.bt_download.UseVisualStyleBackColor = true;
            // 
            // bt_submit
            // 
            this.bt_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_submit.Location = new System.Drawing.Point(282, 120);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(88, 23);
            this.bt_submit.TabIndex = 5;
            this.bt_submit.Text = "&Submit request";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B. File";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(56, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "lb_briefcasefile";
            // 
            // dgv_schedule
            // 
            this.dgv_schedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcol_VesselId_cmb,
            this.dgvcol_InspectionTypeCmb,
            this.dgvcol_VetDate,
            this.dgvcol_InspectionTo});
            this.dgv_schedule.Location = new System.Drawing.Point(376, 17);
            this.dgv_schedule.Name = "dgv_schedule";
            this.dgv_schedule.Size = new System.Drawing.Size(527, 126);
            this.dgv_schedule.TabIndex = 2;
            this.dgv_schedule.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_schedule_RowValidating);
            this.dgv_schedule.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_schedule_RowValidated);
            // 
            // dgvcol_VesselId_cmb
            // 
            this.dgvcol_VesselId_cmb.HeaderText = "Vessel";
            this.dgvcol_VesselId_cmb.MinimumWidth = 100;
            this.dgvcol_VesselId_cmb.Name = "dgvcol_VesselId_cmb";
            this.dgvcol_VesselId_cmb.Width = 150;
            // 
            // dgvcol_InspectionTypeCmb
            // 
            this.dgvcol_InspectionTypeCmb.HeaderText = "Iinspection Type";
            this.dgvcol_InspectionTypeCmb.Name = "dgvcol_InspectionTypeCmb";
            // 
            // dgvcol_VetDate
            // 
            this.dgvcol_VetDate.DataPropertyName = "VetDateFrom";
            dataGridViewCellStyle5.Format = "dd-MM-yyyy";
            this.dgvcol_VetDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcol_VetDate.HeaderText = "Starting date";
            this.dgvcol_VetDate.MinimumWidth = 100;
            this.dgvcol_VetDate.Name = "dgvcol_VetDate";
            this.dgvcol_VetDate.Width = 120;
            // 
            // dgvcol_InspectionTo
            // 
            this.dgvcol_InspectionTo.DataPropertyName = "VetDateTo";
            dataGridViewCellStyle6.Format = "dd-MM-yyyy";
            this.dgvcol_InspectionTo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcol_InspectionTo.HeaderText = "Ending Date";
            this.dgvcol_InspectionTo.Name = "dgvcol_InspectionTo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // lb_username
            // 
            this.lb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_username.Location = new System.Drawing.Point(56, 16);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(314, 23);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(188, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Add Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colRequestCode
            // 
            this.colRequestCode.DataPropertyName = "RequestCode";
            this.colRequestCode.HeaderText = "Request Code";
            this.colRequestCode.MinimumWidth = 100;
            this.colRequestCode.Name = "colRequestCode";
            this.colRequestCode.ReadOnly = true;
            this.colRequestCode.Width = 200;
            // 
            // ComputerName
            // 
            this.ComputerName.DataPropertyName = "ComputerName";
            this.ComputerName.HeaderText = "ComputerName";
            this.ComputerName.MinimumWidth = 120;
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Width = 250;
            // 
            // colUserName
            // 
            this.colUserName.DataPropertyName = "UserName";
            this.colUserName.HeaderText = "User Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Visible = false;
            this.colUserName.Width = 300;
            // 
            // colRequestDate
            // 
            this.colRequestDate.DataPropertyName = "requestDate";
            dataGridViewCellStyle4.Format = "dd-MM-yyyy mm:ss";
            this.colRequestDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRequestDate.HeaderText = "Date of request";
            this.colRequestDate.MinimumWidth = 100;
            this.colRequestDate.Name = "colRequestDate";
            this.colRequestDate.ReadOnly = true;
            this.colRequestDate.Width = 120;
            // 
            // colBriefcaseFile
            // 
            this.colBriefcaseFile.DataPropertyName = "BriefcaseFile";
            this.colBriefcaseFile.HeaderText = "Briefcase File";
            this.colBriefcaseFile.Name = "colBriefcaseFile";
            this.colBriefcaseFile.ReadOnly = true;
            this.colBriefcaseFile.Width = 200;
            // 
            // colGranted
            // 
            this.colGranted.DataPropertyName = "Granted";
            this.colGranted.HeaderText = "Granted";
            this.colGranted.Name = "colGranted";
            this.colGranted.ReadOnly = true;
            this.colGranted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGranted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colVetRequestId
            // 
            this.colVetRequestId.DataPropertyName = "vetRequestid";
            this.colVetRequestId.HeaderText = "RequestId";
            this.colVetRequestId.Name = "colVetRequestId";
            this.colVetRequestId.Visible = false;
            // 
            // FormVettingRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(16, 408);
            this.Name = "FormVettingRequest";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVettingRequest";
            this.Load += new System.EventHandler(this.FormVettingRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vettingrequest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vettingrequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_schedule;
        private System.Windows.Forms.Button bt_download;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcol_VesselId_cmb;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcol_InspectionTypeCmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_VetDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcol_InspectionTo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBriefcaseFile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGranted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVetRequestId;
    }
}