using System;
using eMNY.Domain.Abstracts;

namespace eMNY.Domain.Models
{
  public class SavingsAccount : Account
  {
    public int SavingId { get; set; }
    public double Deposit { get; set; }
  }
}
