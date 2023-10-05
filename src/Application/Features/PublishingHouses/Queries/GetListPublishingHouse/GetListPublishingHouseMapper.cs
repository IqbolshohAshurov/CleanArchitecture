using AutoMapper;
using Domain.Entities;

namespace Application.Features.PublishingHouses.Queries.GetListPublishingHouse;

public class GetListPublishingHouseMapper: Profile
{
    public GetListPublishingHouseMapper()
    {
        CreateMap<PublishingHouse, PublishingHouseVm>();
    }
}