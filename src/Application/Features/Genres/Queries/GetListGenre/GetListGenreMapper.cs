using AutoMapper;
using Domain.Entities;

namespace Application.Features.Genres.Queries.GetListGenre;

public class GetListGenreMapper: Profile
{
    public GetListGenreMapper()
    {
        CreateMap<Genre, GenreViewModel>()
            .ForMember(dest => dest.Name, 
                opt => opt
                    .MapFrom(src => src.Title));
    }
}