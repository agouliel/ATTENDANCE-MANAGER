#define NEVRON
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
#if NEVRON
using Nevron.GraphicsCore;
using Nevron.Chart;
using Nevron.Chart.WinForm;
#endif
using Vetting;
namespace WindowsFormsApplication1
{
    public partial class Form_ReportCritical : Form
    {
        private DataTable tbl_negativecategories;
        private DataTable tbl_negativecategories_fleet;
        private BindingSource bindingsource_negativecategories;
        private BindingSource bindingsource_negativecategories_fleet;
        private BindingSource bindingsource_negativecategories_fleet_objects;

        private Color[] MyColors;
        
        private string FilterVessel="";
        private string FilterCategory="";
        private string FilterVetting = "";
        public Form_ReportCritical()
        {
            InitializeComponent();
            MyColors = new Color[6];
            MyColors[0] = Color.FromArgb(250,100 , 0);
            MyColors[2] = Color.FromArgb(200,200, 0);
            
            MyColors[1] = Color.FromArgb(200,250, 0);
            MyColors[4] = Color.FromArgb(250, 150, 0);
            MyColors[3] = Color.FromArgb(250,250, 0);
            MyColors[5] = Color.FromArgb(255, 0, 0);

            this.tbl_negativecategories = new DataTable();
            this.tbl_negativecategories_fleet = new DataTable();
            this.tbl_negativecategories_fleet.TableName = "NegativeCategoriesFleet";

            this.bindingsource_negativecategories_fleet = new BindingSource();
            this.bindingsource_negativecategories = new BindingSource();

            this.bindingsource_negativecategories.PositionChanged += new EventHandler(bindingsource_negativecategories_PositionChanged);
            this.bindingsource_negativecategories_fleet_objects = new BindingSource();
        }

        void bindingsource_negativecategories_PositionChanged(object sender, EventArgs e)
        {
            if (this.chb_categoryrel.Checked)
            {
                if (this.bindingsource_negativecategories.Count != 0)
                {
                    this.FilterCategory = " CategoryNewId='" + (this.bindingsource_negativecategories.Current as DataRowView)["CategoryNewId"].ToString() + "' ";
                    
                }
            }
            ApplyFilter_CriticalQuestions();
        }



        private void RenderQuestionPieChart(int total,int totalseen,int errors)
        {
            chart.Charts.Clear();
            NChart piechart = new NPieChart();
            NPieSeries pie = (NPieSeries)piechart.Series.Add(SeriesType.Pie);


            pie.AddDataPoint(new NDataPoint(totalseen-errors, "Positive", new NColorFillStyle(Color.LightGreen)));
            pie.AddDataPoint(new NDataPoint(errors, "Negative", new NColorFillStyle(Color.Red)));
            
            pie.Legend.Mode = SeriesLegendMode.DataPoints;
            pie.Legend.Format = "<label> <percent>";
            pie.PieStyle = PieStyle.SmoothEdgePie;
            pie.LabelMode = PieLabelMode.Spider;

            chart.Charts.Add(piechart);
            chart.Refresh();

            this.RenderHistoryChart();
        }

