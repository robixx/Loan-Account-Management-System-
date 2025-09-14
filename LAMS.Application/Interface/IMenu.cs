using LAMS.Application.ModelViewDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Application.Interface
{
    public interface IMenu
    {
        Task<List<MenuDto>> getMenuAsync();
    }
}
