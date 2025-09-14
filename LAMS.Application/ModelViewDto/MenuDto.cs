using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Application.ModelViewDto
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Urls { get; set; }
        public string Icon { get; set; }
        public int ParentId { get; set; }
        public int OrderView { get; set; }
        public string Controller { get; set; }  
        public string Area { get; set; }  
        public string Actions { get; set; }  
        public string ActiveUrls { get; set; }  

        public List<MenuDto> Children { get; set; } = new();
    }
}
