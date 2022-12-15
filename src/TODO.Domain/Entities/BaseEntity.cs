namespace TODO.Domain.Entities;

/// <summary>
/// base entity
/// </summary>
public abstract class BaseEntity
{
    public virtual Guid Id { get; protected set; }
}
