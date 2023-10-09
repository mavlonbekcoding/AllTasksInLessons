namespace N50_HT1.Data.Model;

public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? OrderName { get; set; }
}
