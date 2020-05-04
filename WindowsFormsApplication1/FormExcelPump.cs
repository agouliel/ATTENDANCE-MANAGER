//#define EXCEL2003

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#if EXCEL2003
using Microsoft.Office.Interop.Excel;
#endif
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using System.Collections;
namespace WindowsFormsApplication1
{
    public partial class FormExcelPump : Form
    {
        String m_filepath;
        System.Data.DataTable m_table;

#if EXCEL2003
                Microsoft.Office.Interop.Excel.Application Excelobject = null;
                Microsoft.Office.Interop.Excel.Workbook wkb = null;
                Microsoft.Office.Interop.Excel.Sheets sheets=null;
                Microsoft.Office.Interop.Excel.Worksheet ws = null;
                Microsoft.Office.Interop.Excel.Range range_descr=null;
                Microsoft.Office.Interop.Excel.Range range_codes = null;
#endif
        BindingSource TableBindingSource;
                
        
        public String FilePath
        {
            set
            {
                this.m_filepath = value;
                this.InitializeExcelContext();
            }

        }


        private void InitializeExcelContext()
        {
#if EXCEL2003
                Excelobject = new Microsoft.Office.Interop.Excel.Application();
                if (Excelobject == null)
                {
                    throw new Exception("Excel could not be started");
                    
                }
                this.Excelobject.Visible = true;
                this.wkb = Excelobject.Workbooks.Open(this.m_filepath,0,true,5,"","",true,Microsoft.Office.Interop.Excel.XlPlatform.xlWindows,"\t",false,false,0,false,0,0);
                this.sheets=wkb.Sheets;
                this.ws = (Microsoft.Office.Interop.Excel.Worksheet)wkb.ActiveSheet;

                this.cmb_worksheets.Items.Clear();

                for (int i = 0; i < sheets.Count; i++)
                {

                    ws = (Microsoft.Office.Interop.Excel.Worksheet)sheets[i + 1];
                    cmb_worksheets.Items.Add("No" + (i + 1).ToString() + "   " + ws.Name);

                }
#endif
                this.m_table = new System.Data.DataTable();
                this.m_table.TableName = "PumpTable";
                this.m_table.Columns.Add("DisplayCode");
                this.m_table.Columns.Add("ObjectDescription");
                this.m_table.Columns.Add("Comment");
                
                this.TableBindingSource = new BindingSource();
                this.TableBindingSource.DataSource = this.m_table;
             }
        public FormExcelPump()
        {
            InitializeComponent();
            this.m_filepath = "";


        }
        System.Data.DataTable PumpTable
        {
            set
            {
                this.m_table = value;
            }
            get
            {
                return this.m_table;
            }
        }

        private void FormExcelPump_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.TableBindingSource;
            this.tb_question.DataBindings.Add("Text", this.TableBindingSource, "ObjectDescription");
            this.tb_comment.DataBindings.Add("Text", this.TableBindingSource, "Comment");
            this.dataGridView1.Columns[0].Width = 200;
            this.dataGridView1.Columns[1].Width = 400;
            DragDropGeneric DDG = new DragDropGeneric(this.tb_startdrag);
            DDG.OnDragSetData += new DragDropGeneric.OnDragSetDataDelegate(DDG_OnDragSetData);
        
        }

        void DDG_OnDragSetData(out object data)
        {
            data=this.dataGridView1;
        }


