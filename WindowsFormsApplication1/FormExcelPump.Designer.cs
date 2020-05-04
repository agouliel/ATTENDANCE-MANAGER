namespace WindowsFormsApplication1
{
    partial class FormExcelPump
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_worksheets = new System.Windows.Forms.ComboBox();
            this.lb_activesheet = new System.Windows.Forms.Label();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.bt_pump = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_rowfrom = new System.Windows.Forms.TextBox();
            this.tb_descol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rowto = new System.Windows.Forms.TextBox();
            this.tb_disp_col = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.tb_startdrag = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb_startdrag);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(667, 462);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(10, 10);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.cmb_worksheets);
            this.splitContainer2.Panel1.Controls.Add(this.lb_activesheet);
            this.splitContainer2.Panel1.Controls.Add(this.tb_category);
            this.splitContainer2.Panel1.Controls.Add(this.bt_pump);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.tb_rowfrom);
            this.splitContainer2.Panel1.Controls.Add(this.tb_descol);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.tb_rowto);
            this.splitContainer2.Panel1.Controls.Add(this.tb_disp_col);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Size = new System.Drawing.Size(647, 239);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Columns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rows";
            // 
            // cmb_worksheets
            // 
            this.cmb_worksheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_worksheets.FormattingEnabled = true;
            this.cmb_worksheets.Location = new System.Drawing.Point(27, 3);
            this.cmb_worksheets.Name = "cmb_worksheets";
            this.cmb_worksheets.Size = new System.Drawing.Size(350, 21);
            this.cmb_worksheets.TabIndex = 1;
            this.cmb_worksheets.SelectedIndexChanged += new System.EventHandler(this.cmb_worksheets_SelectedIndexChanged);
            // 
            // lb_activesheet
            // 
            this.lb_activesheet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_activesheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_activesheet.Location = new System.Drawing.Point(0, 95);
            this.lb_activesheet.Name = "lb_activesheet";
            this.lb_activesheet.Size = new System.Drawing.Size(647, 15);
            this.lb_activesheet.TabIndex = 9;
            this.lb_activesheet.Text = "Active Worksheet";
            this.lb_activesheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_category
            // 
            this.tb_category.Location = new System.Drawing.Point(27, 30);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(482, 20);
            this.tb_category.TabIndex = 0;
            // 
            // bt_pump
            // 
            this.bt_pump.Location = new System.Drawing.Point(532, 30);
            this.bt_pump.Name = "bt_pump";
            this.bt_pump.Size = new System.Drawing.Size(98, 32);
            this.bt_pump.TabIndex = 15;
            this.bt_pump.Text = "&Pump";
            this.bt_pump.UseVisualStyleBackColor = true;
            this.bt_pump.Click += new System.EventHandler(this.bt_pump_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DisplayCode";
            // 
            // tb_rowfrom
            // 
            this.tb_rowfrom.Location = new System.Drawing.Point(30, 73);
            this.tb_rowfrom.Name = "tb_rowfrom";
            this.tb_rowfrom.Size = new System.Drawing.Size(40, 20);
            this.tb_rowfrom.TabIndex = 2;
            // 
            // tb_descol
            // 
            this.tb_descol.Location = new System.Drawing.Point(337, 72);
            this.tb_descol.Name = "tb_descol";
            this.tb_descol.Size = new System.Drawing.Size(40, 20);
            this.tb_descol.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // tb_rowto
            // 
            this.tb_rowto.Location = new System.Drawing.Point(87, 73);
            this.tb_rowto.Name = "tb_rowto";
            this.tb_rowto.Size = new System.Drawing.Size(40, 20);
            this.tb_rowto.TabIndex = 3;
            // 
            // tb_disp_col
            // 
            this.tb_disp_col.Location = new System.Drawing.Point(228, 72);
            this.tb_disp_col.Name = "tb_disp_col";
            this.tb_disp_col.Size = new System.Drawing.Size(40, 20);
            this.tb_disp_col.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(10, 10);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tb_question);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tb_comment);
            this.splitContainer3.Size = new System.Drawing.Size(627, 105);
            this.splitContainer3.SplitterDistance = 296;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer3_SplitterMoved);
            // 
            // tb_question
            // 
            this.tb_question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_question.Location = new System.Drawing.Point(3, 14);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_question.Size = new System.Drawing.Size(282, 79);
            this.tb_question.TabIndex = 0;
            // 
            // tb_comment
            // 
            this.tb_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_comment.Location = new System.Drawing.Point(16, 14);
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_comment.Size = new System.Drawing.Size(282, 79);
            this.tb_comment.TabIndex = 1;
            // 
            // tb_startdrag
            // 
            this.tb_startdrag.BackColor = System.Drawing.Color.Yellow;
            this.tb_startdrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_startdrag.Location = new System.Drawing.Point(10, 10);
            this.tb_startdrag.Multiline = true;
            this.tb_startdrag.Name = "tb_startdrag";
            this.tb_startdrag.ReadOnly = true;
            this.tb_startdrag.Size = new System.Drawing.Size(647, 46);
            this.tb_startdrag.TabIndex = 16;
            this.tb_startdrag.Text = "Start Drag Operation FROM HERE";
            this.tb_startdrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // FormExcelPump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 462);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormExcelPump";
            this.Text = "FormExcelPump";
            this.Load += new System.EventHandler(this.FormExcelPump_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormExcelPump_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_category;
        public System.Windows.Forms.ComboBox cmb_worksheets;
        private System.Windows.Forms.Button bt_pump;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_disp_col;
        private System.Windows.Forms.TextBox tb_descol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rowto;
        private System.Windows.Forms.TextBox tb_rowfrom;
        private System.Windows.Forms.Label lb_activesheet;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_startdrag;
    }
}