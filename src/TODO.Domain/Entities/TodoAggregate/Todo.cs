using TODO.Domain.Extensions;
using TODO.Domain.Interfaces;

namespace TODO.Domain.Entities.TodoAggregate;

public class Todo : BaseEntity, IAggregateRoot
{
    public Todo(string header, DateTime createDate, bool isCompleted, CategoryType category, string color)
    {
        Header = header;
        CreateDate = createDate;
        IsCompleted = isCompleted;
        Category = category;
        Color = color;
    }

    public string Header { get; init; }
    
    public DateTime CreateDate { get; init; } = DateTime.Now;
    
    public bool IsCompleted { get; init; }
    
    public CategoryType Category { get; init; }
    
    public string Color { get; init; }

    public override int GetHashCode()
    {
        return Header.ToMd5();
    }
}
