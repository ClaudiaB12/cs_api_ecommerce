using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApiEcommerce.Services;
using ApiEcommerce.Models;

namespace ApiEcommerce.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<Cart>>> GetAll()
        {
            var carts = await _cartService.GetAllAsync();
            return Ok(carts);
        }

        [HttpGet("list/{clientId}")]
        public async Task<ActionResult<IEnumerable<Cart>>> GetByClient(int clientId)
        {
            var carts = await _cartService.GetByClientAsync(clientId);
            return Ok(carts);
        }

        [HttpPost("save")]
        public async Task<ActionResult<Cart>> SaveOrUpdate([FromBody] Cart cart)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _cartService.SaveOrUpdateAsync(cart);
            return Ok(result);
        }
    }
}
