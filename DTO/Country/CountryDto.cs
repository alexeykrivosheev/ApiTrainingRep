using HotelListing.API.DTO.Hotel;

namespace HotelListing.API.DTO.Country
{
    public class CountryDto : BaseCountryDto
    {

        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}
