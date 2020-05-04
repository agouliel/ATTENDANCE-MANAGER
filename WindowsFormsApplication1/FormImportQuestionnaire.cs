#define ASPOSE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormImportQuestionnaire : Form
    {
#if ASPOSE
        Aspose.Cells.Workbook AsposeWkb;
#endif
        private int workbook_idx = -1;
        public FormImportQuestionnaire()
        {
            InitializeComponent();
            DragDropGeneric DDG = new DragDropGeneric(this.tb_startdrag);
            DDG.OnDragSetData += new DragDropGeneric.OnDragSetDataDelegate(DDG_OnDragSetData);
        }

        
        void DDG_OnDragSetData(out object data)
        {
            data = this.questionnaireObjectsDataGridView;
        }
        private void questionnaireObjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.questionnaireObjectsBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.attendance);

        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlg = new OpenFileDialog();
            if (DialogResult.OK == odlg.ShowDialog())
            {
                string filename = odlg.FileName;
                this.Event_ImportFromExcelFile(filename);
            }
        }
#if XLSGEN
        private void Event_ImportFromExcelFile(string filename)
        {

                xlsgen.CoXlsEngine engine = null;
                try
                {
                    engine = new xlsgen.CoXlsEngineClass();
                    xlsgen.IXlsWorkbook wbk = engine.Open(filename, filename);
                    if (workbook_idx == -1)
                    {
                        this.lb_workbooks.Items.Clear();
                        for (int i = 0; i < wbk.WorksheetCount; i++)
                        {
                            this.lb_workbooks.Items.Add(wbk.get_WorksheetByIndex(i).Name);
                        }
                    }
                    wbk.Close();
                }
                finally
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(engine);
                }
        }
#endif
#if ASPOSE
        private void Event_ImportFromExcelFile(string filename)
        {

            try
            {
                Aspose.Cells.Workbook wbk = new Aspose.Cells.Workbook();
                this.AsposeWkb = wbk;
                wbk.Open(filename);
                if (workbook_idx == -1)
                {
                    this.lb_workbooks.Items.Clear();
                    for (int i = 0; i < wbk.Worksheets.Count; i++)
                    {
                        this.lb_workbooks.Items.Add(wbk.Worksheets[i].Name);
                    }

                }
         
            }
            finally
            {
                
            }
        }

        private void Event_ImportWorksheet(Aspose.Cells.Workbook wkb,int idx)
        {
            Aspose.Cells.Worksheet wsh = wkb.Worksheets[idx];
            bool bnotfound=true;
            int rowcount = 0;

            this.attendance.QuestionnaireObjects.Clear();
            this.questionnaireObjectsBindingSource.SuspendBinding();
            while (bnotfound)
            {

                if (rowcount > 1000)
                    break;
                string prefix = "";
                for (int j = 0; j <= 1; j++)
                {
                    if (j == 0)
                        prefix = "Chapter";
                    else
                        prefix = "Section";
                    if (wsh.Cells[rowcount, j].Value != null)
                    {
                        DataRowView drv = (DataRowView)this.questionnaireObjectsBindingSource.AddNew();


                        
                        
                        drv["ObjectType"] = 3;
                        drv["Children"] = -1;
                        drv.EndEdit();

                        drv = (DataRowView)this.questionnaireObjectsBindingSource.AddNew();
                        drv["ObjectDescription"] = wsh.Cells[rowcount, j].Value;
                        drv["ObjectType"] = 1;
                        drv["ObjectCode"] = prefix;
                        //drv["OriginId"] = -1;
                        drv["ObjectType"] = 2;
                        drv["Children"] = -1;
                        drv.EndEdit();

                        
                        drv = (DataRowView)this.questionnaireObjectsBindingSource.AddNew();
                        
                        drv["ObjectType"] = 3;
                        drv["Children"] = -1;
                        drv.EndEdit();
                    }
                }
                
                if (wsh.Cells[rowcount, 3].Value == null)
                {
                    rowcount++;
                    continue;
                }
                else
                {
                    if (wsh.Cells[rowcount, 3].Value.ToString().Trim().ToUpper() == "END" )
                    {

                        bnotfound = false;
                        break;
                    }


                
                
                
                
                    if (wsh.Cells[rowcount, 3].Value.ToString() != "")
                    {
                        DataRowView drv = (DataRowView)this.questionnaireObjectsBindingSource.AddNew();
                        
                        drv["ObjectDescription"] = wsh.Cells[rowcount, 3].Value;
                        drv["ObjectType"] = 1;
                        drv["ObjectCode"] = wsh.Cells[rowcount, 2].Value;
                        //drv["OriginId"] = -1;
                        drv["ObjectType"] = 1;
                        drv["Children"] = -1;
                        drv.EndEdit();
                    }
                }
                rowcount++;

            }
            this.questionnaireObjectsBindingSource.ResumeBinding();
        }
#endif
        private void FormImportQuestionnaire_Load(object sender, EventArgs e)
        {

            SqlDataAdapter daQuestionnaireOrigin = Vetting.QuestionnaireOrigin.GetAdapter(Vetting.MyConnection.GetConnection());
            // TODO: This line of code loads data into the 'attendance.QuestionnaireOrigin' table. You can move, or remove it, as needed.
            daQuestionnaireOrigin.Fill(this.attendance.QuestionnaireOrigin);

            SqlDataAdapter daQuestionnaireObject = Vetting.QuestionnaireObject.GetAdapter(Vetting.MyConnection.GetConnection());

            daQuestionnaireObject.Fill(this.attendance.QuestionnaireObjects);

        }

        private void questionnaireObjectsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.questionnaireObjectsBindingSource.EndEdit();
            // replaced this.tableAdapterManager.UpdateAll(this.attendance);

            Vetting.QuestionnaireObject.GetAdapter(Vetting.MyConnection.GetConnection()).Update(this.attendance.QuestionnaireObjects);
        }

        private void bt_worksheet_Click(object sender, EventArgs e)
        {
            if (this.lb_workbooks.SelectedIndex != -1)
            {
                this.Event_ImportWorksheet(AsposeWkb, this.lb_workbooks.SelectedIndex);
            }
        }

        private void questionnaireObjectsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Do not automatically paint the focus rectangle.
            e.PaintParts &= ~DataGridViewPaintParts.Focus;

            // Determine whether the cell should be painted
            // with the custom selection background.
            if ((e.State & DataGridViewElementStates.Selected) ==
                        DataGridViewElementStates.Selected)
            {
                // Calculate the bounds of the row.
                Rectangle rowBounds = new Rectangle(
                    this.questionnaireObjectsDataGridView.RowHeadersWidth, e.RowBounds.Top,
                    this.questionnaireObjectsDataGridView.Columns.GetColumnsWidth(
                        DataGridViewElementStates.Visible) -
                    this.questionnaireObjectsDataGridView.HorizontalScrollingOffset + 1,
                    e.RowBounds.Height);

                // Paint the custom selection background.
                using (Brush backbrush =
                    new System.Drawing.Drawing2D.LinearGradientBrush(rowBounds,
                        Color.Red,
                        e.InheritedRowStyle.ForeColor,
                        System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(backbrush, rowBounds);
                }
            }

        }

        


    }
}
