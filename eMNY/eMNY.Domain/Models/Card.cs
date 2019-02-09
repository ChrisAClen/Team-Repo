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

    public override bool IsValid()
    {
      return 
      Validator.ValidateNumber(this) &&
      (Account != null) &&
      (ExpirationDate != null);
    }

    public void CreateCardNumber()
    {
      Random rnd = new Random();
      int lead = 1738;
      int RandNumb1 = rnd.Next(0000, 9999);
      int RandNumb2 = rnd.Next(0000, 9999);
      int RandNumb3 = rnd.Next(0000, 9999);
      int RandNumb4 = rnd.Next(000);

      CardNumber = long.Parse(lead.ToString() + RandNumb1.ToString() + RandNumb2.ToString() + RandNumb3.ToString());
      SecurityNumber = int.Parse(RandNumb4.ToString());
    }
  }
}
