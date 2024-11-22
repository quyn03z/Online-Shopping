using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Models.Models
{
    [Table("Users")]
    public class User
    {
        [Key] 
        public Guid UserId { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        [Required]
        public string UserName { get; set; }

        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public DateOnly BirthDay { get; set; }

        public string Avatar { get; } = "default-avatar.png";

        [Required]
        public bool isDeleted { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }


        public virtual IEnumerable<Payment> Payments { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }


    }
}
