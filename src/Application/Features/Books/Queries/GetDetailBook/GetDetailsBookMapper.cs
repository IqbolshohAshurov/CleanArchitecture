using AutoMapper;
using Domain.Entities;

namespace Application.Features.Books.Queries.GetDetailBook;

public class GetDetailsBookMapper: Profile
{
    public GetDetailsBookMapper()
    {
        CreateMap<Book, BookViewModel>();
    }
}