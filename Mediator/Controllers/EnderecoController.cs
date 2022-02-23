using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Mediator.Command;

namespace Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly ILogger<EnderecoController> _logger;
        private readonly Interfaces.IMediator _mediator;

        public EnderecoController(ILogger<EnderecoController> logger, Interfaces.IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("cadastrar-endereco")]
        public async Task<IActionResult> CadastrarEndereco()
        {
            return Ok(await _mediator.SendCommand(new CadastrarEnderecoCommand(0, "Rua", "Oliveira", 10, "B")));
        }
    }
}
