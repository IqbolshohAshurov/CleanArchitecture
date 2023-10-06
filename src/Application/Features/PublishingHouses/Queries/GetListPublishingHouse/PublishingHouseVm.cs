namespace Application.Features.PublishingHouses.Queries.GetListPublishingHouse;

public class PublishingHouseVm
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public Guid CityId { get; set; }

    public PublishingHouseVm()
    {
        
    }

    public PublishingHouseVm(Guid id, string name, Guid cityId)
    {
        Id = id;
        Name = name;
        CityId = cityId;
    }
}