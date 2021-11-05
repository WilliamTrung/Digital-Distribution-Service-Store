using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        [System.ComponentModel.Browsable(false)]
        public int MemberID { get; set; }
        [Required]
        public Boolean Status { get; set; }
        public virtual Member Member { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
