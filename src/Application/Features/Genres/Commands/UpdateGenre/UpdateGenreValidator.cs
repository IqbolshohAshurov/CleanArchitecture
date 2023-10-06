using System.Data;
using FluentValidation;

namespace Application.Features.Genres.Commands.UpdateGenre;

public class UpdateGenreValidator: AbstractValidator<UpdateGenreCommand>
{
    public UpdateGenreValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty();
        RuleFor(x => x.Name).NotNull().NotEmpty();
    }
}