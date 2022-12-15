using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Infrastructure.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
    }
    
    public DbSet<Todo> Todos { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
