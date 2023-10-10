using MediatR;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdateLanguageCommand: IRequest<bool>
{
    public UpdateLanguageCommand() { }

    public UpdateLanguageCommand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
}