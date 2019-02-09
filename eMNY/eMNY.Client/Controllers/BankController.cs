using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eMNY.Client.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Account()
        {
            return View("Account");
        }

        public IActionResult Budget()
        {
          return View("Budget");
        }

        public IActionResult History()
        {
          return View("History");
        }

        public IActionResult Transactions()
        {
          return View("Transaction");
        }
  }
}
