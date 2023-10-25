using Domain.Entities;

namespace Application.Common.Models;

public class AuthenticationResult
{
    public AuthenticationResult(User user, string token)
    {
        User = user;
        Token = token;
    }

    public User User { get; set; } 

    public string Token { get; set; }
};