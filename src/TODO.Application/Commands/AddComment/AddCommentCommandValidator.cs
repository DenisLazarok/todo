using FluentValidation;
using TODO.Application.Commands.AddTodo;

namespace TODO.Application.Commands.AddComment;

public class AddCommentCommandValidator : AbstractValidator<AddTodoCommand>
{
    public AddCommentCommandValidator()
    {
    }
}
