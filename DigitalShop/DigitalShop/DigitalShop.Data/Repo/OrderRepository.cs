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
              return  db.Orders.Where(p=>p.IsDelete).ToList();
           }
        }

        public Order GetOrderByID(int id)
        {
           using (var db = new DBContext())
           {
              return  db.Orders.Find(id);
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
