using CurdOperationWithDTO.DTO.Request;
using CurdOperationWithDTO.DTO.Response;
using CurdOperationWithDTO.Interface;
using Microsoft.EntityFrameworkCore;
using CurdOperationWithDTO.Model;
namespace CurdOperationWithDTO.EmployeServices
{
    public class EmployessServices : IEmployeeService
    {
        private readonly ApplicationDBcontext _context;

        public EmployessServices(ApplicationDBcontext context)
        {
            _context = context;
        }

        public async Task<EmployeeResponseDTO> CreateEmployee(EmployeeRequestAddDTO employeeRequest)
        {
            var employee = new Employee
            {
                Name = employeeRequest.Name,
                Salary = employeeRequest.Salary,
                Department = employeeRequest.Department
            };
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return new EmployeeResponseDTO
            {
                Id = employee.Id,
                Name = employee.Name,
                Salary = employee.Salary,
                Department = employee.Department
            };
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return false;
            }
            else
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        //Get all employee details
        public async Task<IEnumerable<EmployeeResponseDTO>> GetAllEmployees()
        {
            return await _context.Employees.Select(e => new EmployeeResponseDTO
            {
                Id = e.Id,
                Name = e.Name,
                Salary = e.Salary,
                Department = e.Department
            }).ToListAsync();
        }

        public async Task<EmployeeResponseDTO> GetEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return null;
            }
            else
            {
                return new EmployeeResponseDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Salary = employee.Salary,
                    Department = employee.Department
                };
            }
        }

        public async Task<EmployeeResponseDTO> UpdateEmployee(EmployeeRequestUpdateDTO employeeRequest)
        {
            var employee = await _context.Employees.FindAsync(employeeRequest.Id);
            if (employee == null)
            {
                return null;
            }
            else
            {
                employee.Name = employeeRequest.Name;
                employee.Salary = employeeRequest.Salary;
                employee.Department = employeeRequest.Department;
                await _context.SaveChangesAsync();
                return new EmployeeResponseDTO
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Salary = employee.Salary,
                    Department = employee.Department
                };
            }
        }
    }
}
