using AutoMapper;
using MediatR;
using TODO.Application.Queries.GetTodoList;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;
using TODO.Domain.Specifications;

namespace TODO.Application.Commands.AddTodo;

public class AddTodoCommandHandler : IRequestHandler<AddTodoCommand, Guid>
{
    private readonly IRepository<Todo> _todoRepository;
    private readonly IMapper _mapper;

    public AddTodoCommandHandler(IRepository<Todo> todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(AddTodoCommand request, CancellationToken cancellationToken)
    {
        var todo = _mapper.Map<Todo>(request);
        await _todoRepository.AddAsync(todo, cancellationToken);

        return todo.Id;
    }
}
