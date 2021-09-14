using TheaterTicketReservation.BL.Dtos;

namespace TheaterTicketReservation.BL.Managers.Interfaces
{
    public interface ILoginManager
    {
         UserDto GetUser(UserDto userDto);
    }
}
