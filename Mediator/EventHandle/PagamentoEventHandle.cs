using System.Threading;
using System.Threading.Tasks;
using Mediator.Event;
using Mediator.Interfaces;

namespace Mediator.EventHandle
{
    public class PagamentoEventHandle : IEventHandle<PagamentoEvent>
    {
        public async Task Handle(PagamentoEvent notification, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
        }
    }
}