using Bunifu.UI.WinForms; 
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
    public partial class BaseInformation : Form
    {
        private ProductService productService;
        private InventoryService inventoryService;
        private Product productToEdit;
        private bool isEditMode = false;
        private string selectedImagePath = null;

        // Constructor cho THÊM MỚI
        public BaseInformation()
        {
            InitializeComponent();
            productService = new ProductService();
            inventoryService = new InventoryService();
            isEditMode = false;
            SetupFormForAdd();
        }

        // Constructor cho SỬA
        public BaseInformation(Product product)
        {
            InitializeComponent();
            productService = new ProductService();
            inventoryService = new InventoryService();
            productToEdit = product;
            isEditMode = true;
            SetupFormForEdit();
            LoadProductData();
        }

        private void Inven_AddEditProduct_Load(object sender, EventArgs e)
        {
            // Load danh sách cho các Dropdown
            LoadCategories();
            LoadGenders(); // *** HÀM MỚI ***
            LoadSizes();   // *** HÀM MỚI ***
        }

        private void SetupFormForAdd()
        {
            lblTitle.Text = "Add New Product";
            txtSKU.ReadOnly = false;
           
        }

        private void SetupFormForEdit()
        {
            lblTitle.Text = "Edit Product";
            if (productToEdit != null)
            {
                txtSKU.ReadOnly = true; // SKU là khóa chính, không cho sửa
            }
            else
            {
                MessageBox.Show("Lỗi: Không có dữ liệu sản phẩm để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void LoadCategories()
        {
            try
            {
                List<string> categories = productService.GetAllCategories();
                categories.Insert(0, "-- Chọn Loại SP --");
                ddlCategory.DataSource = categories;
                ddlCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void LoadProductData()
        {
            if (productToEdit != null)
            {
                // Sử dụng đúng tên thuộc tính từ Product.cs
                txtName.Text = productToEdit.Name;
                txtSKU.Text = productToEdit.SKU.ToString();

                // Load Category
                if (!string.IsNullOrEmpty(productToEdit.Category) && ddlCategory.Items.Contains(productToEdit.Category))
                {
                    ddlCategory.SelectedItem = productToEdit.Category;
                }
                else
                {
                    ddlCategory.SelectedIndex = 0;
                }

                // *** THÊM CODE: Load Gender ***
                if (!string.IsNullOrEmpty(productToEdit.Gender) && ddlGender.Items.Contains(productToEdit.Gender))
                {
                    ddlGender.SelectedItem = productToEdit.Gender;
                }
                else
                {
                    ddlGender.SelectedIndex = 0;
                }

                // *** THÊM CODE: Load Size ***
                if (!string.IsNullOrEmpty(productToEdit.Size) && ddlSize.Items.Contains(productToEdit.Size))
                {
                    ddlSize.SelectedItem = productToEdit.Size;
                }
                else
                {
                    ddlSize.SelectedIndex = 0;
                }

                // Lấy số lượng tồn kho từ InventoryService
                try
                {
                    numStock.Value = inventoryService.GetStockBySKU(productToEdit.SKU);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy số lượng tồn kho cho SKU {productToEdit.SKU}: " + ex.Message, "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numStock.Value = 0;
                }

                // Price và ImportCost là double
                numPrice.Value = (decimal)productToEdit.Price;
                numImportCost.Value = (decimal)productToEdit.ImportCost; // *** THÊM CODE ***

                // Load ảnh
                selectedImagePath = productToEdit.Illustration;
                if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                {
                    try
                    {
                        pbProductImage.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh sản phẩm: " + ex.Message, "Lỗi Ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // pbProductImage.Image = Properties.Resources.placeholder_image; 
                        selectedImagePath = null;
                    }
                }
                else
                {
                    // pbProductImage.Image = Properties.Resources.placeholder_image;
                    selectedImagePath = null;
                }
            }
        }

        private bool ValidateInput()
        {
            // Kiểm tra Tên
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            // Kiểm tra SKU (int)
            if (string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                MessageBox.Show("SKU không được để trống.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }
            if (!int.TryParse(txtSKU.Text, out int skuValue))
            {
                MessageBox.Show("SKU phải là một số nguyên.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }
            if (!isEditMode && productService.CheckSkuExists(skuValue))
            {
                MessageBox.Show($"SKU '{skuValue}' đã tồn tại.", "Trùng SKU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }
            // Kiểm tra Category
            if (ddlCategory.SelectedIndex <= 0) // Giả sử item 0 là "-- Select Category --"
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlCategory.Focus();
                return false;
            }

            // *** THÊM CODE: Kiểm tra Gender ***
            if (ddlGender.SelectedIndex <= 0) // Giả sử item 0 là "-- Select Gender --"
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlGender.Focus();
                return false;
            }

            // *** THÊM CODE: Kiểm tra Size ***
            if (ddlSize.SelectedIndex <= 0) // Giả sử item 0 là "-- Select Size --"
            {
                MessageBox.Show("Vui lòng chọn kích cỡ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlSize.Focus();
                return false;
            }

            // Kiểm tra Số lượng
            if (numStock.Value < 0)
            {
                MessageBox.Show("Số lượng không thể là số âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numStock.Focus();
                return false;
            }

            // *** THÊM CODE: Kiểm tra Giá nhập ***
            if (numImportCost.Value < 0)
            {
                MessageBox.Show("Giá nhập không thể là số âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numImportCost.Focus();
                return false;
            }

            // Kiểm tra Giá bán
            if (numPrice.Value < 0)
            {
                MessageBox.Show("Giá bán không thể là số âm.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return false;
            }

            // *** THÊM CODE: Kiểm tra Giá nhập < Giá bán (Nếu cần) ***
            if (numImportCost.Value > numPrice.Value)
            {
                MessageBox.Show("Giá bán phải lớn hơn hoặc bằng giá nhập.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPrice.Focus();
                return false;
            }

            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                Product product = isEditMode ? productToEdit : new Product();

                // Cập nhật thông tin Product từ controls
                product.Name = txtName.Text.Trim(); // [Required]
                product.Category = ddlCategory.SelectedItem.ToString(); // [Required]
                product.Price = (double)numPrice.Value;
                product.Illustration = selectedImagePath; // [StringLength(255)]

                // *** THÊM CODE: Lấy dữ liệu cho các trường mới ***
                product.Gender = ddlGender.SelectedItem.ToString(); // [Required]
                product.Size = ddlSize.SelectedItem.ToString(); // [Required]
                product.ImportCost = (double)numImportCost.Value;

                // Chỉ gán SKU khi thêm mới
                if (!isEditMode)
                {
                    product.SKU = int.Parse(txtSKU.Text.Trim()); // [Key]
                }

                // *** XÓA CODE: Xóa các giá trị mặc định đã thêm trước đó ***
                // if (!isEditMode)
                // {
                //     product.Gender = "N/A"; 
                //     product.Size = "N/A";   
                //     product.ImportCost = 0; 
                // }

                // 3. Gọi ProductService để lưu Product
                bool productSuccess;
                if (isEditMode)
                {
                    productSuccess = productService.UpdateProduct(product);
                }
                else
                {
                    productSuccess = productService.AddProduct(product);
                }

                // 4. Nếu lưu Product thành công, cập nhật Inventory
                if (productSuccess)
                {
                    try
                    {
                        Inventory inventory = inventoryService.GetBySKU(product.SKU) ?? new Inventory();
                        inventory.SKU = product.SKU;
                        inventory.instock = (int)numStock.Value;
                        //inventory.last_updated = DateTime.Now; // Cập nhật thời gian cho Inventory

                        inventoryService.InsertUpdate(inventory);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception invEx)
                    {
                        MessageBox.Show("Lưu thông tin sản phẩm thành công, nhưng lỗi khi cập nhật tồn kho: " + invEx.Message, "Lỗi Tồn Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(isEditMode ? "Cập nhật sản phẩm thất bại!" : "Thêm sản phẩm thất bại!", "Lỗi Lưu Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu sản phẩm: " + ex.Message, "Lỗi Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
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
                        // pbProductImage.Image = Properties.Resources.placeholder_image; 
                    }
                }
            }
        }
    }
}