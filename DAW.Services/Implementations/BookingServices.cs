using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;

namespace DAW.Services.Implementations
{
    public class BookingServices : BaseServices, IBookingServices
    {
        public IBookingRepository BookingRepository { get; }

        public BookingServices(HotelDbContext context, IBookingRepository bookingRepository) : base(context)
        {
            BookingRepository = bookingRepository;
        }
    }
}