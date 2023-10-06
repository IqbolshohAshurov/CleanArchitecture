using AutoMapper;
using Domain.Entities;

namespace Application.Features.Cities.Queries.GetDetailCity;

public class GetDetailsCityMapper: Profile
{
    public GetDetailsCityMapper()
    {
        CreateMap<City, CityVm>();
    }
}