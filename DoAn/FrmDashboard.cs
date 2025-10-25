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

        public Point mouseLocation;

        bool FilterMenu_Expanded = false;

        bool PriceSort_Ascending = true;
        bool NameSort_Ascending = true;
        bool CategorySort_Ascending = true;
        bool StockSort_Ascending = true;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            panelFind.Top = -150;
            btnPriceSort.Text = "Giá ▼";
            btnNameSort.Text = "Tên ▲";
            btnCategorySort.Text = "Danh mục ▲";
            btnStockSort.Text = "Tồn kho ▼"; //▲▼
            try {
                var listProduct = productService.GetAll();
                loadcarditem(listProduct);
                
            }
            catch (Exception ex)
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

        public void filterByCategory(string category)
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
        }

        public void searchByName(string name)
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
        }

        public void filterByPriceRange(double minPrice, double maxPrice)
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
        }

        public void filterByStockAvailability()
        {
            try
            {
                var listProduct = inventoryService.GetProductsByStockAvailability();
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

        public void sortByName(bool ascending)
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
        }

        public void sortByCategory(bool ascending)
        {
            try
            {
                var listProduct = productService.GetProductsSortedByCategory(ascending);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void sortByStock(bool ascending)
        {
            try
            {
                var listProduct = inventoryService.GetProductsSortedByStock(ascending);
                loadcarditem(listProduct);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePose;
            }
        }

        private void txtNameFind_Enter(object sender, EventArgs e)
        {
            if(txtNameFind.Text == "Tên")
            {
                txtNameFind.Text = "";
                txtNameFind.ForeColor = Color.Black;
            }

        }

        private void txtNameFind_Leave(object sender, EventArgs e)
        {
            if(txtNameFind.Text == "")
            {
                txtNameFind.Text = "Tên";
                txtNameFind.ForeColor = Color.Gray;
            }
        }

        private void txtSKUFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSKUFind_Enter(object sender, EventArgs e)
        {
            if(txtSKUFind.Text == "SKU")
            {
                txtSKUFind.Text = "";
                txtSKUFind.ForeColor = Color.Black;
            }
        }

        private void txtSKUFind_Leave(object sender, EventArgs e)
        {
            if(txtSKUFind.Text == "")
            {
                txtSKUFind.Text = "SKU";
                txtSKUFind.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtMinFind.Text == "Thấp nhất")
            {
                txtMinFind.Text = "";
                txtMinFind.ForeColor = Color.Black;
            }
        }

        private void txtMinFind_Leave(object sender, EventArgs e)
        {
            if(txtMinFind.Text == "")
            {
                txtMinFind.Text = "Thấp nhất";
                txtMinFind.ForeColor = Color.Gray;
            }
        }

        private void txtMaxFind_Enter(object sender, EventArgs e)
        {
            if(txtMaxFind.Text == "Cao nhất")
            {
                txtMaxFind.Text = "";
                txtMaxFind.ForeColor = Color.Black;
            }
        }

        private void txtMaxFind_Leave(object sender, EventArgs e)
        {
            if(txtMaxFind.Text == "")
            {
                txtMaxFind.Text = "Cao nhất";
                txtMaxFind.ForeColor = Color.Gray;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FindMenuTransition.Start();
            if(!FilterMenu_Expanded)
            {
                FillCategoryComboBox();
            }
        }

        private void FindMenuTransition_Tick(object sender, EventArgs e)
        {
            if (FilterMenu_Expanded == true)
            {
                panelFind.Top -= 10;
                if (panelFind.Top <= -150)
                {
                    FindMenuTransition.Stop();
                    FilterMenu_Expanded = false;
                }

            }
            else
            {
                panelFind.Top += 10;
                if (panelFind.Top >= 0)
                {
                    FindMenuTransition.Stop();
                    FilterMenu_Expanded = true;
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string name = txtNameFind.Text != "Tên" ? txtNameFind.Text : "";
            string skuText = txtSKUFind.Text != "SKU" ? txtSKUFind.Text : "";
            int sku = 0;
            if (!string.IsNullOrEmpty(skuText))
            {
                int.TryParse(skuText, out sku);
            }
            double minPrice = 0;
            double maxPrice = double.MaxValue;
            if (txtMinFind.Text != "Thấp nhất")
            {
                double.TryParse(txtMinFind.Text, out minPrice);
            }
            if (txtMaxFind.Text != "Cao nhất")
            {
                double.TryParse(txtMaxFind.Text, out maxPrice);
            }
            var listProduct = productService.GetAll();
            if (!string.IsNullOrEmpty(name))
            {
                listProduct = listProduct.Where(p => p.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
            if (sku != 0)
            {
                listProduct = listProduct.Where(p => p.SKU == sku).ToList();
            }
            if (radioButtonAvail.Checked) 
            {
                listProduct = inventoryService.GetProductsByStockAvailability();
            }
            else if (radioButtonUnavail.Checked)
            {
                listProduct = inventoryService.GetProductsByOutOfStock();
            }
            listProduct = listProduct.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
            loadcarditem(listProduct);
        }

        private void FillCategoryComboBox()
        {
            try
            {
                var listProduct = productService.GetAll().Select(p => p.Category).Distinct().ToList();
                listProduct.Insert(0, "Tất cả");
                this.cbbCategoryFind.DataSource = listProduct;
                this.cbbCategoryFind.DisplayMember = "Category";
                /*var categories = productService.GetAll()
                                               .Select(p => p.Category)
                                               .Distinct()
                                               .ToList();
                cbbCategoryFind.Items.Clear();
                cbbCategoryFind.Items.Add("Tất cả");
                cbbCategoryFind.Items.AddRange(categories.ToArray());
                cbbCategoryFind.SelectedIndex = 0;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPriceSort_Click(object sender, EventArgs e)
        {
            if (PriceSort_Ascending)
            {
                btnPriceSort.Text = "Giá ▲";
                sortByPrice(PriceSort_Ascending);
                PriceSort_Ascending = !PriceSort_Ascending;
            }
            else
            {
                btnPriceSort.Text = "Giá ▼";
                sortByPrice(PriceSort_Ascending);
                PriceSort_Ascending = !PriceSort_Ascending;
            }
        }

        private void btnNameSort_Click(object sender, EventArgs e)
        {
            if(NameSort_Ascending)
            {
                btnNameSort.Text = "Tên ▼";
                sortByName(NameSort_Ascending);
                NameSort_Ascending = !NameSort_Ascending;
            }
            else
            {
                btnNameSort.Text = "Tên ▲";
                sortByName(NameSort_Ascending);
                NameSort_Ascending = !NameSort_Ascending;
            }
        }

        private void btnCategorySort_Click(object sender, EventArgs e)
        {
            if(CategorySort_Ascending)
            {
                btnCategorySort.Text = "Danh mục ▼";
                sortByCategory(CategorySort_Ascending);
                CategorySort_Ascending = !CategorySort_Ascending;
            }
            else
            {
                btnCategorySort.Text = "Danh mục ▲";
                sortByCategory(CategorySort_Ascending);
                CategorySort_Ascending = !CategorySort_Ascending;
            }
        }

        private void btnStockSort_Click(object sender, EventArgs e)
        {
            if(StockSort_Ascending)
            {
                btnStockSort.Text = "Tồn kho ▲";
                sortByStock(StockSort_Ascending);
                StockSort_Ascending = !StockSort_Ascending;
            }
            else
            {
                btnStockSort.Text = "Tồn kho ▼";
                sortByStock(StockSort_Ascending);
                StockSort_Ascending = !StockSort_Ascending;
            }
        }
    }
}
