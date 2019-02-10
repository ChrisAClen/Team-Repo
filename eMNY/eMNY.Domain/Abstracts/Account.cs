using eMNY.Domain.Interfaces;
using System;
using System.Transactions;

namespace eMNY.Domain.Abstracts
{
  public abstract class Account : IAccount
  {
    public int Id { get; set; }
    public int AccountNumber { get; set; }
    public static decimal Balance { get; private set; }
    public bool IsChecking { get; set; }
    public DateTime CreationDate { get; set; }
    public decimal InterestRate { get; set; }
    public decimal Amount { get; set; }

     public virtual bool IsValid()
    {
      return this.Id > 0;
    }

     protected Account(decimal Amount)
     {
       if(Amount < 0)
         throw new ArgumentOutOfRangeException("Your balance must be more than $0");
     }

    public decimal Withdraw()
    {
      if (Amount <= 0 || Balance > 0)
        return Amount;
      Balance -= Amount;
      return Balance;
    }

    public decimal Deposit()
    {
      if (Amount <= 0)
        return Amount;
      Balance += Amount;
      return Balance;
    }

    public void CreateAccountNumber()
    {
      Random rnd = new Random();
      int lead = 711;
      int RandNumb1 = rnd.Next(0000000, 9999999);

      AccountNumber = int.Parse(lead.ToString() + RandNumb1.ToString());
      
    }
  }
}
