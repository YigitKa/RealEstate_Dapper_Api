using System;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.DTOs.ServieDTOs;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    public class ServicesController : Controller
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDTO createServiceDTO)
        {
            _serviceRepository.CreateService(createServiceDTO);
            return Ok("Servis eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteService(int serviceID)
        {
            _serviceRepository.DeleteService(serviceID);
            return Ok("Kategori silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDTO serviceDTO)
        {
            _serviceRepository.UpdateService(serviceDTO);
            return Ok("Kategori güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _serviceRepository.GetService(id);
            return Ok(value);
        }
    }
}

