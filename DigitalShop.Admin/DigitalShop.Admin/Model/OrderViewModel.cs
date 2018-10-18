using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalShop.Admin.Model
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        public string OrderCode { get; set; }
        public DateTime DateCreate { get; set; }
        public string ShippingAddress { get; set; }
        public int Status { get; set; }
        public string CustomerName { get; set; }
    }
}
