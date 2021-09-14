using System.Collections.Generic;

namespace TheaterTicketReservation.BL.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int DurationMin { get; set; }

        public List<ScreeningDto> Screenings { get; set; } 
    }
}
