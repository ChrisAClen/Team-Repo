using System;
using eMNY.Domain.Abstracts;

namespace eMNY.Domain.Models
{
  public class CheckingAccount : Account
  {
    public int CheckingId { get; set; }
    public double Deposit { get; set; }
  }
}
