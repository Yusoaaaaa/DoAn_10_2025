using DoAn.DAL;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.BUS
{
    public class AccountService
    {
        private StoreDBContext context = new StoreDBContext();
        public Account GetAccount(string email, string password)
        {
            return context.Accounts.FirstOrDefault(a => a.Email == email && a.Pass == password || a.LoginName == email);
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


        //Lấy ID tài khoản  
        public int GetAccountLevel(int id)
        {
            var account = context.Accounts.FirstOrDefault(a => a.AccountID == id);
            return account != null ? account.AccStatus : -1; // Trả về -1 nếu không tìm thấy tài khoản
        }
        public string GetAccountName(int id)
        {
            var account = context.Accounts.FirstOrDefault(a => a.AccountID == id);
            return account != null ? account.Username : ""; // Trả về chuỗi rỗng nếu không tìm thấy tài khoản
        }
        public int GetAccountID(string loginName, string password)
        {
            var account = context.Accounts.FirstOrDefault(a => a.LoginName == loginName && a.Pass == password);
            return account != null ? account.AccountID : -1; // Trả về -1 nếu không tìm thấy tài khoản
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


        public bool AddAccountWithAvatar(Account newAccount, string originalFilePath)
        {
            try
            {
                // 1. XỬ LÝ LƯU HÌNH ẢNH              
                string appDirectory = System.Windows.Forms.Application.StartupPath;

                string avatarFolder = Path.Combine(appDirectory, "Avatars");

                if (!Directory.Exists(avatarFolder))
                {
                    Directory.CreateDirectory(avatarFolder);
                }

                string fileExtension = Path.GetExtension(originalFilePath);
                string newFileName = newAccount.LoginName + fileExtension;

                string destinationPath = Path.Combine(avatarFolder, newFileName);

                File.Copy(originalFilePath, destinationPath, true);


                newAccount.Avatar = Path.Combine("Avatars", newFileName);

                // THÊM: Logic phân biệt Add/Update
                if (newAccount.AccountID == 0)
                {
                    context.Accounts.Add(newAccount);
                }
                else
                {
                    context.Accounts.AddOrUpdate(newAccount);
                }

                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên hoặc lưu ảnh: " + ex.Message);
                return false;
            }
        }




        public List<Account> Search(string keyword)
        {
            using (var freshContext = new StoreDBContext())
            {
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    return freshContext.Accounts.ToList();
                }

                string searchKeyword = keyword.ToLower();
                return freshContext.Accounts
                    .Where(a => a.Username.ToLower().Contains(searchKeyword) ||
                                a.LoginName.ToLower().Contains(searchKeyword) ||
                                a.Email.ToLower().Contains(searchKeyword) ||
                                a.SDT.ToLower().Contains(searchKeyword))
                    .ToList();
            }
        }
    }
}
