using System;
using Dapper;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.StatisticRepositories
{
	public class StatisticRepository : IStatisticRepository
	{
        private readonly Context _context;
		public StatisticRepository(Context context) 
		{
            _context = context;
		}

        public int ActiveCategoryCount()
        {
            string query = "SELECT COUNT(0) FROM Category WHERE CategoryStatus = 1";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "SELECT COUNT(0) FROM Employee WHERE Status = 1";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public int ApartmentCount()
        {
            string query = "SELECT COUNT(0) FROM Product WHERE ProductCategory = 3";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public decimal AverageProductByRent()
        {
            string query = "SELECT AVG(Price) FROM [Product]  WHERE  [Type] = N'Kiralık'";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public decimal AverageProductBySale()
        {
            string query = "SELECT AVG(Price) FROM [Product]  WHERE  [Type] = N'Satılık'";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public int AverageRoomCount()
        {
            string query = "SELECT AVG(RoomCount) FROM ProductDetail";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public int CategoryCount()
        {
            string query = "SELECT COUNT(0) FROM Category";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public string CategoryNameByMaximumProductCount()
        {
            string query = "SELECT CategoryName " +
                "FROM Category WHERE CategoryID = " +
                     "(SELECT TOP 1 ProductCategory  " +
                     "FROM Product " +
                     "GROUP BY  ProductCategory " +
                     "ORDER BY COUNT(*) DESC)))";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<string>(query);
                return value;
            }
        }

        public string CityNameByMaximumProductCount()
        {
            string query = "SELECT TOP 1 City  " +
                "FROM [dbo].[Product]  " +
                "GROUP BY City " +
                "ORDER BY COUNT(*) DESC";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<string>(query);
                return value;
            }
        }

        public int DifferentCityCount()
        {
            string query = "SELECT COUNT(DISTINCT City)  FROM [dbo].[Product]";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public decimal LastProductPrice()
        {
            string query = "SELECT TOP 1 Price FROM Product Order By ProductID DESC";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<decimal>(query);
                return value;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "SELECT TOP 1 BuilYear FROM ProductDetail Order BY CONVERT(INT, BuildYear) DESC";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<string>(query);
                return value;
            }
        }

        public string OldestBuildingYear()
        {
            string query = "SELECT TOP 1 BuilYear FROM ProductDetail Order BY CONVERT(INT, BuildYear) ASC";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<string>(query);
                return value;
            }
        }

        public int PassiveCategoryCount()
        {
            string query = "SELECT COUNT(0) FROM Category WHERE CategoryStatus = 0";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public int ProductCount()
        {
            string query = "SELECT COUNT(0) FROM Product";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }
    }
}

