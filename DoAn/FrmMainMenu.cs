using DoAn.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn
{
    public partial class FrmMainMenu : Form
    {
        private readonly ProductService productService = new ProductService();
        private readonly InventoryService inventoryService = new InventoryService();
        private readonly OrderService orderService = new OrderService();
        public FrmMainMenu()
        {
            InitializeComponent();
            refreshPage();
        }

        private void refreshPage()
        {
            int totalProducts = productService.GetAll().Count();
            int availableProducts = productService.CountProductsAvail();
            int unavailableProducts = productService.CountProductsNotAvail();
            int totalOrders = orderService.CountOrders();
            double totalRevenue = orderService.CalculateTotalRevenue();
            double calculatedProfit = orderService.CalculateTotalProfit();

            OrderNumberLabel.Text = totalOrders.ToString();
            sellingNumberLabel.Text = availableProducts.ToString();
            StoppedSellingNumberLabel.Text = unavailableProducts.ToString();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            IncomeLabel.Text = totalRevenue.ToString("C2");
            ProfitLabel.Text = calculatedProfit.ToString("C2");


            int Month = DateTime.Now.Month;

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series["Series1"].Points.AddXY("Jan", orderService.countOrderByDate(1));
            chart1.Series["Series1"].Points.AddXY("Feb", orderService.countOrderByDate(2));
            chart1.Series["Series1"].Points.AddXY("Mar", orderService.countOrderByDate(3));
            chart1.Series["Series1"].Points.AddXY("Apr", orderService.countOrderByDate(4));
            chart1.Series["Series1"].Points.AddXY("May", orderService.countOrderByDate(5));
            chart1.Series["Series1"].Points.AddXY("Jun", orderService.countOrderByDate(6));
            chart1.Series["Series1"].Points.AddXY("Jul", orderService.countOrderByDate(7));
            chart1.Series["Series1"].Points.AddXY("Aug", orderService.countOrderByDate(8));
            chart1.Series["Series1"].Points.AddXY("Sep", orderService.countOrderByDate(9));
            chart1.Series["Series1"].Points.AddXY("Oct", orderService.countOrderByDate(10));
            chart1.Series["Series1"].Points.AddXY("Nov", orderService.countOrderByDate(11));
            chart1.Series["Series1"].Points.AddXY("Dec", orderService.countOrderByDate(12));

            chart2.ChartAreas[0].AxisX.Interval = 1;
            
            int Sku1 = productService.GetById(orderService.getTop3Product(1)).SKU != null ? productService.GetById(orderService.getTop3Product(1)).SKU : 0;
            string PName1 = productService.GetById(Sku1).Name != null ? productService.GetById(Sku1).Name : "N/A";
            int PCount1 = orderService.getTotalOrderYearByID(Sku1) != null ? orderService.getTotalOrderYearByID(Sku1) : 0;

            int Sku2 = productService.GetById(orderService.getTop3Product(2)).SKU != null ? productService.GetById(orderService.getTop3Product(1)).SKU : 0;
            string PName2 = productService.GetById(Sku2).Name != null ? productService.GetById(Sku1).Name : "N/A";
            int PCount2 = orderService.getTotalOrderYearByID(Sku2) != null ? orderService.getTotalOrderYearByID(Sku1) : 0;

            int Sku3 = productService.GetById(orderService.getTop3Product(3)).SKU != null ? productService.GetById(orderService.getTop3Product(1)).SKU : 0;
            string PName3 = productService.GetById(Sku3).Name != null ? productService.GetById(Sku1).Name : "N/A";
            int PCount3 = orderService.getTotalOrderYearByID(Sku3);

            

            chart2.Series["Series1"].Points.AddXY(PName1, PCount1);
            chart2.Series["Series1"].LegendText = PName1;
            chart2.Series["Series2"].Points.AddXY(PName2, PCount2);
            chart2.Series["Series2"].LegendText = PName2;
            chart2.Series["Series3"].Points.AddXY(PName3, PCount3);
            chart2.Series["Series3"].LegendText = PName3;
            //chart1.Series.Add(series);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void sellingNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            using (FrmDashboard frmDashboard = new FrmDashboard())
            {
                frmDashboard.ShowDialog();
            }
        }
    }
}
