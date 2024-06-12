using HotelListing.API.Data;

namespace HotelListing.API.Contracts
{
    public interface ICountryReposipory : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
