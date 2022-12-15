using MediatR;
using TODO.Application.Models;
using TODO.Application.Queries.GetTodoList;

namespace TODO.Application.Queries.GetTodo;

public class GetTodoQuery : IRequest<TodoVm>
{
    public Guid Id { get; init; }
}
