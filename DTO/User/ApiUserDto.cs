using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTO.User
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
       
    }
}