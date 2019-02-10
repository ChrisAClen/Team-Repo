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

        ExpirationDate = DateTime.Now,
        CardNumber = 1738999900001111,
        Pin = 0123,
        SecurityNumber = 345
      };
    }

  }
}
