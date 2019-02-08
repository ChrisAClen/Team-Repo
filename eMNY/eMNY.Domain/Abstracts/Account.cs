using eMNY.Domain.Interfaces;
using System;
namespace eMNY.Domain.Abstracts
{
  public abstract class Account : IAccount
  {
    public int Id { get; set; }
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
    public bool IsChecking { get; set; }
    public DateTime CreationDate { get; set; }
    public double InterestRate { get; set; }
    public double Deposit { get; set; }

     public virtual bool IsValid()
    {
      return this.Id > 0;
    }

  }
}
