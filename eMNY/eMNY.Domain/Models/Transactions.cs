using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Transactions : AThing
  {
    public int AccountId { get; set; }
    public decimal TransactionAmount { get; set; }
    public DateTime TransactionDate { get; set; }

    public bool IsDeposit { get; set; }

    public Transactions()
    {

    }

    public Transactions(decimal amount, bool type)
    {
      TransactionDate = DateTime.Now;
      TransactionAmount = amount;
      IsDeposit = type;
    }

    public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this) &&
      Validator.ValidateMoney(this) &&
      (TransactionDate != null);
    }
  }
}

