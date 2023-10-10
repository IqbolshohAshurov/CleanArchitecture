using AutoMapper;
using Domain.Entities;

namespace Application.Features.Authors.Queries.GetListAuthor;

public class GetListAuthorMapper: Profile
{
    public GetListAuthorMapper()
    {
        CreateMap<Author, AuthorDetailsViewModel>()
            .ForMember(dest => dest.Name,
                src => src
                .MapFrom(s => s.FirstName + " " + s.LastName));
    }
}