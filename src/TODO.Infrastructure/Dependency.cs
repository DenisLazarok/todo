using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TODO.Infrastructure.Data;

namespace TODO.Infrastructure;

public static class Dependency
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TodoContext>(c =>
            c.UseNpgsql(configuration.GetConnectionString("TodoConnection")));

        return services;
    }
}
