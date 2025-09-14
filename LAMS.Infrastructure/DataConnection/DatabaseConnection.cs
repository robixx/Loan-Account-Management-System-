using LAMS.Application.ModelViewDto;
using LAMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMS.Infrastructure.DataConnection
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options)
        {
            
        }

        //Database Entity
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Accounts> Account { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<LoanInstallment> LoanInstallment { get; set; }
        public DbSet<Payments> Payment { get; set; }
        public DbSet<Transactions> Transaction { get; set; }
        public DbSet<Menu> Menu { get; set; }
        

        //Model View Entity
        public DbSet<MenuDto> MenuDto {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Database Entity
            modelBuilder.Entity<Customers>().HasKey(x => x.CustomerId);
            modelBuilder.Entity<Accounts>().HasKey(x => x.AccountId);
            modelBuilder.Entity<Loan>().HasKey(x => x.LoanId);
            modelBuilder.Entity<LoanInstallment>().HasKey(x => x.InstallmentId);
            modelBuilder.Entity<Payments>().HasKey(x => x.PaymentId);
            modelBuilder.Entity<Transactions>().HasKey(x => x.TransactionId);




            //Model View Entity
            modelBuilder.Entity<MenuDto>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
