using TheaterTicketReservation.BL;
using TheaterTicketReservation.DAL.Repositories;

namespace TheaterTicketReservation.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            MovieRepository = new MovieRepository(context);
            ReservationRepository = new ReservationRepository(context);
            ScreeningRepository = new ScreeningRepository(context);
            SeatRepository = new SeatRepository(context);
            TheaterRepository = new TheaterRepository(context);
            UserRepository = new UserRepository(context);
        }

        public IMovieRepository MovieRepository { get; private set; }

        public IReservationRepository ReservationRepository { get; private set; }

        public IScreeningRepository ScreeningRepository { get; private set; }

        public ISeatRepository SeatRepository { get; private set; }

        public ITheaterRepository TheaterRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
