using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.BUS;
using DoAn.DAL;
using DoAn.DAL.Models;

namespace DoAn
{
    public partial class FrmDashboard : Form
    {
        private readonly ProductService productService = new ProductService();
        private readonly InventoryService inventoryService = new InventoryService();
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            try { 
                var listProduct = productService.GetAll();
                loadcarditem(listProduct);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void carditem(int id, string name, string image, double price, int stock, string category)
        {
            var card = new cardProduct()
            {
                id = id,
                name = name,
                image = image,
                price = price,
                stock = stock,
                category = category
            };

            this.Controls.Add(card);
        }

        public void loadcarditem(List<Product> listProduct)
        {
            try
            {
                this.Controls.Clear();
                foreach (var item in listProduct)
                {
                    int id = item.SKU;
                    string name = item.Name;
                    string image = item.Illustration;
                    double price = item.Price;
                    int stock = inventoryService.GetStockByProductId(item.SKU);
                    string category = item.Category;

                    carditem(id, name, image, price, stock, category);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
