using FluentValidation;
using TODO.Application.Commands.AddTodo;

namespace TODO.Application.Commands.DeleteTodo;

public class DeleteTodoCommandValidator : AbstractValidator<AddTodoCommand>
{
    public DeleteTodoCommandValidator()
    {
    }
}
