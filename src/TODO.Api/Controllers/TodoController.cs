using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TODO.Api.Contracts;
using TODO.Application.Commands.AddTodo;
using TODO.Application.Commands.DeleteTodo;
using TODO.Application.Commands.UpdateTodoHeader;
using TODO.Application.Models;
using TODO.Application.Queries.GetTodo;
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

    /// <summary>
    /// Get list todos
    /// </summary>
    /// <param name="request">filter</param>
    /// <returns>list of todos</returns>
    [HttpPost]
    [Route("[action]")]
    public async Task<IEnumerable<TodoVm>> GetList(GetTodoFilterDto request)
    {
        var queryRequest = _mapper.Map<GetTodoListQuery>(request);
        var result = await _mediator.Send(queryRequest);
        return result;
    }

    /// <summary>
    /// get todo
    /// </summary>
    /// <returns>todo</returns>
    [HttpGet]
    [Route("[action]")]
    public async Task<TodoVm> Get(Guid id)
    {
        var result = await _mediator.Send(new GetTodoQuery() {Id = id});
        return result;
    }

    /// <summary>
    /// Add todo
    /// </summary>
    /// <param name="request"></param>
    /// <returns>guid</returns>
    [HttpPost]
    [Route("[action]")]
    public async Task<Guid> Add(AddTodoDto request)
    {
        var commandRequest = _mapper.Map<AddTodoCommand>(request);
        var result = await _mediator.Send(commandRequest);
        return result;
    }

    /// <summary>
    /// delete todo
    /// </summary>
    /// <param name="id">Todo id</param>
    [HttpDelete]
    [Route("[action]")]
    public async Task Delete(Guid id)
    {
        await _mediator.Send(new DeleteTodoCommand() {Id = id});
    }

    /// <summary>
    /// Update header by todo id 
    /// </summary>
    /// <param name="id">Todo id</param>
    /// <param name="header">header</param>
    [HttpPatch]
    [Route("[action]")]
    public async Task UpdateHeader(Guid id, string header)
    {
        await _mediator.Send(new UpdateTodoHeaderCommand() {Id = id, Header = header});
    }
}
