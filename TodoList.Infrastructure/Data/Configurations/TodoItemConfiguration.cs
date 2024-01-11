using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoList.Domain.Entities;

namespace TodoList.Infrastructure.Data.Configurations;

public class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
{
    public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        builder.ToTable("todo_items");

        builder.Property(ti => ti.Id).HasColumnName("todo_item_id");
        builder.Property(ti => ti.Content).HasColumnName("content");
        builder.Property(ti => ti.IsCompleted).HasColumnName("is_completed");
        builder.Property(ti => ti.UserId).HasColumnName("user_id");
    }
}
