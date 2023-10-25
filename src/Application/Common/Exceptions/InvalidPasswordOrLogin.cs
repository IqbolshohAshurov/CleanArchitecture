namespace Application.Common.Exceptions;

public class InvalidPasswordOrLogin: Exception
{
    public InvalidPasswordOrLogin(string message) : base(message){ }
    
}