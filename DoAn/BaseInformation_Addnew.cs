using Bunifu.UI.WinForms;
using DoAn.BUS;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DoAn
{
    public partial class BaseInformation_Addnew : Form
    {
        private ProductService productService;
        private InventoryService inventoryService;
        private string selectedImagePath = null;

        public BaseInformation_Addnew()
        {
            InitializeComponent();
            productService = new ProductService();
            inventoryService = new InventoryService();
        }

        // Khi form load
        private void Inven_AddEditProduct_Load(object sender, EventArgs e)
        {
            // Category: giữ danh sách có sẵn trong Designer
            ddlCategory.SelectedIndex = 0;
            ddlStatus.SelectedIndex = 0;
            LoadGenders();
            LoadSizes();
        }

        private void LoadGenders()
        {
            var genders = new List<string> { "-- Chọn Giới tính --", "Nam", "Nữ", "Unisex", "N/A" };
            ddlGender.DataSource = genders;
            ddlGender.SelectedIndex = 0;
        }

        private void LoadSizes()
        {
            var sizes = new List<string> { "-- Chọn Size --", "S", "M", "L", "XL", "FreeSize", "N/A" };
            ddlSize.DataSource = sizes;
            ddlSize.SelectedIndex = 0;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                MessageBox.Show("SKU không được để trống.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }

            if (!int.TryParse(txtSKU.Text, out int skuValue))
            {
                MessageBox.Show("SKU phải là số nguyên hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }

            if (productService.CheckSkuExists(skuValue))
            {
                MessageBox.Show($"SKU '{skuValue}' đã tồn tại.", "Trùng SKU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }

            if (ddlCategory.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlCategory.Focus();
                return false;
            }

            if (ddlGender.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlGender.Focus();
                return false;
            }

            if (ddlSize.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn kích cỡ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlSize.Focus();
                return false;
            }

            if (!decimal.TryParse(numImportCost.Text, out decimal importCostValue) || importCostValue < 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numImportCost.Focus();
                return false;
            }

            if (!decimal.TryParse(numPrice.Text, out decimal priceValue) || priceValue < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return false;
            }

            if (importCostValue > priceValue)
            {
                MessageBox.Show("Giá bán phải lớn hơn hoặc bằng giá nhập.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return false;
            }
            if (ddlStatus.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái sản phẩm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlStatus.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            if (!ValidateInput())
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                return;
            }

            try
            {
                Product product = new Product
                {
                    SKU = int.Parse(txtSKU.Text.Trim()),
                    Name = txtName.Text.Trim(),
                    Category = ddlCategory.SelectedItem.ToString(),
                    Gender = ddlGender.SelectedItem.ToString(),
                    Size = ddlSize.SelectedItem.ToString(),
                    Status = ddlStatus.SelectedItem.ToString(),
                    ImportCost = (double)decimal.Parse(numImportCost.Text.Trim()),
                    Price = (double)decimal.Parse(numPrice.Text.Trim()),
                    Illustration = selectedImagePath
                };

                bool productSuccess = productService.AddProduct(product);

                if (productSuccess)
                {
                    // Cập nhật tồn kho mặc định
                    try
                    {
                        Inventory inventory = inventoryService.GetBySKU(product.SKU) ?? new Inventory();
                        inventory.SKU = product.SKU;
                        inventoryService.InsertUpdate(inventory);
                    }
                    catch (Exception invEx)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công, nhưng lỗi khi cập nhật tồn kho: " + invEx.Message, "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Chọn ảnh sản phẩm";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedImagePath = openFileDialog.FileName;
                        pbProductImage.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi Ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        selectedImagePath = null;
                    }
                }
            }
        }
    }
}
