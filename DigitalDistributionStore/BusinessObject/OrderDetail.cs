using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.Browsable(false)]
        public int OrderDetailID { get; set; }
        [Required]
        [System.ComponentModel.Browsable(false)]
        public int OrderID { get; set; }
        [Required]
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual Product Product { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual Order Order { get; set; }

    }
}
