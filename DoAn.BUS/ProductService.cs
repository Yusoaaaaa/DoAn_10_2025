
using DoAn.DAL;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class ProductService
    {
        StoreDBContext context = new StoreDBContext();

        /// <summary>
        /// Lấy tất cả sản phẩm.
        /// </summary>
        public List<Product> GetAll()
        {
            try
            {
                return context.Products.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả sản phẩm: " + ex.Message);
                return new List<Product>();
            }
        }

        /// <summary>
        /// Lấy sản phẩm theo SKU (int Key). Đổi tên từ GetById cho rõ ràng.
        /// </summary>
        public Product GetBySKU(int sku)
        {
            try
            {
                return context.Products.Find(sku);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy sản phẩm theo SKU ({sku}): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Thêm sản phẩm mới.
        /// </summary>
        /// <returns>True nếu thành công.</returns>
        public bool AddProduct(Product product)
        {
            try
            {
                // Kiểm tra xem SKU đã tồn tại chưa (vì nó là Key)
                if (context.Products.Any(p => p.SKU == product.SKU))
                {
                    Console.WriteLine($"SKU '{product.SKU}' đã tồn tại.");
                    return false;
                }

                context.Products.Add(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm sản phẩm: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Cập nhật sản phẩm hiện có.
        /// </summary>
        /// <returns>True nếu thành công.</returns>
        public bool UpdateProduct(Product product)
        {
            try
            {
                // Find existing product by Primary Key (SKU)
                var existingProduct = context.Products.Find(product.SKU);

                if (existingProduct != null)
                {
                    // Update properties using SetValues (efficient for tracked entities)
                    context.Entry(existingProduct).CurrentValues.SetValues(product);

                    // Or update manually if you want more control
                    /*
                    existingProduct.Name = product.Name;
                    existingProduct.Category = product.Category;
                    existingProduct.Gender = product.Gender;
                    existingProduct.Size = product.Size;
                    existingProduct.ImportCost = product.ImportCost;
                    existingProduct.Illustration = product.Illustration;
                    existingProduct.Price = product.Price;
                    // existingProduct.LastUpdated = DateTime.Now; // Example
                    */

                    // Mark as modified (important for EF6)
                    context.Entry(existingProduct).State = EntityState.Modified;

                    return context.SaveChanges() > 0;
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy sản phẩm với SKU '{product.SKU}' để cập nhật.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật sản phẩm: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Xóa sản phẩm dựa trên SKU.
        /// </summary>
        /// <returns>True nếu thành công.</returns>
        public bool DeleteProduct(int SKU) // Parameter is int
        {
            // Bắt buộc phải sử dụng Context mới cho mỗi thao tác (Clean Code)
            using (var context = new StoreDBContext())
            {
                // Bắt đầu Transaction để đảm bảo: hoặc tất cả thành công, hoặc tất cả thất bại.
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Tải sản phẩm cùng với các bản ghi con (Orders và Inventory)
                        var productToDelete = context.Products
                                                     .Include(p => p.Orders)
                                                     .Include(p => p.Inventory) // Nếu Inventory là Navigation Property
                                                     .FirstOrDefault(p => p.SKU == SKU);

                        if (productToDelete == null)
                        {
                            transaction.Rollback();
                            return false; // Sản phẩm không tồn tại
                        }

                        // --- Xóa Tầng (Cascading Delete) ---

                        // 1. XÓA CÁC ĐƠN HÀNG (Orders) LIÊN QUAN (Phải xóa trước Product)
                        if (productToDelete.Orders != null && productToDelete.Orders.Any())
                        {
                            // Dùng ToList() để tránh lỗi khi sửa đổi Collection đang được liệt kê
                            context.Orders.RemoveRange(productToDelete.Orders.ToList());
                        }

                        // 2. XÓA TỒN KHO (Inventory) LIÊN QUAN (Phải xóa trước Product)
                        if (productToDelete.Inventory != null)
                        {
                            // Inventory là mối quan hệ 1-0..1, xóa riêng Inventory
                            context.Inventories.Remove(productToDelete.Inventory);
                        }

                        // 3. XÓA SẢN PHẨM (Product)
                        context.Products.Remove(productToDelete);

                        int changes = context.SaveChanges();

                        transaction.Commit(); // Hoàn tất giao dịch
                        return changes > 0;
                    }
                    catch (DbUpdateException dbEx)
                    {
                        transaction.Rollback();
                        // Nếu vẫn có lỗi, nghĩa là có Entity khác (ví dụ: OrderDetail, hay một bảng ẩn) tham chiếu đến Product.SKU
                        Console.WriteLine("Lỗi Khóa ngoại/DB Update khi xóa: " + dbEx.Message);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Lỗi hệ thống khi xóa sản phẩm: " + ex.Message);
                        return false;
                    }
                }
            }
        }


        /// <summary>
        /// Kiểm tra xem SKU (int) đã tồn tại chưa.
        /// </summary>
        public bool CheckSkuExists(int sku) // Parameter is int
        {
            try
            {
                return context.Products.Any(p => p.SKU == sku);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi kiểm tra SKU ({sku}): " + ex.Message);
                return true; // Assume exists on error to prevent duplicates
            }
        }

        /// <summary>
        /// Lấy danh sách Category duy nhất.
        /// </summary>
        public List<string> GetAllCategories()
        {
            try
            {
                return context.Products
                                .Select(p => p.Category)
                                .Where(c => !string.IsNullOrEmpty(c))
                                .Distinct()
                                .OrderBy(c => c)
                                .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách loại sản phẩm: " + ex.Message);
                return new List<string>();
            }
        }

        public List<Product> GetProductsByStockAvailability(bool inStock)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsSortedByPrice(bool ascending)
        {
            try
            {
                if (ascending)
                {
                    return context.Products.OrderBy(p => p.Price).ToList();
                }
                else
                {
                    return context.Products.OrderByDescending(p => p.Price).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sắp xếp sản phẩm theo giá: " + ex.Message);
                return new List<Product>();
            }
        }


        public void InsertUpdate(Product product)
        {
            try
            {
                context.Products.AddOrUpdate(product); // Relies on SKU being the recognized Key
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong InsertUpdate product: " + ex.Message);
            }
        }
    }
}