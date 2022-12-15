using FluentValidation;
using TODO.Application.Queries.GetTodoList;

namespace TODO.Application.Queries.GetCommentListByTodo;

public class GetCommentListByTodoQueryValidator : AbstractValidator<GetTodoListQuery>
{
    public GetCommentListByTodoQueryValidator()
    {
        
    }
}
