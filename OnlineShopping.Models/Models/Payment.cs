using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Models.Models
{
    [Table("Payments")]
    public class Payment
    {
        [Key]   
        public int PaymentId { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public int OrderId {  get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public string PaymentMethod { get; set; }

        public string TransactionId { get; set; }
    }
}
