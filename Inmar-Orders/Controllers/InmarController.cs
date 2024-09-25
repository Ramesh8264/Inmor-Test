using Inmar_Orders.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Inmar_Orders.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/orders")]
    public class InmarController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public InmarController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("history")]
        public async Task<IActionResult> GetOrderHistory(int userId)
        {
            //var userId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "userId").Value);
            var orders = await _orderService.GetOrderHistoryAsync(userId);

            if (orders == null || !orders.Any())
            {
                return NotFound("No order history found.");
            }

            return Ok(orders);
        }
    }
}
