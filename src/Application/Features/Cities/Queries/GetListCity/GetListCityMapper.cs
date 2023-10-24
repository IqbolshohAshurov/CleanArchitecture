using System.Drawing;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Cities.Queries.GetListCity;

public class GetListCityMapper: Profile
{
    public GetListCityMapper()
    {
        CreateMap<City, CityViewModel>();
    }
}