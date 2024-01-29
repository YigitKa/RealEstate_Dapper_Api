using System;
using RealEstate_Dapper_Api.DTOs.PopularLocationDTOs;
using RealEstate_Dapper_Api.Models.DapperContext;
using Dapper;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
	public class PopularLocationRepository : IPopularLocationRepository
	{
        private readonly Context _context;
		public PopularLocationRepository(Context context)
		{
            _context = context;
		}

        public async Task<List<ResultPopularLocationDTO>> GetAllPopularLocationAsync()
        {
            string query = "SELECT LocationID, CityName, ImageURL FROM PopularLocation";

            using (var connection = _context.CreateConnection())
            {
               var result = await connection.QueryAsync<ResultPopularLocationDTO>(query);
                return result.ToList();
            }
        }
    }
}

