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
            /*//this.ControlBox = false;
            try {
                var listProduct = productService.GetAll();
                loadcarditem(listProduct);
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(2, "test2", "test2.jpg", 45000, 12, "ao");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
                carditem(1, "test", "test.jpg", 33000, 36, "giay");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

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

            flowLayoutPanel1.Controls.Add(card);
        }

        public void loadcarditem(List<Product> listProduct)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void refresh()
        {
            try
            {
                var listProduct = productService.GetAll();
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*public void filterByCategory(string category)
        {
            try
            {
                var listProduct = productService.GetProductsByCategory(category);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        /*public void searchByName(string name)
        {
            try
            {
                var listProduct = productService.SearchProductsByName(name);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        /*public void filterByPriceRange(double minPrice, double maxPrice)
        {
            try
            {
                var listProduct = productService.GetProductsByPriceRange(minPrice, maxPrice);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        public void filterByStockAvailability(bool inStock)
        {
            try
            {
                var listProduct = productService.GetProductsByStockAvailability(inStock);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sortByPrice(bool ascending)
        {
            try
            {
                var listProduct = productService.GetProductsSortedByPrice(ascending);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*public void sortByName(bool ascending)
        {
            try
            {
                var listProduct = productService.GetProductsSortedByName(ascending);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
        /*public void sortByStock(bool ascending)
        {
            try
            {
                var listProduct = productService.GetProductsSortedByStock(ascending);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

    }
}
