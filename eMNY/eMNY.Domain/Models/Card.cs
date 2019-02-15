using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace eMNY.Domain.Models
{
  public class Card : AThing
  {
    public long CardNumber { get; set; }
    public int SecurityNumber { get; set; }
    public List<Account> Account { get; set; }
    public int Pin { get; set; }
    public DateTime ExpirationDate { get; set; }

    private Random rnd;

    public Card()
    {
      DateTime today = DateTime.Now;
      DateTime exp = today.AddYears(4);
      ExpirationDate = exp;
    }

    public override bool IsValid()
    {
      return 
      Validator.ValidateNumber(this) &&
      (Account != null) &&
      (ExpirationDate != null);
    }

    public long CreateCardNumber()
    {
      rnd = new Random();
      int lead = 1738;
      int RandNumb1 = rnd.Next(100000, 999999);
      int RandNumb2 = rnd.Next(100000, 999999);

      CardNumber = long.Parse(lead.ToString() + RandNumb1.ToString() + RandNumb2.ToString());
      

      return CardNumber;
    }

    public int CreateSecurityNumber()
    {
      rnd = new Random();
      int RandNumb = rnd.Next(100);
      SecurityNumber = int.Parse(RandNumb.ToString());
      return SecurityNumber;
    }


  }
}
