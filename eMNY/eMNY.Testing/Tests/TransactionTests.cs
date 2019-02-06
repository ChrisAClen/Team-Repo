using eMNY.Domain.Models;
using System;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class TransactionTests
  {
    private readonly Transactions sut;

    public TransactionTests()
    {
      sut = new Transactions
      {
        IsDeposit = true,
        TransactionAmount = 500d,
        TransactionDate = DateTime.Now
      };
    }

    [Fact]
    public void ExpenseTest()
    {
      Assert.IsType<bool>(sut.IsDeposit);
      Assert.IsType<double>(sut.TransactionAmount);
      Assert.IsType<DateTime>(sut.TransactionDate);
    }
  }
}
