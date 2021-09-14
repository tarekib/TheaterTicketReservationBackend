using System.Collections.Generic;

namespace TheaterTicketReservation.BL.Dtos
{
    public class ReservationDto
    {
        public int Id { get; set; }

        public bool Reserved { get; set; }

        public bool Active { get; set; }

        public List<SeatDto> Seats { get; set; }
    }
}
