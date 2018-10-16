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
        [ForeignKey("OrderID")]
        public Order Order { get; set; }
        public int OrderID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int ProductID { get; set; }
        public double ProductPrice { get; set; }
        public bool IsDelete { get; set; }
    }
}
