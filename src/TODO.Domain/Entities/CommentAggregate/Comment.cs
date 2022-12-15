using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;

namespace TODO.Domain.Entities.CommentAggregate;

public class Comment : BaseEntity, IAggregateRoot
{
    public Comment(string text)
    {
        Text = text;
    }
    
    public int TodoId { get; set; }
    public Todo? Todos { get; set; }
    public string Text { get; private set; }
}
