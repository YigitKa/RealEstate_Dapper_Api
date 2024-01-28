using System;
using Dapper;
using RealEstate_Dapper_Api.DTOs.BottomGridDTOs;
using RealEstate_Dapper_Api.DTOs.ProductDTOs;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public void CreateBottomGrid(CreateBottomGridDTO bottomGridDTO)
        {
            throw new NotImplementedException();
        }

        public void DeleteBottomGrid(int bottomGridID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDTO>> GetAllBottomGridAsync()
        {
            string query = "SELECT *  FROM BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDTO>(query);
                return values.ToList();
            }
        }

        public Task<GetBottomGridDTO> GetBottomGrid(int ID)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDTO bottomGridDTO)
        {
            throw new NotImplementedException();
        }
    }
}

