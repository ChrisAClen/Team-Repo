using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using System;

namespace eMNY.Domain.Models
{
  public class Card : AThing
  {
    public long CardNumber { get; set; }
    public int SecurityNumber { get; set; }
    public Account Account { get; set; }
    public int Pin { get; set; }
    public DateTime ExpirationDate { get; set; }

    public override bool IsValid()
    {
      return 
      Validator.ValidateNumber(this) &&
      Account.IsValid() &&
      (ExpirationDate != null);

    }
  }
}
