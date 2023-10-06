using Domain.Entities;
using MediatR;

namespace Application.Features.Genres.Commands.CreateGenre;

public class CreatedGenreEvent: INotification
{
    public Genre Genre { get; set; }

    public CreatedGenreEvent()
    {
        
    }

    public CreatedGenreEvent(Genre genre)
    {
        Genre = genre;
    }
}