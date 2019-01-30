using System;
namespace eMNY.Domain.Abstracts
{
  public class Account
  {
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
    public bool IsChecking { get; set; }
  }
}
