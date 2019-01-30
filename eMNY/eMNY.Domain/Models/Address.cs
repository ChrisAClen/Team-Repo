using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  class Address
  {
    string StreetName { get; set; }
    int Zipcode { get; set; }
    string City { get; set; }
    string State { get; set; }
  }
}
