using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace eMNY.Client.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Login()
        {
          return View();
        }

        public IActionResult Validation(Customer cust)
        {
          var customer = CustomerHelper.GetCustomerByUserName(cust.UserName);
          if (customer == null)
          {
            return RedirectToAction("Login", "Login");
          }
          
          if (customer.Password != cust.Password)
          {
            return RedirectToAction("Login", "Login");
          }
          return RedirectToAction("Index", "Home");
        }
        
    }
}