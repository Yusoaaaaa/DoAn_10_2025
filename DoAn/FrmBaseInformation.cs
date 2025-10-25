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
using DoAn.BUS;
using DoAn.DAL.Models;

namespace DoAn
{
    public partial class BaseInformation : Form
    {
        private ProductService productService;
        private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();
        private Image placeholderImage;

        public BaseInformation()
        {
            InitializeComponent();
            productService = new ProductService();
        }

        private void BaseInformation_Load(object sender, EventArgs e)
        {
            // Tạo một ảnh placeholder đơn giản
            placeholderImage = new Bitmap(60, 60);
            using (Graphics g = Graphics.FromImage(placeholderImage))
            {
                g.Clear(Color.Gainsboro);
            }

            // Thiết lập AutoGenerateColumns = false
            // Điều này RẤT QUAN TRỌNG, để grid sử dụng các cột ta định nghĩa trong Designer
            dgvProducts.AutoGenerateColumns = false;

            // Tải dữ liệu
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var allProducts = productService.GetAll();
                // Gán nguồn dữ liệu
                dgvProducts.DataSource = allProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tải ảnh vào cột Ảnh
        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chỉ xử lý cột 'colImage'
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colImage" && e.RowIndex >= 0)
            {
                // Lấy đối tượng Product từ dòng hiện tại
                var product = dgvProducts.Rows[e.RowIndex].DataBoundItem as Product;
                if (product == null) return;

                string imagePath = product.Illustration;

                // Nếu đường dẫn trống hoặc file không tồn tại, dùng ảnh placeholder
                if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                {
                    e.Value = placeholderImage;
                    return;
                }

                // Tối ưu: Kiểm tra xem ảnh đã có trong cache chưa
                if (imageCache.ContainsKey(imagePath))
                {
                    e.Value = imageCache[imagePath];
                }
                else
                {
                    try
                    {
                        // Tải ảnh từ file
                        // Đọc file vào MemoryStream để tránh bị khóa file (lock)
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                fs.CopyTo(ms);
                                Image img = Image.FromStream(ms);

                                // Thêm vào cache và gán cho cell
                                imageCache[imagePath] = img;
                                e.Value = img;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        e.Value = placeholderImage;
                    }
                }
            }
        }


