namespace MySpace.Contracts.Authentication;

public record AuthintecationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);