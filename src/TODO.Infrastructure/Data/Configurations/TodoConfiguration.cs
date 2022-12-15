using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Infrastructure.Data.Configurations;

public class TodoConfiguration : IEntityTypeConfiguration<Todo>
{
    public void Configure(EntityTypeBuilder<Todo> builder)
    {
        builder.HasKey(b => b.Id);
        
        builder.HasIndex(x => new {x.Category, x.Header})
            .IsUnique();
        
        builder.Property(b => b.Category)
            .IsRequired();
        builder.Property(b => b.Header)
            .IsRequired();
        builder.Property(b => b.Color)
            .IsRequired();
    }
}
