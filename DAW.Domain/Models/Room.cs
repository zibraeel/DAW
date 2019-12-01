using DAW.Domain.Models.BaseModels;

namespace DAW.Domain.Models
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int Capacity { get; set; }
        public bool IsOccupied { get; set; }
        public bool HasWifi { get; set; }
        public float BasePrice { get; set; }
    }
}