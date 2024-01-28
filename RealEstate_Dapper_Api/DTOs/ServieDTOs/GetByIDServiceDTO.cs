using System;
namespace RealEstate_Dapper_Api.DTOs.ServieDTOs
{
	public class GetByIDServiceDTO
	{
		public int ServiceID { get; set; }
		public string ServiceName { get; set; }
		public bool ServiceStatus { get; set; }
	}
}

