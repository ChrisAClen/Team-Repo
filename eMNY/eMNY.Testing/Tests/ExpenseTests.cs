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
        TargetBalance = 1000m,
        CurrentBalance = 500m,
        StartDate = DateTime.Now,
        TargetDate = DateTime.Now
      };
    }

    [Fact]
    public void ExpenseTest()
    {
      Assert.IsType<string>(sut.ExpenseName);
      Assert.IsType<decimal>(sut.TargetBalance);
      Assert.IsType<decimal>(sut.CurrentBalance);
      Assert.IsType<DateTime>(sut.StartDate);
      Assert.IsType<DateTime>(sut.TargetDate);
    }
  }
}
