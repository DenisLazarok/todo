using AutoMapper;
using MediatR;
using TODO.Application.Common.Exceptions;
using TODO.Application.Models;
using TODO.Application.Queries.GetTodoList;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;
using TODO.Domain.Specifications;

namespace TODO.Application.Queries.GetTodo;

public class GetTodoQueryHandler : IRequestHandler<GetTodoQuery, TodoVm>
{
    private readonly IReadRepository<Todo> _todoRepository;
    private readonly IMapper _mapper;

    public GetTodoQueryHandler(IReadRepository<Todo> todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }

    public async Task<TodoVm> Handle(GetTodoQuery request, CancellationToken cancellationToken)
    {
        var todo = await _todoRepository.GetByIdAsync(request.Id, cancellationToken);
        
        if (todo is null)
            throw new NotFoundException(nameof(Todo), request.Id);

        return _mapper.Map<TodoVm>(todo);
    }
}
