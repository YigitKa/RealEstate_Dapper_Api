using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.StatisticRepositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    public class StatisticsController : Controller
    {

        private readonly IStatisticRepository _statisticRepository;

        public StatisticsController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticRepository.ActiveCategoryCount());
        }

        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticRepository.ActiveEmployeeCount());
        }

        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticRepository.ApartmentCount());
        }

        [HttpGet("AverageProductByRent")]
        public IActionResult AverageProductByRent()
        {
            return Ok(_statisticRepository.AverageProductByRent());
        }

        [HttpGet("AverageProductBySale")]
        public IActionResult AverageProductBySale()
        {
            return Ok(_statisticRepository.AverageProductBySale());
        }

        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticRepository.AverageRoomCount());
        }

        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticRepository.CategoryCount());
        }

        [HttpGet("CategoryNameByMaximumProductCount")]
        public IActionResult CategoryNameByMaximumProductCount()
        {
            return Ok(_statisticRepository.CategoryNameByMaximumProductCount());
        }

        [HttpGet("CityNameByMaximumProductCount")]
        public IActionResult CityNameByMaximumProductCount()
        {
            return Ok(_statisticRepository.CityNameByMaximumProductCount());
        }

        [HttpGet("DifferentCityCount")]
        public IActionResult DifferentCityCount()
        {
            return Ok(_statisticRepository.DifferentCityCount());
        }

        [HttpGet("LastProductPrice")]
        public IActionResult LastProductPrice()
        {
            return Ok(_statisticRepository.LastProductPrice());
        }

        [HttpGet("NewestBuildingYear")]
        public IActionResult NewestBuildingYear()
        {
            return Ok(_statisticRepository.NewestBuildingYear());
        }

        [HttpGet("OldestBuildingYear")]
        public IActionResult OldestBuildingYear()
        {
            return Ok(_statisticRepository.OldestBuildingYear());
        }

        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_statisticRepository.PassiveCategoryCount());
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_statisticRepository.ProductCount());
        }
    }
}

