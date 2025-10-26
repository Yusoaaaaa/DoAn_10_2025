using DoAn.BUS;
using DoAn.DAL.Models;
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
    public partial class FrmBanHang : Form

    {
        private InventoryService inventoryService;
        private ProductService productService;
        private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();
        private OrderService orderService;
        private List<Product> cart = new List<Product>();
        private Image placeholderImage;
        private Random _random = new Random();

        public FrmBanHang()
        {
            InitializeComponent();
            productService = new ProductService();
            orderService = new OrderService();
            inventoryService = new InventoryService();

        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            dgvProducts.AutoGenerateColumns = false;
            LoadData();
            GenerateNewOrderID();
            txtOrderID.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                dgvProducts.DataSource = null; // Xóa nguồn cũ
                dgvProducts.DataSource = cart.ToList(); // Đặt nguồn mới là giỏ hàng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerateNewOrderID()
        {
            int randomOrderId = _random.Next(100000, 1000000);
            txtOrderID.Text = randomOrderId.ToString();
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

            string currentOrderID = txtOrderID.Text;

            // === TRUYỀN OrderID VÀO FORM TRA CỨU ===
            using (HienThiThongTInSKU frmTraCuu = new HienThiThongTInSKU(currentOrderID))
            {
                if (frmTraCuu.ShowDialog() == DialogResult.OK)
                {
                    Product product = frmTraCuu.ProductToAdd;
                    cart.Add(product);
                    LoadData(); // Cập nhật lại DataGridView
                }
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        





            private void BtnThanhToan_Click(object sender, EventArgs e)
            {
                // 1. Kiểm tra giỏ hàng
                if (cart.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng đang rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Lấy thông tin chung
                string currentOrderID = txtOrderID.Text;
                DateTime currentDate = DateTime.Now;

                try
                {
                    // 3. Nhóm giỏ hàng (đếm số lượng mỗi SKU)
                    var groupedCart = cart
                        .GroupBy(product => product.SKU) // Nhóm theo SKU
                        .Select(group => new
                        {
                            SKU = group.Key,
                            Quantity = group.Count(), // Đếm số lượng
                            ProductName = group.First().Name // Lấy tên để báo lỗi
                        });

                    // 4. === KIỂM TRA TỒN KHO TRƯỚC KHI BÁN ===
                    foreach (var item in groupedCart)
                    {
                        int currentStock = inventoryService.GetStockBySKU(item.SKU);
                        if (currentStock < item.Quantity)
                        {
                            MessageBox.Show($"Không đủ hàng cho sản phẩm '{item.ProductName}' (SKU: {item.SKU}).\nChỉ còn {currentStock} sản phẩm trong kho.", "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Dừng thanh toán
                        }
                    }

                    // 5. === NẾU TỒN KHO OK, TIẾN HÀNH LƯU ===
                    foreach (var item in groupedCart)
                    {
                        // a. Tạo dòng hóa đơn
                        Order orderLine = new Order
                        {
                            OrderID = currentOrderID,
                            InvoiceDate = currentDate,
                            SKU = item.SKU,
                            Quantity = item.Quantity
                        };

                        // b. Lưu dòng hóa đơn
                        orderService.Add(orderLine);

                        // c. Trừ tồn kho (dùng số âm)
                        inventoryService.UpdateStock(item.SKU, -item.Quantity);
                    }

                    // 6. Thông báo thành công
                    double tongTien = cart.Sum(product => product.Price);
                    MessageBox.Show($"Tạo hóa đơn {currentOrderID} thành công! \nTổng tiền: {tongTien:N0} VNĐ", "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 7. Dọn dẹp
                    cart.Clear();
                    LoadData();
                    GenerateNewOrderID();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }