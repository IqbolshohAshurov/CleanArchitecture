using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Genres.Commands.CreateGenre;

public class CreatedGenreEventHandler: INotificationHandler<CreatedGenreEvent>
{
    private readonly ILogger<CreatedGenreEventHandler> _logger;

    public CreatedGenreEventHandler(ILogger<CreatedGenreEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedGenreEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Created new row in the table Genre");
        return Task.CompletedTask;
    }
}