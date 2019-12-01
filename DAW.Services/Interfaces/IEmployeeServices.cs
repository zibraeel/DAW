using DAW.Domain.EF.IRepositories;

namespace DAW.Services.Interfaces
{
    public interface IEmployeeServices : IBaseServices
    {
        IEmployeeRepository EmployeeRepository { get; }
    }
}