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

    public Account Account { get; set; }

    public CustomerHelperTests()
    {
      Sut = new CustomerHelper();

      Name = new Name()
      { First = "Frank",
        Last = "Sinatra"
      };

      Address = new Address()
      {
        Street = "4200 North Lois Ave",
        City = "Tampa",
        StateProvince = "FL",
        PostalCode = "33617"
      };

      Account = new Account()
      {
        InterestRate = .1738m,
        Amount = 60000.50m,
      };

      Card = new Card()
      {
        Pin = 6958,
        Account = new List<Account>()
        {Account }
      };

     sutC = new Customer()
      {
        Name = Name,
        Address = Address,
        Card = Card,
        Accounts = new List<Account>()
        {Account },
        UserName = "frank",
        Password = "Pass321",
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
    }

    [Fact]
    public void NameTest()
    {
      Assert.IsType<Name>(sutC.Name);
      Assert.IsType<string>(sutC.Name.First);
      Assert.IsType<string>(sutC.Name.Last);
    }

    [Fact]
    public void AddressTest()
    {
      Assert.IsType<Address>(sutC.Address);
      Assert.IsType<string>(sutC.Address.Street);
      Assert.IsType<string>(sutC.Address.City);
      Assert.IsType<string>(sutC.Address.StateProvince);
      Assert.IsType<string>(sutC.Address.PostalCode);
    }

    [Fact]
    public void CardTest()
    {
      Assert.IsType<Card>(sutC.Card);
      Assert.IsType<int>(sutC.Card.Pin);

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
      Assert.True(sugl.LastOrDefault().UserName == "frank");
      Assert.True(sugl.LastOrDefault().Password == "Pass321");

    }
    [Fact]
    public void Test_GetCustomerByUserName()
    {
      var actual = Sut.GetCustomerByUserName(sutC.UserName);

      Assert.True(actual.UserName == sutC.UserName);
    }

  }
}
