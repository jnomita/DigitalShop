using DigitalShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DigitalShop.Data.Repo
{
    public class OrderRepository
    {
        public List<Order> GetOrders()
        {
           using (var db = new DBContext())
           {
              return  db.Orders.Where(p=>!p.IsDelete).ToList();
           }
        }

        public Order GetOrderByID(int id)
        {
           using (var db = new DBContext())
           {
              var order = db.Orders.Include(p => p.CustomerOrder).FirstOrDefault(p => p.OrderID == id);
              order.OrderItems = db.OrderItems.Include(p => p.Product).ToList();
              return order;
           }
        }

        public void Add(Order Order)
        {
           using (var db = new DBContext())
           {
                db.AddRange(Order);
                db.SaveChanges();
           }
        }

        public void UpdateStatus(int OrderID, int Status)
        {
            using (var db = new DBContext())
            {
                var order = db.Orders.Find(OrderID);
                order.Status = Status;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
           using (var db = new DBContext())
           {
                var Order = db.Orders.Find(id);
                Order.IsDelete = true;
                db.SaveChanges();
           }
        }
    }
}
