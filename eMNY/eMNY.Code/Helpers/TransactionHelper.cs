using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eMNY.Domain.Models;
using System.Text;

namespace eMNY.Code.Helpers
{
  public class TransactionHelper
  {
    private readonly eMNYDbContext _db = new eMNYDbContext();

    public bool SetTransaction(Transactions trans)
    {
      _db.Transactions.Add(trans);
      return _db.SaveChanges() > 0;
    }

    public List<Transactions> GetTransactions()
    {
      var trans = _db.Transactions.FromSql("select * from transactions");
      var query = (from s in _db.Transactions
                   select s).ToList();
      return _db.Transactions.ToList(); //lazy loading
    }


    public List<Transactions> GetTransactionsByCustomer()
    {
      var trans = _db.Transactions.FromSql("select * from transactions");
      var query = (from s in trans
                   select s).ToList();
      return query;  //lazy loading
    }
  }
}
