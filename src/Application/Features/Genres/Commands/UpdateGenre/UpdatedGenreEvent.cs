using Domain.Entities;
using MediatR;

namespace Application.Features.Genres.Commands.UpdateGenre;

public class UpdatedGenreEvent: INotification
{
    public Genre Genre { get; set; }

    public UpdatedGenreEvent()
    {
        
    }

    public UpdatedGenreEvent(Genre genre)
    {
        Genre = genre;
    }
}