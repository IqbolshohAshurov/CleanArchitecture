using Domain.Common;

namespace Domain.Entities;

public class PublishingHouse: BaseEntity
{
    public string Name { get; set; }
    public Guid CityId { get; set; }

    public City City { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();
    public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    public ICollection<GenrePublishingHouse> GenrePublishingHouses { get; set; } = new List<GenrePublishingHouse>();

}