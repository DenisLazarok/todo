using Ardalis.Specification;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Domain.Specifications;

public class TodoListFilterSpecification: Specification<Todo>
{
    public TodoListFilterSpecification(IEnumerable<Guid> ids, string? header)
    {
        Query.Include(x => x.Comments)
            .Where(x => (!ids.Any() || ids.Contains(x.Id)) && (string.IsNullOrEmpty(header) || x.Header.Contains(header)));
    }
}
