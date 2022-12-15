using FluentValidation;
using TODO.Application.Commands.AddTodo;

namespace TODO.Application.Commands.UpdateTodoHeader;

public class UpdateTodoHeaderCommandValidation: AbstractValidator<UpdateTodoHeaderCommand>
{
    public UpdateTodoHeaderCommandValidation()
    {
    }
}
