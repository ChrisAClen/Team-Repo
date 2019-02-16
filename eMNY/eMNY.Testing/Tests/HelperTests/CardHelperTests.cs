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

      var exp = new DateTime(2024, 01, 23);
      Suc = new Card()
      {
        CardNumber = 1738234523452345,
        SecurityNumber = 123,
        Pin = 1234,
        ExpirationDate = exp
      };
    }


    [Fact]
    public void Test_SetRCard()
    {

      Suc.CardNumber = Suc.CreateCardNumber();
      Suc.SecurityNumber = Suc.CreateSecurityNumber();
      Assert.True(Suc.CardNumber != 1738123456789101);
      Assert.True(Suc.SecurityNumber != 123);
      Assert.True(Sut.SetCard(Suc));
    }

    [Fact]
    public void Test_GetCards()
    {
      var sugl = Sut.GetCards();

      Assert.NotNull(sugl);
      Assert.True(sugl.FirstOrDefault().SecurityNumber == 123);
      Assert.True(sugl.FirstOrDefault().Pin == 1234);
    }


  }
}
