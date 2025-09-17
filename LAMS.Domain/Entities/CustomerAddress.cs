using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class CustomerAddress
    {
        [Key]
        public long CustAddressId { get; set; }
        public long CustomerId { get; set; }
        public string PresentAddress { get; set; }
        public string PresentDistrict { get; set; }
        public string PresentDivision { get; set; }
        public string presentZipCode { get; set; }
        public string PermanentAddress { get; set; }
        public string PermanentDistrict { get; set; }
        public string PermanentDivision { get; set; }
        public string PermanentZipCode { get; set; }
    }
}
