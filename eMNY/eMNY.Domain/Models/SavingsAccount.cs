using eMNY.Domain.Abstracts;

namespace eMNY.Domain.Models
{
  public class SavingsAccount : Account
  {
    public SavingsAccount(decimal balance) : base(Balance)
    {
      
    }
    public int SavingsId { get; set; }

     public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this);
    }
  }
}
