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
    public Customer sutC { get; set; }
    public CustomerHelper Sut { get; set; }
    
    public Card Card { get; set; }
    public Name Name { get; set; }
    public Address Address { get; set; }

    public CustomerHelperTests()
    {
      Sut = new CustomerHelper();

      Name = new Name()
      { First = "John",
        Last = "Smith"
      };

      Address = new Address()
      {
        Street = "3230 Banyan Cir",
        City = "Tampa",
        StateProvince = "FL",
        PostalCode = "33613"
      };

      Card = new Card()
      {
        Pin = 4444
      };

     sutC = new Customer()
      {
        Name = Name,
        Address = Address,
        Card = Card,

        UserName = "michelle",
        Password = "Pass123",
        Email = "pass@email.com"
      };
    }

    [Fact]
    public void CustomerTest()
    {
      Assert.IsType<string>(sutC.UserName);
      Assert.NotNull(sutC.UserName);
      Assert.NotEmpty(sutC.UserName);
      Assert.IsType<string>(sutC.Password);
      Assert.NotNull(sutC.Password);
      Assert.IsType<string>(sutC.Email);
      Assert.NotNull(sutC.Email);
      Assert.IsType<Customer>(sutC);
      Assert.True(sutC.UserName == "michelle");
      Assert.True(sutC.Password == "Pass123");
      Assert.True(sutC.Email == "pass@email.com");

    }

    [Fact]
    public void NameTest()
    {
      Assert.IsType<Name>(sutC.Name);
      Assert.IsType<string>(sutC.Name.First);
      Assert.IsType<string>(sutC.Name.Last);
      Assert.True(sutC.Name.First == "John");
      Assert.True(sutC.Name.Last == "Smith");
    }

    [Fact]
    public void AddressTest()
    {
      Assert.IsType<Address>(sutC.Address);
      Assert.IsType<string>(sutC.Address.Street);
      Assert.IsType<string>(sutC.Address.City);
      Assert.IsType<string>(sutC.Address.StateProvince);
      Assert.IsType<string>(sutC.Address.PostalCode);
      Assert.True(sutC.Address.Street == "3230 Banyan Cir");
      Assert.True(sutC.Address.City == "Tampa");
      Assert.True(sutC.Address.StateProvince == "FL");
      Assert.True(sutC.Address.PostalCode == "33613");

    }

    [Fact]
    public void CardTest()
    {
      Assert.IsType<Card>(sutC.Card);
      Assert.IsType<int>(sutC.Card.Pin);
      Assert.True(sutC.Card.Pin == 4444);
      Assert.True(sutC.Card.CardNumber > 1738000000000000);
      Assert.True(sutC.Card.SecurityNumber > 100);

    }

    [Fact]
    public void Test_SetCustomer()
    {
      Assert.True(Sut.SetCustomer(sutC));
    }

    [Fact]
    public void Test_GetCustomer()
    {
      var sugl = Sut.GetCustomers();

      Assert.NotNull(sugl);
      Assert.True(sugl.FirstOrDefault().UserName == "michelle");
      Assert.True(sugl.FirstOrDefault().Password == "Pass123");

    }

  }
}
