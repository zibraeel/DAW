using DAW.Domain.EF;
using DAW.Services.Interfaces;
using System.Threading.Tasks;

namespace DAW.Services.Implementations
{
    public class BaseServices : IBaseServices
    {
        private readonly HotelDbContext _context;

        public BaseServices(HotelDbContext context)
        {
            _context = context;
        }

        public async Task CommitChanges()
        {
            await _context.SaveChangesAsync(true);
        }
    }
}