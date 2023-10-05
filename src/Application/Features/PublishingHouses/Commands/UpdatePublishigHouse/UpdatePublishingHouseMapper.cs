using Application.Features.PublishingHouses.Commands.CreatePublishingHouse;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;

public class UpdatePublishingHouseMapper: Profile
{
    public UpdatePublishingHouseMapper()
    {
        CreateMap<UpdatePublishingHouseCommand, PublishingHouse>();
    }
}