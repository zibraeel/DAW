using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;

namespace DAW.Services.Implementations
{
    public class CustomerServices : BaseServices, ICustomerServices
    {
        public ICustomerRepository CustomerRepository { get; }

        public CustomerServices(HotelDbContext context, ICustomerRepository customerRepository) : base(context)
        {
            CustomerRepository = customerRepository;
        }
    }
}