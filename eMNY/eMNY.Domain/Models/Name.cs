using eMNY.Domain.Abstracts;
using eMNY.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace eMNY.Domain.Models
{
  public class Name
  {
    public string First { get; set; }
    public string Last { get; set; }
    public override bool IsValid()
    {
      return
      Validator.ValidateString(this);
    }
    
  }
}
