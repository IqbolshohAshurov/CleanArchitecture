using Domain.Common;
using Domain.Entities;

namespace Domain.Events.BookEvents;

public class BookCompletedEvent: BaseEvent
{
    public BookCompletedEvent(Book book)
    {
        Book = book;
    }

    public Book Book { get; set; }
}