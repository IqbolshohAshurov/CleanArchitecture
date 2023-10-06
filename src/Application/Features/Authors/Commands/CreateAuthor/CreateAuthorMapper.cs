using AutoMapper;
using Domain.Entities;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreateAuthorMapper: Profile
{
    public CreateAuthorMapper()
    {
        CreateMap<CreateAuthorCommand, Author>();
    }
}