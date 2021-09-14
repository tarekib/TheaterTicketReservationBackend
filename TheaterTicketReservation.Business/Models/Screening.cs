using System;
using System.Collections.Generic;

namespace TheaterTicketReservation.BL.Models
{
    public class Screening
    {
        public int Id { get; set; }

        public Movie Movie { get; set; }

        public int MovieId { get; set; }

        public DateTime StartTime { get; set; }

        public List<Seat> Seats { get; set; }
    }
}
