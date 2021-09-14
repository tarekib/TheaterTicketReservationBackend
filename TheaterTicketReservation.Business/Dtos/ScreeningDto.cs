using System;

namespace TheaterTicketReservation.BL.Dtos
{
    public class ScreeningDto
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public int MovieId { get; set; }
    }
}
