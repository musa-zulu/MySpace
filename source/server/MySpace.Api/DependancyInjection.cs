using Microsoft.AspNetCore.Mvc.Infrastructure;
using MySpace.Api.Common.Errors;
using MySpace.Api.Common.Mapping;

namespace MySpace.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, MySpaceProblemDetailsFactory>();
        services.AddMappings();

        return services;
    }
}