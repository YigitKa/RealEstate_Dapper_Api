using System;
using Dapper;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.DTOs.ServieDTOs;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
	public class ServiceRepository : IServiceRepository
	{
        private readonly Context _context;
		public ServiceRepository(Context context)
		{
            _context = context;
		}

        public async void CreateService(CreateServiceDTO serviceDTO)
        {
            string query = "INSERT INTO Services (ServiceName, ServiceStatus) " +
                "VALUES (@serviceName, @serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", serviceDTO.ServiceName);
            parameters.Add("@serviceStatus", true);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteService(int serviceID)
        {
            string query = "DELETE FROM Services WHERE ServiceID = @serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", serviceID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultServiceDTO>> GetAllServiceAsync()
        {
            string query = "SELECT * FROM Services";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<ResultServiceDTO>(query);
                return result.ToList();
            }
        }

        public async Task<GetByIDServiceDTO> GetService(int ID)
        {
            string query = "SELECT * FROM Services WHERE ServiceID = @serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", ID);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDServiceDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateService(UpdateServiceDTO serviceDTO)
        {
            string query = "UPDATE Services SET ServiceName = @serviceName, ServiceStatus = @serviceStatus " +
                "WHERE ServiceID = @serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", serviceDTO.ServiceName);
            parameters.Add("@serviceStatus", serviceDTO.ServiceStatus);
            parameters.Add("@serviceID", serviceDTO.ServiceID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

