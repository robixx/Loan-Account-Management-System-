using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class MetaData
    {
        [Key]
        public int DataElementId { get; set; }          
        public string DataElementName { get; set; }    
        public string DataElementDescription { get; set; } 
        public string InsertBy { get; set; }           
        public DateTime InsertDate { get; set; }= DateTime.Now;
        public int Status { get; set; }             
    }
}
