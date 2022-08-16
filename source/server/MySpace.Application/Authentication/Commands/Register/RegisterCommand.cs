using ErrorOr;
using MediatR;
using MySpace.Application.Authentication.Common;

namespace MySpace.Application.Authentication.Commands.Register;
public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;