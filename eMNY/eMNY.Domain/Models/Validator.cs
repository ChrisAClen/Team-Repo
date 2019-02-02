using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace eMNY.Domain.Models
{
  public static class Validator
  {
    public static bool ValidateString(object o)
    {
      var props = o.GetType().GetProperties().ToList();

      foreach (var prop in props)
      {
        if (prop.GetType() == typeof(string))
        {
          if (string.IsNullOrWhiteSpace(prop.GetValue(prop).ToString()))
          {
            return false;
          }
        }
      }

      return true;
    }

    public static bool ValidateNumber(object o)
    {
      var props = o.GetType().GetProperties().ToList();

      foreach (var prop in props)
      {
        if (prop.GetType() == typeof(long) || prop.GetType() == typeof(int))
        {
          if ((long)prop.GetValue(prop) < 1)
          {
            return false;
          }
        }
      }

      return true;
    }

    public static bool ValidateMoney(object o)
    {
      var props = o.GetType().GetProperties().ToList();

      foreach (var prop in props)
      {
        if (prop.GetType() == typeof(decimal))
        {
          if ((decimal)prop.GetValue(prop) < 5M)
          {
            return false;
          }
        }
      }

      return true;
    }
  }
}
