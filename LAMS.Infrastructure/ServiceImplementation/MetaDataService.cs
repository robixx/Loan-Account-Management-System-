using LAMS.Application.Interface;
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
