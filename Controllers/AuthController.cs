using Microsoft.AspNetCore.Mvc;
using ApiEcommerce.Requests;
using ApiEcommerce.Services;

namespace ApiEcommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly JwtService _jwtService;

        public AuthController(IAuthService authService, JwtService jwtService)
        {
            _authService = authService;
            _jwtService = jwtService;
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var user = await _authService.ValidateUserAsync(loginRequest);

            if (user == null)
                return Unauthorized(new { message = "Credenciales inválidas" });

            var token = _jwtService.GenerateToken(user.id);

            return Ok(new { message = "Logueo Exitoso", token });
        }
    }
}