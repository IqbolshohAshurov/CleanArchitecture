using Application.Features.Books.Commands.CreateBook;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Features.Books.Commands.UpdateBook;

public class UpdateBookValidator: AbstractValidator<UpdateBookCommand>
{
    public UpdateBookValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty();
        RuleFor(x => x.YearOfPublication).NotNull().NotEmpty();
        RuleFor(x => x.Edition).NotNull().NotEmpty();
        
    }
}