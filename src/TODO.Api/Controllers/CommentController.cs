using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TODO.Api.Contracts;
using TODO.Application.Commands.AddComment;
using TODO.Application.Models;
using TODO.Application.Queries.GetCommentListByTodo;

namespace TODO.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : BaseController
{
    private readonly IMapper _mapper;

    public CommentController(IMediator mediator, IMapper mapper) : base(mediator)
    {
        _mapper = mapper;
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IEnumerable<CommentVm>> GetByTodoId(Guid id)
    {
        var queryRequest = new GetCommentListByTodoQuery(id);
        var result = await _mediator.Send(queryRequest);
        return result;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<Guid> Add(AddCommentDto request)
    {
        var commandRequest = _mapper.Map<AddCommentCommand>(request);
        var result = await _mediator.Send(commandRequest);
        return result;
    }
}
