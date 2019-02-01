using eMNY.Domain.Models;
using Xunit;

namespace eMNY.Testing.Tests
{
    public class CustomerTests
    {
        public CustomerTests()
        {
            var sut = new Customer
            {
                Name = "John Smith",
                UserName = "JSmith123",
                Password = "aPassword",
                Email = "jsmith@email.com"
            };
        }
    }
}