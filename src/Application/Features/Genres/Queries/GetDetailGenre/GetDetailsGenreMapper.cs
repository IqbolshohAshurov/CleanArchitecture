using AutoMapper;
using Domain.Entities;

namespace Application.Features.Genres.Queries.GetDetailGenre;

public class GetDetailsGenreMapper: Profile
{
    public GetDetailsGenreMapper()
    {
        CreateMap<Genre, GenreViewModel>()
            .ForMember(dest => dest.Name,
                opt => opt
                    .MapFrom(src => src.Title));
    }
}