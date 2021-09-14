using Microsoft.AspNetCore.Mvc;
using TheaterTicketReservation.BL.Dtos;
using TheaterTicketReservation.BL.Managers.Interfaces;

namespace TheaterTicketReservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginManager _loginManager;

        public LoginController(ILoginManager loginManager)
        {
            _loginManager = loginManager;
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate(UserDto payload)
        {
            var user = _loginManager.GetUser(payload);
            if (user == null || payload.Password != user.Password)
                return Unauthorized();
            return Ok(user);
        }
    }
}
