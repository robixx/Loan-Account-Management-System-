using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        [Required, MaxLength(150)]
        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

        [MaxLength(50)]
        public string NationalId { get; set; }

        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string MaterialStaus { get; set; }   // e.g., Single / Married

        [MaxLength(100)]
        public string Occupetion { get; set; }      // e.g., Service, Business

        [MaxLength(100)]
        public string SourceOfIncome { get; set; }  // e.g., Job, Business

        [Column(TypeName = "decimal(18,2)")]
        public decimal Income { get; set; } = 0;

        [MaxLength(250)]
        public string Address { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }

        public int CreatedBy { get; set; } = 0;
        public string ImageName { get; set; } 

        public int UpdatedBy { get; set; } = 0;
    }
}
