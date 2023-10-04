using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdatedAuthorEventHandler: INotificationHandler<UpdatedAuthorEvent>
{
    private readonly ILogger<UpdatedAuthorEventHandler> _logger;

    public UpdatedAuthorEventHandler(ILogger<UpdatedAuthorEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(UpdatedAuthorEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Updated row from the table Author with Id = {nameof(notification)}");
        return Task.CompletedTask;
    }
}