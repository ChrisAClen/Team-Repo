using eMNY.Domain.Abstracts;
using System;

namespace eMNY.Domain.Models
{
  public class Card
  {
    public long CardNumber { get; set; }
    public int SecurityNumber { get; set; }
    public Account Account { get; set; }
    public int Pin { get; set; }
    public DateTime ExpirationDate { get; set; }
  }
}
