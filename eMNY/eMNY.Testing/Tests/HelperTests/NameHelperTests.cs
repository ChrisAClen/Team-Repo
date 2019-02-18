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
  public class NameHelperTests
  {
    public NameHelper Sut { get; set; }
    public Name sua { get; set; }

    public NameHelperTests()
    {


      Sut = new NameHelper();

      sua = new Name()
      {
        First = "Jane",
        Last = "Doe"
   
      };
    }

    [Fact]
    public void Test_SetName()
    {
      Assert.NotNull(sua);
    }

    [Fact]
    public void Test_GetName()
    {
      var sugl = Sut.GetNames();

      Assert.NotNull(sugl);
      Assert.True(sugl.FirstOrDefault().First == "Frank");
      Assert.True(sugl.FirstOrDefault().Last == "Sinatra");
    }
  }
}
