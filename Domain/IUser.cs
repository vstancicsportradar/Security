namespace Domain;

public interface IUser : IAggregateRoot
{
    Name Name { get; }
    Email Email { get; }
    void SetName(string name);
    void SetEmail(string email);
}