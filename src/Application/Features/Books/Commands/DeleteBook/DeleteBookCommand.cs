using MediatR;

namespace Application.Features.Books.Commands.DeleteBook;

public class DeleteBookCommand: IRequest<bool>
{
    public Guid Id { get; init; }

    public DeleteBookCommand() { }

    public DeleteBookCommand(Guid id)
    {
        Id = id;
    }
}