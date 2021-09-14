using System.Collections.Generic;

namespace TheaterTicketReservation.BL.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public bool Reserved { get; set; }

        public bool Active { get; set; }

        public int ScreeningId { get; set; }

        public Screening Screening { get; set; }

        public User User { get; set; }
    }
}
