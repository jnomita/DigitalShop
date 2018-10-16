using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalShop.Domain
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public string OrderCode { get; set; }
        public DateTime DateCreate { get; set; }

        [ForeignKey("CustomerID")]
        public Customer CustomerOrder { get; set; }
        public int CustomerID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public string ShippingAddress { get; set; }
        public int Status { get; set; }
        public bool IsDelete { get; set; }
    }
}
