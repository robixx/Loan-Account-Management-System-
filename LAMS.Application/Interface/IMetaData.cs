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
    }
}
