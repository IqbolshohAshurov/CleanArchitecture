using FluentValidation;

namespace Application.Features.Genres.Commands.CreateGenre;

public class CreateGenreValidator: AbstractValidator<CreateGenreCommand>
{
    public CreateGenreValidator()
    {
        RuleFor(x => x.Title).NotNull().NotEmpty().MaximumLength(50);
    }
}