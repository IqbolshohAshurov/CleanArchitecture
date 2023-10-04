using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Authors.Commands.DeleteAuthor;

public class DeletedAuthorEventHandler: INotificationHandler<DeletedAuthorEvent>
{
    private readonly ILogger<DeletedAuthorEventHandler> _logger;

    public DeletedAuthorEventHandler(ILogger<DeletedAuthorEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DeletedAuthorEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Deleted row from the table Author with Id = {nameof(notification)}");
        return Task.CompletedTask;
    }
}