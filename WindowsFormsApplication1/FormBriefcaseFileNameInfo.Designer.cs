namespace WindowsFormsApplication1
{
    partial class FormBriefcaseFileNameInfo
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
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.btPath = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.cmbVettingTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Location = new System.Drawing.Point(272, 141);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 0;
            this.bt_Cancel.Text = "&Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            // 
            // bt_OK
            // 
            this.bt_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_OK.Location = new System.Drawing.Point(188, 141);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 1;
            this.bt_OK.Text = "&Ok";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(81, 43);
            this.tbUser.MaxLength = 256;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(272, 20);
            this.tbUser.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insp. Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path";
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(81, 104);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(272, 20);
            this.tb_Path.TabIndex = 2;
            // 
            // btPath
            // 
            this.btPath.Location = new System.Drawing.Point(355, 104);
            this.btPath.Name = "btPath";
            this.btPath.Size = new System.Drawing.Size(30, 23);
            this.btPath.TabIndex = 8;
            this.btPath.Text = "...";
            this.btPath.UseVisualStyleBackColor = true;
            this.btPath.Click += new System.EventHandler(this.btPath_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(46, 25);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 13);
            this.lbError.TabIndex = 9;
            // 
            // cmbVettingTypes
            // 
            this.cmbVettingTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVettingTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVettingTypes.FormattingEnabled = true;
            this.cmbVettingTypes.Location = new System.Drawing.Point(81, 77);
            this.cmbVettingTypes.Name = "cmbVettingTypes";
            this.cmbVettingTypes.Size = new System.Drawing.Size(272, 21);
            this.cmbVettingTypes.TabIndex = 1;
            // 
            // FormBriefcaseFileNameInfo
            // 
            this.AcceptButton = this.bt_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Cancel;
            this.ClientSize = new System.Drawing.Size(389, 171);
            this.ControlBox = false;
            this.Controls.Add(this.cmbVettingTypes);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btPath);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_Cancel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBriefcaseFileNameInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Briefcase File Name Info";
            this.Load += new System.EventHandler(this.FormBriefcaseFileNameInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button btPath;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.ComboBox cmbVettingTypes;
    }
}