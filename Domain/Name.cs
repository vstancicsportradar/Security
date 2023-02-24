namespace Domain;

public class Name
{
    private Name(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Name Create(string value) => new Name(value);
}