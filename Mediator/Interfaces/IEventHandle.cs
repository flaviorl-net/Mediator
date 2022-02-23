using MediatR;

namespace Mediator.Interfaces
{
    public interface IEventHandle<in TNotification> : INotificationHandler<TNotification> 
        where TNotification : IEvent
    {
    }
}
