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
  public class CustomerHelperTests
  {
    public CustomerHelper Sut { get; set; }
    public Customer sua { get; set; }

    [Fact]
    public void Test_SetCustomer()
    {
      Assert.True(Sut.SetCustomer(sua));
    }

    [Fact]
    public void Test_GetCustomer()
    {
      var sugl = Sut.GetCustomers();

      Assert.NotNull(sugl);
      Assert.True(sugl.FirstOrDefault().UserName == "701 Cherry Lane");
      Assert.True(sugl.Last().Password == "76140");
    }
  }
}
