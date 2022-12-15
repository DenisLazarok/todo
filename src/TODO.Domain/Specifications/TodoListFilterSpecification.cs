using Ardalis.Specification;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Domain.Specifications;

/// <summary>
/// specification for todo filter
/// </summary>
public class TodoListFilterSpecification: Specification<Todo>
{
    public TodoListFilterSpecification(IEnumerable<Guid> ids, string? header)
    {
        Query.Include(x => x.Comments)
            .Where(x => (!ids.Any() || ids.Contains(x.Id)) && (string.IsNullOrEmpty(header) || x.Header.Contains(header)));
    }
}
