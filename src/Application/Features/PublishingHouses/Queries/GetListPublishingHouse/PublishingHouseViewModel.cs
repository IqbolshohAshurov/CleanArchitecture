namespace Application.Features.PublishingHouses.Queries.GetListPublishingHouse;

public class PublishingHouseViewModel
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public Guid CityId { get; set; }

    public PublishingHouseViewModel()
    {
        
    }

    public PublishingHouseViewModel(Guid id, string name, Guid cityId)
    {
        Id = id;
        Name = name;
        CityId = cityId;
    }
}