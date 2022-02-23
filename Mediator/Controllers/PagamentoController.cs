using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Mediator.Event;

namespace Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly ILogger<PagamentoController> _logger;
        private readonly Interfaces.IMediator _mediator;

        public PagamentoController(ILogger<PagamentoController> logger, Interfaces.IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("cadastrar-pagamento")]
        public async Task<IActionResult> CadastrarPagamento()
        {
            await _mediator.PublishEvent(new PagamentoEvent(1, 1, 1, "123456789"));

            return Ok();
        }
    }
}
