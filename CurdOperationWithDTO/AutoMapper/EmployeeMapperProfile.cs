using AutoMapper;
using CurdOperationWithDTO.DTO.Request;
using CurdOperationWithDTO.DTO.Response;
using CurdOperationWithDTO.Model;


namespace CurdOperationWithDTO.AutoMapper
{
    public class EmployeeMapperProfile : Profile
    {
        public EmployeeMapperProfile()
        {
            // Mapping for Employee to EmployeeResponseDTO and vice versa


            //we want to send data to client in the form of EmployeeResponseDTO
           
        }

    }
}
