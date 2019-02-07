using eMNY.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMNY.Client.Models
{
  public class CustomerViewModel
  {
    public List<Customer> Users { get; set; }
    public int setting { get; set; }
    public string Name { get; set; }


  }
}
