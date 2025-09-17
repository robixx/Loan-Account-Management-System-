using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class CustomerNomineeInfo
    {
        [Key]
        public long CustNomineeId { get; set; }
        public long CustomerId { get; set; }
        public string NomineeName { get; set; }
        public string nNID { get; set; }
        public int Relationship { get; set; }
        public string nPhoneNumber { get; set; }
        public string nEmail { get; set; } = "";
        public string nAddress { get; set; }



    }
}
