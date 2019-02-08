using System.Collections.Generic;
using eMNY.Domain.Abstracts;

namespace eMNY.Domain.Models
{
  public class CheckingAccount : Account
  {
    public CheckingAccount(decimal balance) : base(Balance)
    {
      
    }
    
    public int CheckingId{ get; set; }
    public List<Expense> Expenses { get; set; }

     public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this);
    }

     
  }
}
