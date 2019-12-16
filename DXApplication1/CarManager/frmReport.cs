using DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager
{
    public partial class frmReport : Form
    {
        DataProgram db = new DataProgram();
        List<Order> listOrder;
        string type;
        public frmReport()
        {
            InitializeComponent();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 12; i++)
            {
                cbMonth.Items.Add(i + 1);
            }
            listOrder = db.ListOrder();
            btnSearch.Enabled = false;
            reportPieChart.Visible = false;
            reportColumnChart.Visible = false;
        }
 
        
        private void loadPieChart()
        {
            reportPieChart.Visible = true;
            reportColumnChart.Visible = false;
            reportPieChart.Series["Goal Chart"].Points.Clear();
            string month = cbMonth.Text;
            string year = txtYear.Text;
            int total = countQttByDate(month, year);
            reportPieChart.Series["Goal Chart"].Points.AddXY("Quantity", total);
            reportPieChart.Series["Goal Chart"].Points.AddXY("Quantity left",50- total);
            reportPieChart.Series["Goal Chart"]["PieLabelStyle"] = "Disabled";
        }
        private void loadColumnChart()
        {
            reportColumnChart.Visible = true;
            reportPieChart.Visible = false;
            reportColumnChart.Series["Profit"].Points.Clear();
            string year = txtYear.Text;
            List<double> profit = profitByYear(year);
            for(int i = 0; i < profit.Count; i++)
            {
                reportColumnChart.Series["Profit"].Points.AddXY((i+1).ToString(), profit.ElementAt(i));
            }
        }
        private int countQttByDate(string month, string year)
        {
            int count = 0;
            for (int i = 0; i < listOrder.Count; i++)
            {
                string[] tmp = listOrder.ElementAt(i).date_order_.ToString().Split('/',' ');
                if(month.Equals(tmp[0]) && year.Equals(tmp[2]))
                {
                    count += db.countQtt(listOrder.ElementAt(i).order_ID_);
                }
            }
            return count;
        }
        private List<double> profitByYear(string year)
        {
            List<double> money = new List<double>();
            for (int i = 0; i < listOrder.Count; i++)
            {
                string[] tmp = listOrder.ElementAt(i).date_order_.ToString().Split('/', ' ');
                for(int j = 0; j < 12; j++)
                {
                    if (tmp[0].Equals((j+1).ToString()) && year.Equals(tmp[2]))
                    {
                        money.Add(listOrder.ElementAt(i).total_money_);
                    }
                    else
                    {
                        money.Add(0);
                    }
                }              
            }
            return money;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (type.Equals("target"))
            {
                loadPieChart();
            }
            if (type.Equals("profit"))
            {
                loadColumnChart();
            }
        }
        private void btnTarget_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSearch.Enabled = true;
            type = "target";
            cbMonth.Enabled = true;
            cbMonth.Text = "1";
            txtYear.Text = "2000";
            loadPieChart();
        }
        private void btnProfit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSearch.Enabled = true;
            type = "profit";
            cbMonth.Enabled = false;
            txtYear.Text = "2000";
            loadColumnChart();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (type.Equals("target"))
            {
                loadPieChart();
            }
            if (type.Equals("profit"))
            {
                loadColumnChart();
            }
        }
    }
}
