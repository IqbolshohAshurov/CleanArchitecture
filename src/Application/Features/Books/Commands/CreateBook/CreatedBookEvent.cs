using Domain.Entities;
using MediatR;

namespace Application.Features.Books.Commands.CreateBook;

public class CreatedBookEvent: INotification
{
    private Book Book { get; init; }

    public CreatedBookEvent()
    {
        
    }
    public CreatedBookEvent(Book book)
    {
        Book = book;
    }
}