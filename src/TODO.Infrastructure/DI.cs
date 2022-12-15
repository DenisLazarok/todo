using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TODO.Infrastructure.Data;

namespace TODO.Infrastructure;

public static class DI
{
    public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
    {
        services.AddDbContext<TodoContext>(c =>
            c.UseNpgsql(configuration.GetConnectionString("TodoConnection")));
    }
}
