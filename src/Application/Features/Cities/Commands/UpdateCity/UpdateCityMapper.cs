using AutoMapper;
using Domain.Entities;

namespace Application.Features.Cities.Commands.UpdateCity;

public class UpdateCityMapper: Profile
{
    public UpdateCityMapper()
    {
        CreateMap<UpdateCityCommand, City>();
    }
}