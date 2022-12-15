namespace TODO.Domain.Entities;

public abstract class BaseEntity
{
    public virtual Guid Id { get; protected set; }
}
