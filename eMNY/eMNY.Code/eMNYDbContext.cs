using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace eMNY.Code
{
  public class eMNYDbContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Transactions> Transactions { get; set; }
    public DbSet<Card> Cards { get; set; }
    public DbSet<Name> Names { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public IConfiguration Configuration { get; set; }

    public eMNYDbContext(IConfiguration config)
    {
      Configuration = config;
    }

    public eMNYDbContext()
    {

    }


    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
     // builder.UseSqlServer(Configuration.GetConnectionString("eMNYDB"));
     builder.UseSqlServer("server = clendinendotnet2019.database.windows.net; database = eMNYDB; user id = sqladmin; password = Florida2019;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Customer>().HasKey(e => e.Id);
      builder.Entity<Expense>().HasKey(e => e.Id);
      builder.Entity<Transactions>().HasKey(e => e.Id);
      builder.Entity<Card>().HasKey(e => e.Id);
      builder.Entity<Name>().HasKey(e => e.Id);
      builder.Entity<Address>().HasKey(e => e.Id);
      builder.Entity<Account>().HasKey(e => e.Id);

    }
  }
}

