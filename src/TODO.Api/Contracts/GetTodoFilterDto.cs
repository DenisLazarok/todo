namespace TODO.Api.Contracts;

public class GetTodoFilterDto
{
    /// <summary>
    /// List of ids
    /// </summary>
    public IEnumerable<Guid> Ids { get; set; } = new List<Guid>();
    
    /// <summary>
    /// header
    /// </summary>
    public string? Header { get; set; }
}
