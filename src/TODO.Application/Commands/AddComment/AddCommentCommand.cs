using MediatR;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Application.Commands.AddComment;

public class AddCommentCommand : IRequest<Guid>
{
    public Guid TodoId { get; set; }
    public string Text { get; init; } = string.Empty;
}
