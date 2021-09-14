namespace TheaterTicketReservation.BL.Models
{
    public class Seat
    {
        public int Id { get; set; }

        public int Index { get; set; }

        public int Row { get; set; }

        public bool Reserved { get; set; }

        public int ScreeningId { get; set; }

        public int UserId { get; set; }

        public Screening Screening { get; set; }

        public User User { get; set; }
    }
}
