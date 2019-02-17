using System.ComponentModel.DataAnnotations;

namespace eMNY.Client.Models
{
  public class Register
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Confirm { get; set; }
  }
}
