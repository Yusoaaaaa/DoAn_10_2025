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
    public partial class Dashboard : Form
    {
        FrmDashboard frmDashboard;
        FrmSubMenu1 frmSubMenu1;
        FrmSubMenu2 frmSubMenu2;
        FrmSubMenu3 frmSubMenu3;
        FrmSetting frmSetting;
        FrmReport frmReport;


        bool menuExpand = false;
        bool sidebarExpand = true;
        public Dashboard()
        {
            InitializeComponent();
            menuExpand = false;
            sidebarExpand = false;
            menuTransition.Interval = 10;
            flowLayoutPanelSidebar.Width = 40;
            flowLayoutPaneldropdown.Height = 40;
            mdiProp();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false) 
            { 
                flowLayoutPaneldropdown.Height += 10;
                if (flowLayoutPaneldropdown.Height >= 160)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPaneldropdown.Height -= 10;
                if (flowLayoutPaneldropdown.Height <= 40)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void sidebartransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flowLayoutPanelSidebar.Width -= 10;
                if (flowLayoutPanelSidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();
                }
            }
            else
            {
                flowLayoutPanelSidebar.Width += 10;
                if (flowLayoutPanelSidebar.Width >= 260)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(frmDashboard == null)
            {
                frmDashboard = new FrmDashboard();
                frmDashboard.FormClosed += FrmDashboard_FormClosed;
                frmDashboard.MdiParent = this;
                frmDashboard.Dock = DockStyle.Fill;
                frmDashboard.Show();
            }
            else
            {
                frmDashboard.Activate();
            }
        }

        private void FrmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDashboard = null;
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            if(frmSubMenu2 == null)
            {
                frmSubMenu2 = new FrmSubMenu2();
                frmSubMenu2.FormClosed += FrmSubMenu2_FormClosed;
                frmSubMenu2.MdiParent = this;
                frmSubMenu2.Dock = DockStyle.Fill;
                frmSubMenu2.Show();
            }
            else
            {
                frmSubMenu2.Activate();
            }
        }

        private void FrmSubMenu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSubMenu2 = null;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(frmSubMenu3 == null)
            {
                frmSubMenu3 = new FrmSubMenu3();
                frmSubMenu3.FormClosed += FrmSubMenu3_FormClosed;
                frmSubMenu3.MdiParent = this;
                frmSubMenu3.Dock = DockStyle.Fill;
                frmSubMenu3.Show();
            }
            else
            {
                frmSubMenu3.Activate();
            }
        }

        private void FrmSubMenu3_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSubMenu3 = null;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if(frmSetting == null)
            {
                frmSetting = new FrmSetting();
                frmSetting.FormClosed += FrmSetting_FormClosed;
                frmSetting.MdiParent = this;
                frmSetting.Dock = DockStyle.Fill;
                frmSetting.Show();
            }
            else
            {
                frmSetting.Activate();
            }
        }

        private void FrmSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSetting = null;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if(frmReport == null)
            {
                frmReport = new FrmReport();
                frmReport.FormClosed += FrmReport_FormClosed;
                frmReport.MdiParent = this;
                frmReport.Dock = DockStyle.Fill;
                frmReport.Show();
            }
            else
            {
                frmReport.Activate();
            }
        }

        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmReport = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if(frmSubMenu1 == null)
            {
                frmSubMenu1 = new FrmSubMenu1();
                frmSubMenu1.FormClosed += FrmSubMenu1_FormClosed;
                frmSubMenu1.MdiParent = this;
                frmSubMenu1.Dock = DockStyle.Fill;
                frmSubMenu1.Show();
            }
            else
            {
                frmSubMenu1.Activate();
            }
        }

        private void FrmSubMenu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSubMenu1 = null;
        }
    }
}
