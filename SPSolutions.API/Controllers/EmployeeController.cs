using Microsoft.AspNetCore.Mvc;
using SPSolutions.API.DTOs;
using SPSolutions.API.Services;

namespace SPSolutions.API.Controllers
{
    public class EmployeeController : BaseApiController
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        [HttpPost("add")]
        public async Task<ActionResult> AddEmployee([FromBody] EmployeeDto empDto)
        {
            if (await _employeeService.Add(empDto)) return Ok("Employee Added.");

            return BadRequest("Something went wrong!");
        }
    }
}