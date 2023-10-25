using FluentValidation;

namespace Application.Features.Users.Commands.Register;

public class RegisterValidator: AbstractValidator<RegisterCommand>
{
    public RegisterValidator()
    {
        RuleFor(x => x.UserName).NotNull().NotEmpty();
    }
}