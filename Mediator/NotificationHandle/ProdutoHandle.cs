using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Mediator.Notification;

namespace Mediator.NotificationHandle
{
    public class ProdutoHandle : INotificationHandler<ProdutoNotification>
    {
        public async Task Handle(ProdutoNotification notification, CancellationToken cancellationToken)
        {
           await Task.CompletedTask;
        }
    }
}
