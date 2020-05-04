namespace WindowsFormsApplication1
{
    partial class FormExcelPumpPlus
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
            this.bt_proceed = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.tb_recommendations = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chb_feedback = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_proceed
            // 
            this.bt_proceed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_proceed.Location = new System.Drawing.Point(683, 580);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(75, 25);
            this.bt_proceed.TabIndex = 1;
            this.bt_proceed.Text = "&Proceed";
            this.bt_proceed.UseVisualStyleBackColor = true;
            this.bt_proceed.Click += new System.EventHandler(this.bt_proceed_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_cancel.Location = new System.Drawing.Point(583, 582);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "&Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // tb_recommendations
            // 
            this.tb_recommendations.BackColor = System.Drawing.Color.White;
            this.tb_recommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_recommendations.Location = new System.Drawing.Point(102, 573);
            this.tb_recommendations.Multiline = true;
            this.tb_recommendations.Name = "tb_recommendations";
            this.tb_recommendations.ReadOnly = true;
            this.tb_recommendations.Size = new System.Drawing.Size(445, 32);
            this.tb_recommendations.TabIndex = 3;
            this.tb_recommendations.Text = "Please be sure that the Excel file that it is going to be imported  conforms to t" +
                "he standard depicted above and that it is not opened by another application\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.DemExcelFile11;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 523);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(102, 605);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(446, 10);
            this.progressBar1.TabIndex = 4;
            // 
            // chb_feedback
            // 
            this.chb_feedback.AutoSize = true;
            this.chb_feedback.Location = new System.Drawing.Point(102, 550);
            this.chb_feedback.Name = "chb_feedback";
            this.chb_feedback.Size = new System.Drawing.Size(142, 17);
            this.chb_feedback.TabIndex = 5;
            this.chb_feedback.Text = "Notify worksheet parsing";
            this.chb_feedback.UseVisualStyleBackColor = true;
            // 
            // FormExcelPumpPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 627);
            this.Controls.Add(this.chb_feedback);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tb_recommendations);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormExcelPumpPlus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importing Excel file procedure";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox tb_recommendations;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.CheckBox chb_feedback;
    }
}