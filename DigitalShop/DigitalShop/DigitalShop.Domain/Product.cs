using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigitalShop.Domain
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductUrl{ get; set; }
        public string ProductDes { get; set; }
        public double ProductPrice{ get; set; }
        public string ProductImage { get; set; }
        public Category Category { get; set; }
        public bool IsDelete { get; set; }
    }
}
