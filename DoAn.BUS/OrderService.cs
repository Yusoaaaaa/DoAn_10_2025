using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DAL.Models;
using System.Data.Entity;

namespace DoAn.BUS
{
    public class OrderService
    {
        StoreDBContext context = new StoreDBContext();
        public List<Order> GetAll()
        {
            // Implementation to retrieve all order records
            return context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            // Implementation to retrieve an order by its ID
            return context.Orders.Find(id);
        }

        public void Add(Order order)
        {
            // Implementation to add a new order record
            context.Orders.AddOrUpdate(order);
            context.SaveChanges();
        }

        public int CountOrders()
        {
            // Implementation to count total orders
            return context.Orders.Distinct().Count();
        }

        public double CalculateTotalRevenue()
        {
            ProductService productService = new ProductService();

            var result = from o in context.Orders
                         join p in context.Products on o.SKU equals p.SKU
                         select new
                         {
                             TotalPrice = o.Quantity * (p.Price == null ? 0 : p.Price)
                         };
            // Implementation to calculate total revenue from all orders

            //return result.Sum(r => (r.TotalPrice == null? 0 : r.TotalPrice));
            return result.Sum(r => (double?)r.TotalPrice) ?? 0;
        }

        public double CalculateTotalProfit()
        {
            ProductService productService = new ProductService();

            var result = from o in context.Orders
                         join p in context.Products on o.SKU equals p.SKU
                         select new
                         {
                             TotalProfit = o.Quantity * (p.Price - p.ImportCost)
                         };
            // Implementation to calculate total profit from all orders
            return result.Sum(r => (double?)r.TotalProfit) ?? 0;
        }

        public int countOrderByDate(int date)
        {
            int year = DateTime.Now.Year;
            // Implementation to count orders by specific date
            return context.Orders.Where(o => o.InvoiceDate.Month == date && o.InvoiceDate.Year == year).Distinct().Count();
        }

        public int mostOrderMonth(int month)
        {
            int year = DateTime.Now.Year;
            var result = from o in context.Orders
                         where o.InvoiceDate.Year == year && o.InvoiceDate.Month == month
                         group o by o.InvoiceDate.Month into g
                         select new
                         {
                             Month = g.Key,
                             OrderCount = g.Count()
                         };
            var mostOrders = result.OrderByDescending(r => r.OrderCount).FirstOrDefault();
            return mostOrders != null ? mostOrders.Month : 0;
        }

        public int getTop3Product(int top)
        {
            // Implementation to get top 3 products by order quantity
            int year = DateTime.Now.Year;
            var result = from o in context.Orders
                         where o.InvoiceDate.Year == year
                         group o by o.SKU into g
                         select new
                         {
                             SKU = g.Key,
                             TotalQuantity = g.Sum(o => o.Quantity)
                         };
            return result.OrderByDescending(r => r.TotalQuantity).Skip(top - 1).Take(1).Select(r => r.SKU).FirstOrDefault() != null ? result.OrderByDescending(r => r.TotalQuantity).Skip(top - 1).Take(1).Select(r => r.SKU).FirstOrDefault() : 0;
        }

        public int getTotalOrderYearByID(int id)
        {
            int year = DateTime.Now.Year;
            // Implementation to get orders by specific month
            return context.Orders.Where(o => o.InvoiceDate.Year == year && o.SKU == id).Sum(o => (int?)o.Quantity) ?? 0;
        }
        public List<Order> GetOrderItems(string orderId)
        {
            try
            {
                // Dùng .Include() để EF tự động JOIN bảng Product
                // Nó sẽ lấy thông tin Product dựa trên SKU
                return context.Orders
                               .Include(o => o.Product) // Tải kèm thông tin Product
                               .Where(o => o.OrderID == orderId)
                               .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi lay chi tiet don hang: " + ex.Message);
                return new List<Order>();
            }
        }
        //// <summary>
        /// Lấy danh sách lịch sử các sản phẩm đã bán (JOIN Orders và Products)
        /// </summary>

        /// <summary>
        /// Thêm/cập nhật sản phẩm vào một đơn hàng
        /// </summary>
        /// <param name="orderId">Mã đơn hàng (ví dụ: ORD25001)</param>
        /// <param name="sku">Mã sản phẩm (ví dụ: 1001)</param>
        /// <param name="quantity">Số lượng cần thêm</param>
        public void AddProductToOrder(string orderId, int sku, int quantity)
        {
            // 1. Validation cơ bản
            if (quantity <= 0)
            {
                throw new Exception("Số lượng phải lớn hơn 0.");
            }
            if (string.IsNullOrWhiteSpace(orderId))
            {
                throw new Exception("Mã đơn hàng không được để trống.");
            }

            try
            {
                // 2. Kiểm tra xem sản phẩm đã có trong đơn hàng này chưa
                var existingItem = context.Orders.Find(orderId, sku);

                if (existingItem != null)
                {
                    // 3a. NẾU ĐÃ CÓ: Chỉ cần cộng thêm số lượng
                    existingItem.Quantity += quantity;
                }
                else
                {
                    // 3b. NẾU CHƯA CÓ: Tạo một dòng Order (mặt hàng) mới
                    DateTime invoiceDate;
                    string invoiceStatus;

                    var otherItemInOrder = context.Orders.FirstOrDefault(o => o.OrderID == orderId);
                    if (otherItemInOrder != null)
                    {
                        // Đơn hàng đã có từ trước, lấy thông tin cũ
                        invoiceDate = otherItemInOrder.InvoiceDate;
                        invoiceStatus = otherItemInOrder.InvoiceStatus;
                    }
                    else
                    {
                        invoiceDate = DateTime.Now.Date; // Ngày hôm nay
                        invoiceStatus = "Pending"; // Trạng thái mặc định
                    }

                    // Tạo đối tượng Order mới
                    var newItem = new Order
                    {
                        OrderID = orderId,
                        SKU = sku,
                        Quantity = quantity,
                        InvoiceDate = invoiceDate,
                        InvoiceStatus = invoiceStatus
                    };

                    // Thêm vào CSDL
                    context.Orders.Add(newItem);
                }

                // 4. Lưu tất cả thay đổi vào CSDL
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Ném lỗi ra ngoài để Form (btnSave) có thể bắt được
                throw new Exception("Lỗi khi thêm sản phẩm vào đơn hàng: " + ex.Message);
            }
        }
        public List<Order> GetOrdersByDate()
        {
            DateTime today = DateTime.Now.Date;
            return context.Orders.Where(o => DbFunctions.TruncateTime(o.InvoiceDate) == today).ToList();
        }
        public List<Order> GetOrdersSortedByDate()
        {
            return context.Orders.OrderByDescending(o => o.InvoiceDate).ToList();
        }
    }
}
