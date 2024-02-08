using System;
namespace RealEstate_Dapper_Api.Repositories.StatisticRepositories
{
	public interface IStatisticRepository
	{
		int CategoryCount();
		int ActiveCategoryCount();
		int PassiveCategoryCount();
		int ProductCount();
		int ApartmentCount();
		string CategoryNameByMaximumProductCount();
        decimal AverageProductByRent();
        decimal AverageProductBySale();
		string CityNameByMaximumProductCount();
		int DifferentCityCount();
		decimal LastProductPrice();
		string NewestBuildingYear();
		string OldestBuildingYear();
		int AverageRoomCount();
		int ActiveEmployeeCount();
    }
}

