using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreatedAuthorEvent: INotification
{
    public CreatedAuthorEvent(){}
    
    public CreatedAuthorEvent(Author author) => Author = author;
    
    public Author Author { get; set; }
}