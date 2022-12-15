namespace TODO.Application.Queries.GetTodoList;

public class CommentVm : BaseVm
{
    public Guid TodoId { get; set; }
    public string Text { get; private set; }
}
