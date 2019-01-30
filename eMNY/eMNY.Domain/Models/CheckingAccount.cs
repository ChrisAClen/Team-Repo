using System;
using eMNY.Domain.Abstracts;

namespace eMNY.Domain.Models
{
  public class CheckingAccount : Account
  {
    public double Deposit { get; set; }
  }
}
