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
    private readonly Customer sutC;
    public CustomerHelper Sut { get; set; }
    
    public Card Card { get; set; }
    public Name Name { get; set; }
    public Address Address { get; set; }

    public CustomerHelperTests()
    {

      Name = new Name()
      { First = "John", Last = "Smith" };

      Address = new Address()
      {
        Street = "3230 Banyan Cir",
        City = "Tampa",
        StateProvince = "FL",
        PostalCode = "33613"
      };

      Card = new Card()
      {
        Pin = 4444,
      };

      sutC = new Customer()
      {
        Name = Name,
        Address = Address,
        Card = Card,
        UserName = "cardib",
        Password = "Pass123",
        Email = "pass@email.com"
   
      };
    }

    [Fact]
    public void Test_SetCustomer()
    {
     
    }

    [Fact]
    public void Test_GetCustomer()
    {


    }

    [Fact]
    public void CustomerTest()
    {
      Assert.IsType<string>(sutC.UserName);
      Assert.NotNull(sutC.UserName);
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
      Assert.IsType<string>(Name.First);
      Assert.IsType<string>(Name.Last);
    }

    [Fact]
    public void AddressTest()
    {
      Assert.IsType<Address>(sutC.Address);
      Assert.IsType<string>(Address.Street);
      Assert.IsType<string>(Address.City);
      Assert.IsType<string>(Address.StateProvince);
      Assert.IsType<string>(Address.PostalCode);
    }

    [Fact]
    public void CardTest()
    {
      Assert.IsType<Card>(sutC.Card);
      Assert.IsType<int>(Card.Pin);
    }

  }
}
