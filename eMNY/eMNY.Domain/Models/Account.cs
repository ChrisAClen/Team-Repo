using eMNY.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Account : AThing
  {
    public int AccountNumber { get; set; }
    public static decimal Balance { get; private set; }
    public bool IsChecking { get; set; }
    public DateTime CreationDate { get; set; }
    public decimal InterestRate { get; set; }
    public decimal Amount { get; set; }
    public List<Expense> Expenses { get; set; }


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

    public decimal Deposit()
    {
      if (Amount <= 0)
        return Amount;
      Balance += Amount;
      return Balance;
    }

    public int CreateAccountNumber()
    {
      Random rnd = new Random();
      int lead = 711;
      int RandNumb1 = rnd.Next(0000000, 9999999);

      AccountNumber = int.Parse(lead.ToString() + RandNumb1.ToString());
      return AccountNumber;
    }
  }
}
