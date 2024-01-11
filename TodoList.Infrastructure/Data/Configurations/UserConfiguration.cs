using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoList.Domain.Entities;

namespace TodoList.Infrastructure.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasIndex(u => u.Login).IsUnique();

        builder.HasMany(u => u.TodoItems).WithOne(ti => ti.User).HasForeignKey(ti => ti.UserId);

        builder.Property(u => u.Id).HasColumnName("user_id");
        builder.Property(u => u.Name).HasColumnName("name");
        builder.Property(u => u.Login).HasColumnName("login");
        builder.Property(u => u.Password).HasColumnName("password");
    }
}
