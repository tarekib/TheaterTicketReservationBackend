using TheaterTicketReservation.BL;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.DAL.Repositories
{
    public class TheaterRepository : Repository<Theater>, ITheaterRepository
    {
        public TheaterRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
