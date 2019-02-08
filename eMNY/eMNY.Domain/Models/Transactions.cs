using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Transactions : AThing
  {
    public int CustomerId { get; set; }
    public int AccountId { get; set; }
    public decimal TransactionAmount { get; set; }
    public DateTime TransactionDate { get; set; }
    public bool IsDeposit { get; set; }

    public override bool IsValid()
    {
      return 
      Validator.ValidateNumber(this) &&
      Validator.ValidateMoney(this) &&
      (TransactionDate != null);
    }

       
  }
}
