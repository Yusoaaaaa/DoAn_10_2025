using DoAn.BUS; // Cần dùng các Service
using DoAn.DAL.Models; // Cần dùng model
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FrmReport : Form
    {
        private OrderService orderService;
        private ProductService productService;
        private InventoryService inventoryService;
        public FrmReport()
        {
            InitializeComponent();
            orderService = new OrderService();
            productService = new ProductService();
            inventoryService = new InventoryService();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeManagementDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.storeManagementDataSet.DataTable1);
            this.ControlBox = false;

            this.reportViewer1.RefreshReport();
        }
    }
}
