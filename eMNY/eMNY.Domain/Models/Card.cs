using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace eMNY.Domain.Models
{
  public class Card : AThing
  {
    public long CardNumber { get; set; }
    public int SecurityNumber { get; set; }
    public List<Account> Account { get; set; }
    public int Pin { get; set; }
    public DateTime ExpirationDate { get; set; }

    public override bool IsValid()
    {
      return 
      Validator.ValidateNumber(this) &&
      (Account != null) &&
      (ExpirationDate != null);

    }
  }
}
