namespace TODO.Application.Models;

public class CommentVm : BaseVm
{
    public Guid TodoId { get; set; }
    public string Text { get; private set; } = string.Empty;
}
