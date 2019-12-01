using DAW.Domain.EF;
using DAW.Domain.EF.IRepositories;
using DAW.Services.Interfaces;

namespace DAW.Services.Implementations
{
    public class EmployeeServices : BaseServices, IEmployeeServices
    {
        public IEmployeeRepository EmployeeRepository { get; }

        public EmployeeServices(HotelDbContext context, IEmployeeRepository employeeRepository) : base(context)
        {
            EmployeeRepository = employeeRepository;
        }

    }
}