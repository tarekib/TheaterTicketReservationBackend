using Microsoft.AspNetCore.Mvc;
using TheaterTicketReservation.BL;

namespace TheaterTicketReservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TheatersController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("All")]
        public IActionResult All()
        {
            return Ok(_unitOfWork.TheaterRepository.GetAll());
        }
    }
}
