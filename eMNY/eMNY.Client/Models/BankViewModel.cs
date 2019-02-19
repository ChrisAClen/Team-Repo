using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace eMNY.Client.Models
{
  public class BankViewModel
  {
    public int AccountID { get; set; }
    public int AccountNumber { get; private set; }
    public decimal Balance { get; private set; }
    public DateTime Date { get; set; }
    public decimal InterestRate { get; set; }
    public decimal Amount { get; set; }
    public bool IsChecking { get; set; }

    public decimal TransactionAmount { get; set; }
    public DateTime TransactionDate { get; set; }
    public int CustomerId { get; set; }
    public bool IsDeposit { get; set; }






  }

}
