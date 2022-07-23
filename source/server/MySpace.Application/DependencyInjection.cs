using Microsoft.Extensions.DependencyInjection;
using MySpace.Application.Services.Authentication;

namespace MySpace.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
