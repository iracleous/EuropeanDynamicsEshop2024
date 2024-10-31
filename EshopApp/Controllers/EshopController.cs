using EuropeanDynamicsEshop2024.Models;
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
    }
}
