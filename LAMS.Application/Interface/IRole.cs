using LAMS.Application.ModelViewDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Application.Interface
{
    public interface IRole
    {

        Task<List<RoleDto>> getRoleAsync();
        Task<(string Message, bool status)> SaveRoleAsync(RoleDto model);
        Task<(string Message, bool status)> DeleteRoleAsync(int roleId);
    }
}
