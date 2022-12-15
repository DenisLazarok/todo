using AutoMapper;
using MediatR;
using TODO.Application.Commands.AddTodo;
using TODO.Application.Common.Exceptions;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;

namespace TODO.Application.Commands.DeleteTodo;

public class DeleteTodoCommandHandler : IRequestHandler<DeleteTodoCommand>
{
    private readonly IRepository<Todo> _todoRepository;
    private readonly IMapper _mapper;

    public DeleteTodoCommandHandler(IRepository<Todo> todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
    {
        var itemToDelete = await _todoRepository.GetByIdAsync(request.Id, cancellationToken);
        
        if (itemToDelete is null)
            throw new NotFoundException(nameof(Todo), request.Id);
        
        await _todoRepository.DeleteAsync(itemToDelete, cancellationToken);

        return Unit.Value;
    }
}
