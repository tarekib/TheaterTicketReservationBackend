using AutoMapper;
using TheaterTicketReservation.BL.Managers.Interfaces;

namespace TheaterTicketReservation.BL.Managers
{
    public class BaseManager<T> : IBaseManager<T> where T : class, new() 
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        protected BaseManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}
