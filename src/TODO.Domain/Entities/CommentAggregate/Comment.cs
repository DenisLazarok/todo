using TODO.Domain.Interfaces;

namespace TODO.Domain.Entities.CommentAggregate;

public class Comment : BaseEntity, IAggregateRoot
{
    public Comment(int todoId, string text)
    {
        TodoId = todoId;
        Text = text;
    }

    public int TodoId { get; set; }
    public string Text { get; set; }
}
