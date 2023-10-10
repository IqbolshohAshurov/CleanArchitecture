using Domain.Entities;
using MediatR;

namespace Application.Features.Books.Commands.DeleteBook;

public class DeletedBookEvent: INotification
{
    public DeletedBookEvent() {}

    public DeletedBookEvent(Book book) => Book = book;
    
    public Book Book { get; set; }
}