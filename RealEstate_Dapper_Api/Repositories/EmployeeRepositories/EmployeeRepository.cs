using System;
using Dapper;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.DTOs.EmployeeDTOs;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            string query = "INSERT INTO Employee (Name, Title, Mail, Phone, ImageURL, Status) " +
                " VALUES (@name, @title, @mail, @phone, @imageURL, @status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmployeeDTO.Name);
            parameters.Add("@title", createEmployeeDTO.Title);
            parameters.Add("@mail", createEmployeeDTO.Mail);
            parameters.Add("@phone", createEmployeeDTO.PhoneNumber);
            parameters.Add("@imageURL", createEmployeeDTO.ImageURL);
            parameters.Add("@status", true);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "DELETE FROM Employee WHERE EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDTO>> GetAllEmployeeAsync()
        {
            string query = "SELECT * FROM Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDEmployeeDTO> GetEmployee(int employeeID)
        {
            string query = "SELECT * FROM Employee WHERE EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", employeeID);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            string query = "UPDATE Employee SET " +
               "Name = @name, " +
               "Title = @title, " +
               "Mail = @mail, " +
               "Phone = @phone, " +
               "ImageURL = @imageURL, " +
               "Status = @status " +
               "WHERE EmployeeID = @employeeID";

            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmployeeDTO.Name);
            parameters.Add("@title", updateEmployeeDTO.Title);
            parameters.Add("@mail", updateEmployeeDTO.Mail);
            parameters.Add("@phone", updateEmployeeDTO.PhoneNumber);
            parameters.Add("@imageURL", updateEmployeeDTO.ImageURL);
            parameters.Add("@status", updateEmployeeDTO.Status);
            parameters.Add("@employeeID", updateEmployeeDTO.EmployeeID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

