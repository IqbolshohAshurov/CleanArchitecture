using MediatR;

namespace Application.Features.Languages.Commands.DeleteCommand;

public class DeleteLanguageCommand: IRequest<bool>
{
    public DeleteLanguageCommand() { }

    public DeleteLanguageCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}