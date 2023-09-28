using Domain.Common;
using Domain.Entities;

namespace Domain.Events.BookEvents;

public class BookDeletedEvent: BaseEvent
{
    public BookDeletedEvent(Book book)
    {
        Book = book;
    }

    public Book Book { get; set; }
}