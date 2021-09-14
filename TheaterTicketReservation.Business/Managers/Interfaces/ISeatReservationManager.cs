using System.Collections.Generic;
using TheaterTicketReservation.BL.Dtos;

namespace TheaterTicketReservation.BL.Managers.Interfaces
{
    public interface ISeatReservationManager
    {
        List<SeatDto> GetReservedSeats(int screeningId);

        void ReserveSeats(List<SeatDto> seatDtos);
    }
}
