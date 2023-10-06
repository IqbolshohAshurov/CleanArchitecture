using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.DeleteCommand;

public class DeletedLanguageEvent: INotification
{
    
    public Language Language { get; set; }

    public DeletedLanguageEvent()
    {
        
    }

    public DeletedLanguageEvent(Language language)
    {
        Language = language;
    }
}