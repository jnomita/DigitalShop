using DigitalShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DigitalShop.Data.Repo
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
           using (var db = new DBContext())
           {
              return  db.Products.Where(p=>p.IsDelete).ToList();
           }
        }

        public List<Product> GetProductsByCategoryID(int id)
        {
           using (var db = new DBContext())
           {
              return  db.Products.Include(p=>p.Category).Where(p=>p.Category.CategoryID==id).ToList();
           }
        }

        public List<Product> GetProductsByCategoryUrl(string url)
        {
           using (var db = new DBContext())
           {
              return  db.Products.Include(p=>p.Category).Where(p=>p.Category.CategoryUrl==url).ToList();
           }
        }

        public Product GetProductByID(int id)
        {
           using (var db = new DBContext())
           {
              return  db.Products.Find(id);
           }
        }

        public Product GetProductByUrl(string url)
        {
           using (var db = new DBContext())
           {
              return  db.Products.FirstOrDefault(p=>p.ProductUrl.Equals(url));
           }
        }

        public void Add(Product Product)
        {
           using (var db = new DBContext())
           {
                db.AddRange(Product);
                db.SaveChanges();
           }
        }

        public void Delete(int id)
        {
           using (var db = new DBContext())
           {
                var Product = db.Products.Find(id);
                Product.IsDelete = true;
                db.SaveChanges();
           }
        }
    }
}
