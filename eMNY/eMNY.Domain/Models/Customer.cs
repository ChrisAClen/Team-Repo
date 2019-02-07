using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using System.Collections.Generic;

namespace eMNY.Domain.Models
{
  public class Customer : AThing
  {
    public Name Name { get; set; }
    public List<Transactions> Transactions { get; set; }
    public List<Account> Accounts { get; set; }
    public Card Card { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int AccountId { get; set; }
    

    public Customer()
    {
      Name = new Name();
      Card = new Card();
      Transactions = new List<Transactions>();
      Accounts = new List<Account>();
    }
    
    public override bool IsValid()
    {
      return 
      Validator.ValidateString(this) &&
      Validator.ValidateNumber(this) &&
      Name.IsValid() &&
      Card.IsValid();
    }
    
  }
}


