namespace WindowsFormsApplication1
{
    partial class FormVesselRegistry
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
            System.Windows.Forms.Label vesselNameLabel;
            System.Windows.Forms.Label vesselIdLabel;
            System.Windows.Forms.Label iMOLabel;
            System.Windows.Forms.Label fLAGLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label grossTonageLabel;
            System.Windows.Forms.Label deadWeightLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVesselRegistry));
            this.vesselBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vesselBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance = new WindowsFormsApplication1.Attendance();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vesselBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vesselNameTextBox = new System.Windows.Forms.TextBox();
            this.vesselIdTextBox = new System.Windows.Forms.TextBox();
            this.iMOTextBox = new System.Windows.Forms.TextBox();
            this.fLAGTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grossTonageTextBox = new System.Windows.Forms.TextBox();
            this.deadWeightTextBox = new System.Windows.Forms.TextBox();
            
            
            vesselNameLabel = new System.Windows.Forms.Label();
            vesselIdLabel = new System.Windows.Forms.Label();
            iMOLabel = new System.Windows.Forms.Label();
            fLAGLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            grossTonageLabel = new System.Windows.Forms.Label();
            deadWeightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vesselBindingNavigator)).BeginInit();
            this.vesselBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vesselBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // vesselNameLabel
            // 
            vesselNameLabel.AutoSize = true;
            vesselNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vesselNameLabel.Location = new System.Drawing.Point(122, 101);
            vesselNameLabel.Name = "vesselNameLabel";
            vesselNameLabel.Size = new System.Drawing.Size(84, 13);
            vesselNameLabel.TabIndex = 1;
            vesselNameLabel.Text = "Vessel Name:";
            // 
            // vesselIdLabel
            // 
            vesselIdLabel.AutoSize = true;
            vesselIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vesselIdLabel.Location = new System.Drawing.Point(122, 127);
            vesselIdLabel.Name = "vesselIdLabel";
            vesselIdLabel.Size = new System.Drawing.Size(63, 13);
            vesselIdLabel.TabIndex = 3;
            vesselIdLabel.Text = "Vessel Id:";
            // 
            // iMOLabel
            // 
            iMOLabel.AutoSize = true;
            iMOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iMOLabel.Location = new System.Drawing.Point(122, 153);
            iMOLabel.Name = "iMOLabel";
            iMOLabel.Size = new System.Drawing.Size(34, 13);
            iMOLabel.TabIndex = 5;
            iMOLabel.Text = "IMO:";
            // 
            // fLAGLabel
            // 
            fLAGLabel.AutoSize = true;
            fLAGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fLAGLabel.Location = new System.Drawing.Point(122, 179);
            fLAGLabel.Name = "fLAGLabel";
            fLAGLabel.Size = new System.Drawing.Size(42, 13);
            fLAGLabel.TabIndex = 7;
            fLAGLabel.Text = "FLAG:";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deliveryDateLabel.Location = new System.Drawing.Point(122, 206);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(88, 13);
            deliveryDateLabel.TabIndex = 9;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // grossTonageLabel
            // 
            grossTonageLabel.AutoSize = true;
            grossTonageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grossTonageLabel.Location = new System.Drawing.Point(122, 231);
            grossTonageLabel.Name = "grossTonageLabel";
            grossTonageLabel.Size = new System.Drawing.Size(90, 13);
            grossTonageLabel.TabIndex = 11;
            grossTonageLabel.Text = "Gross Tonage:";
            // 
            // deadWeightLabel
            // 
            deadWeightLabel.AutoSize = true;
            deadWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deadWeightLabel.Location = new System.Drawing.Point(122, 257);
            deadWeightLabel.Name = "deadWeightLabel";
            deadWeightLabel.Size = new System.Drawing.Size(85, 13);
            deadWeightLabel.TabIndex = 13;
            deadWeightLabel.Text = "Dead Weight:";
            // 
            // vesselBindingNavigator
            // 
            this.vesselBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vesselBindingNavigator.BindingSource = this.vesselBindingSource;
            this.vesselBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vesselBindingNavigator.DeleteItem = null;
            this.vesselBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vesselBindingNavigatorSaveItem});
            this.vesselBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vesselBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vesselBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vesselBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vesselBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vesselBindingNavigator.Name = "vesselBindingNavigator";
            this.vesselBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vesselBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.vesselBindingNavigator.TabIndex = 0;
            this.vesselBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // vesselBindingSource
            // 
            this.vesselBindingSource.DataMember = "Vessel";
            this.vesselBindingSource.DataSource = this.attendance;
            // 
            // attendance
            // 
            this.attendance.DataSetName = "Attendance";
            this.attendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vesselBindingNavigatorSaveItem
            // 
            this.vesselBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vesselBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vesselBindingNavigatorSaveItem.Image")));
            this.vesselBindingNavigatorSaveItem.Name = "vesselBindingNavigatorSaveItem";
            this.vesselBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vesselBindingNavigatorSaveItem.Text = "Save Data";
            this.vesselBindingNavigatorSaveItem.Click += new System.EventHandler(this.vesselBindingNavigatorSaveItem_Click);
            // 
            // vesselNameTextBox
            // 
            this.vesselNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vesselBindingSource, "VesselName", true));
            this.vesselNameTextBox.Location = new System.Drawing.Point(219, 98);
            this.vesselNameTextBox.MaxLength = 64;
            this.vesselNameTextBox.Name = "vesselNameTextBox";
            this.vesselNameTextBox.Size = new System.Drawing.Size(340, 20);
            this.vesselNameTextBox.TabIndex = 2;
            // 
            // vesselIdTextBox
            // 
            this.vesselIdTextBox.BackColor = System.Drawing.Color.White;
            this.vesselIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vesselBindingSource, "VesselId", true));
            this.vesselIdTextBox.Location = new System.Drawing.Point(219, 124);
            this.vesselIdTextBox.Name = "vesselIdTextBox";
            this.vesselIdTextBox.ReadOnly = true;
            this.vesselIdTextBox.Size = new System.Drawing.Size(105, 20);
            this.vesselIdTextBox.TabIndex = 4;
            this.vesselIdTextBox.TabStop = false;
            this.vesselIdTextBox.WordWrap = false;
            // 
            // iMOTextBox
            // 
            this.iMOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vesselBindingSource, "IMO", true));
            this.iMOTextBox.Location = new System.Drawing.Point(219, 150);
            this.iMOTextBox.MaxLength = 32;
            this.iMOTextBox.Name = "iMOTextBox";
            this.iMOTextBox.Size = new System.Drawing.Size(233, 20);
            this.iMOTextBox.TabIndex = 6;
            // 
            // fLAGTextBox
            // 
            this.fLAGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vesselBindingSource, "FLAG", true));
            this.fLAGTextBox.Location = new System.Drawing.Point(219, 176);
            this.fLAGTextBox.MaxLength = 64;
            this.fLAGTextBox.Name = "fLAGTextBox";
            this.fLAGTextBox.Size = new System.Drawing.Size(233, 20);
            this.fLAGTextBox.TabIndex = 8;
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vesselBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(219, 202);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(105, 20);
            this.deliveryDateDateTimePicker.TabIndex = 10;
            // 
            // grossTonageTextBox
            // 
            this.grossTonageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vesselBindingSource, "GrossTonage", true));
            this.grossTonageTextBox.Location = new System.Drawing.Point(219, 228);
            this.grossTonageTextBox.Name = "grossTonageTextBox";
            this.grossTonageTextBox.Size = new System.Drawing.Size(129, 20);
            this.grossTonageTextBox.TabIndex = 12;
            // 
            // deadWeightTextBox
            // 
            this.deadWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vesselBindingSource, "DeadWeight", true));
            this.deadWeightTextBox.Location = new System.Drawing.Point(219, 254);
            this.deadWeightTextBox.Name = "deadWeightTextBox";
            this.deadWeightTextBox.Size = new System.Drawing.Size(129, 20);
            this.deadWeightTextBox.TabIndex = 14;
            
            
            // 
            // FormVesselRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(vesselNameLabel);
            this.Controls.Add(this.vesselNameTextBox);
            this.Controls.Add(vesselIdLabel);
            this.Controls.Add(this.vesselIdTextBox);
            this.Controls.Add(iMOLabel);
            this.Controls.Add(this.iMOTextBox);
            this.Controls.Add(fLAGLabel);
            this.Controls.Add(this.fLAGTextBox);
            this.Controls.Add(deliveryDateLabel);
            this.Controls.Add(this.deliveryDateDateTimePicker);
            this.Controls.Add(grossTonageLabel);
            this.Controls.Add(this.grossTonageTextBox);
            this.Controls.Add(deadWeightLabel);
            this.Controls.Add(this.deadWeightTextBox);
            this.Controls.Add(this.vesselBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormVesselRegistry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vessel Registry";
            this.Load += new System.EventHandler(this.FormVesselRegistry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vesselBindingNavigator)).EndInit();
            this.vesselBindingNavigator.ResumeLayout(false);
            this.vesselBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vesselBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Attendance attendance;
        private System.Windows.Forms.BindingSource vesselBindingSource;
        
        private System.Windows.Forms.BindingNavigator vesselBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vesselBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vesselNameTextBox;
        private System.Windows.Forms.TextBox vesselIdTextBox;
        private System.Windows.Forms.TextBox iMOTextBox;
        private System.Windows.Forms.TextBox fLAGTextBox;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.TextBox grossTonageTextBox;
        private System.Windows.Forms.TextBox deadWeightTextBox;

    }
}