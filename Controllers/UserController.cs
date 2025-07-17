using Microsoft.AspNetCore.Mvc;
using ApiEcommerce.Requests;
using ApiEcommerce.Services;

namespace ApiEcommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var result = await _userService.RegisterUserAsync(request);

            if (!result)
                return Conflict(new { message = "El usuario ya existe" });

            return Ok(new { message = "Usuario registrado exitosamente" });
        }

        [HttpGet("profile/{clientId}")]
        public async Task<IActionResult> GetUserProfile(int clientId)
        {
            var user = await _userService.GetUserByIdAsync(clientId);

            if (user == null)
                return NotFound(new { message = "Usuario no encontrado" });

            return Ok(new
            {
                user.id,
                user.name,
                user.email,
                user.address,
                user.phone
            });
        }
    }
}