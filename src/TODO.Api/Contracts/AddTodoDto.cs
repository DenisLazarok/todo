using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Api.Contracts;

public class AddTodoDto
{
    public string Header { get; set; }
    public CategoryType Category { get; set; }
    public string Color { get; set; }
}
