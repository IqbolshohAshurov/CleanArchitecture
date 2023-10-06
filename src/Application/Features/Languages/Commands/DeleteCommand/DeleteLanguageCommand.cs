using MediatR;

namespace Application.Features.Languages.Commands.DeleteCommand;

public class DeleteLanguageCommand: IRequest<bool>
{
    public Guid Id { get; set; }

    public DeleteLanguageCommand()
    {
        
    }

    public DeleteLanguageCommand(Guid id)
    {
        Id = id;
    }
    
}