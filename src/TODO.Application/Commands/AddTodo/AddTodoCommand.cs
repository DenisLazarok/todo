using MediatR;
using TODO.Application.Queries.GetTodoList;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Application.Commands.AddTodo;

public class AddTodoCommand : IRequest<Guid>
{
    public string Header { get; init; } = string.Empty;
    public CategoryType Category { get; set; }
    public string Color { get; set; } = string.Empty;
}
