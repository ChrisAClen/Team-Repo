using eMNY.Domain.Models;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class CustomerTests
  {
    private readonly Customer sut;

    public CustomerTests()
    {
      sut = new Customer()
      {
        Name = new Name() { First = "John", Last = "Smith" },
        UserName = "JSmith123",
        Password = "aPassword",
        Email = "jsmith@email.com"
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
        CardNumber = 1234123412341234,
        SecurityNumber = 123,
        Pin = 1234
        //ExpirationDate = 

      };

    }

    [Fact]
    public void CustomerTest()
    {
      Assert.IsType<Name>(sut.Name);
      Assert.IsType<string>(sut.UserName);
      Assert.IsType<string>(sut.Password);
      Assert.IsType<string>(sut.Email);
      Assert.IsType<Address>(sut.Address);
      Assert.IsType<string>(sut.Street);
      Assert.IsType<string>(sut.City);
      Assert.IsType<string>(sut.StateProvince);
      Assert.IsType<string>(sut.PostalCode);
      Assert.IsType<Card>(sut.Card);
      Assert.IsType<long>(sut.CardNumber);
      Assert.IsType<int>(sut.SecurityNumber);
      Assert.Isype<int>(sut.Pin);
    }
  }
}
