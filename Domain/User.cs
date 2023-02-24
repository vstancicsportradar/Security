namespace Domain;

public class User : IUser
{
    public User(Name name, Email email)
    {
        Name = name;
        Email = email;
    }

    public Name Name { get; private set; }
    public Email Email { get; private set; }

    public void SetName(string name) => Name = Name.Create(name);
    public void SetEmail(string email) => Email = Email.Create(email);

}