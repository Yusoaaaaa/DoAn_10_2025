using Bunifu.UI.WinForms;
using DoAn.BUS;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace DoAn
{
    public partial class FrmOrder_Add : Form
    {
        private OrderService orderService;
        private InventoryService inventoryService;
        private ProductService productService;
        private Product productFound = null;
        private string _currentOrderID;
        private int _currentStock = 0;
        public Product ProductToAdd { get; private set; }
        //public Product ProductToAdd { get; private set; }
        
        public FrmOrder_Add()
        {
            
            
        }

        public FrmOrder_Add(string orderId) // Phải nhận OrderID
        {
            InitializeComponent();

            // === KHỞI TẠO CẢ 3 SERVICE ===
            productService = new ProductService();
            orderService = new OrderService();       // Thêm vào
            inventoryService = new InventoryService(); // Thêm vào

            _currentOrderID = orderId;
        }
        private void HienThiThongTInSKU_Load(object sender, EventArgs e)
        {
            SetupFormControls();
            txtOrderID.Text = _currentOrderID; // Hiển thị OrderID lên form
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // === VALIDATION (KIỂM TRA) ===

            // 1. Kiểm tra đã tìm thấy sản phẩm chưa
            if (productFound == null)
            {
                MessageBox.Show("Bạn phải tìm một sản phẩm (SKU) hợp lệ trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Kiểm tra ô nhập số lượng
            if (!int.TryParse(txtSoLuong.Text, out int soLuongMua) || soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng mua phải là một số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return;
            }

            // 3. Kiểm tra tồn kho
            if (soLuongMua > _currentStock)
            {
                MessageBox.Show($"Không đủ hàng. Số lượng tồn kho chỉ còn: {_currentStock}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return;
            }

            // 4. Kiểm tra OrderID
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Lỗi: Không có mã đơn hàng (OrderID).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // === XỬ LÝ LƯU (NẾU MỌI THỨ HỢP LỆ) ===
            try
            {
                // 1. Thêm sản phẩm vào bảng Orders
             
                orderService.AddProductToOrder(
                    txtOrderID.Text,  // Mã đơn hàng
                    productFound.SKU, // SKU
                    soLuongMua        // Số lượng mua
                );

                // 2. Cập nhật (trừ) số lượng tồn kho trong bảng Inventory
                inventoryService.UpdateStockAfterSale(productFound.SKU, soLuongMua);

                
                MessageBox.Show("Thêm sản phẩm vào đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu đơn hàng: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSKU_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void SearchAndDisplayData(int sku)
        {
            try
            {
                // 1. Lấy thông tin sản phẩm
                productFound = productService.GetBySKU(sku);

                // 2. Lấy thông tin tồn kho
                var inventory = inventoryService.GetBySKU(sku); // Giả sử InventoryService có hàm này
                _currentStock = (inventory != null) ? inventory.instock : 0;

                if (productFound != null)
                {
                    // 3. Hiển thị thông tin Product
                    txtName.Text = productFound.Name;
                    numImportCost.Text = productFound.ImportCost.ToString("N0"); // COGS
                    numPrice.Text = productFound.Price.ToString("N0");         // Giá bán
                    txtTrangThaiSanPham.Text = productFound.Status;

                    // 4. HIỂN THỊ SỐ LƯỢNG TỒN
                    lblStockInfo.Text = $"Tồn kho: {_currentStock}";

                    // Tạm thời, chúng ta sẽ cho phép Save
                    btnSave.Enabled = true;

                    //// Focus vào ô nhập số lượng
                    //txtSKU.Focus();
                }
                else
                {
                    // KHÔNG TÌM THẤY
                    MessageBox.Show($"Không tìm thấy sản phẩm có SKU là {sku}.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm SKU: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFormInfo();
            }
        }
        private void ClearFormInfo()
        {
            productFound = null; // Xóa sản phẩm đang lưu
            _currentStock = 0;     // Reset tồn kho

            txtName.Text = "";
            numImportCost.Text = "";
            numPrice.Text = "";
            txtTrangThaiSanPham.Text = "";
            //txtSoLuong.Text = "";  // Xóa ô nhập số lượng//

            btnSave.Enabled = false; // Tắt nút lưu
            txtSKU.Focus(); // Focus lại vào ô SKU
        }
        private void SetupFormControls()
        {
            // Các ô thông tin chỉ cho xem, không cho sửa
            txtName.ReadOnly = true;
            numImportCost.ReadOnly = true;
            numPrice.ReadOnly = true;

            // Tắt nút Save (chỉ bật khi tìm thấy SKU)
            btnSave.Enabled = false;
            txtOrderID.ReadOnly = true;
            // Focus vào ô SKU để người dùng nhập
            txtSKU.Focus();
        }

        private void txtSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnHienThi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                ClearFormInfo();
                return;
            }

            if (int.TryParse(txtSKU.Text.Trim(), out int skuValue))
            {
                
                SearchAndDisplayData(skuValue);
            }
            else
            {
                MessageBox.Show("SKU phải là một con số.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFormInfo();
            }
        }

        private void txtTrangThaiSanPham_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
