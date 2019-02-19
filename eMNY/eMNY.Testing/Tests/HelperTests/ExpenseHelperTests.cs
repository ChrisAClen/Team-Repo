using eMNY.Code;
using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace eMNY.Testing.Tests.HelperTests
{
  public class ExpenseHelperTests
  {
    public Expense sue { get; set; }
    public ExpenseHelper eh { get; set; }
    public AccountHelper ah { get; set; }
    public Account exy { get; set; }

    public ExpenseHelperTests()
    {
      eh = new ExpenseHelper();

      sue = new Expense()
      {
        ExpenseName = "Rent",
        Amount = 1000m,
        ExpenseDate = DateTime.Now,
        Category = "Other",
        AccountId = 2
      };

     // exy = ah.GetAccountById(2);
    }

    [Fact]
    public void Test_SetExpense()
    {
      var sutE = sue;

      Assert.NotNull(sutE);

    }

    [Fact]
    public void Test_GetExpense()
    {
      var sutE = eh.GetExpenses();

      Assert.True(sutE.FirstOrDefault().ExpenseName == "Rent");
      Assert.True(sutE.FirstOrDefault().Amount == 1000m);
    }

    [Fact]
    public void Test_SetExpensesbyAccount()
    {
      var sut = eh.SetExpensesbyAccount(sue);

      Assert.True(sut);
    }

    //[Fact]
    //public void Test_GetExpenseByAccount()
    //{
    //  var sutE = eh.GetExpenseByAccount(sue);

    //  Assert.True(sutE.FirstOrDefault().ExpenseName == "Rent");
    //  Assert.True(sutE.FirstOrDefault().AccountId == 2);
    //}

    //[Fact]
    //public void Test_GetExpenseByAccount()
    //{
    //  var sut = eh.GetExpenseByAccount(exy);

    //  //Assert.NotNull(sut);
    //  Assert.NotEmpty(sut);
    //}

  }
}
