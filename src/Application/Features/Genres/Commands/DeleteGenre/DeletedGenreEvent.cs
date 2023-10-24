using Domain.Entities;
using MediatR;

namespace Application.Features.Genres.Commands.DeleteGenre;

public class DeletedGenreEvent: INotification
{
    public DeletedGenreEvent() { }

    public DeletedGenreEvent(Genre genre)
    {
        Genre = genre;
    }

    public Genre Genre { get; set; }
}