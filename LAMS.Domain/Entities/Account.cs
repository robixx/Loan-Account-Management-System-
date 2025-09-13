using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required, MaxLength(20)]
        public string AccountNumber { get; set; }

        [Required, MaxLength(50)]
        public string AccountType { get; set; }  // e.g., Savings / Current

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; } = 0;

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [MaxLength(20)]
        public string Status { get; set; } = "Active";

        public int CreateBy { get; set; } = 0;

        public int UpdatedBy { get; set; } = 0;

        public DateTime? UpdatedDate { get; set; }
    }
}
