using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Application.ModelViewDto
{
    public class MetaDataDto
    {
        public int DataElementId { get; set; }
        public string DataElementName { get; set; }
        public string DataElementDescription { get; set; }
        public string InsertBy { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public int Status { get; set; }
    }
}
