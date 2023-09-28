using Domain.Entities;
using MediatR;

namespace Application.Features.Books.Commands.DeleteBook;

public class DeletedBookEvent: INotification
{
    public Book Book { get; set; }

    public DeletedBookEvent()
    {
        
    }

    public DeletedBookEvent(Book book)
    {
        Book = book;
    }
}