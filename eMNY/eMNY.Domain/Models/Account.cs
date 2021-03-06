using eMNY.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Account : AThing
  {
    public int AccountNumber { get; set; }
    public static decimal Balance { get; set; }
    public bool IsChecking { get; set; }
    public DateTime CreationDate { get; set; }
    public decimal InterestRate { get; set; }
    public decimal Amount { get; set; }
    public List<Expense> Expenses { get; set; }


    public Account()
    {
      int acn = CreateAccountNumber();
      AccountNumber = acn;
      CreationDate = DateTime.Now;
    }

    protected Account(decimal amt)
    {
      if (amt < 0)
        throw new ArgumentOutOfRangeException("amt", "Your balance must be more than $0");
      else
        Amount = amt;
    }

    public override bool IsValid()
    {
      return
      Validator.ValidateNumber(this) &&
      Validator.ValidateMoney(this) &&
      (CreationDate != null);
    }

    public decimal Withdraw()
    {
      if (Amount <= 0 || Balance > 0)
        return Amount;
      Balance -= Amount;
      return Balance;
    }

    public static decimal Withdraw(decimal amt)
    {
      if (amt <= 0 || Balance > 0)
        return amt;
      Balance -= amt;
      return Balance;
    }

    public decimal Deposit()
    {
      if (Amount <= 0)
        return Amount;
      Balance += Amount;
      return Balance;
    }

    public static decimal Deposit(decimal amt)
    {
      if (amt <= 0)
        return amt;
      Balance += amt;
      return Balance;
    }

    public int CreateAccountNumber()
    {
      Random rnd = new Random();
      int lead = 211;
      int RandNumb1 = rnd.Next(1000000, 9999999);

      AccountNumber = int.Parse(lead.ToString() + RandNumb1.ToString());
      return AccountNumber;
    }
  }
}
