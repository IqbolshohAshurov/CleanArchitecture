using Domain.Common;
using Domain.Entities;

namespace Domain.Events.BookEvents;

public class BookCreatedEvent: BaseEvent
{
    public BookCreatedEvent(Book book)
    {
        Book = book;
    }

    public Book Book { get; set; }
}