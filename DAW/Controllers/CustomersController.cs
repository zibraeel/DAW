using DAW.Domain.ExtensionMethods;
using DAW.Domain.Models;
using DAW.Domain.Requests;
using DAW.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAW.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomersController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<ObjectResult> GetAllCustomersAsync()
        {
            List<Customer> result = await _customerServices.CustomerRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("GetCustomer/{id}")]
        public async Task<ObjectResult> GetCustomerAsync([FromRoute] int id)
        {
            Customer result = await _customerServices.CustomerRepository.GetByIdAsync(id);

            return Ok(result);
        }


        [HttpPost("CreateCustomer")]
        public async Task<ObjectResult> CreateCustomerAsync([FromBody] GeneralCustomerRequest request)
        {
            Customer result = await _customerServices.CustomerRepository.CreateAsync(request.ToDTO());
            await _customerServices.CommitChanges();

            return Ok(result);
        }

        [HttpPut("UpdateCustomer/{id}")]
        public async Task<ObjectResult> UpdateCustomerAsync([FromBody] GeneralCustomerRequest request, [FromRoute] int id)
        {
            Customer result = _customerServices.CustomerRepository.Update(request.ToDTO(id));
            await _customerServices.CommitChanges();

            return Ok(result);
        }

        [HttpDelete("DeleteCustomer/{id}")]
        public async Task<ObjectResult> DeleteCustomerAsync([FromRoute] int id)
        {
            Customer customer = await _customerServices.CustomerRepository.GetByIdAsync(id);
            _customerServices.CustomerRepository.Delete(customer);
            await _customerServices.CommitChanges();

            return Ok(customer);
        }

    }
}