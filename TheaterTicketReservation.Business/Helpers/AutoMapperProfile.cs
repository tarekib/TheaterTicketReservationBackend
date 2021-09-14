using AutoMapper;
using TheaterTicketReservation.BL.Dtos;
using TheaterTicketReservation.BL.Models;

namespace TheaterTicketReservation.BL.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<Screening, ScreeningDto>().ReverseMap();
            CreateMap<Seat, SeatDto>().ReverseMap();
            CreateMap<Theater, TheaterDto>().ReverseMap();

        }
    }
}
