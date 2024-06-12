using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Hotel> GetDetails(int id)
        {
            return await _context.Set<Hotel>().Include(a => a.Country).FirstOrDefaultAsync(a=>a.Id == id);
        }
    }
}
