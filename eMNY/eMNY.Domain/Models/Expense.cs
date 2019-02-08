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
    public decimal TargetBalance { get; set; }
    public decimal CurrentBalance { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime TargetDate { get; set; }




    public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this) &&
      Validator.ValidateMoney(this);
    }
  }
}
