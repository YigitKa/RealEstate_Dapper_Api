using System;
using RealEstate_Dapper_Api.DTOs.ServieDTOs;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
	public interface IServiceRepository
	{
        Task<List<ResultServiceDTO>> GetAllServiceAsync();
        void CreateService(CreateServiceDTO serviceDTO);
        void DeleteService(int serviceID);
        void UpdateService(UpdateServiceDTO serviceDTO);
        Task<GetByIDServiceDTO> GetService(int ID);
    }
}

