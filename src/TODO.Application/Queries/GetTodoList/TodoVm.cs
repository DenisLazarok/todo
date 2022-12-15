using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Application.Queries.GetTodoList;

public class TodoVm : BaseVm
{
    public string Header { get; private set; }
    
    public DateTime CreateDate { get; private set; } = DateTime.Now;
    
    public bool IsCompleted { get; private set; }
    
    public CategoryType Category { get; private set; }

    public List<CommentVm> Comments { get; private set; } = new List<CommentVm>();
    
    public string Color { get; init; }

    public string Hash { get; set; }
}
