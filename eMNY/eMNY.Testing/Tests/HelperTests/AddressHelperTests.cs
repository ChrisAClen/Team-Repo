using eMNY.Code;
using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace eMNY.Testing.Tests.HelperTests
{
  public class AddressHelperTests
  {
    public AddressHelper Sut { get; set; }
    public Address sua { get; set; }

    public AddressHelperTests()
    {


      Sut = new AddressHelper();

      sua = new Address()
      {
        Street = "701 Cherry Lane",
        City = "Fort Worth",
        StateProvince = "TX",
        PostalCode = "76140"
      };
    }

    [Fact]
    public void Test_SetAddress()
    {
      Assert.True(Sut.SetAddress(sua));
    }

  }
}
