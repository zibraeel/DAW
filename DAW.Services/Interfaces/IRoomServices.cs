using DAW.Domain.EF.IRepositories;

namespace DAW.Services.Interfaces
{
    public interface IRoomServices : IBaseServices
    {
        IRoomRepository RoomRepository { get; }
    }
}