using DoAn.DAL;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAn
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void txtEmail_QMK_TextChanged(object sender, EventArgs e)
        {

        }
        // Hàm này tạo một chuỗi ngẫu nhiên với độ dài cho trước
        public string TaoMatKhauNgauNhien(int doDai)
        {
            const string kyTuChoPhep = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; // Các ký tự được phép sử dụng trong mật khẩu

            StringBuilder matKhau = new StringBuilder(); // Sử dụng StringBuilder để xây dựng mật khẩu

            Random random = new Random();

            for (int i = 0; i < doDai; i++)
            {
            
                int viTri = random.Next(0, kyTuChoPhep.Length);

                matKhau.Append(kyTuChoPhep[viTri]);
            }

            return matKhau.ToString();
        }
        private void btnLayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmail_QMK.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email của bạn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var dbContext = new StoreDBContext()) 
                {
                    
                    var account = dbContext.Accounts.FirstOrDefault(a => a.Email == email && a.AccStatus == 1);

                    if (account == null)
                    {
                        
                        MessageBox.Show("Email không tồn tại trong hệ thống hoặc tài khoản chưa được phê duyệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string matKhauTamThoi = TaoMatKhauNgauNhien(8);

                    account.Pass = matKhauTamThoi;

                    dbContext.SaveChanges();

                    Clipboard.SetText(matKhauTamThoi);

                    MessageBox.Show(
                        "Mật khẩu tạm thời đã được tạo và cập nhật trong hệ thống.\n\n" +
                        matKhauTamThoi + " đã SAO CHÉP vào clipboard.\n\n" +
                        "Vui lòng đăng nhập và thay đổi mật khẩu sau.",
                        "Thành Công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối hoặc cập nhật database: {ex.Message}", "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

