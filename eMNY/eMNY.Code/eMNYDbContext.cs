using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using eMNY.Domain.Models;
using eMNY.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Code
{
  public class eMNYDbContext : DbContext
  {
    public DbSet<CheckingAccount> CheckingAccounts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Transactions> Transactions { get; set; }
    public DbSet<SavingsAccount> SavingsAccounts { get; set; }
    public DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=clendinendotnet2019.database.windows.net;database=eMNYDB; user id=sqladmin;password=Florida2019;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<CheckingAccount>().HasKey(e => e.Id);
      builder.Entity<Customer>().HasKey(e => e.Id);
      builder.Entity<Expense>().HasKey(e => e.Id);
      builder.Entity<Transactions>().HasKey(e => e.Id);
      builder.Entity<SavingsAccount>().HasKey(e => e.Id);
      builder.Entity<Account>().HasKey(e => e.Id);

    }
  }
}
