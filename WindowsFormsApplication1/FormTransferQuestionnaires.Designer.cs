namespace WindowsFormsApplication1
{
    partial class FormTransferQuestionnaires
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Transfer = new System.Windows.Forms.Button();
            this.vIQInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            
            this.qIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.finalizedDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.NumQuestions});
            this.dataGridView1.DataSource = this.vIQInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(876, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_Transfer
            // 
            this.bt_Transfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Transfer.Location = new System.Drawing.Point(807, 327);
            this.bt_Transfer.Name = "bt_Transfer";
            this.bt_Transfer.Size = new System.Drawing.Size(81, 22);
            this.bt_Transfer.TabIndex = 1;
            this.bt_Transfer.Text = "&Transfer";
            this.bt_Transfer.UseVisualStyleBackColor = true;
            this.bt_Transfer.Click += new System.EventHandler(this.bt_Transfer_Click);
            // 
            // vIQInfoBindingSource
            // 
            this.vIQInfoBindingSource.DataMember = "VIQInfo";
            this.vIQInfoBindingSource.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
           
            
            this.qIdDataGridViewTextBoxColumn.DataPropertyName = "QId";
            this.qIdDataGridViewTextBoxColumn.Frozen = true;
            this.qIdDataGridViewTextBoxColumn.HeaderText = "QId";
            this.qIdDataGridViewTextBoxColumn.Name = "qIdDataGridViewTextBoxColumn";
            this.qIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.Frozen = true;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 300;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.Frozen = true;
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.Frozen = true;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 200;
            // 
            // finalizedDataGridViewTextBoxColumn
            // 
            this.finalizedDataGridViewTextBoxColumn.DataPropertyName = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.Frozen = true;
            this.finalizedDataGridViewTextBoxColumn.HeaderText = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.Name = "finalizedDataGridViewTextBoxColumn";
            this.finalizedDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalizedDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.Frozen = true;
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NumQuestions
            // 
            this.NumQuestions.DataPropertyName = "NumOfQuestions";
            this.NumQuestions.Frozen = true;
            this.NumQuestions.HeaderText = "Num. Of Questions";
            this.NumQuestions.MinimumWidth = 150;
            this.NumQuestions.Name = "NumQuestions";
            this.NumQuestions.ReadOnly = true;
            this.NumQuestions.Width = 150;
            // 
            // FormTransferQuestionnaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 361);
            this.Controls.Add(this.bt_Transfer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTransferQuestionnaires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Questionnaire Templates";
            this.Load += new System.EventHandler(this.FormTransferQuestionnaires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Transfer;
        private Attendance attendance;
        private System.Windows.Forms.BindingSource vIQInfoBindingSource;
       private System.Windows.Forms.DataGridViewTextBoxColumn qIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalizedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumQuestions;
    }
}