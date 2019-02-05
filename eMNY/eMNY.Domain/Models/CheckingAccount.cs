using System;
using eMNY.Domain.Abstracts;

namespace eMNY.Domain.Models
{
  public class CheckingAccount : Account
  {
    public double CheckingId{ get; set; }

     public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this);
    }
  }
}
