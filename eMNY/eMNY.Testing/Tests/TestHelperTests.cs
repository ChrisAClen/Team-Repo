using eMNY.Domain.Models;
using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using eMNY.Code.Helpers;

namespace eMNY.Testing.Tests
{
  public class TestHelperTests
  {
    private Card sut;
    public CardHelper sutH { get; set; }

    public TestHelperTests()
    {
      sut = new Card()
      {
        CardNumber = 1738123456789101,
        Pin = 1234,
        SecurityNumber = 123        
      };

      sutH = new CardHelper();
    }

    [Fact]
    public void Test_SetUser()
    {
      Assert.True(sutH.SetCard(sut));
    }
  }
}
