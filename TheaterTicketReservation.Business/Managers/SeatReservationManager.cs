using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using TheaterTicketReservation.BL.Dtos;
using TheaterTicketReservation.BL.Managers.Interfaces;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.BL.Managers
{
    public class SeatReservationManager : BaseManager<SeatDto>, ISeatReservationManager
    {
        public SeatReservationManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public List<SeatDto> GetReservedSeats(int screeningId)
        {
            var entities = UnitOfWork.SeatRepository.Find(x => x.ScreeningId == screeningId).ToList();
            var reservedSeats = Mapper.Map<List<SeatDto>>(entities);
            return reservedSeats;
        }

        public void ReserveSeats(List<SeatDto> seatDtos)
        {
            var entities = Mapper.Map<List<Seat>>(seatDtos);
            UnitOfWork.SeatRepository.AddRange(entities);
            UnitOfWork.Complete();
        }
    }
}
