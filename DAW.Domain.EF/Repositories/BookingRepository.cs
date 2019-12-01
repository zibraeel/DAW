using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;

namespace DAW.Domain.EF.Repositories
{
    public class BookingRepository : BaseRepository<Booking>, IBookingRepository
    {
        public BookingRepository(HotelDbContext context) : base(context)
        {
        }
    }
}