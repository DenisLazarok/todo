using Ardalis.Specification;
using TODO.Domain.Entities.CommentAggregate;

namespace TODO.Domain.Specifications;

/// <summary>
/// specification for get comments by todo id
/// </summary>
public class CommentGetByTodoSpecification: Specification<Comment>
{
    public CommentGetByTodoSpecification(Guid id)
    {
        Query
            .Where(x => x.TodoId == id);
    }
}
