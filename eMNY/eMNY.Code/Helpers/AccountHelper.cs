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
    private eMNYDbContext _db = new eMNYDbContext();

    public bool SetSavingsAccount(SavingsAccount savings)
    {
      _db.SavingsAccounts.Add(savings);
      return _db.SaveChanges() > 0;
    }

    public List<SavingsAccount> GetSavings()
    {
      var account = _db.SavingsAccounts.FromSql("select * from users");
      var query = (from s in _db.SavingsAccounts
                   select s).ToList();
      return _db.SavingsAccounts.Include(m => m.AccountNumber).ToList(); //lazy loading
    }

    public bool SetCheckingAccount(CheckingAccount checking)
    {
      _db.CheckingAccounts.Add(checking);
      return _db.SaveChanges() > 0;
    }

    public List<CheckingAccount> GetChecking()
    {
      var account = _db.CheckingAccounts.FromSql("select * from users");
      var query = (from c in _db.CheckingAccounts
                   select c).ToList();
      return _db.CheckingAccounts.Include(m => m.AccountNumber).ToList(); //lazy loading
    }
  }
}