        // Xử lý nút Thêm
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            using (BaseInformation_Addnew frmAdd = new BaseInformation_Addnew())
            {
                if (frmAdd.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu click vào header
            if (e.RowIndex < 0) return;

            // Lấy SKU từ dòng được click Đảm bảo rằng cột colSKU tồn tại và có giá trị
            if (dgvProducts.Rows[e.RowIndex].Cells["colSKU"].Value == null) return;

            int sku = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["colSKU"].Value);

            // 1. XỬ LÝ NÚT SỬA 
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colEdit")
            {
                try
                {
                    Product productToEdit = productService.GetBySKU(sku); // Lấy đối tượng Product đầy đủ từ BUS
                    if (productToEdit == null)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData(); // Tải lại grid phòng trường hợp dữ liệu cũ
                        return;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở form sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // 2. XỬ LÝ NÚT XÓA 
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colDelete")
            {
                try
                {
                    string productName = dgvProducts.Rows[e.RowIndex].Cells["colName"].Value.ToString();
                    var dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm '{productName}' (SKU: {sku}) không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool success = productService.DeleteProduct(sku);
                        if (success)
                        {
                            //MessageBox.Show("Xóa sản phẩm thành công!");
                            LoadData(); // Tải lại dữ liệu
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Xử lý tìm kiếm
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            // Chỉ tìm kiếm khi nhấn Enter
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string searchTerm = txtSearch.Text.ToLower().Trim();
                    var allProducts = productService.GetAll();

                    if (string.IsNullOrWhiteSpace(searchTerm))
                    {
                        // Nếu ô tìm kiếm trống, tải lại tất cả
                        dgvProducts.DataSource = allProducts;
                    }
                    else
                    {
                        // Lọc theo Tên hoặc SKU
                        var filteredList = allProducts.Where(p =>
                            p.Name.ToLower().Contains(searchTerm) ||
                            p.SKU.ToString().Contains(searchTerm)
                        ).ToList();

                        dgvProducts.DataSource = filteredList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm này không dùng nhưng Bunifu Tooltip cần
        private void bunifuToolTip1_Popup(object sender, Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs e)
        {

        }

        //Thêm form nhỏ cho filter theo Category và gender
        public class FilterDialog : Form
        {
            public string SelectedCategory { get; private set; }
            public string SelectedGender { get; private set; }

            private ComboBox cboCategory;
            private ComboBox cboGender;
            private Button btnOK;
            private Button btnCancel;

            public FilterDialog(IEnumerable<string> categories, IEnumerable<string> genders)
            {
                Text = "Filter sản phẩm";
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                Width = 350;
                Height = 220;
                Font = new Font("Segoe UI", 9F);

                Label lblCategory = new Label { Text = "Loại sản phẩm:", Left = 20, Top = 20, Width = 100 };
                Label lblGender = new Label { Text = "Giới tính:", Left = 20, Top = 70, Width = 100 };

                cboCategory = new ComboBox { Left = 130, Top = 18, Width = 180, DropDownStyle = ComboBoxStyle.DropDownList };
                cboCategory.Items.Add("Tất cả");
                cboCategory.Items.AddRange(categories.Distinct().ToArray());
                cboCategory.SelectedIndex = 0;

                cboGender = new ComboBox { Left = 130, Top = 68, Width = 180, DropDownStyle = ComboBoxStyle.DropDownList };
                cboGender.Items.Add("Tất cả");
                cboGender.Items.AddRange(genders.Distinct().ToArray());
                cboGender.SelectedIndex = 0;

                btnOK = new Button { Text = "Áp dụng", Left = 130, Width = 80, Top = 120, DialogResult = DialogResult.OK };
                btnCancel = new Button { Text = "Hủy", Left = 230, Width = 80, Top = 120, DialogResult = DialogResult.Cancel };

                Controls.Add(lblCategory);
                Controls.Add(lblGender);
                Controls.Add(cboCategory);
                Controls.Add(cboGender);
                Controls.Add(btnOK);
                Controls.Add(btnCancel);

                AcceptButton = btnOK;
                CancelButton = btnCancel;
            }

            protected override void OnFormClosing(FormClosingEventArgs e)
            {
                if (DialogResult == DialogResult.OK)
                {
                    SelectedCategory = cboCategory.SelectedItem?.ToString() ?? "Tất cả";
                    SelectedGender = cboGender.SelectedItem?.ToString() ?? "Tất cả";
                }
                base.OnFormClosing(e);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                var allProducts = productService.GetAll();
                var categories = allProducts.Select(p => p.Category).Where(c => !string.IsNullOrEmpty(c));
                var genders = allProducts.Select(p => p.Gender).Where(g => !string.IsNullOrEmpty(g));

                using (var dialog = new FilterDialog(categories, genders))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedCategory = dialog.SelectedCategory;
                        string selectedGender = dialog.SelectedGender;

                        var filtered = allProducts.AsQueryable();

                        if (selectedCategory != "Tất cả")
                            filtered = filtered.Where(p => p.Category == selectedCategory);

                        if (selectedGender != "Tất cả")
                            filtered = filtered.Where(p => p.Gender == selectedGender);

                        dgvProducts.DataSource = filtered.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.ToLower().Trim();
                var allProducts = productService.GetAll();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    dgvProducts.DataSource = allProducts;
                }
                else
                {
                    var filteredList = allProducts.Where(p =>
                        // SKU
                        p.SKU.ToString().Contains(searchTerm)
                        ||
                        // Tên sản phẩm
                        (!string.IsNullOrEmpty(p.Name) && p.Name.ToLower().Contains(searchTerm))
                        ||
                        // Giá nhập
                        p.ImportCost.ToString("N0").Replace(",", "").Contains(searchTerm)
                        ||
                        // Giá bán
                        p.Price.ToString("N0").Replace(",", "").Contains(searchTerm)
                    ).ToList();

                    dgvProducts.DataSource = filteredList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu click vào header
            if (e.RowIndex < 0) return;

            // 1. Lấy SKU từ dòng được double-click
            var cellValue = dgvProducts.Rows[e.RowIndex].Cells["colSKU"].Value;
            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int sku)) return;

            try
            {
                // 2. Lấy đối tượng Product đầy đủ từ BUS
                Product productToEdit = productService.GetBySKU(sku);

                if (productToEdit == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadData();
                    return;
                }

                // 3. Khởi tạo Form sửa với tham số Product
                using (BaseInformation_Edit frmEdit = new BaseInformation_Edit(productToEdit))
                {
                    if (frmEdit.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}