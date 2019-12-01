using DAW.Domain.EF.IRepositories;
using DAW.Domain.Models;

namespace DAW.Domain.EF.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(HotelDbContext context) : base(context)
        {
        }
    }
}