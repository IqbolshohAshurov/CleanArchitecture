using Domain.Common;

namespace Domain.Entities;

public class Genre: BaseEntity
{
    public string Title { get; set; }

    public ICollection<Book> Books = new List<Book>();
    public ICollection<PublishingHouse> PublishingHouses { get; set; } = new List<PublishingHouse>();
    public ICollection<GenrePublishingHouse> GenrePublishingHouses { get; set; } = new List<GenrePublishingHouse>();

}