using TODO.Domain.Entities.CommentAggregate;
using TODO.Domain.Extensions;
using TODO.Domain.Interfaces;

namespace TODO.Domain.Entities.TodoAggregate;

public class Todo : BaseEntity, IAggregateRoot
{
    #pragma warning disable CS8618 // for automapper
    private Todo()
    {
        IsCompleted = false;
    }
    
    public Todo(string header, CategoryType category, string color) 
    {
        Header = header;
        Category = category;
        Color = color;
    }
    
    public Todo(string header, CategoryType category, string color, List<Comment> comments)
    {
        Header = header;
        Category = category;
        Color = color;
        Comments = comments;   
    }

    public string Header { get; private set; }
    
    public DateTime CreateDate { get; private set; } = DateTime.Now;
    
    public bool IsCompleted { get; private set; }
    
    public CategoryType Category { get; private set; }

    public List<Comment> Comments { get; private set; } = new List<Comment>();
    
    public string Color { get; init; }


    public void UpdateHeader(string newValue)
    {
        Header = newValue;
    }
}
