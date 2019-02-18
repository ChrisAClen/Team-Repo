using System.Linq;
using eMNY.Client.ViewModels;
using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMNY.Client.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Account()
        {
          return View();
        }

        public IActionResult Validation(Customer cust)
        {
          var uvm = new UserViewModel();
          var customer = uvm.GetCustomerByUserName(cust.UserName);

          if (customer == null)
          {
            return RedirectToAction("Login", "Home");
          }

          if (customer.Password != cust.Password)
          {
            return RedirectToAction("Login", "Home");
          }

          return RedirectToAction("Index", "Home");
        }

        public IActionResult Register(Customer cust)
        {
/*
          if (CustomerHelper.SetCustomer(cust))
          {
            var customer = CustomerHelper.GetCustomers().Where(u => u.UserName == cust.UserName).FirstOrDefault();
            
            HttpContext.Session.SetString("Username", customer.UserName);
            return RedirectToAction("Index", "Home");
          }
*/

          return RedirectToAction("Register", "Home");
        }
    }
}
