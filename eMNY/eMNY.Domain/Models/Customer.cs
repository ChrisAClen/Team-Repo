using eMNY.Domain.Abstracts;
using System;
namespace eMNY.Domain.Models
{
  public class Customer : AThing
  {
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public int AddressId { get; set; }
    public int AccountId { get; set; }
  }
}
