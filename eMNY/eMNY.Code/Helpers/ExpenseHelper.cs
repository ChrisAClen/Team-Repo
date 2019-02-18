using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eMNY.Domain.Models;
using System;
using System.Text;

namespace eMNY.Code.Helpers
{
  public class ExpenseHelper
  {
    private readonly eMNYDbContext _db = new eMNYDbContext();

    public bool SetExpense(Expense exp)
    {
      _db.Expenses.Add(exp);
      return _db.SaveChanges() > 0;
    }

    public List<Expense> GetExpenses()
    {
      var exp = _db.Expenses.FromSql("select * from expenses");
      var query = (from s in _db.Expenses
                   select s).ToList();
      return _db.Expenses.ToList(); //lazy loading
    }

    public List<Expense> GetExpensesByAccount()
    {
      var exp = _db.Expenses.FromSql("select * from expenses");
      var query = (from s in exp
                   select s).ToList();
      return query; //lazy loading
    }

  }
}

