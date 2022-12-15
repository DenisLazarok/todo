using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Api.Contracts;

public class AddTodoDto
{
    /// <summary>
    /// Header
    /// </summary>
    public string Header { get; set; } = string.Empty;
    
    /// <summary>
    /// Category type
    /// Possible:
    /// Bookkeeping = 1,
    /// Analytics = 2
    /// Marketing = 3
    /// </summary>
    public CategoryType Category { get; set; }
    
    /// <summary>
    /// Color
    /// Possible:
    /// red
    /// blue
    /// green
    /// </summary>
    public string Color { get; set; } = string.Empty;
}
