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
        FrmNhanVien frmNhanVien;

        bool menuExpand = false;
        bool sidebarExpand = true;
        bool statusExpand = false;


        public Dashboard()
        {
            InitializeComponent();
            menuExpand = false;
            sidebarExpand = false;
            menuTransition.Interval = 10;
            flowLayoutPanelSidebar.Width = 40;
            flowLayoutPaneldropdown.Height = 40;
            mdiProp();
            timer1.Start();
            panel2.Left = this.Width + 10;
            panel2Status("Chào mừng bạn đến với\nhệ thống quản lý kho!"); 
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            /*using (FrmLogin frmLogin = new FrmLogin())
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }*/
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
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                flowLayoutPanelInfo.Left -= 10;
                flowLayoutPanelInfo.Width += 10;
                if (flowLayoutPanelSidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebartransition.Stop();
                }
                //pictureBox1.Visible = true;
            }
            else
            {
                flowLayoutPanelSidebar.Width += 10;
                flowLayoutPanelInfo.Left += 10;
                flowLayoutPanelInfo.Width -= 10;
                if (flowLayoutPanelSidebar.Width >= 260)
                {
                    sidebarExpand = true;
                    sidebartransition.Stop();
                }
                //pictureBox1.Visible = ;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (frmDashboard == null)
            {
                frmDashboard = new FrmDashboard();
                frmDashboard.FormClosed += FrmDashboard_FormClosed;
                frmDashboard.MdiParent = this;
                frmDashboard.StartPosition = FormStartPosition.Manual;
                frmDashboard.Location = new Point(260, 50);
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
            if (frmSubMenu2 == null)
            {
                frmSubMenu2 = new FrmSubMenu2();
                frmSubMenu2.FormClosed += FrmSubMenu2_FormClosed;
                frmSubMenu2.MdiParent = this;
                frmSubMenu2.StartPosition = FormStartPosition.Manual;
                frmSubMenu2.Location = new Point(260, 50);
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
            if (frmSubMenu3 == null)
            {
                frmSubMenu3 = new FrmSubMenu3();
                frmSubMenu3.FormClosed += FrmSubMenu3_FormClosed;
                frmSubMenu3.MdiParent = this;
                frmSubMenu3.StartPosition = FormStartPosition.Manual;
                frmSubMenu3.Location = new Point(260, 50);
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
            if (frmSetting == null)
            {
                frmSetting = new FrmSetting();
                frmSetting.FormClosed += FrmSetting_FormClosed;
                frmSetting.MdiParent = this;
                frmSetting.StartPosition = FormStartPosition.Manual;
                frmSetting.Location = new Point(260, 50);
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
            if (frmReport == null)
            {
                frmReport = new FrmReport();
                frmReport.FormClosed += FrmReport_FormClosed;
                frmReport.MdiParent = this;
                frmReport.StartPosition = FormStartPosition.Manual;
                frmReport.Location = new Point(260, 50);
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
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                using (FrmLogin frmLogin = new FrmLogin())
                {
                    frmLogin.ShowDialog();
                    if (frmLogin.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                    }
                    else if (frmLogin.DialogResult == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (frmSubMenu1 == null)
            {
                frmSubMenu1 = new FrmSubMenu1();
                frmSubMenu1.FormClosed += FrmSubMenu1_FormClosed;
                frmSubMenu1.MdiParent = this;
                frmSubMenu1.StartPosition = FormStartPosition.Manual;
                frmSubMenu1.Location = new Point(260, 50);
                frmSubMenu1.Show();
            }
            else
            {
                frmSubMenu1.Activate();
            }
            
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            if(frmNhanVien == null) {                
                frmNhanVien = new FrmNhanVien();
                frmNhanVien.FormClosed += FrmNhanVien_FormClosed;
                frmNhanVien.MdiParent = this;
                frmNhanVien.StartPosition = FormStartPosition.Manual;
                frmNhanVien.Location = new Point(260, 50);
                frmNhanVien.Show();
            }
            else
            {
                frmNhanVien.Activate();
            }
        }
        private void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNhanVien = null;
        }
        private void FrmSubMenu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSubMenu1 = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private async Task panel2Status(string status)
        {
            this.labelStatus.Text = status;
            CenterLabel(labelStatus, panel2);
            Status.Start();
            await Task.Delay(4000);
            Status.Start();
        }

        private void Status_Tick(object sender, EventArgs e)
        {
            if (statusExpand == false)
            {
                panel2.Left -= 10;
                if (panel2.Left <= this.Width - 280)
                {
                    statusExpand = true;
                    Status.Stop();
                }
            }
            else
            {
                panel2.Left += 10;
                if (panel2.Left >= this.Width + 10)
                {
                    statusExpand = false;
                    Status.Stop();
                }
            }
        }

        private void CenterLabel(Label lbl, Panel pnl)
        {
            lbl.Left = (pnl.Width - lbl.Width) / 2;
            lbl.Top = (pnl.Height - lbl.Height) / 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
