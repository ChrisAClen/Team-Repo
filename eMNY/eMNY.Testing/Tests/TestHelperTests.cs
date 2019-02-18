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
        CardNumber = 1738123456789101,
        Pin = 1234,
        SecurityNumber = 123        
      };

      

      sutH = new TestHelper();
    }

    [Fact]
    public void Test_SetCard()
    {
      
    }

    [Fact]
    public void Test_SetRCard()
    {
      var sutR = sut;
      sutR.CardNumber = sut.CreateCardNumber();
      sutR.SecurityNumber = sut.CreateSecurityNumber();
      Assert.True(sutR.CardNumber != 1738123456789101);
      Assert.True(sutR.SecurityNumber != 123);
     
    }

    [Fact]
    public void Test_GetCard()
    {
      var sutGC = sutH.GetCards();

      Assert.NotNull(sutGC);
    }
  }
}
