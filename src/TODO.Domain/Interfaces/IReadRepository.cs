using Ardalis.Specification;

namespace TODO.Domain.Interfaces;

/// <summary>
/// repository for read data
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
    
}
