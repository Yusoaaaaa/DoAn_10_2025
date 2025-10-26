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
    public partial class HienThiThongTInSKU : Form
    {
        private ProductService productService;
        private string _currentOrderID;
        
        public Product ProductToAdd { get; private set; }
        //public Product ProductToAdd { get; private set; }
        private Product productFound = null;
        public HienThiThongTInSKU()
        {
            InitializeComponent();
            productService = new ProductService();
            
        }

        public HienThiThongTInSKU(string orderId) // Phải nhận OrderID
        {
            InitializeComponent();
            productService = new ProductService();
            _currentOrderID = orderId; // Lưu OrderID lại
        }
        private void HienThiThongTInSKU_Load(object sender, EventArgs e)
        {
            SetupFormControls();
            txtOrderID.Text = _currentOrderID; // Hiển thị OrderID lên form
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(productFound == null)
            {
                MessageBox.Show("Lỗi: Không có sản phẩm nào để thêm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. Lưu sản phẩm vào biến public
            this.ProductToAdd = productFound;

            // 2. Báo cho FrmBanHang biết là đã "OK"
            this.DialogResult = DialogResult.OK;
            this.Close();
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
        private void SearchAndDisplaySKU(int sku)
        {
            try
            {
                
                productFound = productService.GetBySKU(sku);

                if (productFound != null)
                {
                    // TÌM THẤY: Đổ dữ liệu vào các ô
                    txtName.Text = productFound.Name;
                    numImportCost.Text = productFound.ImportCost.ToString("N0");
                    numPrice.Text = productFound.Price.ToString("N0");
                    txtLoaiSanPham.Text = productFound.Category;
                    txtTrangThaiSanPham.Text = productFound.Status;

                    btnSave.Enabled = true;
                    // (Bạn có thể thêm 1 ô NumericUpDown để nhập số lượng ở đây)
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
            txtName.Text = "";
            numImportCost.Text = "";
            numPrice.Text = "";
            // (Xóa các ô khác...)

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
                // Gọi hàm tìm kiếm và hiển thị
                SearchAndDisplaySKU(skuValue);
            }
            else
            {
                MessageBox.Show("SKU phải là một con số.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFormInfo();
            }
            


        }
    }
}
