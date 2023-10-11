namespace ToDoList.Entities;

public class ToDo
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; }
}
