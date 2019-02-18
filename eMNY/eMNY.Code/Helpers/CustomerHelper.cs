using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eMNY.Domain.Models;
using System;

namespace eMNY.Code.Helpers
{
  public class CustomerHelper
  {
    private static readonly eMNYDbContext _db = new eMNYDbContext();

    public bool SetCustomer(Customer customer)
    {
      //var customer = _db.Customers.FirstOrDefault(a => a.CustomerId == account.CustomerId);
      _db.Customers.Add(customer);
      return _db.SaveChanges() > 0;
    }

    public List<Customer> GetCustomers()
    {
      var customers = _db.Customers.FromSql("select * from customers");
      var query = (from u in _db.Customers
                   select u).ToList();
      return _db.Customers.ToList(); //lazy loading
    }
  }
}



