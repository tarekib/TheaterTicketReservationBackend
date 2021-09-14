using AutoMapper;
using TheaterTicketReservation.BL.Dtos;
using TheaterTicketReservation.BL.Managers.Interfaces;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.BL.Managers
{
    public class TheaterManager : BaseManager<TheaterDto>, ITheaterManager
    {
        public TheaterManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public void AddTheater(TheaterDto theaterDto)
        {
            var entity = Mapper.Map<TheaterDto, Theater>(theaterDto);
            UnitOfWork.TheaterRepository.Add(entity);
        }
    }
}
