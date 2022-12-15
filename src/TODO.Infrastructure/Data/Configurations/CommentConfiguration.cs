using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TODO.Domain.Entities.CommentAggregate;

namespace TODO.Infrastructure.Data.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(b => b.Id);

        builder.Property(b => b.Text)
            .IsRequired();

        builder.HasOne(x => x.Todos)
            .WithMany(x => x.Comments)
            .HasForeignKey(x => x.TodoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
