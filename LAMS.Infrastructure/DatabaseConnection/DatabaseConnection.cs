using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Infrastructure.DatabaseConnection
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options)
        {

            //Database Entity

            //Model View Entity
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Database Entity
            //modelBuilder.Entity<DataMapping>().HasKey(x => x.Id);
            //Model View Entity
            //modelBuilder.Entity<VisitLogGallarayDto>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
