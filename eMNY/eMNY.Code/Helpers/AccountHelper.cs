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

    public List<Account> GetAccounts()
    {
      var account = _db.Accounts.FromSql("select * from accounts");
      var query = (from s in _db.Accounts
                   select s).ToList();
      return _db.Accounts.ToList(); //lazy loading
    }

    public bool SetAccountbyCard(Account account)
    {
      var customer = _db.Customers.FirstOrDefault(a => a.Id == account.Id);
      var card = _db.Cards.FirstOrDefault(a => a.Id == account.Id);
      var dataaccount = new Account()
      {
        AccountNumber = account.AccountNumber,
        CreationDate = account.CreationDate,
        InterestRate = account.InterestRate,
        Amount = account.Amount

      };

      if (customer == null || card == null)
      {
        return false;
      }

      _db.Accounts.Add(dataaccount);

      return _db.SaveChanges() == 1;
    }
  }
    
  }

