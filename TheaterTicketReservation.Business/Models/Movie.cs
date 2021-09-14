using System.Collections.Generic;

namespace TheaterTicketReservation.BL.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int DurationMin { get; set; }

        public Theater Theater { get; set; }

        public List<Screening> Screenings { get; set; } 
    }
}
