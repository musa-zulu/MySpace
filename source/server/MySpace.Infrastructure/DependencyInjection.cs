using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySpace.Application.Common.Interfaces.Authentication;
using MySpace.Application.Common.Interfaces.Persistence;
using MySpace.Application.Common.Interfaces.Services;
using MySpace.Infrastructure.Authentication;
using MySpace.Infrastructure.Persistence;
using MySpace.Infrastructure.Services;

namespace MySpace.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                    ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
