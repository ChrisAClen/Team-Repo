using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eMNY.Domain.Models;
using System;
using System.Text;

namespace eMNY.Code.Helpers
{
  public class AddressHelper
  {
    private static eMNYDbContext _db = new eMNYDbContext();

    public bool SetAddress(Address address)
    {
      _db.Addresses.Add(address);
      return _db.SaveChanges() > 0;
    }

    public List<Address> GetAddress()
    {
      var users = _db.Addresses.FromSql("select * from addresses");
      var query = (from u in _db.Addresses
                   select u).ToList();
      return _db.Addresses.Include(m => m.Street).Include(m => m.City).Include(m => m.StateProvince).ToList(); //lazy loading
    }
  }
}
