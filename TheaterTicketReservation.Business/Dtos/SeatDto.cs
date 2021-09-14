namespace TheaterTicketReservation.BL.Dtos
{
    public class SeatDto
    {
        public int Id { get; set; }

        public int Index { get; set; }

        public int Row { get; set; }

        public bool Reserved { get; set; }

        public int ScreeningId { get; set; }

        public int UserId { get; set; }
    }
}
