using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DAL.Models;

namespace DoAn.BUS
{
    public class InventoryService
    {
        StoreDBContext context = new StoreDBContext();
        public List<Inventory> GetAll()
        {
            return context.Inventories.ToList();
        }

        public Inventory GetById(int SKU)
        {
            return context.Inventories.FirstOrDefault(i => i.SKU == SKU);
        }

        public int GetStockByProductId(int SKU)
        {
            return context.Inventories
                          .Where(i => i.SKU == SKU)
                          .Select(i => i.instock)
                          .FirstOrDefault();
        }

        public void InsertUpdate(Inventory inventory)
        {
            // Implementation to insert or update an inventory record
            context.Inventories.AddOrUpdate(inventory);
            context.SaveChanges();
        }
        /// <summary>
        /// Lấy bản ghi inventory theo SKU (int Key).
        /// Đổi tên từ GetById cho rõ ràng hơn, giữ nguyên logic gốc.
        /// </summary>
        /// <param name="sku">Mã SKU kiểu int.</param>
        /// <returns>Đối tượng Inventory nếu tìm thấy, ngược lại trả về null.</returns>
        public Inventory GetBySKU(int sku) // Giữ tên hàm GetById như gốc nếu bạn muốn
        {
            try
            {
                // Sử dụng tên biến SKU từ model Inventory.cs
                return context.Inventories.FirstOrDefault(i => i.SKU == sku);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy inventory theo SKU ({sku}): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Lấy số lượng tồn kho hiện tại cho một SKU (int Key).
        /// Đổi tên từ GetStockByProductId cho rõ ràng hơn, giữ nguyên logic gốc.
        /// Trả về 0 nếu không tìm thấy SKU hoặc có lỗi.
        /// </summary>
        /// <param name="sku">Mã SKU kiểu int.</param>
        /// <returns>Số lượng tồn kho (int).</returns>
        /// 






        public List<Product> GetProductsByStockAvailability()
        {
            var productsInStock = from p in context.Products
                                  join i in context.Inventories on p.SKU equals i.SKU
                                  where i.instock > 0
                                  select p;
            return productsInStock.ToList();
        }

        public List<Product> GetProductsByOutOfStock()
        {
            var productsOutOfStock = from p in context.Products
                                     join i in context.Inventories on p.SKU equals i.SKU
                                     where i.instock == 0
                                     select p;
            return productsOutOfStock.ToList();
        }

        public List<Product> GetProductsSortedByStock(bool ascending)
        {
            return ascending ?
                (from p in context.Products
                 join i in context.Inventories on p.SKU equals i.SKU
                 orderby i.instock ascending
                 select p).ToList() :
                (from p in context.Products
                 join i in context.Inventories on p.SKU equals i.SKU
                 orderby i.instock descending
                 select p).ToList();
        }

        public void SubmitChanges()
        {
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var inventory = context.Inventories.FirstOrDefault(i => i.SKU == id);
            if (inventory != null)
            {
                context.Inventories.Remove(inventory);
                context.SaveChanges();
            }
        }

        //test




        public int GetStockBySKU(int sku)
        {
            try
            {
                // Tìm bản ghi inventory
                var inventoryRecord = context.Inventories.FirstOrDefault(i => i.SKU == sku);

                // Sử dụng tên biến instock và trả về 0 nếu không tìm thấy bản ghi
                return inventoryRecord?.instock ?? 0;

                // Cách viết dài hơn tương đương với code gốc của bạn:
                // return context.Inventories
                //               .Where(i => i.SKU == sku)
                //               .Select(i => i.instock) // Chọn cột instock
                //               .FirstOrDefault(); // Lấy giá trị đầu tiên hoặc mặc định (0 cho int)
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy số lượng tồn kho cho SKU ({sku}): " + ex.Message);
                // Xem xét ghi log chi tiết hoặc ném lại lỗi
                return 0; // Trả về 0 nếu có lỗi
            }
        }
        public void UpdateStock(int sku, int newStock)
        {
            try
            {
                var inventoryRecord = context.Inventories.FirstOrDefault(i => i.SKU == sku);
                if (inventoryRecord != null)
                {
                    inventoryRecord.instock = newStock;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy bản ghi inventory cho SKU: {sku}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật số lượng tồn kho cho SKU ({sku}): " + ex.Message);
            }
        }
    }
}