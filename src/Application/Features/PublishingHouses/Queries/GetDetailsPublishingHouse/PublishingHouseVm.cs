namespace Application.Features.PublishingHouses.Queries.GetDetailsPublishingHouse;

public class PublishingHouseVm
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public Guid CityId { get; set; }

    public PublishingHouseVm()
    {
        
    }

    public PublishingHouseVm(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}