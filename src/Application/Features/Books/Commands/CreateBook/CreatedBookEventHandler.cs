using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Books.Commands.CreateBook;
public class CreatedBookEventHandler : INotificationHandler<CreatedBookEvent>
{
    private readonly ILogger<CreatedBookEventHandler> _logger;
    public CreatedBookEventHandler(ILogger<CreatedBookEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedBookEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"The {notification.GetType().Name} was added successfully");
        return Task.CompletedTask;
    }
}