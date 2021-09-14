using AutoMapper;
using System.Linq;
using TheaterTicketReservation.BL.Dtos;
using TheaterTicketReservation.BL.Managers.Interfaces;

namespace TheaterTicketReservation.BL.Managers
{
    public class LoginManager : BaseManager<UserDto>, ILoginManager
    {
        public LoginManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public UserDto GetUser(UserDto userDto)
        {
            var user = UnitOfWork.UserRepository.Find(u => u.Username == userDto.Username).FirstOrDefault();
            return Mapper.Map<UserDto>(user);
        }
    }
}
