using AutoMapper;
using Domain.Entities;

namespace Application.Features.Languages.Queries.GetListQuery;

public class GetListLanguageMapper: Profile
{
    public GetListLanguageMapper()
    {
        CreateMap<Language, LanguageViewModel>();
    }
}