using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    public class PopularLocationsController : Controller
	{
		private readonly IPopularLocationRepository _popularLocationRepository;

		public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
		{
			_popularLocationRepository = popularLocationRepository;
		}

		[HttpGet]
		public async Task<IActionResult> PopularLocationList()
		{
			var result = await _popularLocationRepository.GetAllPopularLocationAsync();
			return Ok(result);
        }
	}
}

