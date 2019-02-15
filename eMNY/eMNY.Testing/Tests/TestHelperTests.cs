using eMNY.Domain.Models;
using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using eMNY.Domain.Models;
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
