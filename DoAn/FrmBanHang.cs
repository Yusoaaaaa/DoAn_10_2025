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
using Microsoft.VisualBasic;

namespace DoAn
{
    public partial class FrmBanHang : Form
    {


        private ProductService productService;
        private OrderService orderService;
        private Dictionary<string, Image> imageCache = new Dictionary<string, Image>();
        private string _currentOrderID;
        private Image placeholderImage;
        //private List<OrderDetailViewModel> orderHistoryList;


        public FrmBanHang()
        {
            InitializeComponent();


        }



        private void FrmBanHang_Load(object sender, EventArgs e)
        {

            dgvProducts.AutoGenerateColumns = false;
            LoadData();

        }

        // Tải dữ liệu lên DataGridView
        private void LoadData()
        {
            orderService = new OrderService();
            productService = new ProductService();
            List<Order> ListOrrder = orderService.GetAll(); // Lấy danh sách đơn hàng từ CSDL
            dgvProducts.Rows.Clear();
            foreach (Order item in ListOrrder)
            {
                Product product = productService.GetById(item.SKU);
                if (product != null)
                {
                    dgvProducts.Rows.Add(
                        item.OrderID,
                        item.SKU,
                        product.Name,
                        product.ImportCost,
                        item.InvoiceStatus,
                        product.Price,
                        item.Quantity,
                        item.InvoiceDate.ToString("dd/MM/yyyy")
                    );
                }
            }
            dgvProducts.ClearSelection();
        }




        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }


