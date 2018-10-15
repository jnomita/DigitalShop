using DigitalShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DigitalShop.Data.Repo
{
    public class CategoryRepository
    {
        public List<Category> GetCategories()
        {
           using (var db = new DBContext())
           {
              return  db.Categories.Where(p=>!p.IsDelete).ToList();
           }
        }
        public List<Category> GetHaveProductCategories()
        {
           using (var db = new DBContext())
           {
              return  db.Categories.Include(p=>p.Products).Where(p=>!p.IsDelete && p.Products.Any(p2=>!p2.IsDelete)).ToList();
           }
        }

        public Category GetCategoryByID(int id)
        {
           using (var db = new DBContext())
           {
              return  db.Categories.Find(id);
           }
        }

        public Category GetCategoryByUrl(string url)
        {
           using (var db = new DBContext())
           {
              return  db.Categories.FirstOrDefault(p=>p.CategoryUrl.Equals(url));
           }
        }

        public void Add(Category category)
        {
           using (var db = new DBContext())
           {
                db.AddRange(category);
                db.SaveChanges();
           }
        }

        public void Delete(int id)
        {
           using (var db = new DBContext())
           {
                var category = db.Categories.Find(id);
                category.IsDelete = true;
                db.SaveChanges();
           }
        }
    }
}
