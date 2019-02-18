using System.Collections.Generic;
using eMNY.Code.Helpers;
using edm = eMNY.Domain.Models;

namespace eMNY.Client.ViewModels
{
  public class UserViewModel
  {
    public CustomerHelper ch;

    public List<edm.Customer> GetCustomers()
    {
      return ch.GetCustomers();
    }
     
    public edm.Customer GetCustomerByUserName(string username)
    {
      return ch.GetCustomerByUserName(username);
    }

    public bool ULogin(string username, string password)
    {
      return ch.GetLogin(username, password);
    }

    internal bool Register(edm.Name name, string username, string password, string email)
    {

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
