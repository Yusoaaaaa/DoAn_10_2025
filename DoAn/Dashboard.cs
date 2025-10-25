using DoAn.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DoAn
{
    public partial class Dashboard : Form
    {
        //khai báo dịch vụ
        private readonly ProductService productService = new ProductService();
        private readonly InventoryService inventoryService = new InventoryService();

        //biến dùng để làm carousel
        private int scrollSpeed = 1;
        private bool isScrolling = false;
        private int direction = 1; // 1 for right, -1 for left

        //biến vị trí chuột dùng di chuyển form
        public Point mouseLocation;

        //khai báo MDIChildren
        FrmDashboard frmDashboard;
        FrmSubMenu1 frmSubMenu1;
        FrmSubMenu2 frmSubMenu2;
        FrmSubMenu3 frmSubMenu3;
        FrmSetting frmSetting;
        FrmReport frmReport;
        FrmMainMenu frmMainMenu;

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
            panel2Status("Chào mừng bạn đến với\nhệ thống quản lý kho!");

            //cài đặt cho carousel
            /*for(int i = 0; i < 8; i++)
            {
                var uc = new cardProduct()
                {
                    id = 1,
                    name = "test",
                    image = "test.jpg",
                    price = 33000,
                    stock = 36,
                    category = "giay"
                };
                flowLayoutPanel1.Controls.Add(uc);
            }
            duplicateEdges();

            slideTimer.Interval = 10;
            slideTimer.Tick += slideTimer_Tick;*/
        }

        //Clone cardProduct trước và sau
        /*public void duplicateEdges()
        {
            var first = (cardProduct)flowLayoutPanel1.Controls[0];
            var firstClone = CloneControl(first);
            flowLayoutPanel1.Controls.Add(firstClone);

            var last = (cardProduct)flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 2];
            var lastClone = CloneControl(last);
            flowLayoutPanel1.Controls.Add(lastClone);
        }*/

        public UserControl CloneControl(UserControl original)
        {
            var clone = new cardProduct();
            clone = (cardProduct)original;
            return clone;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

            //sử dụng form đăng nhập khi mở app
            using (FrmLogin frmLogin = new FrmLogin())
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    if(frmLogin.level == 1)
                    {
                        btnStaff.Visible = false;
                    } 
                    else
                    {
                        btnStaff.Visible = true;
                    }
                    this.Show();
                }
                else
                {
                    this.Close();
                }
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

        //cài đặt sự kiện menu container
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

        //cài đặt sự kiện sidebar
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

        //kích hoạt sự kiện nút Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }


        //mở MDIChildren FrmDashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            /*if (frmMainMenu == null)
            {
                frmMainMenu = new FrmMainMenu();
                frmMainMenu.FormClosed += frmMainMenu_FormClosed;
                frmMainMenu.MdiParent = this;
                frmMainMenu.StartPosition = FormStartPosition.Manual;
                frmMainMenu.Location = new Point(260, 50);
                frmMainMenu.Show();
            }
            else
            {
                frmMainMenu.Activate();
            }*/
            if(frmDashboard == null)
            {
                frmDashboard = new FrmDashboard();
                frmDashboard.FormClosed += FrmDashboard_FormClosed;
                frmDashboard.StartPosition = FormStartPosition.Manual;
                frmDashboard.Location = new Point(260, 50);
                frmDashboard.MdiParent = this;
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

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainMenu = null;
        }

        //mở MDIChildren FrmSubMenu2
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

        //mở MDIChildren FrmSubMenu3
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

        //mở MDIChildren FrmSetting
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

        //mở MDIChildren FrmReport
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

        //đóng Dashboard và mở FrmLogin
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

        //mở MDIChildren FrmSubMenu1
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

        private void FrmSubMenu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSubMenu1 = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //cài đặt date
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        //cài đặt panel status
        private async Task panel2Status(string status)
        {
            if(labelStatus.Text.Length >= 20)
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

        private void btnStaff_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
        
        private void slideTimer_Tick(object sender, EventArgs e)
        {
            /*flowLayoutPanel1.Left -= scrollSpeed * direction;

            int itemWidth = flowLayoutPanel1.Controls[0].Width;
            if (Math.Abs(flowLayoutPanel1.Left) >= itemWidth)
            {
                *//*slideTimer.Stop();
                isScrolling = false;*//*

                if(direction == 1)
                {
                    var first = flowLayoutPanel1.Controls[0];
                    flowLayoutPanel1.Controls.RemoveAt(0);
                    flowLayoutPanel1.Controls.Add(first);
                }
                else
                {
                    var last = flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.Count - 1];
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                    flowLayoutPanel1.Controls.Add(last);
                    flowLayoutPanel1.Controls.SetChildIndex(last, 0);
                }
                flowLayoutPanel1.Left = 0;
            }*/
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isScrolling) {
                direction = 1;
                slideTimer.Start();
                isScrolling = true;
            }
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