        // Lọc 
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy danh sách Tình Trạng (Status) TỪ CÁC HÀNG
                var statuses = dgvProducts.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow && r.Cells[4].Value != null) // Lấy từ Cell 4
                    .Select(r => r.Cells[4].Value.ToString())
                    .Where(s => !string.IsNullOrEmpty(s))
                    .Distinct();

                if (!statuses.Any())
                {
                    MessageBox.Show("Chưa có dữ liệu để lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2. Mở Dialog (Code này của bạn đã đúng)
                using (var dialog = new FilterDialog(statuses))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedStatus = dialog.SelectedStatus;

                        dgvProducts.SuspendLayout(); // Tạm dừng vẽ

                        // 3. Lọc trên các hàng (Rows)
                        foreach (DataGridViewRow row in dgvProducts.Rows)
                        {
                            if (row.IsNewRow) continue;

                            if (selectedStatus == "Tất cả")
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                string rowStatus = row.Cells[4].Value?.ToString() ?? "";
                                row.Visible = (rowStatus == selectedStatus);
                            }
                        }

                        dgvProducts.ResumeLayout(); // Vẽ lại
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Các hàm rỗng (cần cho designer)
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void bunifuToolTip1_Popup(object sender, Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.ToLower().Trim();

                // Ẩn tất cả các hàng trước khi lọc
                dgvProducts.SuspendLayout(); // Tạm dừng việc vẽ DataGridView để tăng tốc

                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua hàng mới (nếu có)

                    // 1. Nếu ô tìm kiếm trống -> Hiển thị tất cả
                    if (string.IsNullOrWhiteSpace(searchTerm))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        // 2. Lấy giá trị từ các Ô (Cells)
                        string orderID = row.Cells[0].Value?.ToString()?.ToLower() ?? "";
                        string sku = row.Cells[1].Value?.ToString() ?? "";
                        string tenSP = row.Cells[2].Value?.ToString()?.ToLower() ?? "";
                        string giaNhap = row.Cells[3].Value?.ToString()?.Replace(",", "") ?? "";
                        string giaBan = row.Cells[5].Value?.ToString()?.Replace(",", "") ?? "";
                        string soLuong = row.Cells[6].Value?.ToString() ?? "";
                        string tinhTrang = row.Cells[4].Value?.ToString()?.ToLower() ?? "";

                        // 3. So sánh và quyết định ẩn/hiện
                        bool isMatch = orderID.Contains(searchTerm) ||
                                       sku.Contains(searchTerm) ||
                                       tenSP.Contains(searchTerm) ||
                                       giaNhap.Contains(searchTerm) ||
                                       giaBan.Contains(searchTerm) ||
                                       soLuong.Contains(searchTerm) ||
                                       tinhTrang.Contains(searchTerm);

                        row.Visible = isMatch;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvProducts.ResumeLayout(); // Vẽ lại DataGridView
            }
        }



        // Đặt lớp này bên trong FrmBanHang.cs, ở dưới cùng
        public class FilterDialog : Form
        {
            public string SelectedStatus { get; private set; }
            private ComboBox cboStatus;
            private Button btnOK;
            private Button btnCancel;

            // Constructor mới: Chỉ nhận vào danh sách Tình Trạng (statuses)
            public FilterDialog(IEnumerable<string> statuses)
            {
                Text = "Lọc theo Tình Trạng";
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                Width = 350;
                Height = 180;
                Font = new Font("Segoe UI", 9F);

                Label lblStatus = new Label { Text = "Tình trạng đơn hàng:", Left = 20, Top = 20, Width = 110 };

                cboStatus = new ComboBox { Left = 130, Top = 18, Width = 180, DropDownStyle = ComboBoxStyle.DropDownList };
                cboStatus.Items.Add("Tất cả");
                cboStatus.Items.AddRange(statuses.Distinct().ToArray()); // Nạp các trạng thái
                cboStatus.SelectedIndex = 0;

                // Di chuyển nút lên cao hơn
                btnOK = new Button { Text = "Áp dụng", Left = 130, Width = 80, Top = 80, DialogResult = DialogResult.OK };
                btnCancel = new Button { Text = "Hủy", Left = 230, Width = 80, Top = 80, DialogResult = DialogResult.Cancel };

                Controls.Add(lblStatus);
                Controls.Add(cboStatus);
                Controls.Add(btnOK);
                Controls.Add(btnCancel);

                AcceptButton = btnOK;
                CancelButton = btnCancel;
            }

            // Cập nhật hàm OnFormClosing
            protected override void OnFormClosing(FormClosingEventArgs e)
            {
                if (DialogResult == DialogResult.OK)
                {
                    // Chỉ lấy Tình Trạng (Status)
                    SelectedStatus = cboStatus.SelectedItem?.ToString() ?? "Tất cả";
                }
                base.OnFormClosing(e);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string orderIdToAddTo = "";

            // === KỊCH BẢN 1: Người dùng ĐÃ CHỌN một đơn hàng ===
            if (dgvProducts.SelectedRows.Count > 0)
            {
                // Lấy giá trị từ Cell[0] (cột OrderID) của hàng đang chọn
                orderIdToAddTo = dgvProducts.SelectedRows[0].Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(orderIdToAddTo))
                {
                    // Mở form FrmOrder_Add ngay lập tức
                    OpenAddProductForm(orderIdToAddTo);
                }
            }
            else
            {
                DialogResult choice = MessageBox.Show(
                    "Bạn chưa chọn đơn hàng.\n\n" +
                    "  [Yes] = Tạo một Đơn Hàng Mới (tự động).\n" +
                    "  [No]  = Tự nhập mã Đơn Hàng Cũ.\n",
                    "Tạo Đơn Hàng Mới?",
                    MessageBoxButtons.YesNoCancel, // Yes = Tạo mới, No = Tự nhập, Cancel = Hủy
                    MessageBoxIcon.Question
                );

                if (choice == DialogResult.Yes)
                {


                    // Ví dụ: ORD251026223630
                    orderIdToAddTo = $"ORD{DateTime.Now:dd}";

                    // Mở form
                    OpenAddProductForm(orderIdToAddTo);
                }
                else if (choice == DialogResult.No)
                {
                    // --- TỰ NHẬP OrderID (Logic cũ) ---
                    string input = Interaction.InputBox(
                        "Nhập mã đơn hàng bạn muốn thêm vào:",
                        "Thêm vào Đơn Hàng Cũ",
                        "" // Giá trị mặc định
                    );

                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        orderIdToAddTo = input.Trim().ToUpper();
                        OpenAddProductForm(orderIdToAddTo);
                    }
                    // Nếu input trống, người dùng đã nhấn Cancel (không làm gì cả)
                }
            }
        }
        /// <summary>
        /// Hàm trợ giúp để mở FrmOrder_Add với một OrderID cụ thể
        /// </summary>
        private void OpenAddProductForm(string orderId)
        {
            // Kiểm tra xem OrderID có hợp lệ không
            if (string.IsNullOrWhiteSpace(orderId))
            {
                MessageBox.Show("Mã đơn hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Mở form thêm chi tiết
                FrmOrder_Add frmAdd = new FrmOrder_Add(orderId);
                var result = frmAdd.ShowDialog(); // Hiển thị form

                // Nếu người dùng nhấn Save (OK) trên FrmOrder_Add
                if (result == DialogResult.OK)
                {
                    // Tải lại DataGridView để thấy sản phẩm mới
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts.ClearSelection();
        }
    }
}