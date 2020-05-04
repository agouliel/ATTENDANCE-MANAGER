namespace WindowsFormsApplication1
{
    partial class FormBriefcaseVessels
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_bcvessels = new System.Windows.Forms.ListBox();
            this.attendance_briefcase = new WindowsFormsApplication1.Attendance();
            this.lb_dbvessels = new System.Windows.Forms.ListBox();
            this.attendance_rdbms = new WindowsFormsApplication1.Attendance();
            this.bt_tobc = new System.Windows.Forms.Button();
            this.bt_removefrombc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_briefcase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_rdbms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered Vessels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Briefcase Vessels";
            // 
            // lb_bcvessels
            // 
            this.lb_bcvessels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_bcvessels.DataSource = this.attendance_briefcase;
            this.lb_bcvessels.DisplayMember = "Vessel.VesselName";
            this.lb_bcvessels.FormattingEnabled = true;
            this.lb_bcvessels.Location = new System.Drawing.Point(310, 52);
            this.lb_bcvessels.Name = "lb_bcvessels";
            this.lb_bcvessels.Size = new System.Drawing.Size(281, 355);
            this.lb_bcvessels.TabIndex = 3;
            // 
            // attendance_briefcase
            // 
            this.attendance_briefcase.DataSetName = "Attendance";
            this.attendance_briefcase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_dbvessels
            // 
            this.lb_dbvessels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_dbvessels.DataSource = this.attendance_rdbms;
            this.lb_dbvessels.DisplayMember = "Vessel.VesselName";
            this.lb_dbvessels.FormattingEnabled = true;
            this.lb_dbvessels.Location = new System.Drawing.Point(12, 52);
            this.lb_dbvessels.Name = "lb_dbvessels";
            this.lb_dbvessels.Size = new System.Drawing.Size(275, 355);
            this.lb_dbvessels.TabIndex = 2;
            // 
            // attendance_rdbms
            // 
            this.attendance_rdbms.DataSetName = "Attendance";
            this.attendance_rdbms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_tobc
            // 
            this.bt_tobc.Location = new System.Drawing.Point(287, 187);
            this.bt_tobc.Name = "bt_tobc";
            this.bt_tobc.Size = new System.Drawing.Size(23, 25);
            this.bt_tobc.TabIndex = 4;
            this.bt_tobc.Text = ">";
            this.bt_tobc.UseVisualStyleBackColor = true;
            this.bt_tobc.Click += new System.EventHandler(this.bt_tobc_Click);
            // 
            // bt_removefrombc
            // 
            this.bt_removefrombc.Location = new System.Drawing.Point(287, 238);
            this.bt_removefrombc.Name = "bt_removefrombc";
            this.bt_removefrombc.Size = new System.Drawing.Size(23, 25);
            this.bt_removefrombc.TabIndex = 5;
            this.bt_removefrombc.Text = "<";
            this.bt_removefrombc.UseVisualStyleBackColor = true;
            // 
            // FormBriefcaseVessels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 442);
            this.Controls.Add(this.bt_removefrombc);
            this.Controls.Add(this.bt_tobc);
            this.Controls.Add(this.lb_bcvessels);
            this.Controls.Add(this.lb_dbvessels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormBriefcaseVessels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vessels";
            this.Load += new System.EventHandler(this.FormBriefcaseVessels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendance_briefcase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_rdbms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_dbvessels;
        private System.Windows.Forms.ListBox lb_bcvessels;
        private Attendance attendance_rdbms;
        private Attendance attendance_briefcase;
        private System.Windows.Forms.Button bt_tobc;
        private System.Windows.Forms.Button bt_removefrombc;
    }
}