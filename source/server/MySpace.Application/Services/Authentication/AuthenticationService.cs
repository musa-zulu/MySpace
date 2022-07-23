using MySpace.Application.Common.Interfaces.Authentication;
using MySpace.Application.Common.Interfaces.Persistence;
using MySpace.Domain.Entities;

namespace MySpace.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // validate the user doesn't exist
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("user with given email already exists.");
        }

        // Create a user (generate unique ID) and persist to DB
        var user = new User 
        { 
            FirstName = firstName,
            LastName =lastName,
            Email = email,
            Password = password            
        };

        _userRepository.AddUser(user);

        // Create JWT token        
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(
            user,                        
            token
        );
    }

    public AuthenticationResult Login(string email, string password)
    {
        // Validate user exists
        if (_userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User with given email does not exist.");
        }
        
        // Validate the password is correct 
        if (user.Password != password)
        {
            throw new Exception("Invalid password.");
        }

        // Create JWT token  
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );
    }
}