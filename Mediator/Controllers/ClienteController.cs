using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Mediator.Command;
using Mediator.Request;

namespace Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IMediator _mediator;

        public ClienteController(ILogger<ClienteController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("cadastrar-cliente")]
        public async Task<IActionResult> CadastrarCliente()
        {
            return Ok(await _mediator.Send(new CadastrarClienteRequest(0, "Flavio", "Lima", DateTime.Now.AddYears(-38))));
        }
    }
}
