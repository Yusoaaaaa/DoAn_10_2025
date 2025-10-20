using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;

namespace DoAn.BUS
{
    public class AccountBUS
    {
        private AccountDAL DAL = new AccountDAL();

        public int Login (String Email , String MatKhau)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(MatKhau))
            {
                return 1; // Lỗi nhập liệu, không cần gọi DAL
            }

            var account = DAL.GetAccount(Email,MatKhau);

            if (account == null)
            {
                return 1; // Sai tài khoản hoặc mật khẩu
            }

            if (account.TRANG_THAI != 1)
            {
                return 2; // Tài khoản chưa kích hoạt
            }

            

            return 0; // Đăng nhập thành công
        }
    }
}
