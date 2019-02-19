using System;
using System.Collections.Generic;
using System.Text;
using eMNY.Domain.Models;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class AccountTests
  {
    private readonly Account sut;

    public AccountTests()
    {
      sut = new Account()
      {
        AccountNumber = 2111234567,
        CreationDate = DateTime.Now,
        InterestRate = 17.05m,
        Amount = 16780.50m

      };
    }

    [Fact]
    public void AccountTest()
    {
      Assert.IsType<int>(sut.AccountNumber);
      Assert.IsType<DateTime>(sut.CreationDate);
      Assert.IsType<decimal>(sut.InterestRate);
      Assert.IsType<decimal>(sut.Amount);
    }

  }
}
