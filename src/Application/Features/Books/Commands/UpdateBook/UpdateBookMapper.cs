using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Application.Features.Books.Commands.UpdateBook;

public class UpdateBookMapper : Profile
{
    public UpdateBookMapper()
    {
        CreateMap<UpdateBookCommand, Book>();
    }
}