using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
	public class _DefaultHomePageProductPage : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultHomePageProductPage(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7123/api/Products/ProductListWithCategoryName");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<DTOs.ProductDTOs.ResultProductDTO>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}

