using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class MetaDataProperty
    {
        [Key] 
        public int DataPropertyId { get; set; }          
        public int DataElementId { get; set; }         
       
        public string DataPropertyValue { get; set; }    
        public int ViewOrder { get; set; }               
        public string InsertBy { get; set; }            
        public DateTime InsertDate { get; set; }        
        public int Status { get; set; }                
    }
}
