using ErrorOr;
using MediatR;
using MySpace.Application.Authentication.Common;

namespace MySpace.Application.Authentication.Queries.Login;
public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;