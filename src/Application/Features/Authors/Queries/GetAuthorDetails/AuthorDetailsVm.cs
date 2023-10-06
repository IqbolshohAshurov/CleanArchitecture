using Application.Common.Models.DTOs.BookDTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Authors.Queries.GetAuthors;

public class AuthorDetailsVm
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}