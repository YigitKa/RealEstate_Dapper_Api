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
            throw new NotImplementedException();
        }

        public decimal AverageProductByRent()
        {
            throw new NotImplementedException();
        }

        public decimal AverageProductBySale()
        {
            throw new NotImplementedException();
        }

        public int AverageRoomCount()
        {
            throw new NotImplementedException();
        }

        public int CategoryCount()
        {
            throw new NotImplementedException();
        }

        public string CategoryNameByMaximumProductCount()
        {
            throw new NotImplementedException();
        }

        public string CityNameByMaximumProductCount()
        {
            throw new NotImplementedException();
        }

        public int DifferentCityCount()
        {
            throw new NotImplementedException();
        }

        public decimal LastProductPrice()
        {
            throw new NotImplementedException();
        }

        public string NewestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public string OldestBuildingYear()
        {
            throw new NotImplementedException();
        }

        public int PassiveCategoryCount()
        {
            throw new NotImplementedException();
        }

        public int ProductCount()
        {
            throw new NotImplementedException();
        }
    }
}

