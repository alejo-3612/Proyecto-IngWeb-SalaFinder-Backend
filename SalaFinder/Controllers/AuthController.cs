using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SalaFinder.Interfaces;
using SalaFinder.Models.DTOs;

namespace SalaFinder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(IAuthService authService, UserManager<IdentityUser> userManager)
        {
            _authService = authService;
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _authService.Register(model.Email, model.Password, model.Role);
            if (result.Succeeded)
                return Ok(new { Message = $"Usuario {model.Email} creado con éxito." });
            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return Unauthorized(new { Message = "Credenciales incorrectas." });

            var token = await _authService.Login(model.Email, model.Password);
            if (token == null)
                return Unauthorized(new { Message = "Credenciales incorrectas." });

            var roles = await _userManager.GetRolesAsync(user);

            return Ok(new
            {
                token = token,
                id = user.Id,
                role = roles.FirstOrDefault() ?? "Student"
            });
        }
    }
}