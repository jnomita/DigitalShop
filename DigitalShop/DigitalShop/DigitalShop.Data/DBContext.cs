using System;
using DigitalShop.Domain;
using Microsoft.EntityFrameworkCore;

namespace DigitalShop.Data
{
    public class DBContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging(true)
                .UseSqlServer(@"Data Source=DESKTOP-OR2DL8D;Initial Catalog=DigitalShop; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
