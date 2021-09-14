using Microsoft.EntityFrameworkCore;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.DAL
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // to be moved to appsettings.json
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1JIPV0D;Initial Catalog=MoviesReservation;User ID=sa;Password=p@ssw0rd");
            }
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Screening> Screenings { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Theater> Theaters { get; set; }
    }
}
