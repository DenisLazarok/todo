using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using TODO.Domain.Interfaces;

namespace TODO.Infrastructure.Data;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(TodoContext dbContext) : base(dbContext)
    {
    }
}
