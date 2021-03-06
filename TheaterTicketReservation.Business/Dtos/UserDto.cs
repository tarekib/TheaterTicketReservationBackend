using System.Text.Json.Serialization;

namespace TheaterTicketReservation.BL.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
