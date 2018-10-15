using DigitalShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShop.Models
{
    public class HomeModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> TopSeller { get; set; }
        public List<Product> RecentlyViewed { get; set; }
        public List<Product> TopNew { get; set; }
    }
}
