using DoAn.BUS;
using DoAn.DAL;
using DoAn.DAL.Models;
using Newtonsoft.Json.Linq;
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
    public partial class FrmLogin : Form
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];

        private AccountService bus = new AccountService();

        //biến vị trí chuột dùng di chuyển form
        public Point mouseLocation;

        public FrmLogin()
        {
            InitializeComponent();
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            for(int i = 0; i < 24; i++)
            {
                location[i] = Path.Combine(parentDirectory, "Resources", "textbox_user_" + (i+1).ToString() + ".jpg");
            }
            tounage();
        }

        private void tounage()
        {
            for(int i = 0; i < 24; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?","Thông Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTk = TxtTK_DangNhap.Text;
            string mkTk = TxtMatKhau_DangNhap.Text;
            try
            {
                int loginResult = 1;//= bus.Login(tenTk, mkTk);
                if(tenTk == "admin" && mkTk == "admin123@")
                    {
                    loginResult = 0; // Gán kết quả đăng nhập thành công cho admin
                }

                // GUI chỉ làm nhiệm vụ hiển thị thông báo
                switch (loginResult)
                {
                    case 0: // Thành công
                        MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // ... (Mở Form Main) ...
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case 1: 
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2: 
                        MessageBox.Show("Tài khoản của bạn đang chờ Admin phê duyệt.", "Tài Khoản Chưa Kích Hoạt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lLForgetPassWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtMatKhau_DangNhap.UseSystemPasswordChar = true;
        }

        private void HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(HienThiMatKhau.Checked)
            {
                TxtMatKhau_DangNhap.UseSystemPasswordChar = false;
            }
            else
            {
                TxtMatKhau_DangNhap.UseSystemPasswordChar = true;
            }
        }

        private void PanelQuenMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtTK_DangNhap_TextChanged(object sender, EventArgs e)
        {
            if(TxtTK_DangNhap.Text.Length > 0 && TxtTK_DangNhap.Text.Length <= 22)
            {
                pictureBox1.Image = images[TxtTK_DangNhap.Text.Length - 1];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if(TxtTK_DangNhap.Text.Length == 0)
            {
                pictureBox1.Image = Properties.Resources.debut;
            }
            else
            {
                pictureBox1.Image = images[23];
            }
        }

        private void TxtMatKhau_DangNhap_Click(object sender, EventArgs e)
        {
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            Bitmap bmpass = new Bitmap(Path.Combine(parentDirectory, "Resources", "textbox_password.png"));
            pictureBox1.Image = bmpass;
        }

        private void TxtTK_DangNhap_Click(object sender, EventArgs e)
        {
            if(TxtTK_DangNhap.Text.Length > 0)
            {
                pictureBox1.Image = images[TxtTK_DangNhap.Text.Length - 1];
            }
            else
            {
                pictureBox1.Image = Properties.Resources.debut;
            }
        }

        private void TxtMatKhau_DangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtTK_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtTK_DangNhap_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                Bitmap bmpass = new Bitmap(Path.Combine(parentDirectory, "Resources", "textbox_password.png"));
                pictureBox1.Image = bmpass;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePose;
            }
        }
    }
}
