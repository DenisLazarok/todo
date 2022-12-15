using FluentValidation;
using TODO.Application.Commands.AddTodo;

namespace TODO.Application.Commands.DeleteTodo;

public class DeleteTodoCommandValidator : AbstractValidator<DeleteTodoCommand>
{
    public DeleteTodoCommandValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEqual(Guid.Empty).WithMessage("Id field cant be empty");
    }
}
