using CurdOperationWithDTO.DTO.Request;
using CurdOperationWithDTO.DTO.Response;

namespace CurdOperationWithDTO.Interface
{
    public interface IEmployeeService
    {
         Task<IEnumerable<EmployeeResponseDTO>> GetAllEmployees();

        Task<EmployeeResponseDTO> GetEmployeeById(int id); 
        Task<EmployeeResponseDTO> CreateEmployee(EmployeeRequestAddDTO employeeRequest);

        Task<EmployeeResponseDTO> UpdateEmployee(EmployeeRequestUpdateDTO employeeRequest); 
        Task<bool> DeleteEmployee(int id);
    }
}
