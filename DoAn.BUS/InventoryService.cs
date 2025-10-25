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

        
    }
}
