using System;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_Api.Repositories.WhoWeAreDetailRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    public class WhoWeAreDetails : Controller
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreDetailRepository;

        public WhoWeAreDetails(IWhoWeAreDetailRepository whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreDetailRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO)
        {
            _whoWeAreDetailRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDTO);
            return Ok("WhoWeAreDetail eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreDetailRepository.DeleteWhoWeAreDetail(id);
            return Ok("WhoWeAreDetail silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail([FromBody] UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO)
        {
            _whoWeAreDetailRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDTO);
            return Ok("WhoWeAreDetail güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetail(int id)
        {
            var value = await _whoWeAreDetailRepository.GetWhoWeAreDetail(id);
            return Ok(value);
        }
    }
}
