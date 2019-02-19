using Microsoft.AspNetCore.Mvc;

namespace eMNY.Client.Controllers
{
    public class BankController : Controller
    {
        public IActionResult Account()
        {
          return View("Account");
        }

        public IActionResult Expense()
        {
          return View("Expense");
        }

        public IActionResult History()
        {
          return View("History");
        }

        public IActionResult Transactions()
        {
          return View("Transactions");
        }
  }
}
