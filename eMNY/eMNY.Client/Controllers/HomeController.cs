﻿using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using eMNY.Client.Models;
using eMNY.Code.Helpers;
using eMNY.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using Newtonsoft.Json;

namespace eMNY.Client.Controllers
{
  public class HomeController : Controller
  {
    CustomerHelper ch = new CustomerHelper();

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }
    
    public IActionResult Login()
    {
      return View();
    }
    
    [HttpPost("Login")]
    public IActionResult Login(Login customer)
    {
      if (ModelState.IsValid)
      {
        var custInDb = ch.GetCustomers().FirstOrDefault(u => u.UserName == customer.Username);
        if (custInDb == null || customer.Password != custInDb.Password)
        {
          ModelState.AddModelError("Username", "Invalid Username/Password");
          return View("Login");
        }
        else
        {
          HttpContext.Session.SetString("Username", JsonConvert.SerializeObject(customer));
          return RedirectToAction("Index", "Home");
        }
      }
      else
      {
        return View("Login");
      }
    }
   
    public IActionResult Register()
    {
      return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
