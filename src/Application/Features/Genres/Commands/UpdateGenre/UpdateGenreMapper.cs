using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Genres.Commands.UpdateGenre;

public class UpdateGenreMapper: Profile
{
    public UpdateGenreMapper()
    {
        CreateMap<UpdateGenreCommand, Genre>()
            .ForMember(dest => dest.Title,
                opt => opt
                    .MapFrom(src => src.Name));
    }
}