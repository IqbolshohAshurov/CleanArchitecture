using Application.Common.Interfaces;
using AutoMapper;
using MediatR;

namespace Application.Features.Languages.Queries.GetDetailQuery;

public class GetDetailsLanguageQuery: IRequest<LanguageViewModel>
{
    public Guid Id { get; set; }

    public GetDetailsLanguageQuery()
    {
        
    }

    public GetDetailsLanguageQuery(Guid id)
    {
        Id = id;
    }
}