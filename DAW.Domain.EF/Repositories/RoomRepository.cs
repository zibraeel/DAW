using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;

namespace DAW.Domain.EF.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelDbContext context) : base(context)
        {
        }
    }
}