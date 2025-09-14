using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Domain.Entities
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Urls { get; set; }
        public string Icon { get; set; }
        public string Area { get; set; }
        public string Actions { get; set; }
        public string Controller { get; set; }
        public int ParentId { get; set; } = 0;
        public int IsActive { get; set; } = 1;
        public int OrderView { get; set; } = 0;
        public string ActiveUrls { get; set; } 
    }
}
