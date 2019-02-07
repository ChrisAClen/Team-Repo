using eMNY.Domain.Abstracts;
using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eMNY.Client.Models
{
  public class CustomerViewModel
  {
    public List<Customer> Users { get; set; }
    public List<Transactions> Transactions { get; set; }
    public List<Account> Accounts { get; set; }
    public Card Card { get; set; }

    [Required(ErrorMessage = "A User must be Inputted!")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "A Password is Required!")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Re-Enter Password!")]
    public string RePassword { get; set; }
    [Required(ErrorMessage = "An Email is Required!")]
    public string Email { get; set; }

    public int AccountID { get; set; }
    public int UserID { get; set; }


  }
}
