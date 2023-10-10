using Domain.Entities;
using MediatR;

namespace Application.Features.Books.Commands.CreateBook;

public class CreatedBookEvent: INotification
{
    public CreatedBookEvent() {}

    public CreatedBookEvent(Book book) => Book = book;
    
    public Book Book { get; init; }
}