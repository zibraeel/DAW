using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;

namespace DAW.Services.Implementations
{
    public class RoomServices : BaseServices, IRoomServices
    {
        public IRoomRepository RoomRepository { get; }

        public RoomServices(HotelDbContext context, IRoomRepository roomRepository) : base(context)
        {
            RoomRepository = roomRepository;
        }

    }
}