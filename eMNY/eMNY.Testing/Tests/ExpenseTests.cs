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
        CurrentBalance = 500m
      };
    }

    [Fact]
    public void ExpenseTest()
    {
      Assert.IsType<string>(sut.ExpenseName);
      Assert.IsType<decimal>(sut.TargetBalance);
      Assert.IsType<decimal>(sut.CurrentBalance);
    }
  }
}
