using MySpace.Domain.Entities;

namespace MySpace.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);