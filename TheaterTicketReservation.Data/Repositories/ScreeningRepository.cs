using TheaterTicketReservation.BL;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.DAL.Repositories
{
    public class ScreeningRepository : Repository<Screening>, IScreeningRepository
    {
        public ScreeningRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
