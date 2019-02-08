namespace eMNY.Domain.Interfaces
{
    public interface IAccount
    {
      int Id { get; }
      bool IsValid();
    }
}
