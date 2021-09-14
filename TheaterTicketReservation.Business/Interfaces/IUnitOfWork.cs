using System;

namespace TheaterTicketReservation.BL
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }

        IReservationRepository ReservationRepository { get;  }

        IScreeningRepository ScreeningRepository { get; }

        ISeatRepository SeatRepository { get; }

        ITheaterRepository TheaterRepository { get; }

        IUserRepository UserRepository { get;  }

        void Complete();
    }
}
