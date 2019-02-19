using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eMNY.Domain.Models;
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

    public bool SetExpensesbyAccount(Expense expo)
    {
      var account = _db.Accounts.FirstOrDefault(a => a.Id == expo.Id);
      var dataex = new Expense()
      {

        ExpenseName = expo.ExpenseName,
        ExpenseDate = expo.ExpenseDate,
        Category = expo.Category,
        Amount = expo.Amount,
        AccountId = 2

      };

      if (dataex == null)
      {
        return false;
      }

      _db.Expenses.Add(dataex);

      return _db.SaveChanges() == 1;
    }

    public List<Expense> GetExpenseByAccount(Account exy)
    {
      List<Expense> res = _db.Expenses.Where(m => m.AccountId == exy.Id).ToList();

      return res;
    }

  }
}

