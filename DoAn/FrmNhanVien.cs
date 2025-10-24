using DoAn.BUS;
using DoAn.DAL.Models;
using DoAn.DAL;
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
    public partial class FrmNhanVien : Form
    {
        private readonly AccountService accountService = new AccountService(); //Khai báo biến dịch vụ tài khoản
        
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                var listAccount = accountService.GetAll();
                //dgvNhanVien.AllowUserToResizeColumns = false;
                BindGird(listAccount);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BindGird(List<Account> listAccount)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.Rows.Clear();
            //var accounts = accountService.GetAll();
            //dgvNhanVien.DataSource = listAccount;
            foreach (var account in listAccount)
            {
                dgvNhanVien.Rows.Add(account.AccountID, account.Username, account.SDT, account.Email, account.LoginName, account.Pass, account.Pos, account.AccStatus, account.Avatar);
            }

        }

        private void avatar_Click(object sender, EventArgs e) { }



        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvNhanVien.Rows[e.RowIndex];
                var account = (Account)selectedRow.DataBoundItem;
                txtID.Text = account.AccountID.ToString();
                txtHoTen.Text = account.Username;
                txtSDT.Text = account.SDT;
                txtEmail.Text = account.Email;
                txtAcc.Text = account.LoginName;
                txtPass.Text = account.Pass;

                int ChucVu = account.AccStatus;

                string chucVuText = "";

                switch (ChucVu)
                {
                    case 3:
                        chucVuText = "Admin";
                        break;
                    case 2:
                        chucVuText = "Manager";
                        break;
                    case 1:
                        chucVuText = "Staff";
                        break;
                }
                CmbChucVu.Text = chucVuText;

                showAvatar(account.Avatar);


            }
        }
        private void showAvatar(string source_Image)
        {
            try
            {
                if (string.IsNullOrEmpty(source_Image))
                {
                    avatar.Image = Properties.Resources.profile;
                    MessageBox.Show("1");
                }
                else
                {
                    string appPath = AppDomain.CurrentDomain.BaseDirectory;
                    string ImagePath = Path.Combine(appPath, "Avatars", source_Image);
                    if (File.Exists(ImagePath))
                    {
                        avatar.Image = LoadImageWithoutLocking(ImagePath);
                    }
                    else
                    {
                        avatar.Image = Properties.Resources.profile;
                        MessageBox.Show("2");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị ảnh: " + ex.Message);
            }
        }
        private Image LoadImageWithoutLocking(string path)
        {
            try
            {
                byte[] fileBytes = File.ReadAllBytes(path);
                using (MemoryStream ms = new MemoryStream(fileBytes))
                {
                    Image originalImage = Image.FromStream(ms);
                    Image finalImage = new Bitmap(originalImage);
                    return finalImage;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void BtnAdd_Update_Click(object sender, EventArgs e)
        {
            Account add = new Account()
            {
                AccountID = int.Parse(txtID.Text),
                Username = txtHoTen.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                LoginName = txtAcc.Text,
                Pass = txtPass.Text,
                Pos = CmbChucVu.Text,
                AccStatus = 1
            };

            accountService.InsertUpdate(add);
            BindGird(accountService.GetAll());
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            accountService.Delete(int.Parse(txtID.Text));
            BindGird(accountService.GetAll());
        }
    }
    
}
