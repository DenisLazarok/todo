using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;

namespace TODO.Domain.Entities.CommentAggregate;

public class Comment : BaseEntity, IAggregateRoot
{
    
#pragma warning disable CS8618 // for automapper
    private Comment()
#pragma warning restore CS8618
    {
        
    }
    public Comment(string text)
    {
        Text = text;
    }
    
    public Guid TodoId { get; private set; }
    public Todo? Todos { get; private set; }
    public string Text { get; private set; }
}
