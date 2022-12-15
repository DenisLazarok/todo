using System.Collections.ObjectModel;
using TODO.Domain.Entities.TodoAggregate;

namespace TODO.Application.Models;

public class TodoVm : BaseVm
{
    public string Header { get; private set; } = string.Empty;
    
    public DateTime CreateDate { get; private set; } = DateTime.Now;

    public bool IsCompleted { get; private set; } = false;
    
    public CategoryType Category { get; private set; }

    public ReadOnlyCollection<CommentVm> Comments { get; private set; }
    
    public string Color { get; init; } = string.Empty;

    public string Hash { get; set; } = string.Empty;
}
