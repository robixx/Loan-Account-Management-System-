using LAMS.Application.Interface;
using LAMS.Application.ModelViewDto;
using LAMS.Domain.Entities;
using LAMS.Infrastructure.DataConnection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Infrastructure.ServiceImplementation
{
    public class MetaDataService : IMetaData
    {
        private readonly DatabaseConnection _connection;
        public MetaDataService(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<(List<EmployeeDataDto> Data, int Total)> getAsync(int pageNumber, int pageSize, string searchTerm)
        {
            try
            {
                var query = _connection.EmployeeData.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    string lowerSearch = searchTerm.ToLower();

                    query = query.Where(e =>
                        e.EmployeeName.ToLower().Contains(lowerSearch) ||
                        e.Designation.ToLower().Contains(lowerSearch) ||
                        e.Department.ToLower().Contains(lowerSearch));
                }

                int totalCount = await query.CountAsync(); // SQL COUNT

                var employees = await query
                    .Skip((pageNumber-1)*pageSize)
                    .Take(pageSize)
                    .ToListAsync();
                

                var result = employees.Select(e => new EmployeeDataDto
                {
                    EmployeeID = e.EmployeeID,
                    EmployeeName = e.EmployeeName,
                    Designation = e.Designation,
                    Department = e.Department,
                    Salary = e.Salary
                }).ToList();

                return (result,totalCount);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get all metadata 
        public async Task<List<MetaData>> getMetaDataAsync()
        {
            try
            {
                var result = new List<MetaData>();
                //var result = await _connection.MetaData.ToListAsync();

                return result;

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       
    }
}
