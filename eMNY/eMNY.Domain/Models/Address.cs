using eMNY.Domain.Abstracts;


namespace eMNY.Domain.Models
{
  public class Address: AThing
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string PostalCode { get; set; }
       
    public override bool IsValid()
    {
      return
        Validator.ValidateString(this);
    }
  }
}
