using DigitalShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalShop.Data
{
    public class TestData
    {
        List<Product> products = new List<Product>()
        {
           new Product(){ProductName = "Sony Smart TV - 2015",Category = new Category(){CategoryName = "Smart Tv",CategoryUrl="smart-tv",IsDelete=false},
                         DateCreate = DateTime.Now,IsDelete=false,ProductDes="Lorem ipsum dolor sit amet, consectetur adipiscing elit",ProductImage="/product-1.jpg",
                         ProductPrice = 700,ProductUrl ="sony-smart-tv-2015"},

           new Product(){ProductName = "Apple new mac book 2015 March",Category =  new Category(){CategoryName = "Lapptop",CategoryUrl="laptop",IsDelete=false},
                         DateCreate = DateTime.Now,IsDelete=false,ProductDes="Lorem ipsum dolor sit amet, consectetur adipiscing elit",ProductImage="/product-2.jpg",
                         ProductPrice = 899,ProductUrl ="apple-new-mac-book-2015-march"},

           new Product(){ProductName = "Apple new i phone 6",Category = new Category(){CategoryName = "Phone",CategoryUrl="phone",IsDelete=false},
                         DateCreate = DateTime.Now,IsDelete=false,ProductDes="Lorem ipsum dolor sit amet, consectetur adipiscing elit",ProductImage="/product-3.jpg",
                         ProductPrice = 400,ProductUrl ="apple-new-i-phone-6"},

           new Product(){ProductName = "Sony playstation microsoft",Category = new Category(){CategoryName = "Game",CategoryUrl="game",IsDelete=false},
                         DateCreate = DateTime.Now,IsDelete=false,ProductDes="Lorem ipsum dolor sit amet, consectetur adipiscing elit",ProductImage="/product-4.jpg",
                         ProductPrice = 200,ProductUrl ="sony-playstation-microsoft"},

           new Product(){ProductName = "Sony Smart Air Condtion",Category = new Category(){CategoryName = "Smart Air",CategoryUrl="smart-air",IsDelete=false},
                         DateCreate = DateTime.Now,IsDelete=false,ProductDes="Lorem ipsum dolor sit amet, consectetur adipiscing elit",ProductImage="/product-5.jpg",
                         ProductPrice = 700,ProductUrl ="sony-smart-air-condtion"},
        };

        public TestData()
        {
           using (var db = new DBContext())
           {
                db.AddRange(products);
                db.SaveChanges();
           }
        }
    }
}
