using TheaterTicketReservation.BL;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.DAL.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
