using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Genres.Commands.UpdateGenre;

public class UpdatedGenreEventHandler: INotificationHandler<UpdatedGenreEvent>
{
    private readonly ILogger<UpdatedGenreEventHandler> _logger;

    public UpdatedGenreEventHandler(ILogger<UpdatedGenreEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(UpdatedGenreEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Updated row in the table Genre with Id {notification.Genre.Id}");
        return Task.CompletedTask;
    }
}