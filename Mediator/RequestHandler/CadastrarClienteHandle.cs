using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Mediator.Request;

namespace Mediator.RequestHandler
{
    public class CadastrarClienteHandle : IRequestHandler<CadastrarClienteRequest, string>
    {
        public async Task<string> Handle(CadastrarClienteRequest request, CancellationToken cancellationToken)
        {
            return await Task.FromResult("Handle Executado");
        }
    }
}