        private void Event_ShowContext(bool bvesselspecific)
        {
            WindowsFormsApplication1.FormObjectContext frm = new FormObjectContext();
            try
            {
                if (this.negativeQuestionsBindingSource.Current == null)
                    throw new Exception("Select a negative question row");
                DataRowView drv = this.negativeQuestionsBindingSource.Current as DataRowView;
                DataRowView drvship = this.bindingSource_Vessels.Current as DataRowView;

                frm.ObjectId = (Guid)drv["ObjectId"];
                if (bvesselspecific)
                frm.VesselId = (int)drvship["VesselId"];

                frm.tb_comment.Text = drv["ObjectComments"].ToString();
                frm.tb_question.Text = drv["ObjectDescription"].ToString();
                frm.lb_defcode.Text = drv["QuestionCode"].ToString();
                frm.ShowDialog();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }


     private string GetCommalist(DataTable tbl,string fieldname,bool bforstring)
    {
        string res = "(";
        int colidx = tbl.Columns.IndexOf(fieldname);
        bool bfound = false;

        if (bforstring)
        {
            foreach (DataRow dr in tbl.Rows)
            {

                if (!bfound)
                {
                    res += "'"+dr[colidx].ToString()+"'";
                    bfound = true;
                }
                else
                {
                    res += "," + "'"+dr[colidx].ToString()+"'";
                }


            }
        }
        else
        {
            foreach (DataRow dr in tbl.Rows)
            {

                if (!bfound)
                {
                    res += dr[colidx].ToString();
                    bfound = true;
                }
                else
                {
                    res += "," + dr[colidx].ToString();
                }


            }
        }
        res += ")";
        return res;

    }

        private void RenderCategory(bool bvesselspecific)
        {

            string vessel_list = "";
            string category_list = GetCommalist(this.tbl_negativecategories, "CategoryNewId",true);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = MyConnection.GetConnection();

            int vesselid=(int)(this.bindingSource_Vessels.Current as DataRowView)["VesselId"];

            if (bvesselspecific)
            {

                cmd.CommandText =
                "  Select a.*,b.CategoryDescription,b.categorycode from ( Select  cn.CategoryNewId,count(*) as NegativeTotal from Vetting a join Objects o on a.objectid=o.objectid join VettingInfo v on a.vetid=v.vetid join Category cn on o.CategoryId=cn.CategoryNewID"
                                            + " where a.answer=2 and cn.CategoryNewId in " + category_list + " and v.vesselid= " + vesselid.ToString()
                                            + " group by cn.CategoryNewId ) a inner join Category b on a.categorynewid=b.categorynewid ";                             
            
                /*
                //"Objects AS b ON a.objectid = b.objectid INNER JOIN category c  on b.CategoryId=c.categoryNewid " +
                  //              "WHERE     (a.answer = 2) and (d.vesselid=@pvesselid)order by categorycode";
                cmd.CommandText =
                "  Select a.*,b.CategoryDescription,b.categorycode from ( Select  cn.CategoryNewId,count(*) as NegativeTotal from Vetting a join VIQPlus b on a.objectid=b.objectid join VettingInfo v on a.vetid=v.vetid join Category cn on b.ParentId=cn.CategoryNewID"
                                            + " where a.answer=2 and cn.CategoryNewId in " + category_list + " and v.vesselid= " + vesselid.ToString()
                                            + " group by cn.CategoryNewId ) a inner join Category b on a.categorynewid=b.categorynewid ";                             
                 * */
            }
            else
                cmd.CommandText =
               "  Select a.*,b.CategoryDescription,b.categorycode from ( Select  cn.CategoryNewId,count(*) as NegativeTotal from Vetting a join Objects o on a.objectid=o.objectid join VettingInfo v on a.vetid=v.vetid join Category cn on o.CategoryId=cn.CategoryNewID"
                                           + " where a.answer=2 and cn.CategoryNewId in " + category_list 
                                           + " group by cn.CategoryNewId ) a inner join Category b on a.categorynewid=b.categorynewid ";                             
            
               

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable tbl = new DataTable();


            int num = 0;
            try
            {
                num=da.Fill(tbl);
            }
            catch (Exception e1)
            {
                int i = 0;
            }
            finally
            {
                cmd.Connection.Close();

            }


            this.ChartCategory.Charts.Clear();
            NChart piechart = new NPieChart();
            NPieSeries ss = (NPieSeries)piechart.Series.Add(SeriesType.Pie);
            tbl.DefaultView.Sort = "NegativeTotal desc";
            int rc = 255;
            int gc = 0;
            int bc = 0;
            foreach(DataRowView dr in tbl.DefaultView)
            {
                ss.AddDataPoint(new NDataPoint(Convert.ToDouble(dr["NegativeTotal"]),"{"+dr["CategoryCode"].ToString()+"}",new NColorFillStyle(Color.FromArgb(rc,gc,bc)) ));
                /*
                if (rc - 5 > 0)
                    rc -= 5;
                else
                    rc = 0;
                 */
                int step = 10;
                if (gc + step < 255)
                    gc +=step ;
                else
                    gc = 0;
                if (bc + step < 255)
                    bc += step;
                else
                    bc = 0;
             }
            this.ChartCategory.Charts.Add(piechart);
            this.ChartCategory.Refresh();






            
        }


        private void RenderHistoryChart()
        {


            Guid objectid = (Guid)(this.negativeQuestionsBindingSource.Current as DataRowView)["ObjectId"];
            int VesselId = (int)(this.bindingSource_Vessels.Current as DataRowView)["Vesselid"];
            DataTable tbl = new DataTable();

            this.ChartHistory.Charts.Clear();
            NChart histchart = new NCartesianChart();
            //NChart histchart = new NCartesianChart();
            //NStepLineSeries ss = (NStepLineSeries)histchart.Series.Add(SeriesType.StepLine);

            
            //NBarSeries ss = (NBarSeries)histchart.Series.Add(SeriesType.Bar);
            histchart.Axis(StandardAxis.PrimaryX).ScaleConfigurator = new NDateTimeScaleConfigurator();

            NPointSeries ss = (NPointSeries)histchart.Series.Add(SeriesType.Point);
            //ss.LineSegmentShape=LineSegmentShape.Tape;
            ss.DataLabelStyle.Visible = false;
            //ss.DepthPercent = 70f;
           // histchart.Enable3D = true;
            ss.UseXValues=true;


            if (!this.chb_vesselspecific.Checked)
                VesselId = -1;

            if (Vetting.Vetting.FillObjectRelatedTable(MyConnection.GetConnection(), objectid, VesselId, tbl) > 0)
            {
                double value = 0d;
                value = 0d;
                //ss.AddDataPoint(new NDataPoint((double)value));

                foreach (DataRow dr in tbl.Rows)
                {
                    DateTime dt = (DateTime)dr["VetDate"];
                    if (dr["answer"] != DBNull.Value)
                    {
                        value = Convert.ToDouble(dr["answer"]);
                        if (value > 2d || value < 1d)
                            continue;
                    }
                    else
                        continue;
                //    if (value>1d)
                 //       ss.AddDataPoint(new NDataPoint(Convert.ToDouble(dt),value));//, new NColorFillStyle(Color.Red)));
                  //  else
                   //     ss.AddDataPoint(new NDataPoint(Convert.ToDouble(dt),value));//, new NColorFillStyle(Color.LightGreen)));

                    ss.Values.Add(value);
                    ss.XValues.Add(dt);


                 
                }

            }


            
            


            
            

    
            //pie.Legend.Mode = SeriesLegendMode.DataPoints;
            //pie.Legend.Format = "<label> <percent>";
            //pie.PieStyle = PieStyle.SmoothEdgePie;
            //pie.LabelMode = PieLabelMode.Spider;

            this.ChartHistory.Charts.Add(histchart);
            this.ChartHistory.Refresh();
        }

        private void Form_ReportCritical_Load(object sender, EventArgs e)
        {
            Reporter.FillTableVessel(MyConnection.GetConnection(), this.DataSet_ReportCritical.Vessels);
            Reporter.FillTableNegativeQuestions(MyConnection.GetConnection(), this.DataSet_ReportCritical.NegativeQuestions);
            Reporter.FillTableVetting(MyConnection.GetConnection(),this.DataSet_ReportCritical.Vetting);

            /*
            foreach (DataRow rr in this.DataSet_ReportCritical.NegativeQuestions.Rows)
            {
                if(rr["vesselid"].ToString()=="10")
                System.Console.Out.WriteLine(rr["Questioncode"].ToString()+"   "+rr["categoryNewid"].ToString());
            }
            */
            

            this.DataSet_ReportCritical.Tables.Add(this.tbl_negativecategories_fleet);

            if (ApplicationInfo.ActiveUserMode == ApplicationInfo.UserMode.Administrator)
            {
                this.chart.Visible = true;
                this.ChartCategory.Visible = true;
                this.ChartHistory.Visible = true;

            }

           // WindowsFormsApplication1.CrystalReport_CriticalReport cr=new CrystalReport_CriticalReport();
           // cr.SetDataSource(this.dataSet_ReportCritical1.Vetting as DataTable );
           // cr.Subreports[0].SetDataSource(this.dataSet_ReportCritical1.NegativeQuestions as DataTable);
           // this.crystalReportViewer1.ReportSource = cr;
            this.lb_sig_1.BackColor = MyColors[1]; this.lb_sig_1.BorderStyle = BorderStyle.None;
            this.lb_sig_2.BackColor = MyColors[2]; this.lb_sig_2.BorderStyle = BorderStyle.None;
            this.lb_sig_3.BackColor = MyColors[3]; this.lb_sig_3.BorderStyle = BorderStyle.None;
            this.lb_sig_4.BackColor = MyColors[4]; this.lb_sig_4.BorderStyle = BorderStyle.None;
            this.lb_sig_5.BackColor = MyColors[5]; this.lb_sig_5.BorderStyle = BorderStyle.None;


            this.lb_sig_bot_1.BackColor = MyColors[1]; this.lb_sig_1.BorderStyle = BorderStyle.None;
            this.lb_sig_bot_2.BackColor = MyColors[2]; this.lb_sig_2.BorderStyle = BorderStyle.None;
            this.lb_sig_bot_3.BackColor = MyColors[3]; this.lb_sig_3.BorderStyle = BorderStyle.None;
            this.lb_sig_bot_4.BackColor = MyColors[4]; this.lb_sig_4.BorderStyle = BorderStyle.None;
            this.lb_sig_bot_5.BackColor = MyColors[5]; this.lb_sig_5.BorderStyle = BorderStyle.None;

            this.dataGridView_CriticalQuestions.DataSource = this.negativeQuestionsBindingSource;
            this.negativeQuestionsBindingSource.Sort = "DisplayOrder asc";
        }

        private void dataGridView_Results_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv=(DataGridView) sender;
            if ( dgv.Columns[e.ColumnIndex].DataPropertyName=="Significance" )
            {
                
                DataRowView drv = (DataRowView)dgv.Rows[e.RowIndex].DataBoundItem;
                int sig=(int)drv["significance"];
                  e.CellStyle.BackColor = MyColors[sig];
                  e.Value = sig;
                
            }
        }

