namespace WindowsFormsApplication1
{
    partial class FormBriefcaseVLog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_filename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_versioncode = new System.Windows.Forms.TextBox();
            this.ValidFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionnaireLimitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VettingLimitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitNumberLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VettingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionnaireNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValidFromDate,
            this.ValidToDate,
            this.LastDate,
            this.VisitNumber,
            this.QuestionnaireLimitNo,
            this.VettingLimitNo,
            this.VisitNumberLimit,
            this.VettingNumber,
            this.QuestionnaireNumber});
            this.dataGridView1.Location = new System.Drawing.Point(25, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 126);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File";
            // 
            // lb_filename
            // 
            this.lb_filename.AutoSize = true;
            this.lb_filename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filename.Location = new System.Drawing.Point(71, 12);
            this.lb_filename.Name = "lb_filename";
            this.lb_filename.Size = new System.Drawing.Size(41, 13);
            this.lb_filename.TabIndex = 2;
            this.lb_filename.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(702, 186);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 5;
            this.bt_save.Text = "&Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // tb_versioncode
            // 
            this.tb_versioncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_versioncode.Location = new System.Drawing.Point(70, 29);
            this.tb_versioncode.Name = "tb_versioncode";
            this.tb_versioncode.Size = new System.Drawing.Size(449, 20);
            this.tb_versioncode.TabIndex = 6;
            // 
            // ValidFromDate
            // 
            this.ValidFromDate.DataPropertyName = "ValidFromDate";
            this.ValidFromDate.HeaderText = "Valid From";
            this.ValidFromDate.Name = "ValidFromDate";
            // 
            // ValidToDate
            // 
            this.ValidToDate.DataPropertyName = "ValidToDate";
            this.ValidToDate.HeaderText = "Valild until";
            this.ValidToDate.Name = "ValidToDate";
            // 
            // LastDate
            // 
            this.LastDate.DataPropertyName = "LastDate";
            this.LastDate.HeaderText = "Last Date";
            this.LastDate.Name = "LastDate";
            // 
            // VisitNumber
            // 
            this.VisitNumber.DataPropertyName = "VisitNumber";
            this.VisitNumber.HeaderText = "Visit number";
            this.VisitNumber.Name = "VisitNumber";
            this.VisitNumber.ReadOnly = true;
            // 
            // QuestionnaireLimitNo
            // 
            this.QuestionnaireLimitNo.DataPropertyName = "QuestionnaireLimit";
            this.QuestionnaireLimitNo.HeaderText = "Questionnaire Limit";
            this.QuestionnaireLimitNo.MinimumWidth = 50;
            this.QuestionnaireLimitNo.Name = "QuestionnaireLimitNo";
            this.QuestionnaireLimitNo.Width = 150;
            // 
            // VettingLimitNo
            // 
            this.VettingLimitNo.DataPropertyName = "VettingNumberLimit";
            this.VettingLimitNo.HeaderText = "Vetting Limit";
            this.VettingLimitNo.MinimumWidth = 50;
            this.VettingLimitNo.Name = "VettingLimitNo";
            this.VettingLimitNo.Width = 150;
            // 
            // VisitNumberLimit
            // 
            this.VisitNumberLimit.DataPropertyName = "VisitNumberLimit";
            this.VisitNumberLimit.HeaderText = "Visit limit";
            this.VisitNumberLimit.Name = "VisitNumberLimit";
            // 
            // VettingNumber
            // 
            this.VettingNumber.DataPropertyName = "VettingNumber";
            this.VettingNumber.HeaderText = "VettingNumber";
            this.VettingNumber.Name = "VettingNumber";
            this.VettingNumber.ReadOnly = true;
            this.VettingNumber.Visible = false;
            // 
            // QuestionnaireNumber
            // 
            this.QuestionnaireNumber.DataPropertyName = "QuestionnaireNumber";
            this.QuestionnaireNumber.HeaderText = "QuestionnaireNumber";
            this.QuestionnaireNumber.Name = "QuestionnaireNumber";
            this.QuestionnaireNumber.ReadOnly = true;
            this.QuestionnaireNumber.Visible = false;
            // 
            // FormBriefcaseVLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 215);
            this.Controls.Add(this.tb_versioncode);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_filename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormBriefcaseVLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Briefcase VLog";
            this.Load += new System.EventHandler(this.FormBriefcaseVLog_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.FormBriefcaseVLog_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_filename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox tb_versioncode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionnaireLimitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VettingLimitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitNumberLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn VettingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionnaireNumber;
    }
}