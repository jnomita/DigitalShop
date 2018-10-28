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
              return  db.Products.Where(p=>!p.IsDelete).ToList();
           }
        }

        public List<Product> GetHaveCategoryProducts()
        {
            using (var db = new DBContext())
            {
                return db.Products.Include(p=>p.Category).Where(p => !p.IsDelete).ToList();
            }
        }

        public List<Product> GetProductsByCategoryID(int id)
        {
           using (var db = new DBContext())
           {
              return  db.Products.Include(p=>p.Category).Where(p=>p.Category.CategoryID==id && !p.IsDelete).ToList();
           }
        }

        public List<Product> GetProductsByCategoryUrl(string url)
        {
           using (var db = new DBContext())
           {
              return  db.Products.Include(p=>p.Category).Where(p=>p.Category.CategoryUrl==url && !p.IsDelete).ToList();
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

          public Product GetHaveCategoryProductByUrl(string url)
        {
           using (var db = new DBContext())
           {
              return  db.Products.Include(p=>p.Category).ThenInclude(p=>p.Products).FirstOrDefault(p=>p.ProductUrl.Equals(url));
           }
        }

        public List<Product> GetTopSellProducts()
        {
           using (var db = new DBContext())
           {
              var list = db.OrderItems.Include(p=>p.Product).Select(p=>p.Product)
                .GroupBy(n => n)
                .Select(n => new
                    {
                        Product = n.Key,
                        Count = n.Count()
                    }).Where(p=>p.Count>0).OrderByDescending(n => n.Count).Select(p=>p.Product).Take(5);

                return list.ToList();
           }
        }

        public List<Product> GetTopNewProducts()
        {
           using (var db = new DBContext())
           {
              return  db.Products.OrderByDescending(p=>p.DateCreate).Take(5).ToList();
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

        public void Update(Product product)
        {
            using (var db = new DBContext())
            {
                db.Entry(product).State = EntityState.Modified;
                db.Update(product);
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
