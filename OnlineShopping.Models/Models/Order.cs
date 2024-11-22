using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Models.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateOnly OrderDate { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        [Required]
        public bool Status { get; set; }

        public string Notes { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public virtual IEnumerable<Payment> Payments { get; set; }

        public virtual IEnumerable<OrderDetails> OrderDetails { get; set; }

    }
}
