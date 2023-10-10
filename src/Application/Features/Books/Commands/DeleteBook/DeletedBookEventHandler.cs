using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Books.Commands.DeleteBook;

public class DeletedBookEventHandler: INotificationHandler<DeletedBookEvent>
{
    private readonly ILogger<DeletedBookEventHandler> _logger;

    public DeletedBookEventHandler(ILogger<DeletedBookEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DeletedBookEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Deleted row from the table {nameof(notification)}");
        return Task.CompletedTask;
    }
}