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
    public partial class cardProduct : UserControl
    {
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
        public double price { 
            get
            {
                return double.Parse(Price.Text);
            }
            set
            {
                Price.Text = value.ToString();
            }
        }
        public string image { get; set; }
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
    }
}
