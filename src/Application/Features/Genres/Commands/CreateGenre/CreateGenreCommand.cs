using MediatR;

namespace Application.Features.Genres.Commands.CreateGenre;

public class CreateGenreCommand: IRequest<bool>
{
    public string Title { get; set; }
}