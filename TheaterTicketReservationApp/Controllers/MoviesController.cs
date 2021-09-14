using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TheaterTicketReservation.BL;

namespace TheaterTicketReservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MoviesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetTheaterMovies")]
        public IActionResult GetTheaterMovies(int theaterId)
        {
            var movies = _unitOfWork.MovieRepository.Find(m => m.Theater.Id == theaterId).ToList();
            return Ok(movies);
        }

        [HttpGet("Screenings")]
        public IActionResult GetMovieScreening(int movieId)
        {
            var screenings = _unitOfWork.ScreeningRepository.Find(s => s.MovieId == movieId).ToList();
            return Ok(screenings);
        }
    }
}
