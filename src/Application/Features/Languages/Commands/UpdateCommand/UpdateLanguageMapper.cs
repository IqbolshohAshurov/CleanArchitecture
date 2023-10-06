using AutoMapper;
using Domain.Entities;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdateLanguageMapper: Profile
{
    public UpdateLanguageMapper()
    {
        CreateMap<UpdateLanguageCommand, Language>();
    }
}