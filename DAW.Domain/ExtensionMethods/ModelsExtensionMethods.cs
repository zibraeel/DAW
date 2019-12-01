using DAW.Domain.Models;
using DAW.Domain.Requests;

namespace DAW.Domain.ExtensionMethods
{
    public static class ModelsExtensionMethods
    {
        public static Customer ToDTO(this GeneralCustomerRequest request)
        {
            return new Customer
            {
                Address = request.Address,
                BirthDate = request.BirthDate,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone
            };
        }

        public static Customer ToDTO(this GeneralCustomerRequest request, int id)
        {
            return new Customer
            {
                Address = request.Address,
                BirthDate = request.BirthDate,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Phone = request.Phone,
                Id = id
            };
        }
    }
}