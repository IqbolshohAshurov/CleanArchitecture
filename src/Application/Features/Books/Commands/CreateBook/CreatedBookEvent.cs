using Domain.Entities;
using MediatR;

namespace Application.Features.Books.Commands.CreateBook;

public class CreatedBookEvent: INotification
{
    public CreatedBookEvent(Book book)
    {
        Book = book;
    }

    private Book Book { get; init; }

}