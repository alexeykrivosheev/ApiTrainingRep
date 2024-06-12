using HotelListing.API.Data;

namespace HotelListing.API.Contracts
{
    public interface IHotelRepository : IGenericRepository<Hotel>
    {
        Task<Hotel> GetDetails(int id);
    }
}
