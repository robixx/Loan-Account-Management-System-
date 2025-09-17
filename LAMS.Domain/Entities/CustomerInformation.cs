using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class CustomerInformation
    {
        [Key]
        public long CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int Gender { get; set; } 
        public int MaterialState { get; set; }
        public string NID { get; set; } = "";
        public string PassportNo { get; set; } = "";
        public string ImageName { get; set; }
        public int Status { get; set; } = 1;
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime Updatedate { get; set; }
        public DateTime CreateDate { get; set; }= DateTime.Now;

    }
}
