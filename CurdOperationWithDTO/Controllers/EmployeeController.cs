using CurdOperationWithDTO.DTO.Request;
using CurdOperationWithDTO.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurdOperationWithDTO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
     {
            var employees = await _employeeService.GetAllEmployees();
            if (employees == null) { return BadRequest(); }
            return Ok(employees);
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(EmployeeRequestAddDTO employeeRequest)
        {
            var createdEmployee = await _employeeService.CreateEmployee(employeeRequest);
            if (createdEmployee == null)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new { id = createdEmployee.Id }, createdEmployee);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(EmployeeRequestUpdateDTO employeeRequest)
        {
            var updatedEmployee = await _employeeService.UpdateEmployee(employeeRequest);
            if (updatedEmployee == null)
            {
                return NotFound();
            }
            return Ok(updatedEmployee);
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var isDeleted = await _employeeService.DeleteEmployee(id);
            if(!isDeleted)
            {
                return NotFound();
            } return Ok();
        }
    }
}
