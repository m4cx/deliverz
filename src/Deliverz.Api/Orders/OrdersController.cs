using Deliverz.Application.Orders.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Deliverz.Api.Orders
{
    [ApiController]
    [Route("api/orders")]
    public sealed class OrdersController : ControllerBase
    {
        private readonly IMediator mediator;

        public OrdersController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetOrders()
        {
            return Ok(await mediator.Send(new GetOrdersQuery()).ConfigureAwait(false));
        } 
    }
}
