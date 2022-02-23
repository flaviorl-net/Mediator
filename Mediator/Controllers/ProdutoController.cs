using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Mediator.Notification;

namespace Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly IMediator _mediator;

        public ProdutoController(ILogger<ProdutoController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("cadastrar-produto")]
        public async Task<IActionResult> CadastrarProduto()
        {
            await _mediator.Publish(new ProdutoNotification(1, "Teclado", 750, 200));

            return Ok();
        }
    }
}