namespace TodoList.Domain.Entities;

public class TodoItem
{
    public Guid Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public Guid UserId { get; set; }

    public virtual User? User { get; set; }
}
