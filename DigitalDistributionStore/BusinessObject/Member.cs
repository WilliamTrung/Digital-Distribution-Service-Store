using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberID { get; set; }
        [Required]
        public string MemberName { get; set; }
        [Required, MaxLength(20)]
        public string Email { get; set; }
        [Required, MaxLength(20)]
        public string Password { get; set; }
        [Required]
        public Boolean Status { get; set; }
        [Required]
        public Boolean IsAdmin { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
