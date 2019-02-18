using eMNY.Code;
using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }

    [Fact]
    public void Test_GetAddress()
    {
      var sugl = Sut.GetAddress();

      Assert.NotNull(sugl);
      Assert.True(sugl.FirstOrDefault().Street == "701 Cherry Lane");
      Assert.True(sugl.Last().PostalCode== "76140");
    }

  }
}
