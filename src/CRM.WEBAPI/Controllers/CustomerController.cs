using CRM.APPLICATION.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM.WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task<IActionResult> Index()
        {
            var customers = await _customerService.GetAll();
            return Ok(customers);
        }

    }
}
