using DoAn.BUS;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Dashboard : Form
    {


        //khai báo dịch vụ
        private readonly ProductService productService = new ProductService();
        private readonly InventoryService inventoryService = new InventoryService();



        //biến vị trí chuột dùng di chuyển form
        public Point mouseLocation;

        //khai báo MDIChildren
        FrmDashboard frmDashboard;
        FrmNhapHang frmNhapHang;
        FrmBanHang FrmBanHang;
        FrmSetting frmSetting;
        FrmReport frmReport;
        FrmMainMenu frmMainMenu;
        BaseInformation baseInformation;
        FrmNhanVien frmNhanVien;

        //khai báo trạng thái sidebar, menu container
        bool menuExpand = false;
        bool sidebarExpand = true;
        bool statusExpand = false;



        public Dashboard()
        {
            InitializeComponent();

            //cài đặt mặc định cho sidebar
            menuExpand = false;
            sidebarExpand = false;
            menuTransition.Interval = 10;
            flowLayoutPanelSidebar.Width = 40;
            flowLayoutPaneldropdown.Height = 40;
            btnStaff.Visible = false;

            mdiProp();

            timer1.Start(); //chạy thời gian

            //cài đặt mặc định cho panel trạng thái
            panel2.Left = this.Width + 10;

        }
        public UserControl CloneControl(UserControl original)
        {
            var clone = new cardProduct();
            clone = (cardProduct)original;
            return clone;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

            using (FrmLogin frmLogin = new FrmLogin())
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    if (frmLogin.level == 1)
                    {
                        btnStaff.Visible = false;
                        Email.Text = frmLogin.UserName;
                        

                    }
                    else
                    {
                        btnStaff.Visible = true;
                        Email.Text = frmLogin.UserName;

                    }
                    this.Show();
                    panel2Status("Chào mừng bạn đến với\nhệ thống quản lý kho!");
                }
                else
                {
                    this.Close();
                }
            }
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }


            if (frmSetting == null)
            {
                frmSetting = new FrmSetting();
                frmSetting.FormClosed += FrmDashboard_FormClosed;
                frmSetting.MdiParent = this;
                frmSetting.StartPosition = FormStartPosition.Manual;
                frmSetting.Location = new Point(260, 50);
                frmSetting.Show();
            }
            else
            {
                frmMainMenu.Activate();
            }
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        //chạy animation sibebar
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        //nút nguồn góc trên phải
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
                if (flowLayoutPaneldropdown.Height >= 200)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                    //btnMenu.ForeColor = Color.Black;
                }
            }
            else
            {
                flowLayoutPaneldropdown.Height -= 10;
                if (flowLayoutPaneldropdown.Height <= 40)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                    //btnMenu.ForeColor = Color.Black;

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
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }


            if (frmMainMenu == null)
            {
                frmMainMenu = new FrmMainMenu();
                frmMainMenu.FormClosed += FrmDashboard_FormClosed;
                frmMainMenu.MdiParent = this;
                frmMainMenu.StartPosition = FormStartPosition.Manual;
                frmMainMenu.Location = new Point(260, 50);
                frmMainMenu.Show();
            }
            else
            {
                frmMainMenu.Activate();
            }
        }

        private void FrmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainMenu = null;
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            if (frmDashboard == null)
            {
                frmDashboard = new FrmDashboard();
                frmDashboard.FormClosed += FrmInventory_FormClosed;
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

        private void FrmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDashboard = null;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            if (FrmBanHang == null)
            {
                FrmBanHang = new FrmBanHang();
                FrmBanHang.FormClosed += FrmBanHang_FormClosed;
                FrmBanHang.MdiParent = this;
                FrmBanHang.StartPosition = FormStartPosition.Manual;
                FrmBanHang.Location = new Point(260, 50);
                FrmBanHang.Show();
            }
            else
            {
                FrmBanHang.Activate();
            }
        }

        private void FrmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmBanHang = null;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
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
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
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
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            if (frmNhapHang == null)
            {
                frmNhapHang = new FrmNhapHang();
                frmNhapHang.FormClosed += frmNhapHang_FormClosed;
                frmNhapHang.MdiParent = this;
                frmNhapHang.StartPosition = FormStartPosition.Manual;
                frmNhapHang.Location = new Point(260, 50);
                frmNhapHang.Show();
            }
            else
            {
                frmNhapHang.Activate();
            }

        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            if (frmNhanVien == null)
            {
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
        private void frmNhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmNhapHang = null;
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
            if (labelStatus.Text.Length >= 20)
            {
                status = status.Insert(20, "\n");
            }
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

        private void btnBaseInfo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            if (baseInformation == null)
            {
                baseInformation = new BaseInformation();
                baseInformation.FormClosed += BaseInformation_FormClosed;
                baseInformation.MdiParent = this;
                baseInformation.StartPosition = FormStartPosition.Manual;
                baseInformation.Location = new Point(260, 50);
                baseInformation.Show();
            }
            else
            {
                baseInformation.Activate();
            }
        }

        private void BaseInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            baseInformation = null;
        }
        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePose;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }
    }
}
