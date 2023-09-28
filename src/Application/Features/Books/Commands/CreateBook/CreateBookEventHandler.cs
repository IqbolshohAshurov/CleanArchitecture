using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Books.Commands.CreateBook;
public class CreateBookEventHandler : INotificationHandler<CreatedBookEvent>
{
    private readonly ILogger<CreateBookEventHandler> _logger;
    public CreateBookEventHandler(ILogger<CreateBookEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedBookEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"The {notification.GetType().Name} was added successfully");
        return Task.CompletedTask;
    }
}