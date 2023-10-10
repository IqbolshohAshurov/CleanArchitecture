using MediatR;

namespace Application.Features.Genres.Commands.CreateGenre;

public class CreateGenreCommand: IRequest<bool>
{
    public CreateGenreCommand() { }

    public CreateGenreCommand(string title)
    {
        Title = title;
    }
    public string Title { get; set; }
}