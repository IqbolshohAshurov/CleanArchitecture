using Domain.Entities;
using MediatR;

namespace Application.Features.Genres.Commands.DeleteGenre;

public class DeletedGenreEvent: INotification
{
    public Genre Genre { get; set; }

    public DeletedGenreEvent()
    {
        
    }

    public DeletedGenreEvent(Genre genre)
    {
        Genre = genre;
    }
}