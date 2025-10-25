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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmSubMenu2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}