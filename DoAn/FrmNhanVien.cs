using DoAn.BUS;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private AccountService accountService; //Khai báo biến dịch vụ tài khoản
        private string _currentAvatarPath = string.Empty;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AllowUserToResizeColumns = false;
            BindGird();
            fillComboBox();
            dgvNhanVien.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvNhanVien_CellFormatting);
        }
        private void BindGird()
        {

            accountService = new AccountService();


            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.ReadOnly = true;

            dgvNhanVien.DataSource = null;

            List<Account> accounts = accountService.GetAll();

            dgvNhanVien.DataSource = accounts;
        }
        private void fillComboBox()
        {
            CmbChucVu.Items.Clear();

            CmbChucVu.Items.Add("Admin");
            CmbChucVu.Items.Add("Manager");
            CmbChucVu.Items.Add("Staff");
        }
        private void avatar_Click(object sender, EventArgs e) { }

        // Định dạng hiển thị cho cột "Chức Vụ"
        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvNhanVien.Columns[e.ColumnIndex].HeaderText == "Chức Vụ" && e.Value != null)
            {
                if (e.Value is int ChucVu)
                {
                    string chucVuText = "";
                    switch (ChucVu) { case 3: chucVuText = "Admin"; break; case 2: chucVuText = "Manager"; break; case 1: chucVuText = "Staff"; break; }
                    CmbChucVu.Text = chucVuText;
                    e.Value = chucVuText;
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];
                Account account = (Account)selectedRow.DataBoundItem;
                txtID.Text = account.AccountID.ToString();
                txtHoTen.Text = account.Username;
                txtSDT.Text = account.SDT;
                txtEmail.Text = account.Email;
                txtAcc.Text = account.LoginName;
                txtPass.Text = account.Pass;

                int ChucVu = account.AccStatus; // Lấy giá trị ChucVu từ đối tượng Account
                string chucVuText = ""; // Biến lưu trữ chuỗi chức vụ
                // Chuyển đổi giá trị ChucVu thành chuỗi tương ứng
                // 3 - Admin, 2 - Manager, 1 - Staff
                switch (ChucVu) { case 3: chucVuText = "Admin"; break; case 2: chucVuText = "Manager"; break; case 1: chucVuText = "Staff"; break; }
                CmbChucVu.Text = chucVuText;

                showAvatar(account.Avatar); // cái loz


            }
        }
        private void showAvatar(string source_Image)
        {
            try
            {
                if (string.IsNullOrEmpty(source_Image))
                {
                    avatar.Image = Properties.Resources.profile;
                }
                else
                {
                    string ImagePath = Path.Combine("Anh_dai_dien", source_Image);
                    if (File.Exists(ImagePath))
                    {
                        avatar.Image = LoadImageWithoutLocking(ImagePath);
                    }
                    else
                    {
                        avatar.Image = Properties.Resources.profile;
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
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtAcc.Text) ||
                string.IsNullOrEmpty(txtPass.Text) || CmbChucVu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var a = new Account();

            a.AccountID = string.IsNullOrEmpty(txtID.Text) ? 0 : int.Parse(txtID.Text); // Nếu txtID rỗng, gán 0 để thêm mới
            a.Username = txtHoTen.Text;
            a.SDT = txtSDT.Text;
            a.Email = txtEmail.Text;
            a.LoginName = txtAcc.Text;
            a.Pass = txtPass.Text;
            a.AccStatus = CmbChucVu.SelectedItem.ToString() == "Admin" ? 3 : CmbChucVu.SelectedItem.ToString() == "Manager" ? 2 : 1;
            a.Avatar = _currentAvatarPath;
            a.Pos = "Nhân Viên";

            string action = a.AccountID == 0 ? "thêm mới" : "cập nhật";

            AccountService accountService = new AccountService();
            accountService.InsertUpdate(a);
            BindGird();
            MessageBox.Show($"Đã {action} thông tin thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();


        }
        // Đặt hàm này trong lớp FrmNhanVien
        private void ClearInputs()
        {

            txtID.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtAcc.Clear();
            txtPass.Clear();
            CmbChucVu.SelectedIndex = -1;
            _currentAvatarPath = string.Empty;
            avatar.Image = Properties.Resources.profile;
            txtHoTen.Focus();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = dgvNhanVien.SelectedRows[0].Index;
            int accountId = 0;

            if (dgvNhanVien.Rows[selectedRowIndex].Cells[0].Value != null)
            {
                if (int.TryParse(dgvNhanVien.Rows[selectedRowIndex].Cells[0].Value.ToString(), out accountId))
                {
                    if (accountId <= 0)
                    {
                        MessageBox.Show("ID tài khoản không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (accountId == 0)
            {
                MessageBox.Show("Không tìm thấy ID tài khoản để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa tài khoản có ID {accountId} này không?",
                "Xác Nhận Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    AccountService accountService = new AccountService();
                    accountService.Delete(accountId);

                    MessageBox.Show("Xóa tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGird();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa tài khoản: {ex.Message}", "Lỗi Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = BTBValue.Text.Trim();
            AccountService accountService = new AccountService();
            List<Account> searchResults = accountService.Search(keyword);
            dgvNhanVien.DataSource = searchResults;

        }

        private void BTBValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLinkAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Tệp ảnh (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif|Tất cả tệp (*.*)|*.*";
            openFileDialog.Title = "Chọn ảnh đại diện";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Lưu đường dẫn tệp ảnh vào biến thành viên (Field)
                    _currentAvatarPath = openFileDialog.FileName;

                    // 2. Hiển thị ảnh lên PictureBox (giả sử PictureBox có tên là ptbAvatar)
                    if (avatar != null)
                    {
                        avatar.ImageLocation = _currentAvatarPath;
                        avatar.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                    MessageBox.Show("Đã chọn ảnh thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    _currentAvatarPath = string.Empty; // Xóa đường dẫn nếu có lỗi
                    MessageBox.Show($"Lỗi khi tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
