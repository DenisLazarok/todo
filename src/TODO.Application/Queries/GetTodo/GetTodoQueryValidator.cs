using FluentValidation;

namespace TODO.Application.Queries.GetTodo;

public class GetTodoQueryValidator : AbstractValidator<GetTodoQuery>
{
    public GetTodoQueryValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEqual(Guid.Empty).WithMessage("Id field cant be empty");
    }
}
