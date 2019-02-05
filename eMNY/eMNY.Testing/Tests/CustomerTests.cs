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
    }

    [Fact]
    public void CustomerTest()
    {
      Assert.IsType<Name>(sut.Name);
      Assert.IsType<string>(sut.UserName);
      Assert.IsType<string>(sut.Password);
      Assert.IsType<string>(sut.Email);
    }
  }
}
