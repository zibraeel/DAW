using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;

namespace DAW.Domain.EF.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(HotelDbContext context) : base(context)
        {
        }
    }
}