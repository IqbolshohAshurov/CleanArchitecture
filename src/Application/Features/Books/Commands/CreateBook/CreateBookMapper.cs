using AutoMapper;
using Domain.Entities;

namespace Application.Features.Books.Commands.CreateBook;

public class CreateBookMapper: Profile
{
    public CreateBookMapper()
    {
        CreateMap<CreateBookCommand, Book>();
    }
}