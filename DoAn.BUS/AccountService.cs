using DoAn.DAL;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class AccountService
    {
        private StoreDBContext context = new StoreDBContext();
        public Account GetAccount(string email, string password)
        {
                return context.Accounts.FirstOrDefault(a => a.Email == email && a.Pass == password);
        }
        public int Login (String Email , String MatKhau)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(MatKhau))
            {
                return 1; // Lỗi nhập liệu, không cần gọi DAL
            }

            var account = GetAccount(Email,MatKhau);

            if (account == null)
            {
                return 1; // Sai tài khoản hoặc mật khẩu
            }

            if (account.AccStatus != 1)
            {
                return 2; // Tài khoản chưa kích hoạt
            }

            return 0; // Đăng nhập thành công
        }

        public int GetRole(string email, string password)
        {
            var account = GetAccount(email, password);
            if (account != null)
            {
                return account.AccStatus;
            }
            return -1; // Trả về -1 nếu không tìm thấy tài khoản
        }

        public List<Account> GetAll()
        {
            return context.Accounts.ToList();
        }

        public void InsertUpdate(Account account)
        {
            context.Accounts.AddOrUpdate(account);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var account = context.Accounts.Find(id);
            if (account != null)
            {
                context.Accounts.Remove(account);
                context.SaveChanges();
            }
        }
    }
}
