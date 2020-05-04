namespace WindowsFormsApplication1
{
    partial class FormVettingGeneralInfo
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
            this.attendance1 = new WindowsFormsApplication1.Attendance();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_vesselname = new System.Windows.Forms.TextBox();
            this.dtp_vetdate = new System.Windows.Forms.DateTimePicker();
            this.tb_inspectorname = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.tb_comments = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_vettime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_vettingcode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_insepctiontypes = new System.Windows.Forms.ComboBox();
            this.inspectionTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance1BindingSource = new System.Windows.Forms.BindingSource(this.components);
           this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_companyrepresentativename = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.attendance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attendance1
            // 
            this.attendance1.DataSetName = "Attendance";
            this.attendance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inspector\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vessel\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inspection date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comments";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_vesselname
            // 
            this.tb_vesselname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_vesselname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vesselname.Location = new System.Drawing.Point(159, 12);
            this.tb_vesselname.Name = "tb_vesselname";
            this.tb_vesselname.Size = new System.Drawing.Size(368, 20);
            this.tb_vesselname.TabIndex = 0;
            // 
            // dtp_vetdate
            // 
            this.dtp_vetdate.CustomFormat = "dd/MM/yyyy";
            this.dtp_vetdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_vetdate.Location = new System.Drawing.Point(159, 85);
            this.dtp_vetdate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_vetdate.Name = "dtp_vetdate";
            this.dtp_vetdate.Size = new System.Drawing.Size(97, 20);
            this.dtp_vetdate.TabIndex = 10;
            // 
            // tb_inspectorname
            // 
            this.tb_inspectorname.Location = new System.Drawing.Point(158, 160);
            this.tb_inspectorname.Name = "tb_inspectorname";
            this.tb_inspectorname.Size = new System.Drawing.Size(334, 20);
            this.tb_inspectorname.TabIndex = 20;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(158, 234);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(222, 20);
            this.tb_port.TabIndex = 25;
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(158, 276);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(222, 20);
            this.tb_country.TabIndex = 30;
            // 
            // tb_comments
            // 
            this.tb_comments.AcceptsReturn = true;
            this.tb_comments.Location = new System.Drawing.Point(161, 314);
            this.tb_comments.Multiline = true;
            this.tb_comments.Name = "tb_comments";
            this.tb_comments.Size = new System.Drawing.Size(575, 90);
            this.tb_comments.TabIndex = 35;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(650, 420);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(83, 22);
            this.bt_ok.TabIndex = 45;
            this.bt_ok.Text = "&Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(554, 420);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(80, 22);
            this.bt_cancel.TabIndex = 40;
            this.bt_cancel.Text = "&Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Inspection time (UTC)";
            // 
            // dtp_vettime
            // 
            this.dtp_vettime.CustomFormat = "hh:mm";
            this.dtp_vettime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_vettime.Location = new System.Drawing.Point(430, 85);
            this.dtp_vettime.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtp_vettime.Name = "dtp_vettime";
            this.dtp_vettime.Size = new System.Drawing.Size(97, 20);
            this.dtp_vettime.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(534, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(262, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(534, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Inspection\'s Code";
            // 
            // tb_vettingcode
            // 
            this.tb_vettingcode.Location = new System.Drawing.Point(159, 50);
            this.tb_vettingcode.Name = "tb_vettingcode";
            this.tb_vettingcode.Size = new System.Drawing.Size(265, 20);
            this.tb_vettingcode.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(47, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Inspection Type";
            // 
            // cmb_insepctiontypes
            // 
            this.cmb_insepctiontypes.DataSource = this.inspectionTypesBindingSource;
            this.cmb_insepctiontypes.DisplayMember = "InspectionType";
            this.cmb_insepctiontypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_insepctiontypes.FormattingEnabled = true;
            this.cmb_insepctiontypes.Location = new System.Drawing.Point(159, 198);
            this.cmb_insepctiontypes.Name = "cmb_insepctiontypes";
            this.cmb_insepctiontypes.Size = new System.Drawing.Size(220, 21);
            this.cmb_insepctiontypes.TabIndex = 47;
            this.cmb_insepctiontypes.ValueMember = "InspectionTypeId";
            // 
            // inspectionTypesBindingSource
            // 
            this.inspectionTypesBindingSource.DataMember = "InspectionTypes";
            this.inspectionTypesBindingSource.DataSource = this.attendance1BindingSource;
            // 
            // attendance1BindingSource
            // 
            this.attendance1BindingSource.DataSource = this.attendance1;
            this.attendance1BindingSource.Position = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(385, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(498, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "*";
            // 
            // tb_companyrepresentativename
            // 
            this.tb_companyrepresentativename.Location = new System.Drawing.Point(158, 125);
            this.tb_companyrepresentativename.Name = "tb_companyrepresentativename";
            this.tb_companyrepresentativename.Size = new System.Drawing.Size(334, 20);
            this.tb_companyrepresentativename.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Company\'s Repr.  Name";
            // 
            // FormVettingGeneralInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 452);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_companyrepresentativename);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmb_insepctiontypes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_vettingcode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_vettime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_comments);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_inspectorname);
            this.Controls.Add(this.dtp_vetdate);
            this.Controls.Add(this.tb_vesselname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormVettingGeneralInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspetion General Information";
            this.Load += new System.EventHandler(this.FormVettingGeneralInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Attendance attendance1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_vesselname;
        public System.Windows.Forms.DateTimePicker dtp_vetdate;
        public System.Windows.Forms.TextBox tb_inspectorname;
        public System.Windows.Forms.TextBox tb_port;
        public System.Windows.Forms.TextBox tb_country;
        public System.Windows.Forms.TextBox tb_comments;
        public System.Windows.Forms.DateTimePicker dtp_vettime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tb_vettingcode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource attendance1BindingSource;
        private System.Windows.Forms.BindingSource inspectionTypesBindingSource;
        
        public System.Windows.Forms.ComboBox cmb_insepctiontypes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tb_companyrepresentativename;
        private System.Windows.Forms.Label label16;
    }
}