namespace WindowsFormsApplication1
{
    partial class FormObjectContext
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
            System.Windows.Forms.Label lb_vetdate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.objectVettingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_vettings = new System.Windows.Forms.DataGridView();
            this.vesselNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.significanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vettingCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorSirnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vesselIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetGUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionnaireTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_questionnaires = new System.Windows.Forms.DataGridView();
            this.qIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalizedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCategoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfQuestionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIQInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_defcode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_inspectorcomment = new System.Windows.Forms.TextBox();
            this.lb_inspname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chb_vesselspecific = new System.Windows.Forms.CheckBox();
            lb_vetdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectVettingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_questionnaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_vetdate
            // 
            lb_vetdate.AutoSize = true;
            lb_vetdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectVettingInfoBindingSource, "VetDate", true));
            lb_vetdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_vetdate.Location = new System.Drawing.Point(651, 3);
            lb_vetdate.Name = "lb_vetdate";
            lb_vetdate.Size = new System.Drawing.Size(53, 13);
            lb_vetdate.TabIndex = 10;
            lb_vetdate.Text = "VetDate";
            // 
            // objectVettingInfoBindingSource
            // 
            this.objectVettingInfoBindingSource.DataMember = "ObjectVettingInfo";
            this.objectVettingInfoBindingSource.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 201);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_vettings);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_questionnaires);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(829, 454);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView_vettings
            // 
            this.dataGridView_vettings.AllowUserToAddRows = false;
            this.dataGridView_vettings.AllowUserToDeleteRows = false;
            this.dataGridView_vettings.AllowUserToResizeRows = false;
            this.dataGridView_vettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_vettings.AutoGenerateColumns = false;
            this.dataGridView_vettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_vettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vesselNameDataGridViewTextBoxColumn,
            this.DisplayCode,
            this.vetDateDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.significanceDataGridViewTextBoxColumn,
            this.vettingCodeDataGridViewTextBoxColumn,
            this.inspectorCommentsDataGridViewTextBoxColumn,
            this.inspectorNameDataGridViewTextBoxColumn,
            this.inspectorSirnameDataGridViewTextBoxColumn,
            this.portPlaceDataGridViewTextBoxColumn,
            this.vetTimeDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn,
            this.vesselIDDataGridViewTextBoxColumn,
            this.vetIdDataGridViewTextBoxColumn,
            this.qIdDataGridViewTextBoxColumn,
            this.numAnswerDataGridViewTextBoxColumn,
            this.vetGUIDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.questionnaireTitleDataGridViewTextBoxColumn,
            this.inspectionTypeIdDataGridViewTextBoxColumn,
            this.inspectionTypeDataGridViewTextBoxColumn});
            this.dataGridView_vettings.DataSource = this.objectVettingInfoBindingSource;
            this.dataGridView_vettings.Location = new System.Drawing.Point(6, 16);
            this.dataGridView_vettings.MultiSelect = false;
            this.dataGridView_vettings.Name = "dataGridView_vettings";
            this.dataGridView_vettings.ReadOnly = true;
            this.dataGridView_vettings.Size = new System.Drawing.Size(820, 217);
            this.dataGridView_vettings.TabIndex = 1;
            this.dataGridView_vettings.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_vettings_RowPostPaint);
            this.dataGridView_vettings.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_vettings_CellMouseDoubleClick);
            // 
            // vesselNameDataGridViewTextBoxColumn
            // 
            this.vesselNameDataGridViewTextBoxColumn.DataPropertyName = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn.Frozen = true;
            this.vesselNameDataGridViewTextBoxColumn.HeaderText = "VesselName";
            this.vesselNameDataGridViewTextBoxColumn.Name = "vesselNameDataGridViewTextBoxColumn";
            this.vesselNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DisplayCode
            // 
            this.DisplayCode.DataPropertyName = "DisplayCode";
            this.DisplayCode.Frozen = true;
            this.DisplayCode.HeaderText = "DisplayCode";
            this.DisplayCode.Name = "DisplayCode";
            this.DisplayCode.ReadOnly = true;
            // 
            // vetDateDataGridViewTextBoxColumn
            // 
            this.vetDateDataGridViewTextBoxColumn.DataPropertyName = "VetDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "dd/MM/yyyy";
            this.vetDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vetDateDataGridViewTextBoxColumn.Frozen = true;
            this.vetDateDataGridViewTextBoxColumn.HeaderText = "VetDate";
            this.vetDateDataGridViewTextBoxColumn.Name = "vetDateDataGridViewTextBoxColumn";
            this.vetDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.answerDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.answerDataGridViewTextBoxColumn.Frozen = true;
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.answerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // significanceDataGridViewTextBoxColumn
            // 
            this.significanceDataGridViewTextBoxColumn.DataPropertyName = "Significance";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.significanceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.significanceDataGridViewTextBoxColumn.Frozen = true;
            this.significanceDataGridViewTextBoxColumn.HeaderText = "Significance";
            this.significanceDataGridViewTextBoxColumn.Name = "significanceDataGridViewTextBoxColumn";
            this.significanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vettingCodeDataGridViewTextBoxColumn
            // 
            this.vettingCodeDataGridViewTextBoxColumn.DataPropertyName = "VettingCode";
            this.vettingCodeDataGridViewTextBoxColumn.HeaderText = "VettingCode";
            this.vettingCodeDataGridViewTextBoxColumn.Name = "vettingCodeDataGridViewTextBoxColumn";
            this.vettingCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorCommentsDataGridViewTextBoxColumn
            // 
            this.inspectorCommentsDataGridViewTextBoxColumn.DataPropertyName = "InspectorComments";
            this.inspectorCommentsDataGridViewTextBoxColumn.HeaderText = "Insp. Comments";
            this.inspectorCommentsDataGridViewTextBoxColumn.Name = "inspectorCommentsDataGridViewTextBoxColumn";
            this.inspectorCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectorCommentsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inspectorCommentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // inspectorNameDataGridViewTextBoxColumn
            // 
            this.inspectorNameDataGridViewTextBoxColumn.DataPropertyName = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.HeaderText = "InspectorName";
            this.inspectorNameDataGridViewTextBoxColumn.Name = "inspectorNameDataGridViewTextBoxColumn";
            this.inspectorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectorSirnameDataGridViewTextBoxColumn
            // 
            this.inspectorSirnameDataGridViewTextBoxColumn.DataPropertyName = "InspectorSirname";
            this.inspectorSirnameDataGridViewTextBoxColumn.HeaderText = "InspectorSirname";
            this.inspectorSirnameDataGridViewTextBoxColumn.Name = "inspectorSirnameDataGridViewTextBoxColumn";
            this.inspectorSirnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectorSirnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // portPlaceDataGridViewTextBoxColumn
            // 
            this.portPlaceDataGridViewTextBoxColumn.DataPropertyName = "Port/Place";
            this.portPlaceDataGridViewTextBoxColumn.HeaderText = "Port/Place";
            this.portPlaceDataGridViewTextBoxColumn.Name = "portPlaceDataGridViewTextBoxColumn";
            this.portPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vetTimeDataGridViewTextBoxColumn
            // 
            this.vetTimeDataGridViewTextBoxColumn.DataPropertyName = "VetTime";
            this.vetTimeDataGridViewTextBoxColumn.HeaderText = "VetTime";
            this.vetTimeDataGridViewTextBoxColumn.Name = "vetTimeDataGridViewTextBoxColumn";
            this.vetTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            this.commentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vesselIDDataGridViewTextBoxColumn
            // 
            this.vesselIDDataGridViewTextBoxColumn.DataPropertyName = "VesselID";
            this.vesselIDDataGridViewTextBoxColumn.HeaderText = "VesselID";
            this.vesselIDDataGridViewTextBoxColumn.Name = "vesselIDDataGridViewTextBoxColumn";
            this.vesselIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vesselIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // vetIdDataGridViewTextBoxColumn
            // 
            this.vetIdDataGridViewTextBoxColumn.DataPropertyName = "VetId";
            this.vetIdDataGridViewTextBoxColumn.HeaderText = "VetId";
            this.vetIdDataGridViewTextBoxColumn.Name = "vetIdDataGridViewTextBoxColumn";
            this.vetIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // qIdDataGridViewTextBoxColumn
            // 
            this.qIdDataGridViewTextBoxColumn.DataPropertyName = "QId";
            this.qIdDataGridViewTextBoxColumn.HeaderText = "QId";
            this.qIdDataGridViewTextBoxColumn.Name = "qIdDataGridViewTextBoxColumn";
            this.qIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.qIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // numAnswerDataGridViewTextBoxColumn
            // 
            this.numAnswerDataGridViewTextBoxColumn.DataPropertyName = "NumAnswer";
            this.numAnswerDataGridViewTextBoxColumn.HeaderText = "NumAnswer";
            this.numAnswerDataGridViewTextBoxColumn.Name = "numAnswerDataGridViewTextBoxColumn";
            this.numAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vetGUIDataGridViewTextBoxColumn
            // 
            this.vetGUIDataGridViewTextBoxColumn.DataPropertyName = "VetGUI";
            this.vetGUIDataGridViewTextBoxColumn.HeaderText = "VetGUI";
            this.vetGUIDataGridViewTextBoxColumn.Name = "vetGUIDataGridViewTextBoxColumn";
            this.vetGUIDataGridViewTextBoxColumn.ReadOnly = true;
            this.vetGUIDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questionnaireTitleDataGridViewTextBoxColumn
            // 
            this.questionnaireTitleDataGridViewTextBoxColumn.DataPropertyName = "QuestionnaireTitle";
            this.questionnaireTitleDataGridViewTextBoxColumn.HeaderText = "QuestionnaireTitle";
            this.questionnaireTitleDataGridViewTextBoxColumn.Name = "questionnaireTitleDataGridViewTextBoxColumn";
            this.questionnaireTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inspectionTypeIdDataGridViewTextBoxColumn
            // 
            this.inspectionTypeIdDataGridViewTextBoxColumn.DataPropertyName = "InspectionTypeId";
            this.inspectionTypeIdDataGridViewTextBoxColumn.HeaderText = "InspectionTypeId";
            this.inspectionTypeIdDataGridViewTextBoxColumn.Name = "inspectionTypeIdDataGridViewTextBoxColumn";
            this.inspectionTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.inspectionTypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // inspectionTypeDataGridViewTextBoxColumn
            // 
            this.inspectionTypeDataGridViewTextBoxColumn.DataPropertyName = "InspectionType";
            this.inspectionTypeDataGridViewTextBoxColumn.HeaderText = "InspectionType";
            this.inspectionTypeDataGridViewTextBoxColumn.Name = "inspectionTypeDataGridViewTextBoxColumn";
            this.inspectionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Related Attendances";
            // 
            // dataGridView_questionnaires
            // 
            this.dataGridView_questionnaires.AllowUserToAddRows = false;
            this.dataGridView_questionnaires.AllowUserToDeleteRows = false;
            this.dataGridView_questionnaires.AllowUserToResizeRows = false;
            this.dataGridView_questionnaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_questionnaires.AutoGenerateColumns = false;
            this.dataGridView_questionnaires.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView_questionnaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_questionnaires.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIdDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn1,
            this.finalizedDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn1,
            this.numCategoriesDataGridViewTextBoxColumn,
            this.numOfQuestionsDataGridViewTextBoxColumn});
            this.dataGridView_questionnaires.DataSource = this.vIQInfoBindingSource;
            this.dataGridView_questionnaires.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_questionnaires.MultiSelect = false;
            this.dataGridView_questionnaires.Name = "dataGridView_questionnaires";
            this.dataGridView_questionnaires.ReadOnly = true;
            this.dataGridView_questionnaires.Size = new System.Drawing.Size(820, 193);
            this.dataGridView_questionnaires.TabIndex = 2;
            // 
            // qIdDataGridViewTextBoxColumn1
            // 
            this.qIdDataGridViewTextBoxColumn1.DataPropertyName = "QId";
            this.qIdDataGridViewTextBoxColumn1.HeaderText = "QId";
            this.qIdDataGridViewTextBoxColumn1.Name = "qIdDataGridViewTextBoxColumn1";
            this.qIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentsDataGridViewTextBoxColumn1
            // 
            this.commentsDataGridViewTextBoxColumn1.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn1.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn1.Name = "commentsDataGridViewTextBoxColumn1";
            this.commentsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // finalizedDataGridViewTextBoxColumn
            // 
            this.finalizedDataGridViewTextBoxColumn.DataPropertyName = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.HeaderText = "Finalized";
            this.finalizedDataGridViewTextBoxColumn.Name = "finalizedDataGridViewTextBoxColumn";
            this.finalizedDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalizedDataGridViewTextBoxColumn.Visible = false;
            // 
            // registrationDateDataGridViewTextBoxColumn1
            // 
            this.registrationDateDataGridViewTextBoxColumn1.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn1.HeaderText = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn1.Name = "registrationDateDataGridViewTextBoxColumn1";
            this.registrationDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numCategoriesDataGridViewTextBoxColumn
            // 
            this.numCategoriesDataGridViewTextBoxColumn.DataPropertyName = "NumCategories";
            this.numCategoriesDataGridViewTextBoxColumn.HeaderText = "NumCategories";
            this.numCategoriesDataGridViewTextBoxColumn.Name = "numCategoriesDataGridViewTextBoxColumn";
            this.numCategoriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.numCategoriesDataGridViewTextBoxColumn.Visible = false;
            // 
            // numOfQuestionsDataGridViewTextBoxColumn
            // 
            this.numOfQuestionsDataGridViewTextBoxColumn.DataPropertyName = "NumOfQuestions";
            this.numOfQuestionsDataGridViewTextBoxColumn.HeaderText = "NumOfQuestions";
            this.numOfQuestionsDataGridViewTextBoxColumn.Name = "numOfQuestionsDataGridViewTextBoxColumn";
            this.numOfQuestionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vIQInfoBindingSource
            // 
            this.vIQInfoBindingSource.DataMember = "VIQInfo";
            this.vIQInfoBindingSource.DataSource = this.attendance;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Related Questionnaires";
            // 
            // tb_question
            // 
            this.tb_question.BackColor = System.Drawing.Color.White;
            this.tb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_question.Location = new System.Drawing.Point(18, 55);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(540, 52);
            this.tb_question.TabIndex = 1;
            this.tb_question.TabStop = false;
            // 
            // tb_comment
            // 
            this.tb_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_comment.Location = new System.Drawing.Point(15, 123);
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.ReadOnly = true;
            this.tb_comment.Size = new System.Drawing.Size(540, 49);
            this.tb_comment.TabIndex = 2;
            this.tb_comment.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Question";
            // 
            // lb_defcode
            // 
            this.lb_defcode.AutoSize = true;
            this.lb_defcode.BackColor = System.Drawing.Color.Yellow;
            this.lb_defcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_defcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_defcode.Location = new System.Drawing.Point(286, 33);
            this.lb_defcode.Name = "lb_defcode";
            this.lb_defcode.Size = new System.Drawing.Size(28, 19);
            this.lb_defcode.TabIndex = 5;
            this.lb_defcode.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Default Code";
            // 
            // tb_inspectorcomment
            // 
            this.tb_inspectorcomment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_inspectorcomment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_inspectorcomment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectVettingInfoBindingSource, "InspectorComments", true));
            this.tb_inspectorcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_inspectorcomment.Location = new System.Drawing.Point(564, 55);
            this.tb_inspectorcomment.Multiline = true;
            this.tb_inspectorcomment.Name = "tb_inspectorcomment";
            this.tb_inspectorcomment.ReadOnly = true;
            this.tb_inspectorcomment.Size = new System.Drawing.Size(274, 117);
            this.tb_inspectorcomment.TabIndex = 7;
            this.tb_inspectorcomment.TabStop = false;
            // 
            // lb_inspname
            // 
            this.lb_inspname.AutoSize = true;
            this.lb_inspname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectVettingInfoBindingSource, "InspectorName", true));
            this.lb_inspname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inspname.Location = new System.Drawing.Point(651, 39);
            this.lb_inspname.Name = "lb_inspname";
            this.lb_inspname.Size = new System.Drawing.Size(60, 13);
            this.lb_inspname.TabIndex = 8;
            this.lb_inspname.Text = "Inspector";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Comments from";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Context";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objectVettingInfoBindingSource, "VesselName", true));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(651, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Vessel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(592, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Dated";
            // 
            // chb_vesselspecific
            // 
            this.chb_vesselspecific.AutoSize = true;
            this.chb_vesselspecific.Checked = true;
            this.chb_vesselspecific.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_vesselspecific.Location = new System.Drawing.Point(18, 3);
            this.chb_vesselspecific.Name = "chb_vesselspecific";
            this.chb_vesselspecific.Size = new System.Drawing.Size(98, 17);
            this.chb_vesselspecific.TabIndex = 14;
            this.chb_vesselspecific.Text = "Vessel Specific";
            this.chb_vesselspecific.UseVisualStyleBackColor = true;
            this.chb_vesselspecific.Visible = false;
            this.chb_vesselspecific.CheckStateChanged += new System.EventHandler(this.chb_vesselspecific_CheckStateChanged);
            // 
            // FormObjectContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 667);
            this.Controls.Add(this.chb_vesselspecific);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(lb_vetdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_inspname);
            this.Controls.Add(this.tb_inspectorcomment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_defcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_comment);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormObjectContext";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Related Context";
            this.Load += new System.EventHandler(this.FormObjectContext_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectVettingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_questionnaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIQInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_vettings;
        private System.Windows.Forms.DataGridView dataGridView_questionnaires;
        private Attendance attendance;
        private System.Windows.Forms.BindingSource vIQInfoBindingSource;
        public System.Windows.Forms.TextBox tb_question;
        public System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalizedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCategoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfQuestionsDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label lb_defcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource objectVettingInfoBindingSource;
        public System.Windows.Forms.TextBox tb_inspectorcomment;
        private System.Windows.Forms.Label lb_inspname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chb_vesselspecific;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn significanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vettingCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorCommentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorSirnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn portPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vesselIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetGUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionnaireTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectionTypeDataGridViewTextBoxColumn;
    }
}