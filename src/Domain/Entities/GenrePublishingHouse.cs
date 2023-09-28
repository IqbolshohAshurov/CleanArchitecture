using Domain.Common;

namespace Domain.Entities;

public class GenrePublishingHouse: BaseEntity
{
    public Guid Id { get; set; }
    public Guid PublishingHouseId { get; set; }
    public PublishingHouse? PublishingHouse { get; set; }
    public Guid GenreId { get; set; }

    public Genre? Genre { get; set; }
}