using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required, MaxLength(50)]
        public string TransactionType { get; set; } // Debit / Credit

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
