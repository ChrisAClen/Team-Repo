using System.Collections.Generic;
using eMNY.Code.Helpers;
using edm = eMNY.Domain.Models;

namespace eMNY.Client.ViewModels
{
  public class UserViewModel
  {
    public List<edm.Customer> GetCustomers()
    {
      var ch = new CustomerHelper();
      return ch.GetCustomers();
    }

    public bool ULogin(string username, string password)
    {
      return CustomerHelper.GetLogin(username, password);
    }

    internal bool Register(edm.Name name, string username, string password, string email)
    {
      var ch = new CustomerHelper();

      var cust = new edm.Customer
      {
        Name = name,
        UserName = username,
        Password = password,
        Email = email
      };
 
      return ch.SetCustomer(cust);
    }
  }
}
