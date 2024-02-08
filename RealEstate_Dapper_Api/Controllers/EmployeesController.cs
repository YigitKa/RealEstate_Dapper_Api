using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.DTOs.EmployeeDTOs;
using RealEstate_Dapper_Api.Repositories.EmployeeRepositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }


        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDTO createEmployeeDTO)
        {
            _employeeRepository.CreateEmployee(createEmployeeDTO);
            return Ok("Personel Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Personel silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeDTO updateEmployeeDTO)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDTO);
            return Ok("Personel güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await _employeeRepository.GetEmployee(id);
            return Ok(value);
        }
    }
}

