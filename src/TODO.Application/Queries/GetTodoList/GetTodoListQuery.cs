using MediatR;
using TODO.Application.Models;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Application.Queries.GetTodoList;

public class GetTodoListQuery : IRequest<List<TodoVm>>
{
    public IEnumerable<Guid> Ids { get; set; } = new List<Guid>();
    public string? Header { get; private set; }
}
