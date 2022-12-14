using Ardalis.Specification;

namespace TODO.Domain.Interfaces;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
    
}
