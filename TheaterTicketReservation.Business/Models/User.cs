using System.Collections.Generic;

namespace TheaterTicketReservation.BL.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public List<Seat> Seats { get; set; }
    }
}
