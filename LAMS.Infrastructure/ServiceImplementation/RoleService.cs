using LAMS.Application.Interface;
using LAMS.Application.ModelViewDto;
using LAMS.Domain.Entities;
using LAMS.Infrastructure.DataConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Infrastructure.ServiceImplementation
{
    public class RoleService : IRole
    {
        private readonly DatabaseConnection _connection;
        public RoleService(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<(string Message, bool status)> DeleteRoleAsync(int roleId)
        {
            try
            {
                var role = await _connection.UserRole.FirstOrDefaultAsync(i => i.RoleId == roleId);
                if (role == null)
                {
                    return ("Role not found.", false);
                }

                // Remove the role
                _connection.UserRole.Remove(role);

                // Save changes
                await _connection.SaveChangesAsync();

                return ("Role deleted successfully.", true);


            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<RoleDto>> getRoleAsync()
        {
            try
            {
                List<RoleDto> rolelist = new List<RoleDto>();
                var list = await _connection.UserRole
                    .Select (r=> new RoleDto
                    {
                        RoleId = r.RoleId,
                        RoleName = r.RoleName,
                        Description = r.Description,
                        IsActive = r.IsActive==1?true : false,
                        CreateDate=r.CreateDate
                    })                    
                    .ToListAsync();
                if (list == null)
                {
                    return rolelist;
                }
               
                return list;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<(string Message, bool status)> SaveRoleAsync(RoleDto model)
        {
            try
            {
                string message = "";
                if (model.RoleId > 0)
                {
                    // Edit existing role
                    var existingRole = await _connection.UserRole.FindAsync(model.RoleId);
                    if (existingRole == null)
                        return ($"Role with ID {model.RoleName} not found", false);

                    existingRole.RoleName = model.RoleName;
                    existingRole.Description = model.Description;
                    existingRole.IsActive = model.IsActive ? 1 : 0;

                    _connection.UserRole.Update(existingRole);

                    message = "Updated";

                }
                else
                {
                    var data = new UserRole
                    {
                        RoleName = model.RoleName,
                        Description = model.Description,
                        CreateDate = DateTime.Now,
                        IsActive = model.IsActive == true ? 1 : 0
                    };
                    await _connection.UserRole.AddRangeAsync(data);
                    message = "Save";

                }

                await _connection.SaveChangesAsync();

                return ($"{model.RoleName} Role {message} Successfully", true);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
