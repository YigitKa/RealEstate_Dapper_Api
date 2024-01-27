using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.Repositories.CategoryRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            _categoryRepository.CreateCategory(createCategoryDTO);
            return Ok("Kategori eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int categoryID)
        {
            _categoryRepository.DeleteCategory(categoryID);
            return Ok("Kategori silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDTO categoryDTO)
        {
            _categoryRepository.UpdateCategory(categoryDTO);
            return Ok("Kategori güncellendi");
        }
    }
}

