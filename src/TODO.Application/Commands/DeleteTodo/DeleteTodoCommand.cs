using MediatR;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Application.Commands.DeleteTodo;

public class DeleteTodoCommand : IRequest
{
    public Guid Id { get; init; }
}
