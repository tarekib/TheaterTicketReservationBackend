using System.Collections.Generic;

namespace TheaterTicketReservation.BL.Models
{
    public class Theater
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SeatsNumber { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
