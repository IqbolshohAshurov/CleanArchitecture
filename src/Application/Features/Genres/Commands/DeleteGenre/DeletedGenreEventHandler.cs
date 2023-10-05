using System.Data;
using Application.Features.Genres.Commands.CreateGenre;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Genres.Commands.DeleteGenre;

public class DeletedGenreEventHandler: INotificationHandler<DeletedGenreEvent>
{
    private readonly ILogger<DeletedGenreEventHandler> _logger;

    public DeletedGenreEventHandler(ILogger<DeletedGenreEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DeletedGenreEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Deleted row in the table Genre with Id {notification.Genre.Id}");
        return Task.CompletedTask;
    }
}