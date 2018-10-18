using DigitalShop.Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DigitalShop.Admin.Repository
{
   public class OrderRepository
    {
        public List<Order> GetAllOrders()
        {
           using (var db = new DigitalShopEntities())
           {
              return  db.Orders.Include("Customer").Where(p=>!p.IsDelete && p.OrderItems.Any()).ToList();
           }
        }
    }
}
