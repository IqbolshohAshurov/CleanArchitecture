using MediatR;

namespace Application.Features.Genres.Commands.UpdateGenre;

public class UpdateGenreCommand: IRequest<bool>
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public UpdateGenreCommand() { }

    public UpdateGenreCommand(Guid id, string title)
    {
        Id = id;
        Name = title;
    }
}