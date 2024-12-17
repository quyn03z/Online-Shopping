using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Business.Services;
using OnlineShopping.Models.ModelsDTO;

namespace OnlineShopping.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginDTO loginDTO)
        {
            if (loginDTO == null || string.IsNullOrEmpty(loginDTO.UserName) || string.IsNullOrEmpty(loginDTO.Password)) {
                return BadRequest("Invalid login request.");
            }

            var user = _authService.Login(loginDTO.UserName, loginDTO.Password);
            if (user == null) {
                return BadRequest("User is not Found.");
            }

            // Create JWT token for the user

            var token = _authService.GenerateJwtToken(user);
            var response = new
            {
                user = new
                {
                    user.Email,
                },
                token
            };
            return Ok(response);
        }

    }
}
