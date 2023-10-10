using MediatR;

namespace Application.Features.PublishingHouses.Queries.GetDetailsPublishingHouse;

public class GetDetailsPublishingHouseQuery: IRequest<PublishingHouseViewModel>
{
    public GetDetailsPublishingHouseQuery(Guid id)
    {
        Id = id;
    }

    public GetDetailsPublishingHouseQuery()
    {
        
    }

    public Guid Id { get; set; }
}