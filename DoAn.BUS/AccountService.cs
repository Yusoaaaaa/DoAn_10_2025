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
        StoreDBContext context = new StoreDBContext();
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
            
            var account = GetAccount(Email,MatKhau); // Gọi DAL để lấy thông tin tài khoản

            if (account == null)
            {
                return 1; // Sai tài khoản hoặc mật khẩu
            }

            return 0; // Đăng nhập thành công
        }

        public List<Account> GetAll() //Lấy tất cả tài khoản
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
