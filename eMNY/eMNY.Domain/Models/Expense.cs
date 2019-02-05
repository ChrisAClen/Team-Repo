using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Expense: AThing
  {
    public int UserId { get; set; }
    public int AccountId { get; set; }

    public string ExpenseName { get; set; }
    public double TargetBalance { get; set; }
    public double CurrentBalance { get; set; }

    public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this) &&
      Validator.ValidateMoney(this);
    }
  }
}
