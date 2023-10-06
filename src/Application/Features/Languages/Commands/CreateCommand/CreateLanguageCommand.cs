using MediatR;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreateLanguageCommand: IRequest<bool>
{
    public string Name { get; set; }
    
}