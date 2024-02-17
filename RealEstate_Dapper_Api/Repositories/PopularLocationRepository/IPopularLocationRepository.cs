using System;
using RealEstate_Dapper_Api.DTOs.PopularLocationDTOs;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
	public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDTO>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDTO createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDto);
        Task<GetByIDPopularLocationDTO> GetPopularLocation(int id);
    }
}

