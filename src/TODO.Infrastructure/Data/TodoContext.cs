using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Infrastructure.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options) {}

    public DbSet<Todo> Baskets { get; set; }
    public DbSet<Comment> CatalogItems { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
