using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreatedLanguageEvent: INotification
{
    public CreatedLanguageEvent() { }

    public CreatedLanguageEvent(Language language)
    {
        Language = language;
    }

    public Language Language { get; set; }
}