using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.Browsable(false)]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        [System.ComponentModel.Browsable(false)]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
