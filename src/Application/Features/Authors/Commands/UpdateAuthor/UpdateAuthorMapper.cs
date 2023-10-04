using AutoMapper;
using Domain.Entities;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdateAuthorMapper: Profile
{
    public UpdateAuthorMapper()
    {
        CreateMap<UpdateAuthorCommand, Author>();
    }
}