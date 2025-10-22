using DoAn.model;
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

namespace DoAn
{
    public partial class FrmLogin : Form
    {

        private AccountBUS bus = new AccountBUS();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?","Thông Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTk = TxtTK_DangNhap.Text;
            string mkTk = TxtMatKhau_DangNhap.Text;
            try
            {
                int loginResult = bus.Login(tenTk, mkTk);

                // GUI chỉ làm nhiệm vụ hiển thị thông báo
                switch (loginResult)
                {
                    case 0: // Thành công
                        MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // ... (Mở Form Main) ...
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
    }
}
