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
        public decimal price { get; set; }
        public Image image { 
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string stock
        {
            get
            {
                return labelAmount.Text;
            }
            set
            {
                labelAmount.Text = value;
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
