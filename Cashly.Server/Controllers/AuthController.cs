using Cashly.Server.Services.AuthService;
using Microsoft.AspNetCore.Mvc;

namespace Cashly.Server.Controllers
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

        [HttpGet("IsUsernameTaken")]
        public async Task<ActionResult<bool>> IsUsernameTaken(string username)
        {
            var isTaken = await _authService.UserExists(username);
            return Ok(isTaken);
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegister request)
        {
            var res = await _authService.Register(
                   new User
                   {
                       Username = request.Username
                   }, request.Password);

            if (!res.Success)
            {
                return BadRequest(res.Message);
            }

            return Ok(res);
        }
    }
}