        private void dataGridView_CriticalQuestions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataRowView drv = (DataRowView)(((DataGridView)sender).DataSource as BindingSource).List[e.RowIndex];
            



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Event_ClearStatistics()
        {

            this.lb_totalnum.Text = "";
            this.lb_negativenum.Text = "";
            this.lb_perc.Text = "";
            this.lb_totalseen.Text = "";
            this.lb_seentotalperc.Text = "";
            this.ChartHistory.Charts.Clear();
            this.chart.Charts.Clear();

        }
        private void bt_calculate_Click(object sender, EventArgs e)
        {

            this.Event_CalculateStatistics();
        }
        private void Event_CalculateStatistics()
        {
            try
            {
                DataRowView drv = this.dataGridView_CriticalQuestions.CurrentRow.DataBoundItem as DataRowView;
                if (drv == null)
                    return;
                int errnum = 0;
                float perc = 0f;
                int totalnum = 0;
                int num = 0;
                int totalseen = 0;
                int significance = 0;
                object vessname = null;

                if (this.chb_vesselspecific.Checked)
                    vessname=(dataGridView_Vessels.CurrentRow.DataBoundItem as DataRowView)["VesselName"];

                object dtfrom = null;
                object dtto = null;
                DateTime dt=DateTime.MinValue;
                if (dtp_from.Checked)
                    dtfrom = dtp_from.Value.Date;
                if (dtp_to.Checked)
                {
                    dt=dtp_to.Value.Date.AddDays(1f).AddSeconds(-1f);
                    dtto = dt;
                }
                Reporter.GetQuestionStatistics(null, dtfrom, dtto, vessname, drv["ObjectId"], out totalnum,out totalseen, out significance, out errnum, out perc);
                this.lb_totalnum.Text = totalnum.ToString();
                this.lb_totalseen.Text = totalseen.ToString();
                this.lb_negativenum.Text = errnum.ToString();
                if (totalnum > 0)
                    this.lb_seentotalperc.Text = ((float)totalseen*100.0f / totalnum).ToString("###.##");
                else
                    this.lb_seentotalperc.Text = "-";
                perc *= 100f;
                this.lb_perc.Text = perc.ToString("###.##");


                this.RenderQuestionPieChart((int)totalnum, (int)totalseen, (int)errnum);
                
               
            }
            catch (Exception e1)
            {
                MessageBox.Show("Cannot calculate statistics");
            }
        }

