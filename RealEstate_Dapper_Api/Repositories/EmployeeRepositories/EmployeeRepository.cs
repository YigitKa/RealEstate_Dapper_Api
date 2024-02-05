using System;
using RealEstate_Dapper_Api.DTOs.EmployeeDTOs;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		public EmployeeRepository()
		{
		}

        public void CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(DeleteEmployeeDTO deleteEmployeeDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultEmployeeDTO>> GetAllEmployeeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIDEmployeeDTO> GetEmployee(int employeeID)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            throw new NotImplementedException();
        }
    }
}

