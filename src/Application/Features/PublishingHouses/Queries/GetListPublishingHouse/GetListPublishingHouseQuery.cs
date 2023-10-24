using MediatR;

namespace Application.Features.PublishingHouses.Queries.GetListPublishingHouse;

public class GetListPublishingHouseQuery: IRequest<IEnumerable<PublishingHouseViewModel>>
{
    
}