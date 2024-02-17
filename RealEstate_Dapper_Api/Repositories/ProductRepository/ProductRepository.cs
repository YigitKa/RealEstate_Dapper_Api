using System;
using Dapper;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.DTOs.ProductDTOs;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
	public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
		{
            _context = context;
		}

        public async Task<List<ResultProductDTO>> GetAllProductAsync()
        {
            string query = "SELECT ProductID,Title, Price,City, District, ProductCategory, Type, CoverImage, Address  FROM Product " +
                "INNER JOIN Category ON CategoryID = ProductCategory";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDTO>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryNameDTO>> GetAllProductWithCategoryNameAsync()
        {
            string query = "SELECT ProductID,Title, Price,City, District, CategoryName, Type, CoverImage, Address, DealOfTheDay  FROM Product " +
                          "INNER JOIN Category ON CategoryID = ProductCategory";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryNameDTO>(query);
                return values.ToList();
            }
        }


        public async void ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay=0 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay=1 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

