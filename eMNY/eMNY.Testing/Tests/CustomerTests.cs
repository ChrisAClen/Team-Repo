using eMNY.Domain.Models;
using Xunit;

namespace eMNY.Testing.Tests
{
  public class CustomerTests
  {
    private readonly Customer sut;
    private readonly Address sua;
    private readonly Card suc;

    public CustomerTests()
    {
      sut = new Customer()
      {
        Name = new Name() { First = "John", Last = "Smith" },
        UserName = "JSmith123",
        Password = "aPassword",
        Email = "jsmith@email.com",
        Address = new Address(),
        Card = new Card()

      };

      sua = new Address()
      {
        Street = "3230 Banyan Cir",
        City = "Tampa",
        StateProvince = "FL",
        PostalCode = "33613"
      };

      suc = new Card()
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
      Assert.IsType<string>(sua.Street);
      Assert.IsType<string>(sua.City);
      Assert.IsType<string>(sua.StateProvince);
      Assert.IsType<string>(sua.PostalCode);
      Assert.IsType<Card>(sut.Card);
      Assert.IsType<long>(suc.CardNumber);
      Assert.IsType<int>(suc.SecurityNumber);
      Assert.IsType<int>(suc.Pin);
    }
  }
}
