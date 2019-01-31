using System;
namespace eMNY.Domain.Abstracts
{
  public abstract class Account
  {
    public int Id { get; set; }
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
    public bool IsChecking { get; set; }
    public DateTime CreationDate { get; set; }
    public double InterestRate { get; set; }
  }
}
