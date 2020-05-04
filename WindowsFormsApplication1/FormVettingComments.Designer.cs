namespace WindowsFormsApplication1
{
    partial class FormVettingComments
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
            this.tb_comments = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_comments
            // 
            this.tb_comments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_comments.Location = new System.Drawing.Point(27, 12);
            this.tb_comments.MaxLength = 4000;
            this.tb_comments.Multiline = true;
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_comments.Size = new System.Drawing.Size(780, 508);
            this.tb_comments.TabIndex = 0;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(715, 526);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(91, 23);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "&Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // FormVettingComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 553);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.tb_comments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormVettingComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetting Comments";
            this.Load += new System.EventHandler(this.FormVettingComments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_comments;
        private System.Windows.Forms.Button bt_save;
    }
}