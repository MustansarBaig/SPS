using Microsoft.AspNetCore.Mvc;
using SPSolutions.API.DTOs;
using SPSolutions.API.Entities;
using SPSolutions.API.Services;

namespace SPSolutions.API.Controllers
{
    public class DepartmentController : BaseApiController
    {
        private readonly ILogger<DepartmentController> _logger;
        private readonly IDepartmentService _departmentService;

        public DepartmentController(ILogger<DepartmentController> logger, IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            _logger = logger;
        }

        [HttpPost("add")]
        public async Task<ActionResult> AddDepartment([FromBody] DepartmentDto deptDto)
        {
            if (await _departmentService.Add(deptDto)) return Ok("Department Added.");

            return BadRequest("Something went wrong!");
        }

        [HttpPost("update")]
        public async Task<ActionResult> UpdateDepartment([FromBody] DepartmentDto deptDto)
        {
            if (await _departmentService.Update(deptDto)) return Ok("Department updated.");

            return BadRequest("Something went wrong!");
        }

        [HttpGet("get/{employeesCount}")]
        public async Task<ActionResult<ICollection<Department>>> GetDepartments(int employeesCount)
        {
            var departments = await _departmentService.Get(employeesCount);

            if (departments != null)
            {
                return Ok(departments);
            }

            return BadRequest("Something went wrong!");
        }

    }
}