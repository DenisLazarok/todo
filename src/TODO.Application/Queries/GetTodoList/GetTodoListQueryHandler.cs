using AutoMapper;
using MediatR;
using TODO.Domain.Entities.TodoAggregate;
using TODO.Domain.Interfaces;
using TODO.Domain.Specifications;

namespace TODO.Application.Queries.GetTodoList;

public class GetTodoListQueryHandler : IRequestHandler<GetTodoListQuery, List<TodoVm>>
{
    private readonly IReadRepository<Todo> _todoRepository;
    private readonly IMapper _mapper;

    public GetTodoListQueryHandler(IReadRepository<Todo> todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }

    public async Task<List<TodoVm>> Handle(GetTodoListQuery request, CancellationToken cancellationToken)
    {
        var specification = new TodoListFilterSpecification(request.Ids, request.Header);
        var todoList = await _todoRepository.ListAsync(specification, cancellationToken);
        
        return _mapper.Map<List<TodoVm>>(todoList);
    }
}
