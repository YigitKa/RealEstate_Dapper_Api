using System;
using RealEstate_Dapper_Api.DTOs.BottomGridDTOs;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
	public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDTO>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDTO bottomGridDTO);
        void DeleteBottomGrid(int bottomGridID);
        void UpdateBottomGrid(UpdateBottomGridDTO bottomGridDTO);
        Task<GetBottomGridDTO> GetBottomGrid(int ID);
    }
}

