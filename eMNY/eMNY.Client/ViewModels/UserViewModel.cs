using System.Collections.Generic;
using eMNY.Code.Helpers;
using edm = eMNY.Domain.Models;

namespace eMNY.Client.ViewModels
{
  public class UserViewModel
  {
    public List<edm.Customer> GetCustomers()
    {
      return CustomerHelper.GetCustomers();
    }
  }
}
