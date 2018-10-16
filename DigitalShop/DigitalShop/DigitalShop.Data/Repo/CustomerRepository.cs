using DigitalShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DigitalShop.Data.Repo
{
    public class CustomerRepository
    {
        public List<Customer> GetCustomers()
        {
           using (var db = new DBContext())
           {
              return  db.Customers.Where(p=>!p.IsDelete).ToList();
           }
        }

        public int MaxCode()
        {
           using (var db = new DBContext())
           {
              return  db.Customers.Count();
           }
        }

        public Customer GetCustomerByID(int id)
        {
           using (var db = new DBContext())
           {
              return  db.Customers.Find(id);
           }
        }

        public Customer GetCustomerByPhone(string phone)
        {
           using (var db = new DBContext())
           {
               return  db.Customers.FirstOrDefault(p=>!p.IsDelete && p.Phone.Equals(phone));
           }
        }

        public bool CheckCustomExistsByPhone(string phone)
        {
           using (var db = new DBContext())
           {
              return  db.Customers.Any(p=>!p.IsDelete && p.Phone.Equals(phone));
           }
        }
        public void Add(Customer Customer)
        {
           using (var db = new DBContext())
           {
                db.AddRange(Customer);
                db.SaveChanges();
           }
        }

        public void Delete(int id)
        {
           using (var db = new DBContext())
           {
                var Customer = db.Customers.Find(id);
                Customer.IsDelete = true;
                db.SaveChanges();
           }
        }
    }
}
