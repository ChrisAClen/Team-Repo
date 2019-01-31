using eMNY.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Address: AThing
  {
    public string StreetName { get; set; }
    public int Zipcode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
  }
}
