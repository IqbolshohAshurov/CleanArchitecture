using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreatedLanguageEvent: INotification
{
    public Language Language { get; set; }

    public CreatedLanguageEvent()
    {
        
    }

    public CreatedLanguageEvent(Language language)
    {
        Language = language;
    }
}