using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreatedLanguageEventHandler: INotificationHandler<CreatedLanguageEvent>
{
    private readonly ILogger<CreatedLanguageEventHandler> _logger;

    public CreatedLanguageEventHandler(ILogger<CreatedLanguageEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedLanguageEvent notify, CancellationToken ct)
    {
        _logger.LogInformation($"Created new row in the table {typeof(Language)}.Name");
        return Task.CompletedTask;
    }
}