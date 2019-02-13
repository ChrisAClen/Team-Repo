using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using eMNY.Domain.Abstracts;
using Microsoft.Extensions.Configuration;

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
    public IConfiguration Configuration { get; private set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer(Configuration.GetConnectionString("EschmnyDatabase"));
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

