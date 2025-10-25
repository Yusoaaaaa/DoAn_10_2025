using DoAn.DAL;
using DoAn.DAL.Models;
using System;
using System.Collections.Generic;
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
            return context.Products.FirstOrDefault(p => p.SKU == id) != null ? context.Products.FirstOrDefault(p => p.SKU == id) : new Product();
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

        //hoạt động
        public int CountProductsAvail()
        {
            // Implementation to count total products
            return context.Products.Select(o => o.Name == "Hoạt động").Count();
        }

        //không hoạt động
        public int CountProductsNotAvail()
        {
            // Implementation to count total products
            return context.Products.Select(o => o.Name == "Không hoạt động").Count();
        }

        public double GetImportPrice(int sku)
        {
            return context.Products.Where(p => p.SKU == sku).Select(p => p.ImportCost).FirstOrDefault();
        }
    }
}
