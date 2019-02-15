using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class CardTests
  {
    private readonly Card sut;

    public CardTests()
    {
      var exp = new DateTime(2024, 01, 23);

      sut = new Card()
      {
        CardNumber = 1738234523452345,
        SecurityNumber = 123,
        Pin = 1234,
        ExpirationDate = exp

      };
    }

    [Fact]
    public void CardTest()
    {
      long newCard = sut.CreateCardNumber();
      Assert.True(newCard.ToString().Length == 16);
    }

    [Fact]
    public void Test_CardProperties()
    {
      Assert.IsType<long>(sut.CardNumber);
      Assert.IsType<int>(sut.SecurityNumber);
      Assert.IsType<int>(sut.Pin);
    }

  }
}

