using FluentValidation;
using TODO.Application.Queries.GetTodoList;

namespace TODO.Application.Queries.GetCommentListByTodo;

public class GetCommentListByTodoQueryValidator : AbstractValidator<GetCommentListByTodoQuery>
{
    public GetCommentListByTodoQueryValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEqual(Guid.Empty).WithMessage("Id field cant be empty");
    }
}
