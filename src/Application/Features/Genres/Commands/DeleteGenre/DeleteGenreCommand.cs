using MediatR;

namespace Application.Features.Genres.Commands.DeleteGenre;

public class DeleteGenreCommand: IRequest<bool>
{
    public Guid Id { get; set; }

    public DeleteGenreCommand() { }

    public DeleteGenreCommand(Guid id)
    {
        Id = id;
    }
}