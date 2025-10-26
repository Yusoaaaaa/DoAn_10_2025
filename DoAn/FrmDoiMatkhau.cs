using DoAn.BUS;
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
    public partial class FrmDoiMatkhau : Form
    {
        AccountService accountService = new AccountService();
        private string _currentLoginName = "";
        public FrmDoiMatkhau()
        {
            InitializeComponent();
        }

        private void FrmDoiMatkhau_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.Focus();

            txtMatKhauCu.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;
        }

        private void HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(HienThiMatKhau.Checked)
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtXacNhanMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtXacNhanMK.UseSystemPasswordChar = true;
            }
        }

        // Trong FrmDoiMatkhau.cs
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên đăng nhập đã được truyền chưa
            string login = txtEmail.Text.Trim();

            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMK.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(matKhauCu) ||
                string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập/Email, Mật khẩu cũ và Mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matKhauMoi == matKhauCu)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int result = accountService.ChangePassword(login, matKhauCu, matKhauMoi);

                switch (result)
                {
                    case 0: // Thành công
                        MessageBox.Show("Đổi mật khẩu thành công! Bạn cần đăng nhập lại với mật khẩu mới.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        break;
                    case 1: // Mật khẩu cũ sai
                        MessageBox.Show("Mật khẩu cũ không đúng! Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2: // Không tìm thấy tài khoản
                        MessageBox.Show("Tên đăng nhập/Email không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống khi đổi mật khẩu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
