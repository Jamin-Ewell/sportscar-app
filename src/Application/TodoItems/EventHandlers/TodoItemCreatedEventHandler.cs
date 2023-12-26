﻿using Microsoft.Extensions.Logging;
using sportscar_app.Domain.Events;

namespace sportscar_app.Application.TodoItems.EventHandlers;
public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("sportscar_app Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
