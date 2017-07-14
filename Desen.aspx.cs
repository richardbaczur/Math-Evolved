using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INfoEducatie
{
    public partial class Desen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedValue)
            {
                case "1":
                    this.a.Enabled = true;
                    this.b.Enabled = true;
                    this.c.Enabled = false;
                    this.d.Enabled = false;
                    this.e.Enabled = false;
                    break;
                case "2":
                    this.a.Enabled = true;
                    this.b.Enabled = true;
                    this.c.Enabled = true;
                    this.d.Enabled = false;
                    this.e.Enabled = false;
                    break;
                case "3":
                    this.a.Enabled = true;
                    this.b.Enabled = true;
                    this.c.Enabled = true;
                    this.d.Enabled = true;
                    this.e.Enabled = false;
                    break;
                case "4":
                    this.a.Enabled= true;
                    this.b.Enabled = true;
                    this.c.Enabled = true;
                    this.d.Enabled= true;
                    this.e.Enabled = true;
                    break;
            }
        }
        public double getData(int x)
        {
            double ret = 0;
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    ret = Convert.ToInt32(a.Text) * x + Convert.ToInt32(b.Text);
                    break;
                case 1:
                    ret = Convert.ToInt32(a.Text) * Math.Pow(x, 2) + Convert.ToInt32(b.Text) * x + Convert.ToInt32(c.Text);
                    break;
                case 2:
                    ret = Convert.ToInt32(a.Text) * Math.Pow(x, 3) + Convert.ToInt32(b.Text) * Math.Pow(x, 2) + Convert.ToInt32(c.Text) * x + Convert.ToInt32(d.Text);
                    break;
                case 3:
                    ret = Convert.ToInt32(a.Text) * Math.Pow(x, 4) + Convert.ToInt32(b.Text) * Math.Pow(x, 3) + Convert.ToInt32(c.Text) + Math.Pow(x, 2) + Convert.ToInt32(d.Text) * x + Convert.ToInt32(e.Text);
                    break;
            }
            return ret;
        }
        protected void plot_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
            chart.Series.Add("Series0");
            chart.Series[0].Points.Clear();
            chart.Series[0].ChartType = System.Web.UI.DataVisualization.Charting.SeriesChartType.Line;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "{F2}";
            chart.ChartAreas[0].AxisX.Title = "x";
            chart.ChartAreas[0].AxisY.Title = "y";
            for (int i=-9;i<=9;i++)
            {
                int x = i;
                double y = getData(x);
                chart.Series[0].Points.AddXY(x, y);
            }

        }
    }
}