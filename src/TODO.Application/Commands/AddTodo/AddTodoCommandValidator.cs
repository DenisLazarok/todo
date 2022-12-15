using FluentValidation;

namespace TODO.Application.Commands.AddTodo;

public class AddTodoCommandValidator : AbstractValidator<AddTodoCommand>
{
    public AddTodoCommandValidator()
    {
        //TODO add enum validation
    }
}
