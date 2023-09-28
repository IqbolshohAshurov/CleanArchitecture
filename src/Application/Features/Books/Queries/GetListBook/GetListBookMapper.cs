using Application.Common.Models.DTOs.BookDTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Books.Queries.GetListBook;

public class GetListBookMapper: Profile
{
    public GetListBookMapper()
    {
        CreateMap<Book, BookDto>();
    }
}