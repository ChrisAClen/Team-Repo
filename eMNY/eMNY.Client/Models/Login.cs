using System.ComponentModel.DataAnnotations;

namespace eMNY.Client.Models
{
  public class Login
  {
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
  }
}
