using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eMNY.Domain.Models;
using System.Text;

namespace eMNY.Code.Helpers
{
  public class AccountHelper
  {
    private readonly eMNYDbContext _db = new eMNYDbContext();

    public bool SetAccount(Account savings)
    {
      _db.Accounts.Add(savings);
      return _db.SaveChanges() > 0;
    }

    public List<Account> GetAccount()
    {
      var account = _db.Accounts.FromSql("select * from accounts");
      var query = (from s in _db.Accounts
                   select s).ToList();
      return _db.Accounts.Include(m => m.AccountNumber).ToList(); //lazy loading
    }

    
  }
}
