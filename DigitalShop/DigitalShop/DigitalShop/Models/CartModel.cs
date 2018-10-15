using DigitalShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalShop.Models
{
    public class CartModel
    {
        public List<CartItemModel> Items { get; set; }
        public Customer Customer { get; set; }
        public string ShippingAddress { get; set; }
    }
    public class CartItemModel
    {
        public Product Product { get; set; }
        public int Qty { get; set; }
    }

    public class CartUpdateItemModel
    {
        public int ProductID { get; set; }
        public int Qty { get; set; }
    }
}
