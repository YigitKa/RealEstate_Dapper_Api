using System;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.DTOs.EmployeeDTOs;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
	public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDTO>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDTO createEmployeeDTO);
        void DeleteEmployee(DeleteEmployeeDTO deleteEmployeeDTO);
        void UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO);
        Task<GetByIDEmployeeDTO> GetEmployee(int employeeID);
    }
}

