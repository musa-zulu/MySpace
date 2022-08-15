using ErrorOr;
using MediatR;
using MySpace.Application.Services.Authentication.Common;

namespace MySpace.Application.Services.Authentication.Commands.Register;
public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;