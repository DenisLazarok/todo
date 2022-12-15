using MediatR;
using TODO.Application.Models;

namespace TODO.Application.Queries.GetCommentListByTodo;

public class GetCommentListByTodoQuery : IRequest<List<CommentVm>>
{
    public GetCommentListByTodoQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}
