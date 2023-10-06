using AutoMapper;
using Domain.Entities;

namespace Application.Features.Languages.Queries.GetDetailQuery;

public class GetDetailsLanguageMapper: Profile
{
    public GetDetailsLanguageMapper()
    {
        CreateMap<Language, LanguageVm>();
    }
}