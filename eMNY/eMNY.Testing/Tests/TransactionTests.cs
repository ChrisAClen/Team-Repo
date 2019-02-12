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
      sut = new Transactions(500m, true)
      {
        TransactionDate = DateTime.Now
      };
    }

    [Fact]
    public void TransactionTest()
    {
      Assert.IsType<bool>(sut.IsDeposit);
      Assert.IsType<decimal>(sut.TransactionAmount);
      Assert.IsType<DateTime>(sut.TransactionDate);
    }
  }
}
