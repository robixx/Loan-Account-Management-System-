using LAMS.Application.ModelViewDto;
using LAMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Application.Interface
{
    public interface IMetaData
    {
        Task<List<MetaData>> getMetaDataAsync();
        Task<(List<EmployeeDataDto> Data, int Total)> getAsync(int pageNumber, int pageSize, string searchTerm);
    }
}
