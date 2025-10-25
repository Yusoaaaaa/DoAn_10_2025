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
    }
}
