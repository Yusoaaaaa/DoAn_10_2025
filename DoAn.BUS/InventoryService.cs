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
            // Implementation to retrieve all inventory records
            return context.Inventories.ToList();
        }

        public Inventory GetById(int SKU)
        {
            // Implementation to retrieve an inventory record by its ID
            return context.Inventories.FirstOrDefault(i => i.SKU == SKU);
        }

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
    }
}
