using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TODO.Api.Contracts;
using TODO.Application.Commands.AddTodo;
using TODO.Application.Queries.GetTodoList;

namespace TODO.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : BaseController
{

    private readonly ILogger<TodoController> _logger;
    private readonly IMapper _mapper;

    public TodoController(IMediator mediator, ILogger<TodoController> logger, IMapper mapper) : base(mediator)
    {
        _logger = logger;
        _mapper = mapper;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IEnumerable<TodoVm>> Get(GetTodoFilterDto request)
    {
        var queryRequest = _mapper.Map<GetTodoListQuery>(request);
        var result = await _mediator.Send(queryRequest);
        return result;
    }
    
    [HttpPost]
    [Route("[action]")]
    public async Task<Guid> Add(AddTodoDto request)
    {
        var commandRequest = _mapper.Map<AddTodoCommand>(request);
        var result = await _mediator.Send(commandRequest);
        return result;
    }
}
