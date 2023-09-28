using Domain.Common;

namespace Domain.Entities;

public class City: BaseEntity
{
    public string Name { get; set; }

    public ICollection<PublishingHouse> PublishingHouses { get; set; } = new List<PublishingHouse>();
}