using System;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.Models.DapperContext;
using Dapper;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{
	public class CategoryRepository : ICategoryRepository
	{
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            string query = "INSERT INTO Category (CategoryName, CategoryStatus) " +
                " VALUES (@categoryName, @categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", createCategoryDTO.CategoryName);
            parameters.Add("@categoryStatus", true);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "DELETE FROM Category WHERE CategoryID = @categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategoryAsync()
        {
            string query = "SELECT * FROM Category";
            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDCategoryDTO> GetCategory(int ID)
        {
            string query = "SELECT * FROM Category WHERE CategoryID = @categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", ID);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateCategory(UpdateCategoryDTO categoryDTO)
        {
            string query = "UPDATE Category SET " +
                "CategoryName = @categoryName, " +
                "CategoryStatus = @categoryStatus " +
                "WHERE CategoryID = @categoryID";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDTO.CategoryName);
            parameters.Add("@categoryStatus", categoryDTO.CategoryStatus);
            parameters.Add("@categoryID", categoryDTO.CategoryID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

