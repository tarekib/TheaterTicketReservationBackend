using TheaterTicketReservation.BL;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
