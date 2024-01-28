using System;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.DTOs.CategoryDTOs;
using RealEstate_Dapper_Api.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreDetailRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;
        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO whoWeAreDetailDTO)
        {
            string query = "INSERT INTO WhoWeAreDetail (Title, SubTitle, Description1, Description2) " +
                " VALUES (@title, @subTitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", whoWeAreDetailDTO.Title);
            parameters.Add("@subTitle", whoWeAreDetailDTO.SubTitle);
            parameters.Add("@description1", whoWeAreDetailDTO.Description1);
            parameters.Add("@description2", whoWeAreDetailDTO.Description2);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetail(int whoWeAreDetailID)
        {
            string query = "DELETE FROM WhoWeAreDetail WHERE WhoWeAreDetailID = @whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", whoWeAreDetailID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDTO>> GetAllWhoWeAreDetailAsync()
        {
            string query = "SELECT * FROM WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDWhoWeAreDetailDTO> GetWhoWeAreDetail(int ID)
        {
            string query = "SELECT * FROM WhoWeAreDetail WHERE WhoWeAreDetailID = @whoWeAreDetailID";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailID", ID);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO whoWeAreDetailDTO)
        {
            string query = "UPDATE WhoWeAreDetial SET " +
                            "Title = @title, " +
                            "SubTitle = @subTitle, " +
                            "Description1 = @description1, " +
                            "Description2 = @description2 " +
                            "WHERE WhoWeAreDetialID = @whoWeAreDetailID";

            var parameters = new DynamicParameters();
            parameters.Add("@title", whoWeAreDetailDTO.Title);
            parameters.Add("@subTitle", whoWeAreDetailDTO.SubTitle);
            parameters.Add("@description1", whoWeAreDetailDTO.Description1);
            parameters.Add("@description2", whoWeAreDetailDTO.Description2);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}