        private void LoadExcelFileData()
        {
#if EXCEL2003
            try
            {
                this.m_table.Rows.Clear();
                this.ws = (Microsoft.Office.Interop.Excel.Worksheet)this.wkb.Sheets[this.cmb_worksheets.SelectedIndex + 1];
                this.lb_activesheet.Text = ws.Name;

                string rng_des_from = this.tb_descol.Text.Trim() + this.tb_rowfrom.Text.Trim();
                string rng_des_to = this.tb_descol.Text.Trim() + this.tb_rowto.Text.Trim();



                string rng_disp_from = this.tb_disp_col.Text.Trim() + this.tb_rowfrom.Text.Trim();
                string rng_disp_to = this.tb_disp_col.Text.Trim() + this.tb_rowto.Text.Trim();

                try
                {
                    this.range_codes = this.ws.get_Range(rng_disp_from, rng_disp_to);
                }
                catch
                {
                    throw new Exception("Invalid display code range");

                }
                try
                {
                    this.range_descr = this.ws.get_Range(rng_des_from, rng_des_to);
                }
                catch
                {
                    throw new Exception("Invalid description range");
                }

                this.range_descr.Activate();

                System.Array ar = (System.Array)range_descr.Cells.Value2;

                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    DataRow dr = this.m_table.NewRow();
                    dr["ObjectDescription"] = ar.GetValue(i + 1, 1);
                    this.m_table.Rows.Add(dr);
                }
                range_codes.Activate();
                ar = (System.Array)range_codes.Cells.Value2;
                for (int i = 0; i < ar.GetLength(0); i++)
                {
                    DataRow dr = this.m_table.Rows[i];
                    dr["DisplayCode"] = ar.GetValue(i + 1, 1);

                }
              //  this.dataGridView1.DataSource = this.m_table;
                this.dataGridView1.Update();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
                this.Hide();
                this.Dispose();
            }
#endif
        }

        private void bt_pump_Click(object sender, EventArgs e)
        {
            this.LoadExcelFileData();
 
        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            ArrayList list = new ArrayList();
            foreach (DataGridViewRow dgvr in this.dataGridView1.SelectedRows)
            {
                if (dgvr.DataBoundItem != null)
                {
                    object[] itemarray = (dgvr.DataBoundItem as DataRowView).Row.ItemArray;
                    list.Add(itemarray);
                }
            }
            Clipboard.SetData("PumpGridView", this.Serialize(list));
            
           
        }

        private string DeSerialize(string SerializationString)
        {
            object deserialObject=null;
            byte[]arrayByte=Convert.FromBase64String(SerializationString);
            using(System.IO.MemoryStream ms1=new System.IO.MemoryStream(arrayByte))
            {
                BinaryFormatter b=new BinaryFormatter();
                deserialObject=b.Deserialize(ms1);
            }
            return (string)deserialObject;
        }

        private string Serialize(object objectToSerialize)
        {
            string serialString = null;
            using (System.IO.MemoryStream ms1 = new System.IO.MemoryStream())
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(ms1, objectToSerialize);
                byte[] arrayByte = ms1.ToArray();
                serialString = Convert.ToBase64String(arrayByte);
            }
            return serialString;
            

        }

        private void FormExcelPump_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clipboard.Clear();
#if EXCEL2003
            this.Excelobject.Quit();
            while (Marshal.ReleaseComObject(this.Excelobject) != 0)
            {
            }
            this.Excelobject = null;
#endif

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void cmb_worksheets_SelectedIndexChanged(object sender, EventArgs e)
        {
#if EXCEL2003
            try
            {
                if (((System.Windows.Forms.ComboBox)sender).SelectedIndex != -1)
                {
                    this.ws = (Microsoft.Office.Interop.Excel.Worksheet)this.wkb.Worksheets[((System.Windows.Forms.ComboBox)sender).SelectedIndex + 1];
                    this.ws.Activate();
                }
            }
            catch (Exception e1)
            {
                if (DialogResult.Yes == MessageBox.Show("Unknown error occured.Reloading File ?", "Data retrieval failed", MessageBoxButtons.YesNo))
                    this.InitializeExcelContext();
                else
                {
                    this.Hide();
                    this.Close();
                    this.Dispose();
                }
            }
#endif
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }





    class DragDropGeneric
    {
        object _data;
        int _threshold;
        bool bDragStarted;
        bool bmousedown;
        int StartX;
        int StartY;
        System.Windows.Forms.Control m_ctrl;
        public delegate void OnDragSetDataDelegate(out object data);
        public event OnDragSetDataDelegate OnDragSetData;
        public DragDropGeneric(System.Windows.Forms.Control ctrl)
        {
            this._threshold = 10;
            this.bDragStarted = false;
            this.bmousedown=false;
            this.m_ctrl = ctrl;
            this.m_ctrl.MouseDown += new MouseEventHandler(m_ctrl_MouseDown);
            this.m_ctrl.MouseMove += new MouseEventHandler(m_ctrl_MouseMove);
            this.m_ctrl.MouseUp += new MouseEventHandler(m_ctrl_MouseUp);
            this.m_ctrl.DragDrop += new DragEventHandler(m_ctrl_DragDrop);
            
            _data = this.m_ctrl;
        }

        void m_ctrl_DragDrop(object sender, DragEventArgs e)
        {
            this.bDragStarted = false;
            this.m_ctrl.Capture = false;
        }

        void m_ctrl_MouseUp(object sender, MouseEventArgs e)
        {
            this.bDragStarted = false;
            this.m_ctrl.Capture = false;
            this.bmousedown = false;
        }

        void m_ctrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (bmousedown&&!this.bDragStarted)
            {
                if (Math.Abs(e.X - this.StartX) > _threshold || Math.Abs(e.Y - this.StartY) > _threshold)
                {
                    this.bDragStarted = true;
                    this.m_ctrl.DoDragDrop(_data, DragDropEffects.Copy);
                    
                }
            }
        }

        void m_ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            this.bDragStarted = false;
            this.bmousedown = true;
            this.StartX = e.X;
            this.StartY = e.Y;
            if (OnDragSetData != null)
                OnDragSetData(out _data);

            
        }
        

    }
}
