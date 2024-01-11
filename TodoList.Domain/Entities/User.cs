namespace TodoList.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public virtual ICollection<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
}
