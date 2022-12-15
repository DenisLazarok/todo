using FluentValidation;
using TODO.Application.Commands.AddTodo;

namespace TODO.Application.Commands.AddComment;

public class AddCommentCommandValidator : AbstractValidator<AddCommentCommand>
{
    public AddCommentCommandValidator()
    {
        RuleFor(x => x.Text).NotEmpty().NotNull().WithMessage("Text field cant be empty");
        RuleFor(x => x.TodoId).NotNull().NotEqual(Guid.Empty).WithMessage("Id field cant be empty");
    }
}
