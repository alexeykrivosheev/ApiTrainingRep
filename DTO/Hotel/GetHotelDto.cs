namespace HotelListing.API.DTO.Hotel
{
    public class GetHotelDto : BaseHotelDto
    {
        public int Id { get; set; }

        public string CountryName { get; set; }
    }
}
