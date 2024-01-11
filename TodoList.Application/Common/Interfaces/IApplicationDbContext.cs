using Microsoft.EntityFrameworkCore;
using TodoList.Domain.Entities;

namespace TodoList.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<User> Users { get; }
    public DbSet<TodoItem> TodoItems { get; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
