using Ardalis.Specification;

namespace TODO.Domain.Interfaces;

/// <summary>
/// repository for change data
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
    
}
