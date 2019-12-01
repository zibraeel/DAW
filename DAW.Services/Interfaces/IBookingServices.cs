using DAW.Domain.EF.IRepositories;

namespace DAW.Services.Interfaces
{
    public interface IBookingServices : IBaseServices
    {
        IBookingRepository BookingRepository { get; }
    }
}