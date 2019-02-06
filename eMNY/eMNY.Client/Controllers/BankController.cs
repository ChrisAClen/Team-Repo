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
            return View();
        }

        public IActionResult Budget()
        {
          return View();
        }

        public IActionResult History()
        {
          return View();
        }

        public IActionResult Transactions()
        {
          return View();
        }
  }
}
