using TheaterTicketReservation.BL;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.DAL.Repositories
{
    public class SeatRepository : Repository<Seat>, ISeatRepository
    {
        public SeatRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
