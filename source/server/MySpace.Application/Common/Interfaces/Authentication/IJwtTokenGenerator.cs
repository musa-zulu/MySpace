using MySpace.Domain.Entities;

namespace MySpace.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}