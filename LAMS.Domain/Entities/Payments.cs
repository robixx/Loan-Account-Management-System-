using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public  class Payments
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int LoanId { get; set; }

        [Required]
        public int AccountId { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        [Required, MaxLength(50)]
        public string PaymentMethod { get; set; }
    }
}
