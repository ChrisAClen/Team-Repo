using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eMNY.Domain.Models;
using System;

namespace eMNY.Code.Helpers
{
  public class CustomerHelper
  {
    private eMNYDbContext _db = new eMNYDbContext();

    public bool SetUser(Customer user)
    {
      _db.Customers.Add(user);
      return _db.SaveChanges() > 0;
    }

    public List<Customer> GetUsers()
    {
      var users = _db.Customers.FromSql("select * from users");
      var query = (from u in _db.Customers
                   select u).ToList();
      return _db.Customers.Include(m => m.Name).ToList(); //lazy loading
    }
  }
}



