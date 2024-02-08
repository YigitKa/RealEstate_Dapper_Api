using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/ActiveEmployeeCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/ApertmentCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.apertmentCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/AverageProductByRent");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.averageProductByRent = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/AverageProductBySale");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.averageProductBySale = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/AverageRoomCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/CategoryCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/CategoryNameByMaximumProductCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaximumProductCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/CityNameByMaximumProductCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaximumProductCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/DifferentCityCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.differentCityCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/NewestBuildingYear");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/OldestBuildingYear");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/PassiveCategoryCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsonData;

            responseMessage = await client.GetAsync("https://localhost:7123/api/Statistics/ProductCount");
            jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.productCount = jsonData;
            return View();
        }
    }
}

