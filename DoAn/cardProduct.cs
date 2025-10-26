using DoAn.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class cardProduct : UserControl
    {
        private readonly InventoryService inventoryService = new InventoryService();
        public int id { get; set; }
        public string name
        {
            get
            {
                return PName.Text;
            }
            set
            {
                PName.Text = value;
            }
        }
        public double price
        {
            get
            {
                return double.Parse(Price.Text);
            }
            set
            {
                Price.Text = value.ToString() + " VND";
            }
        }
        public string image
        {
            get
            {
                return image;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string imagePath = Path.Combine(parentDirectory, "Illustrations", value);
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Refresh();
                }
            }
        }
        public int stock
        {
            get
            {
                return int.Parse(labelAmount.Text);
            }
            set
            {
                labelAmount.Text = value.ToString();
            }
        }
        public string category { get; set; }
        public cardProduct()
        {
            InitializeComponent();
        }

        private void cardProduct_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            var inventory = inventoryService.GetById(id);
            if (int.TryParse(textBox1.Text, out int number))
            {
                int newStock = stock + number;
                stock = newStock;
                inventory.instock = newStock;
                textBox1.Text = "";
                inventoryService.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Không phải là số!");
            }
        }
    }
}
