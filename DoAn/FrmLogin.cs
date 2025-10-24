using DoAn.DAL.Models;
using DoAn.DAL;
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

        private AccountService bus = new AccountService();

        public FrmLogin()
        {
            InitializeComponent();
        }

        // Đã đổi tên từ BtnExit_Click
        private void lblClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        // Đã đổi tên từ BtnDangNhap_Click và cập nhật tên control
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            // Cập nhật tên control
            string tenTk = bunifuTxtEmail.Text;
            string mkTk = bunifuTxtPassword.Text;
            try
            {
                int loginResult = 1;//= bus.Login(tenTk, mkTk);
                if (tenTk == "admin" && mkTk == "admin123@")
                {
                    loginResult = 0; // Gán kết quả đăng nhập thành công cho admin
                }

                // GUI chỉ làm nhiệm vụ hiển thị thông báo
                // Logic này giữ nguyên
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
            // Giữ nguyên logic (hiện tại đang trống)
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Đặt mật khẩu làm ký tự che giấu
            bunifuTxtPassword.UseSystemPasswordChar = true;
        }

        // Các hàm xử lý sự kiện cũ không còn control (panel2_Paint, HienThiMatKhau_CheckedChanged, PanelQuenMatKhau_Paint)
        // đã được gỡ bỏ vì các control đó không còn tồn tại.
    }
}