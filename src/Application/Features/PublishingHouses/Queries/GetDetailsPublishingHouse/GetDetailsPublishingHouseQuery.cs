using MediatR;

namespace Application.Features.PublishingHouses.Queries.GetDetailsPublishingHouse;

public class GetDetailsPublishingHouseQuery: IRequest<PublishingHouseViewModel>
{
    public Guid Id { get; set; }

    public GetDetailsPublishingHouseQuery(Guid id)
    {
        Id = id;
    }

    public GetDetailsPublishingHouseQuery()
    {
        
    }
}