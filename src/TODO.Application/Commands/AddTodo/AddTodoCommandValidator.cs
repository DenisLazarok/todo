using FluentValidation;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Application.Commands.AddTodo;

public class AddTodoCommandValidator : AbstractValidator<AddTodoCommand>
{
    private readonly List<string> _possibleColors = new List<string>()
    {
        "red",
        "blue",
        "green"
    };
    
    public AddTodoCommandValidator()
    {
        RuleFor(x => x.Category).Must(x => Enum.IsDefined(typeof(CategoryType), x)).WithMessage("Unknown category type!");
        RuleFor(x => x.Color).Must(x => _possibleColors.Contains(x)).WithMessage("Unknown color!");
    }
}
