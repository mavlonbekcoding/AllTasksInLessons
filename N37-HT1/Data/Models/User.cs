namespace N37_HT1.Data.Models;

public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Status UserStatus { get; set; }
}
public enum Status
{
    Registered,
    Active,
    Deleted
}
