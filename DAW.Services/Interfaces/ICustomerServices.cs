using DAW.Domain.EF.IRepositories;

namespace DAW.Services.Interfaces
{
    public interface ICustomerServices : IBaseServices
    {
        ICustomerRepository CustomerRepository { get; }
    }
}