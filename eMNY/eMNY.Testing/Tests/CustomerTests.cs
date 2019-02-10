using eMNY.Domain.Models;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class CustomerTests
  {
    private readonly Customer sut;
    public Name Name { get; set; }
    public Address Address { get; set; }
    public Card Card { get; set; }

    public CustomerTests()
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
        CardNumber = 1234123412341234,
        SecurityNumber = 123,
        Pin = 1234

      };

      sut = new Customer()
      {
        Name = Name,
        Address = Address,
        Card = Card,
        UserName = "JSmith123",
        Password = "aPassword",
        Email = "jsmith@email.com",
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
      Assert.IsType<string>(Address.Street);
      Assert.IsType<string>(Address.City);
      Assert.IsType<string>(Address.StateProvince);
      Assert.IsType<string>(Address.PostalCode);
      Assert.IsType<Card>(sut.Card);
      Assert.IsType<long>(Card.CardNumber);
      Assert.IsType<int>(Card.SecurityNumber);
      Assert.IsType<int>(Card.Pin);
    }
  }
}
