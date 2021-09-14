using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheaterTicketReservation.BL.Dtos;
using TheaterTicketReservation.BL.Managers.Interfaces;

namespace TheaterTicketReservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatReservationController : ControllerBase
    {
        private readonly ISeatReservationManager _seatReservationManager;

        public SeatReservationController(ISeatReservationManager seatReservationManager)
        {
            _seatReservationManager = seatReservationManager;
        }

        [HttpGet("Reserved")]
        public IActionResult GetReservedSeats(int screeningId)
        {
            var reservedSeats = _seatReservationManager.GetReservedSeats(screeningId);
            return Ok(reservedSeats);
        } 

        [HttpPost("Reserve")]
        public IActionResult ReserveSeats(List<SeatDto> seatDtos)
        {
            _seatReservationManager.ReserveSeats(seatDtos);
            return Ok();
        }
    }
}
