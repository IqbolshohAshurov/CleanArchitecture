using Application.Common.Models.DTOs.BookDTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Books.Queries.GetBookById;

public class GetBookByIdMapper: Profile
{
    public GetBookByIdMapper()
    {
        CreateMap<Book, BookDto>();
    }
}