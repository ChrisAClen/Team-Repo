using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class AddressTests
  {
    private readonly Address sut;

    AddressHelper ah = new AddressHelper();


    public AddressTests()
    {
      sut = new Address()
      {
        Street = "701 Cherry Lane",
        City = "Fort Worth",
        StateProvince = "TX",
        PostalCode = "76140"
      };
    }

    [Fact]
    public void Test_AddressProperties()
    {
      Assert.IsType<string>(sut.Street);
      Assert.IsType<string>(sut.City);
      Assert.IsType<string>(sut.StateProvince);
      Assert.IsType<string>(sut.PostalCode);
    }
  }
}