        private void dataGridView_CriticalQuestions_SelectionChanged(object sender, EventArgs e)
        {
            this.Event_ClearStatistics();
            if (this.chb_autostatistics.Checked)
                this.Event_CalculateStatistics();
        }

        private void chb_vesselspecific_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_vesselspecific.Checked)
            {
                this.lb_vesselname.Visible = true;
                this.RenderCategory(true);
            }
            else
            {
                this.lb_vesselname.Visible = false;
                this.RenderCategory(false);
            }
            this.Event_ClearStatistics();
            if (this.chb_autostatistics.Checked)
            this.Event_CalculateStatistics();

        }

        private void chb_autostatistics_CheckedChanged(object sender, EventArgs e)
        {
            this.Event_CalculateStatistics();
        }

        private void dataGridView_Results_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex < 0)
                return;
            var dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].DataPropertyName == "Significance")
            {
                
                    e.PaintBackground(e.ClipBounds, false);
                    e.PaintContent(e.ClipBounds);
                    e.Handled = true;
                
            }
        }

        private void Event_ShowVetting(object sender)
        {
            try
            {
                int vetid = (int)((sender as DataGridView).SelectedRows[0].DataBoundItem as DataRowView)["VetId"];
                //int qid = (int)((sender as DataGridView).SelectedRows[0].DataBoundItem as DataRowView)["QId"];
                WindowsFormsApplication1.FormQuestionnaire frmq = new FormQuestionnaire();
                frmq.VetId = vetid;
                //frmq.QId = qid;
                frmq.QuestionnaireOrigin = FormQuestionnaire.BasicOrigin.Database;
                frmq.ShowDialog();

            }
            catch
            {
            }
        }
        private void dataGridView_Results_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Event_ShowVetting(sender);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CriticalQuestions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int vetid = (int)((this.dataGridView_Results).CurrentRow.DataBoundItem as DataRowView)["VetId"];
                //int qid = (int)((sender as DataGridView).SelectedRows[0].DataBoundItem as DataRowView)["QId"];
                WindowsFormsApplication1.FormQuestionnaire frmq = new FormQuestionnaire();
                frmq.VetId = vetid;
                //frmq.QId = qid;
                frmq.QuestionnaireOrigin = FormQuestionnaire.BasicOrigin.Database;
                frmq.DefaultNavigationQuestionCode = ((sender as DataGridView).CurrentRow.DataBoundItem as DataRowView)["QuestionCode"].ToString();
                frmq.ShowDialog();

            }
            catch
            {
            }

        }

        private void bindingSource_Vessels_PositionChanged(object sender, EventArgs e)
        {
            
            DataRowView drv = this.bindingSource_Vessels.Current as DataRowView;

            if (drv == null)
                return;
            //MessageBox.Show(drv["VesselId"].ToString());
            FilterVessel = "VesselId = "+drv["Vesselid"].ToString();
            
            this.tbl_negativecategories.Clear();
            Reporter.FillTableNegativeCategoriesPerVessel(MyConnection.GetConnection(), this.tbl_negativecategories, (int)drv["VesselId"]);
            this.bindingsource_negativecategories.DataSource = this.tbl_negativecategories;
            this.dgview_negative_categories.DataSource = this.bindingsource_negativecategories;
            this.lb_category.DataBindings.Clear();
            this.lb_category.DataBindings.Add("Text", this.bindingsource_negativecategories, "CategoryDescription");

            this.ApplyFilter_CriticalQuestions();
            if (this.chb_vesselspecific.Checked)
            this.RenderCategory(true);

            

        }
        private void ApplyFilter_CriticalQuestions()
        {
            if (FilterVessel != "" && FilterCategory != "")
                this.negativeQuestionsBindingSource.Filter = FilterVessel + " and " + FilterCategory;
            else if (FilterVessel != "")
                this.negativeQuestionsBindingSource.Filter = FilterVessel;
            else if (FilterCategory != "")
                this.negativeQuestionsBindingSource.Filter = FilterCategory;
            if (this.negativeQuestionsBindingSource.Count > 0)
                this.negativeQuestionsBindingSource.Position = 0;

            this.vettingBindingSource.ResetCurrentItem();

        }

        private void chb_categoryrel_CheckedChanged(object sender, EventArgs e)
        {
           // if (this.chb_categoryrel.Checked)
           // {
                this.lb_category.Visible = this.chb_categoryrel.Checked;
                this.Category_crit.DisplayIndex=0;
                //this.Category_crit.Visible = !this.chb_categoryrel.Checked;
                this.dataGridView_CriticalQuestions.Columns["Category_crit"].Visible = !this.chb_categoryrel.Checked;
                this.lb_shipname_question.Visible = !this.chb_categoryrel.Checked;
                //this.lb_shipname_categories.Visible = !this.chb_categoryrel.Checked;
                if (!this.chb_categoryrel.Checked)
                    FilterCategory = "";
                else
                {
                    if (this.bindingsource_negativecategories.Count != 0)
                    {
                      FilterCategory=  this.negativeQuestionsBindingSource.Filter = "CategoryNewId='" + (this.bindingsource_negativecategories.Current as DataRowView)["CategoryNewId"].ToString() + "'";
                    }

                }
            ApplyFilter_CriticalQuestions();
                
                
           // }
        }

        private void chb_fleetwise_CheckedChanged(object sender, EventArgs e)
        {
            return; //uncomment to implement
            if (this.chb_fleetwise.Checked)
            {
                this.tbl_negativecategories_fleet.Clear();
                Reporter.FillTableNegativeCategoriesPerFleet(MyConnection.GetConnection(), this.tbl_negativecategories_fleet);
                this.bindingsource_negativecategories_fleet.DataSource = this.DataSet_ReportCritical;
                this.bindingsource_negativecategories_fleet.DataMember = "NegativeCategoriesFleet";

                this.dgview_negative_categories.DataSource = this.bindingsource_negativecategories_fleet;
                //this.dataGridView_Vessels.ClearSelection();
                this.dataGridView_Vessels.BackgroundColor = Color.Black;
                
                if (!this.DataSet_ReportCritical.Relations.Contains("relNegativeCategoriesObjects"))
                {
                    DataColumn dcCategoryCategoryId = this.tbl_negativecategories_fleet.Columns["CategoryId"];
                    DataColumn dcCategoryVesselId = this.tbl_negativecategories_fleet.Columns["VesselId"];
                    
                    DataColumn dcObjectsCategoryId = this.DataSet_ReportCritical.NegativeQuestions.Columns["CategoryNewId"];
                    DataColumn dcObjectsVesselId = this.DataSet_ReportCritical.NegativeQuestions.Columns["VesselId"];

                    //DataColumn []dcCategories=new DataColumn[]{dcCategoryCategoryId,dcCategoryVesselId};
                    //DataColumn []dcObjects=new DataColumn[]{dcObjectsCategoryId,dcObjectsVesselId};

                    DataRelation drCategoryObjects = new DataRelation("relNegativeCategoriesObjects", new DataColumn[]{dcCategoryCategoryId,dcCategoryVesselId}, new DataColumn[]{dcObjectsCategoryId,dcObjectsVesselId});

                    
                    this.DataSet_ReportCritical.Relations.Add(drCategoryObjects);
                    this.bindingsource_negativecategories_fleet_objects.DataSource = this.DataSet_ReportCritical;
                    this.bindingsource_negativecategories_fleet_objects.DataMember = "NegativeCategoriesFleet.relNegativeCategoriesObjects";
                    this.dataGridView_CriticalQuestions.DataSource = this.bindingsource_negativecategories_fleet_objects;
                }
          }
            else
            {
                this.dgview_negative_categories.DataSource = this.bindingsource_negativecategories;
                
                try
                {
                    this.dataGridView_Vessels.Rows[0].Selected = true;
                }
                catch
                {

                }
                this.dataGridView_Vessels.BackgroundColor = SystemColors.ControlDark;
                this.bindingsource_negativecategories.ResetCurrentItem();
            }
            this.dataGridView_Vessels.Enabled = !this.chb_fleetwise.Checked;

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
           
        }

        private void viewContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Event_ShowContext(this.chb_vesselspecific.Checked);
        }

        private void negativeQuestionsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            BindingSource bs=sender as BindingSource;
            if (bs.Current != null)
            {
                FilterVetting = "ObjectId  ='" + (bs.Current as DataRowView)["objectid"].ToString() + "'" +"And " +FilterVessel;
            }
            ApplyFilter_Vetting();
        }

        

        private void negativeQuestionsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            BindingSource bs = sender as BindingSource;
            if (bs.Current != null)
            {
                FilterVetting = "ObjectId  ='" + (bs.Current as DataRowView)["objectid"].ToString() + "'" + "And " + FilterVessel;
            }
            ApplyFilter_Vetting();
        }
        private void ApplyFilter_Vetting()
        {
            this.vettingBindingSource.Filter = FilterVetting;
        }

        private void defaultSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bindingsource_negativecategories.Sort = "DisplayOrder asc";
        }

        private void viewVettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event_ShowVetting(this.dataGridView_Results);
        }

        private void defaultSortNegAnswersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.negativeQuestionsBindingSource.Sort = "DisplayOrder asc";
        }

        
    }
}
