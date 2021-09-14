using TheaterTicketReservation.BL.Dtos;

namespace TheaterTicketReservation.BL.Managers.Interfaces
{
    public interface ITheaterManager
    {
        void AddTheater(TheaterDto theaterDto);
    }
}
