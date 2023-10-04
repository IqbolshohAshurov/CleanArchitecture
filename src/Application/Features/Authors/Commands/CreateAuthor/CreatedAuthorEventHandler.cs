using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreatedAuthorEventHandler: INotificationHandler<CreatedAuthorEvent>
{
    private readonly ILogger<CreatedAuthorEventHandler> _logger;

    public CreatedAuthorEventHandler(ILogger<CreatedAuthorEventHandler> logger)
    {
        _logger = logger;
    }
    
    public Task Handle(CreatedAuthorEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Added new row to table Author with Id = {nameof(notification)}");
        return Task.CompletedTask;
    }
}