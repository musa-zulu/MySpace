using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using MySpace.Contracts.Authentication;
using MediatR;
using MySpace.Application.Authentication.Common;
using MySpace.Application.Authentication.Queries.Login;
using MySpace.Application.Authentication.Commands.Register;
using MapsterMapper;
using Microsoft.AspNetCore.Authorization;

namespace MySpace.Api.Controllers;

[Route("auth")]
[AllowAnonymous]
public class AuthenticationController : ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public AuthenticationController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = _mapper.Map<RegisterCommand>(request);        
        ErrorOr<AuthenticationResult> registerResult = await _mediator.Send(command);

        return registerResult.Match(
            authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
            errors => Problem(errors)
        );
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = _mapper.Map<LoginQuery>(request);
        var authResult = await _mediator.Send(query);

        if (authResult.IsError && authResult.FirstError == Domain.Common.Errors.Authentication.InvalidCredentials)
        {
            return Problem(statusCode: StatusCodes.Status401Unauthorized,
            title: authResult.FirstError.Description);
        }
        return authResult.Match(authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)), errors => Problem(errors));
    }
}