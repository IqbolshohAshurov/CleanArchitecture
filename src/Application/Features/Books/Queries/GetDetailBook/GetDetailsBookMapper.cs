using AutoMapper;
using Domain.Entities;

namespace Application.Features.Books.Queries.GetBookById;

public class GetDetailsBookMapper: Profile
{
    public GetDetailsBookMapper()
    {
        CreateMap<Book, BookViewModel>();
    }
}