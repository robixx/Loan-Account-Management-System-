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

        public DbSet<MetaData> MetaData { get; set; }
        public DbSet<MetaDataProperty> MetaDataProperty { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Accounts> Account { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<LoanInstallment> LoanInstallment { get; set; }
        public DbSet<Payments> Payment { get; set; }
        public DbSet<Transactions> Transaction { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<CustomerInformation> CustomerInformation { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }
        public DbSet<CustomerNomineeInfo> CustomerNomineeInfo { get; set; }
        public DbSet<CustomerDetailsInfo> CustomerDetailsInfo { get; set; }
        public DbSet<EmployeeData> EmployeeData { get; set; }
        

        //Model View Entity
        public DbSet<MenuDto> MenuDto {  get; set; }
        public DbSet<MetaDataDto> MetaDataDto {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Database Entity
            modelBuilder.Entity<MetaData>().HasKey(x => x.DataElementId);
            modelBuilder.Entity<MetaDataProperty>().HasKey(x => x.DataPropertyId);
            modelBuilder.Entity<Customers>().HasKey(x => x.CustomerId);
            modelBuilder.Entity<Accounts>().HasKey(x => x.AccountId);
            modelBuilder.Entity<Loan>().HasKey(x => x.LoanId);
            modelBuilder.Entity<LoanInstallment>().HasKey(x => x.InstallmentId);
            modelBuilder.Entity<Payments>().HasKey(x => x.PaymentId);
            modelBuilder.Entity<Transactions>().HasKey(x => x.TransactionId);
            modelBuilder.Entity<CustomerDetailsInfo>().HasKey(x => x.CustDetailsId);
            modelBuilder.Entity<CustomerNomineeInfo>().HasKey(x => x.CustNomineeId);
            modelBuilder.Entity<CustomerAddress>().HasKey(x => x.CustAddressId);
            modelBuilder.Entity<CustomerInformation>().HasKey(x => x.CustomerId);
            modelBuilder.Entity<EmployeeData>().HasKey(x => x.EmployeeID);




            //Model View Entity
            modelBuilder.Entity<MenuDto>().HasNoKey();
            modelBuilder.Entity<MetaDataDto>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
