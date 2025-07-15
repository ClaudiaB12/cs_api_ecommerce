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

                return Ok(new { message = "Usuario registrado exitosamente"});
        }

    }
}    