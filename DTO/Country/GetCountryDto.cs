using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.DTO.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
    }
}
