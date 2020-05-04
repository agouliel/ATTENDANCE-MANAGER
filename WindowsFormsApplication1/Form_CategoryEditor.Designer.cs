namespace WindowsFormsApplication1
{
    partial class Form_CategoryEditor
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
            this.tb_categorydescription = new System.Windows.Forms.TextBox();
            this.tb_categorycode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_categorydescription
            // 
            this.tb_categorydescription.Location = new System.Drawing.Point(132, 64);
            this.tb_categorydescription.Name = "tb_categorydescription";
            this.tb_categorydescription.Size = new System.Drawing.Size(392, 20);
            this.tb_categorydescription.TabIndex = 10;
            // 
            // tb_categorycode
            // 
            this.tb_categorycode.Location = new System.Drawing.Point(132, 34);
            this.tb_categorycode.Name = "tb_categorycode";
            this.tb_categorycode.Size = new System.Drawing.Size(158, 20);
            this.tb_categorycode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category Title";
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(450, 107);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(74, 24);
            this.bt_ok.TabIndex = 15;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(357, 107);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(74, 24);
            this.bt_cancel.TabIndex = 20;
            this.bt_cancel.Text = "&Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_CategoryEditor
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(557, 148);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_categorycode);
            this.Controls.Add(this.tb_categorydescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CategoryEditor";
            this.Text = "New Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
        public System.Windows.Forms.TextBox tb_categorydescription;
        public System.Windows.Forms.TextBox tb_categorycode;
    }
}