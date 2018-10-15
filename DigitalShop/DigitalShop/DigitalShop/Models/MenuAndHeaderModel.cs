using DigitalShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShop.Models
{
    public class MenuAndHeaderModel
    {
        public List<CartItemModel> ProductsCart { set; get; }
        public List<Category> Menus { get; set; }
    }
}
