using ErrorOr;
using MediatR;
using MySpace.Application.Services.Authentication.Common;

namespace MySpace.Application.Services.Authentication.Queries.Login;
public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;