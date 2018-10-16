using DigitalShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalShop.Data.Repo
{
    public class OrderItemRepository
    {
        public List<OrderItem> GetOrderItems()
        {
           using (var db = new DBContext())
           {
              return  db.OrderItems.Where(p=>!p.IsDelete).ToList();
           }
        }

        public OrderItem GetOrderItemByID(int id)
        {
           using (var db = new DBContext())
           {
              return  db.OrderItems.Find(id);
           }
        }

        public void Add(OrderItem OrderItem)
        {
           using (var db = new DBContext())
           {
                db.AddRange(OrderItem);
                db.SaveChanges();
           }
        }

        public void Add(List<OrderItem> OrderItem)
        {
            if (OrderItem.Any())
            {
                using (var db = new DBContext())
                {
                    db.AddRange(OrderItem);
                    db.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
           using (var db = new DBContext())
           {
                var OrderItem = db.OrderItems.Find(id);
                OrderItem.IsDelete = true;
                db.SaveChanges();
           }
        }
    }
}
