namespace Domain;

public class Email
{
    private Email(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Email Create(string value) => new Email(value);
}