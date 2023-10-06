using AutoMapper;
using Domain.Entities;

namespace Application.Features.PublishingHouses.Queries.GetDetailsPublishingHouse;

public class GetDetailsPublishingHouseMapper: Profile
{
    public GetDetailsPublishingHouseMapper()
    {
        CreateMap<PublishingHouse, PublishingHouseVm>();
    }    
}