using AutoMapper;
using MediatR;
using TODO.Application.Commands.DeleteTodo;
using TODO.Application.Common.Exceptions;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;

namespace TODO.Application.Commands.UpdateTodoHeader;

public class UpdateTodoHeaderCommandHandler : IRequestHandler<UpdateTodoHeaderCommand>
{
    private readonly IRepository<Todo> _todoRepository;

    public UpdateTodoHeaderCommandHandler(IRepository<Todo> todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public async Task<Unit> Handle(UpdateTodoHeaderCommand request, CancellationToken cancellationToken)
    {
        var todo = await _todoRepository.GetByIdAsync(request.Id, cancellationToken);
        
        if (todo is null)
            throw new NotFoundException(nameof(Todo), request.Id);
        
        todo.UpdateHeader(request.Header);
        
        await _todoRepository.UpdateAsync(todo, cancellationToken);

        return Unit.Value;
    }
}
