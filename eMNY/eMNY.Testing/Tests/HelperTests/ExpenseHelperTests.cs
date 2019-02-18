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

    public ExpenseHelperTests()
    {
      eh = new ExpenseHelper();

      sue = new Expense()
      {
        ExpenseName = "Rent",
        Amount = 1000m,
        ExpenseDate = DateTime.Now,
        Category = "Other"
      };
    }

    [Fact]
    public void Test_SetExpense()
    {
      var sutE = eh.SetExpense(sue);

    }

    [Fact]
    public void Test_GetExpense()
    {
      var sutE = eh.GetExpenses();

      Assert.NotNull(sutE);
    }
  }
}
