using System.Reflection;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TODO.Application.Common.Behaviors;

namespace TODO.Application;

public static class Dependency
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services
            .AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
        services.AddTransient(typeof(IPipelineBehavior<,>),
            typeof(ValidationBehavior<,>));
        return services;
    }
   
}
