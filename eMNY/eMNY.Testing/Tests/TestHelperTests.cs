using eMNY.Domain.Models;
using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using eMNY.Code.Helpers;
using System.Linq;

namespace eMNY.Testing.Tests
{
  public class TestHelperTests
  {
    private readonly Card sut;
    public TestHelper sutH { get; set; }

    public TestHelperTests()
    {
      sut = new Card()
      {
     
      };

      

      sutH = new TestHelper();
    }

    [Fact]
    public void Test_SetCard()
    {
      Assert.NotNull(sutH);
    }

    [Fact]
    public void Test_SetRCard()
    {
      var sutR = sut;
      Assert.True(sutR.CardNumber >= 1737999999999999);
      Assert.True(sutR.SecurityNumber >= 99);
     
    }

    [Fact]
    public void Test_GetCard()
    {
      var sutGC = sutH.GetCards();

      Assert.NotNull(sutGC);
    }
  }
}
