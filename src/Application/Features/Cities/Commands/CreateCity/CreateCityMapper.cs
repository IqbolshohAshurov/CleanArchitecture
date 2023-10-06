using AutoMapper;
using Domain.Entities;

namespace Application.Features.Cities.Commands.CreateCity;

public class CreateCityMapper: Profile
{
    public CreateCityMapper()
    {
        CreateMap<CreateCityCommand, City>();
    }
}