using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class LoanInstallment
    {
        [Key]
        public int InstallmentId { get; set; }

        [Required]
        public int LoanId { get; set; }

        public int InstallmentNumber { get; set; }

        public DateTime DueDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public bool IsPaid { get; set; } = false;

        public DateTime? PaidDate { get; set; }
        
    }
}
