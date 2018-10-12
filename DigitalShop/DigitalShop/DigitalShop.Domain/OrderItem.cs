using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalShop.Domain
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemID { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public double ProductPrice { get; set; }
        public bool IsDelete { get; set; }
    }
}
