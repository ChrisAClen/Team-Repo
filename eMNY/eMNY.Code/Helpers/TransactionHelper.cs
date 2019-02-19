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

    //public List<Transactions> GetTransactionsByCustomer()
    //{
    //  var trans = _db.Transactions.FromSql("select * from transactions");
    //  var query = (from s in trans
    //               select s).ToList();
    //  return query;  //lazy loading
    //}

    public bool SetTransactionbyCustomer(Transactions tran)
    {
      var customer = _db.Customers.FirstOrDefault(a => a.Id == tran.Id);
      var datatran = new Transactions()
      {
        TransactionAmount = tran.TransactionAmount,
        TransactionDate = tran.TransactionDate,
        CustomerId = 3

      };

      if (datatran == null)
      {
        return false;
      }

      _db.Transactions.Add(datatran);

      return _db.SaveChanges() == 1;
    }

    public List<Transactions> GetTransactionByCustomer(int custoId)
    { 
      return _db.Transactions.Where(m => m.CustomerId == custoId).ToList();
    }

    public List<Transactions> GetTransactionByCustomer(Transactions tran)
    {
      List<Transactions> res = _db.Transactions.Where(m => m.CustomerId == tran.Id).ToList();

      return res;
    }
  }
}
