using MySpace.Domain.Entities;

namespace MySpace.Application.Services.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);