using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class CustomerDetailsInfo
    {
        [Key]
        public long CustDetailsId { get; set; }
        public long CustomerId { get; set; }
        public int OccupationId { get; set; }
        public decimal IncomeAmount { get; set; }

    }
}
