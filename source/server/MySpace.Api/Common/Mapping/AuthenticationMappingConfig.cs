using Mapster;
using MySpace.Application.Services.Authentication.Commands.Register;
using MySpace.Application.Services.Authentication.Common;
using MySpace.Application.Services.Authentication.Queries.Login;
using MySpace.Contracts.Authentication;

namespace MySpace.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()                
                .Map(dest => dest, src => src.User);
    }
}