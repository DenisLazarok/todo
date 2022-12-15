using MediatR;

namespace TODO.Application.Commands.UpdateTodoHeader;

public class UpdateTodoHeaderCommand : IRequest
{
    public Guid Id { get; init; }
    public string Header { get; set; } = string.Empty;
}
