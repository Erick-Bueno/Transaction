namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class order : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public order(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PedidoDto pedidoDto)
        {
            var newOrder = await _pedidoService.create(pedidoDto);
            return Ok(newOrder);
        }
    }
}