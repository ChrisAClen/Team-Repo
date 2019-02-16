using System;
using eMNY.Domain.Models;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class ExpenseTests
  {
    private readonly Expense sut;

    public ExpenseTests()
    {
      sut = new Expense()
      {
        ExpenseName = "Rent",
        Amount = 1000m,
        ExpenseDate = DateTime.Now
      };
    }

    [Fact]
    public void ExpenseTest()
    {
      Assert.IsType<string>(sut.ExpenseName);
      Assert.IsType<decimal>(sut.Amount);
      Assert.IsType<DateTime>(sut.ExpenseDate);
    }
  }
}
