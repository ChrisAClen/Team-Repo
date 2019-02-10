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
      sut = new Card()
      {
       
      };
    }

    [Fact]
    public void CardTest()
    {
      long newCard = sut.CreateCardNumber();
      Assert.True(newCard.ToString().Length == 16);
    }

  }
}
