using System;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.DTOs.WhoWeAreDetailDTOs;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreDetailRepository
{
	public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDTO>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO whoWeAreDetailDTO);
        void DeleteWhoWeAreDetail(int whoWeAreDetailID);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO whoWeAreDetailDTO);
        Task<GetByIDWhoWeAreDetailDTO> GetWhoWeAreDetail(int ID);
    }
}

