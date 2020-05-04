namespace WindowsFormsApplication1
{
    partial class FormImportQuestionnaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Origin = new System.Windows.Forms.ComboBox();
            this.questionnaireOriginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.tb_startdrag = new System.Windows.Forms.TextBox();
            this.bt_worksheet = new System.Windows.Forms.Button();
            this.lb_workbooks = new System.Windows.Forms.ListBox();
            this.bt_import = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelright = new System.Windows.Forms.Panel();
            this.questionnaireObjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionnaireObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel_Left = new System.Windows.Forms.Panel();
            
            
            
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireOriginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireObjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireObjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_Origin);
            this.panel1.Controls.Add(this.tb_startdrag);
            this.panel1.Controls.Add(this.bt_worksheet);
            this.panel1.Controls.Add(this.lb_workbooks);
            this.panel1.Controls.Add(this.bt_import);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 111);
            this.panel1.TabIndex = 0;
            // 
            // cmb_Origin
            // 
            this.cmb_Origin.DataSource = this.questionnaireOriginBindingSource;
            this.cmb_Origin.DisplayMember = "OriginTitle";
            this.cmb_Origin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Origin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Origin.FormattingEnabled = true;
            this.cmb_Origin.Location = new System.Drawing.Point(4, 87);
            this.cmb_Origin.Name = "cmb_Origin";
            this.cmb_Origin.Size = new System.Drawing.Size(548, 21);
            this.cmb_Origin.TabIndex = 18;
            this.cmb_Origin.ValueMember = "OriginNo";
            // 
            // questionnaireOriginBindingSource
            // 
            this.questionnaireOriginBindingSource.DataMember = "QuestionnaireOrigin";
            this.questionnaireOriginBindingSource.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_startdrag
            // 
            this.tb_startdrag.BackColor = System.Drawing.Color.Yellow;
            this.tb_startdrag.Location = new System.Drawing.Point(0, 34);
            this.tb_startdrag.Multiline = true;
            this.tb_startdrag.Name = "tb_startdrag";
            this.tb_startdrag.ReadOnly = true;
            this.tb_startdrag.Size = new System.Drawing.Size(552, 46);
            this.tb_startdrag.TabIndex = 17;
            this.tb_startdrag.Tag = "";
            this.tb_startdrag.Text = "Start Drag Operation FROM HERE";
            this.tb_startdrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_worksheet
            // 
            this.bt_worksheet.Location = new System.Drawing.Point(909, 82);
            this.bt_worksheet.Name = "bt_worksheet";
            this.bt_worksheet.Size = new System.Drawing.Size(75, 23);
            this.bt_worksheet.TabIndex = 2;
            this.bt_worksheet.Text = "Parse Worksheet";
            this.bt_worksheet.UseVisualStyleBackColor = true;
            this.bt_worksheet.Click += new System.EventHandler(this.bt_worksheet_Click);
            // 
            // lb_workbooks
            // 
            this.lb_workbooks.FormattingEnabled = true;
            this.lb_workbooks.Location = new System.Drawing.Point(665, 10);
            this.lb_workbooks.Name = "lb_workbooks";
            this.lb_workbooks.Size = new System.Drawing.Size(238, 95);
            this.lb_workbooks.TabIndex = 1;
            // 
            // bt_import
            // 
            this.bt_import.Location = new System.Drawing.Point(909, 10);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(75, 23);
            this.bt_import.TabIndex = 0;
            this.bt_import.Text = "Import";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.panelright);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.panel_Left);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 631);
            this.panel2.TabIndex = 1;
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.questionnaireObjectsDataGridView);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelright.Location = new System.Drawing.Point(552, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(444, 631);
            this.panelright.TabIndex = 3;
            // 
            // questionnaireObjectsDataGridView
            // 
            this.questionnaireObjectsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.questionnaireObjectsDataGridView.AutoGenerateColumns = false;
            this.questionnaireObjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionnaireObjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.questionnaireObjectsDataGridView.DataSource = this.questionnaireObjectsBindingSource;
            this.questionnaireObjectsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.questionnaireObjectsDataGridView.Name = "questionnaireObjectsDataGridView";
            this.questionnaireObjectsDataGridView.Size = new System.Drawing.Size(438, 600);
            this.questionnaireObjectsDataGridView.TabIndex = 2;
            this.questionnaireObjectsDataGridView.Tag = "ImportQuestionnaire";
            this.questionnaireObjectsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.questionnaireObjectsDataGridView_RowPrePaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ObjectId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ObjectId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ObjectNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "ObjectNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ObjectCode";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "ObjectCode";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ObjectDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "ObjectDescription";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ObjectType";
            this.dataGridViewTextBoxColumn5.HeaderText = "ObjectType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OriginId";
            this.dataGridViewTextBoxColumn6.HeaderText = "OriginId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ObjectComments";
            this.dataGridViewTextBoxColumn7.HeaderText = "ObjectComments";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ParentId";
            this.dataGridViewTextBoxColumn8.HeaderText = "ParentId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GlobalDisplayIndex";
            this.dataGridViewTextBoxColumn9.HeaderText = "GlobalDisplayIndex";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Children";
            this.dataGridViewTextBoxColumn10.HeaderText = "Children";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // questionnaireObjectsBindingSource
            // 
            this.questionnaireObjectsBindingSource.DataMember = "QuestionnaireObjects";
            this.questionnaireObjectsBindingSource.DataSource = this.attendance;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitter1.Location = new System.Drawing.Point(542, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 631);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel_Left
            // 
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(542, 631);
            this.panel_Left.TabIndex = 0;
            
           
            // 
            // FormImportQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormImportQuestionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Questionnaire ";
            this.Load += new System.EventHandler(this.FormImportQuestionnaire_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireOriginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelright.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireObjectsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionnaireObjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.ListBox lb_workbooks;
        private Attendance attendance;
        private System.Windows.Forms.BindingSource questionnaireObjectsBindingSource;
        
        
        private System.Windows.Forms.DataGridView questionnaireObjectsDataGridView;
        private System.Windows.Forms.Button bt_worksheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.TextBox tb_startdrag;
        
        private System.Windows.Forms.BindingSource questionnaireOriginBindingSource;
        public System.Windows.Forms.ComboBox cmb_Origin;
    }
}