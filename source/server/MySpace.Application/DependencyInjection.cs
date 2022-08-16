using ErrorOr;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MySpace.Application.Common.Behavious;
using MySpace.Application.Authentication.Commands.Register;
using MySpace.Application.Authentication.Common;
namespace MySpace.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {        
        services.AddMediatR(typeof(DependencyInjection).Assembly);
        services.AddScoped<IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>,ValidateRegisterCommandBehavior>();
        return services;
    }
}
