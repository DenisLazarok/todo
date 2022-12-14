using Ardalis.Specification;

namespace TODO.Domain.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
    
}
