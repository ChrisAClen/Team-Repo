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
        Pin = 1234,
      };
    }


    [Fact]
    public void CardTest()
    {
      Assert.True(sut.CardNumber.ToString().Length == 16);
      Assert.True(sut.Pin.ToString().Length == 4);
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

