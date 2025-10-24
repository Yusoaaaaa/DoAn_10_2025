/*using DoAn.DAL;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    public class ProductService
    {
        StoreDBContext context = new StoreDBContext();
        public List<Product> GetAll()
        {
            // Implementation to retrieve all products
            return context.Products.ToList();
        }

        public Product GetById(int id)
        {
            // Implementation to retrieve a product by its ID
            return context.Products.FirstOrDefault(p => p.SKU == id);
        }

        public List<Product> GetProductsByStockAvailability(bool inStock)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsSortedByPrice(bool ascending)
        {
            throw new NotImplementedException();
        }

        public void InsertUpdate(Product product)
        {
            // Implementation to insert or update a product
            context.Products.AddOrUpdate(product);
            context.SaveChanges();
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Data.Entity; // **QUAN TRỌNG:** Needed for EntityState
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DAL.Models;

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
                // Include Inventory data if needed for display (optional)
                // return context.Products.Include(p => p.Inventory).AsNoTracking().ToList(); 
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
                // Find uses the primary key directly
                return context.Products.Find(sku);
                // Or using FirstOrDefault:
                // return context.Products.FirstOrDefault(p => p.SKU == sku);
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

                // Set default values or timestamps if needed before adding
                // product.LastUpdated = DateTime.Now; // Example if you add LastUpdated field to Product model

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
        public bool DeleteProduct(int sku) // Parameter is int
        {
            try
            {
                var productToDelete = context.Products.Find(sku); // Use Find for PK
                if (productToDelete != null)
                {
                    // Handle related data if necessary (e.g., Inventory, Orders)
                    // Option 1: Cascade delete configured in DbContext or DB? If so, just remove product.
                    // Option 2: Manually delete related data
                    /*
                    var inventory = context.Inventories.FirstOrDefault(i => i.SKU == sku);
                    if (inventory != null) context.Inventories.Remove(inventory);
                    // Handle Orders? (Maybe set Product SKU to null or prevent deletion if orders exist?)
                    var relatedOrders = context.Orders.Where(o => o.SKU == sku).ToList();
                    if (relatedOrders.Any()) {
                         Console.WriteLine($"Cannot delete product SKU {sku} as it has associated orders.");
                         return false; // Or handle differently
                    }
                    */

                    context.Products.Remove(productToDelete);
                    return context.SaveChanges() > 0;
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy sản phẩm với SKU '{sku}' để xóa.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Catch potential foreign key constraint errors if cascade delete isn't set up
                Console.WriteLine("Lỗi khi xóa sản phẩm: " + ex.Message);
                return false;
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

        // --- HÀM KHÔNG THAY ĐỔI / CHƯA IMPLEMENT ---
        public List<Product> GetProductsByStockAvailability(bool inStock)
        {
            // You would need to join with Inventory table here
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

        // --- HÀM InsertUpdate HIỆN CÓ ---
        // Sử dụng hàm này cẩn thận, đảm bảo SKU là khóa chính được EF nhận diện.
        // Các hàm AddProduct/UpdateProduct riêng biệt thường an toàn hơn.
        public void InsertUpdate(Product product)
        {
            try
            {
                // product.LastUpdated = DateTime.Now; // Add this if you add the field
                context.Products.AddOrUpdate(product); // Relies on SKU being the recognized Key
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi trong InsertUpdate product: " + ex.Message);
                // Should handle or re-throw
            }
        }
    }
}