using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TODO.Api.Controllers;

public class BaseController : ControllerBase
{
    protected IMediator _mediator;

    public BaseController(IMediator mediator)
    {
        _mediator = mediator;
    }
}
