using AutoMapper;
using Domain.Entities;

namespace Application.Features.Genres.Commands.CreateGenre;

public class CreateGenreMapper: Profile
{
    public CreateGenreMapper()
    {
        CreateMap<CreateGenreCommand, Genre>();
    }
}