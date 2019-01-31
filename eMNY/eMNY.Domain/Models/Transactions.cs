using eMNY.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Transactions : AThing
  {
    public int CustomerId { get; set; }
    public int AccountId { get; set; }
    public double TransactionAmount { get; set; }
    public DateTime TransactionDate { get; set; }
    public bool IsDeposit { get; set; }

  }
}
