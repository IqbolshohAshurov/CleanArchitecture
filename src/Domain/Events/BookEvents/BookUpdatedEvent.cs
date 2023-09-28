using Domain.Common;
using Domain.Entities;

namespace Domain.Events.BookEvents;

public class BookUpdatedEvent: BaseEvent
{
    public BookUpdatedEvent(Book book)
    {
        Book = book;
    }

    public Book Book { get; set; }
}