using AutoMapper;
using Domain.Entities;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreateLanguageMapper: Profile
{
    public CreateLanguageMapper()
    {
        CreateMap<CreateLanguageCommand, Language>();
    }
}