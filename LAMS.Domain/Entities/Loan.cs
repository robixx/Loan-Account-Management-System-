using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required, MaxLength(50)]
        public string LoanType { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrincipalAmount { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal InterestRate { get; set; }

        public int DurationMonths { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [MaxLength(20)]
        public string Status { get; set; } = "Pending";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int CreateBy { get; set; } = 0;

        public int UpdatedBy { get; set; } = 0;

        public DateTime? UpdatedDate { get; set; }

    }
}
