using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eMNY.Code;
using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using Xunit;

namespace eMNY.Testing.Tests.HelperTests
{
  public class CardHelperTests
  {
    public CardHelper Sut { get; set; }
    public Card Suc { get; set; }

    public CardHelperTests()
    {


      Sut = new CardHelper();

      Suc = new Card()
      {
        Pin = 1234,
      };
    }


    [Fact]
    public void Test_SetRCard()
    {
      Assert.True(Sut.SetCard(Suc));
    }

    [Fact]
    public void Test_GetCards()
    {
      var sugl = Sut.GetCards();

      Assert.NotNull(sugl);
      Assert.True(sugl.FirstOrDefault().SecurityNumber == 909);
      Assert.True(sugl.FirstOrDefault().Pin == 1234);
    }


  }
}
