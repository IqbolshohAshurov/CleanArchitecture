using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatePublishingHouseMapper: Profile
{
    public CreatePublishingHouseMapper()
    {
        CreateMap<CreatePublishingHouseCommand, PublishingHouse>();
    }
}