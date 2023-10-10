using Domain.Entities;
using MediatR;

namespace Application.Features.Books.Commands.UpdateBook;

public class UpdatedBookEvent: INotification
{
    public UpdatedBookEvent() { }

    public UpdatedBookEvent(Book book) => Book = book;
    
    public Book Book { get; init; }
}