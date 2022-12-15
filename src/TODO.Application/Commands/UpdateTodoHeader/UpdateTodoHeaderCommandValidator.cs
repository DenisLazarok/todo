using System.Data;
using FluentValidation;
using TODO.Application.Commands.AddTodo;

namespace TODO.Application.Commands.UpdateTodoHeader;

public class UpdateTodoHeaderCommandValidation : AbstractValidator<UpdateTodoHeaderCommand>
{
    public UpdateTodoHeaderCommandValidation()
    {
        RuleFor(x => x.Id).NotNull().NotEqual(Guid.Empty).WithMessage("Id field cant be empty");
        RuleFor(x => x.Header).NotNull().NotEmpty().WithMessage("Header field cant be empty");
    }
}
