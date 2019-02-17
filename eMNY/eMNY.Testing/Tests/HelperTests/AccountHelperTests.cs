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
    private readonly Account sua;
    public AccountHelper ah { get; set; }

    public Customer customer { get; set; }
    public Card suc { get; set; }

    public AccountHelperTests()
    {
      suc = new Card()
      {
        Pin = 4444,
      };

      sua = new Account()
      {
        AccountNumber = 2119876543,
        CreationDate = DateTime.Now,
        InterestRate = 17.38m,
        Amount = 60000.50m,

      };
    }

    [Fact]
    public void Test_SetAccount()
    {
      
    }

    [Fact]
    public void Test_GetAccounts()
    {
     
    }

  }
}
