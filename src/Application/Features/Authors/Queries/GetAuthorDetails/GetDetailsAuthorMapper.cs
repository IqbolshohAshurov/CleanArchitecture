using AutoMapper;
using Domain.Entities;

namespace Application.Features.Authors.Queries.GetAuthorDetails;

public class GetDetailsAuthorMapper: Profile
{
    public GetDetailsAuthorMapper()
    {
        CreateMap<Author, AuthorDetailsViewModel>()
            .ForMember(dest => dest.Name,
                src => src.MapFrom(
                    s => s.FirstName + " " + s.LastName));
    }
}