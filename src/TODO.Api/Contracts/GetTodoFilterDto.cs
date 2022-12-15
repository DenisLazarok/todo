namespace TODO.Api.Contracts;

public class GetTodoFilterDto
{
    public IEnumerable<Guid> Ids { get; set; } = new List<Guid>();
    public string? Header { get; set; }
}
