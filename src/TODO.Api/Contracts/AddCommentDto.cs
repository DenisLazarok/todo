namespace TODO.Api.Contracts;

public class AddCommentDto
{
    /// <summary>
    /// Todo id
    /// </summary>
    public Guid TodoId { get; set; }
    
    /// <summary>
    /// Comment text
    /// </summary>
    public string Text { get; set; } = string.Empty;
}
