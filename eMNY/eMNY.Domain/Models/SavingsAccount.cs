using System;
using eMNY.Domain.Abstracts;

namespace eMNY.Domain.Models
{
  public class SavingsAccount : Account
  {
    public double SavingsId { get; set; }

     public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this);
    }
  }
}
