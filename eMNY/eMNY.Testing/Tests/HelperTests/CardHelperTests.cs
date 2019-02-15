using System;
using System.Collections.Generic;
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

      var exp = new DateTime(2024, 01, 23);

      Sut = new CardHelper();

      Suc = new Card()
      {
        CardNumber = 1738234523452345,
        SecurityNumber = 123,
        Pin = 1234,
        ExpirationDate = exp

      };
    }

    [Fact]
    public void Test_SetCard()
    {
      Assert.True(Sut.SetCard(Suc));
    }

  }
}
