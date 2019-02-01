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
        TargetBalance = (double)1000m,
        CurrentBalance = (double)500m
      };
    }

    [Fact]
    public void ExpenseTest()
    {
      Assert.IsType<string>(sut.ExpenseName);
      Assert.IsType<double>(sut.TargetBalance);
      Assert.IsType<double>(sut.CurrentBalance);
    }
  }
}
