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
  public class TransactionHelperTests
  {
    public Transactions sut { get; set; }
    public TransactionHelper the { get; set; }

    public TransactionHelperTests()
    {
      the = new TransactionHelper();

      sut = new Transactions()
      {
        TransactionAmount = 35.00m,
        TransactionDate = DateTime.Now
      };
    }

    [Fact]
    public void Test_SetTransaction()
    {
      var sutT = the.SetTransaction(sut);

    }

    [Fact]
    public void Test_GetTransaction()
    {
      var sutT = the.GetTransactions();

      Assert.NotNull(sutT);
    }

  }
}
