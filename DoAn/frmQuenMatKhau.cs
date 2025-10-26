using DoAn.BUS;
using DoAn.DAL;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
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
        private readonly AccountService accountService = new AccountService();
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void txtEmail_QMK_TextChanged(object sender, EventArgs e)
        {

        }
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
                 
                {
                    
                    var account = accountService.GetByEmail(email);

                    if (account == null)
                    {
                        
                        MessageBox.Show("Email không tồn tại trong hệ thống hoặc tài khoản chưa được phê duyệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string matkhautamthoi = TaoMatKhauNgauNhien(8); // Tạo mật khẩu ngẫu nhiên mới
                    account.Pass = matkhautamthoi;
                    accountService.SaveChanges();
                    Clipboard.SetText(account.Pass);

                    MessageBox.Show(
                        "Mật khẩu tạm thời đã được tạo và cập nhật trong hệ thống.\n\n" +
                       matkhautamthoi + " đã SAO CHÉP vào clipboard.\n\n" +
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

