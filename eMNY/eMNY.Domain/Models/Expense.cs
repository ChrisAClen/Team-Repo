using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Expense : AThing
  {
    public string ExpenseName { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public DateTime ExpenseDate { get; set; }

    public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this) &&
      Validator.ValidateMoney(this);
    }

    public decimal SetExpense()
    {
      return Amount;
    }
  }
}

