using App.Models.Dto;
using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IDataService _dataService;

        public ClientsController(IDataService dataService) {
            _dataService = dataService;
        }

        [HttpGet("{clientId}/orders")]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders(int clientId)
        {
            var client = await _dataService.GetClient(clientId);

            if (client == null) return NotFound();
            
            return Ok(client.Orders.Select(OrderDto.From));
        }

        [HttpPost("{clientId}/orders")]
        public async Task<ActionResult> AddOrder(int clientId, [FromBody] OrderRequest request)
        {
            var client = await _dataService.GetClient(clientId);

            if (client == null) return NotFound();

            var statuses = await _dataService.GetStatuses();
            if (statuses.Where(x => x.Name == "Created").Any()) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            await _dataService.CreateOrder(clientId, request.CreatedAt, request.FulfilledAt);

            return Ok();
        }
    }
}
