using System.Threading;
using System.Threading.Tasks;
using Mediator.Command;
using Mediator.Interfaces;

namespace Mediator.CommandHandle
{
    public class CadastrarEnderecoHandle : ICommandHandle<CadastrarEnderecoCommand, string>
    {
        public async Task<string> Handle(CadastrarEnderecoCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult("Handle Executado");
        }
    }
}
