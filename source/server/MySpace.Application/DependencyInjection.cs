using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MySpace.Application.Common.Behavious;
using FluentValidation;

namespace MySpace.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {        
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}
