using System;
using System.Collections.Generic;
using System.Text;
using eMNY.Domain.Interfaces;

namespace eMNY.Domain.Abstracts
{
  public abstract class AThing: IThing
  {
    public int Id { get; private set; }
    public virtual bool IsValid()
    {
      return this.Id > 0;
    }
  }
}
