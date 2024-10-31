using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Responses;
using EuropeanDynamicsEshop2024.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EshopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EshopController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public EshopController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("customers")]
        public List<Customer> GetCustomers()
        {
            return _customerService.ReadCustomers();
        }
        [HttpGet("customer/{id}")]
        public ResponseApi<Customer> GetCustomer([FromRoute] int id)
        {
            return _customerService.ReadCustomer(id);
        }

        [HttpPost("customer")]
        public ResponseApi<Customer> CreateCustomer([FromBody] Customer customer)
        {
            return _customerService.CreateCustomer(customer);
        }

        [HttpPut("customer")]
        public ResponseApi<Customer> UpdateCustomer([FromBody] Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }

        [HttpDelete("customer/{id}")]
        public bool DeleteCustomer([FromRoute]  int id)
        {
            return _customerService.DeleteCustomer(id);
        }

    }
}
