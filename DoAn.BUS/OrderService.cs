using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DAL.Models;

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
    }
}
