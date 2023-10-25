using FluentValidation;

namespace Application.Features.Users.Queries.Login;

public class LoginValidator: AbstractValidator<LoginQuery>
{
    public LoginValidator()
    {
        RuleFor(x => x.UserName).NotNull().NotEmpty();
        RuleFor(x => x.Password).NotNull().NotEmpty();
    }
}