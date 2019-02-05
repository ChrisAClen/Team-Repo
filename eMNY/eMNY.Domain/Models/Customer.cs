using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;

namespace eMNY.Domain.Models
{
  public class Customer : AThing
  {
    public Name Name { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int AccountId { get; set; }
    public Card Card { get; set; }

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


