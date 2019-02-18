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
  public class AccountHelperTests
  {
    public Account sua { get; set; }
    public AccountHelper ah { get; set; }

    public Customer customer { get; set; }
    public Card suc { get; set; }

    public AccountHelperTests()
    {
      ah = new AccountHelper();

      sua = new Account()
      {
        AccountNumber = 2119876543,
        CreationDate = DateTime.Now,
        InterestRate = 17.38m,
        Amount = 60000.50m,
      };
    }

    [Fact]
    public void AccountTest()
    {
      Assert.IsType<int>(sua.AccountNumber);
      Assert.IsType<DateTime>(sua.CreationDate);
      Assert.IsType<decimal>(sua.InterestRate);
      Assert.IsType<decimal>(sua.Amount);
    }

    [Fact]
    public void Test_SetAccount()
    {
      Assert.NotNull(sua);
    }

    [Fact]
    public void Test_GetAccounts()
    {
      var sutA = ah.GetAccounts();

      Assert.NotNull(sutA);
    }

  }
}
